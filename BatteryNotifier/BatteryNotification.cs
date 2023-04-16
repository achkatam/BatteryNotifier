﻿
using System;
using System.Windows.Forms;

namespace BatteryInformer.UI
{
    using BatteryNotifier.Service;

    public partial class BatteryNotification : Form
    {
        public BatteryNotification()
        {
            InitializeComponent();
        }

        public BatteryNotification(int value, bool isAutoClose)
        {
            InitializeComponent();
            lblValue.Text = $"Your Battery Level is {value}. Please disconnect the charger.";
            timer.Interval = 10000;
            timerHard.Interval = 1000;
            if (isAutoClose)
            {
                timer.Enabled = true;
            }
            else
            {
                timerHard.Enabled = true;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerHard_Tick(object sender, EventArgs e)
        {
            if (!BatteryService.IsCharging())
            {
                this.Close();
            }
        }
    }
}
