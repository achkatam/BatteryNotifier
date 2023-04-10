namespace BatteryNotifier;

using System;
using System.Windows.Forms;
using BatteryInformer.UI;
using Service;

public partial class BatteryForm : Form
{
    private bool isToolTipLoaded = false;
    public BatteryForm()
    {
        InitializeComponent();
        timer1.Interval = 30000;
        timer1.Enabled = true;
    }

    private void BatteryForm_Shown(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Minimized;
        this.Hide();
        notifyIcon1.Visible = true;
        notifyIcon1.ContextMenuStrip = contextMenuStrip1;
        showHighLevelToolStripMenuItem.Checked = true;
        showLowLevelToolStripMenuItem.Checked = true;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        var isCharging = BatteryService.IsCharging();
        var batteryLevel = BatteryService.GetPercentage();

        if (isCharging)
        {
            timer1.Stop();

            if (showHighLevelToolStripMenuItem.Checked)
            {
                if (batteryLevel >= 80)
                {
                    var popup = new BatteryNotification(batteryLevel, true);
                    popup.ShowDialog();
                }
                else if (batteryLevel == 95)
                {
                    var popup = new BatteryNotification(batteryLevel, true);
                    popup.ShowDialog();
                }
            }
            timer1.Start();
        }
        else
        {
            if (showLowLevelToolStripMenuItem.Checked)
            {
                if (batteryLevel is 30 or 20)
                {
                    ShowToolTip("Battery Notification", $"Battery level is {batteryLevel}%.Plug in the charger!", false);
                }
                else if (batteryLevel == 15)
                {
                    ShowToolTip("Battery Notification", $"Battery critically low. {batteryLevel}%.", true);
                }
                else
                {
                    isToolTipLoaded = false;
                }
            }
        }
    }

    private void ShowToolTip(string notificationTitle, string notificationText, bool isAlert)
    {
        if (!isToolTipLoaded)
        {
            notifyIcon1.BalloonTipTitle = notificationTitle;
            notifyIcon1.BalloonTipText = notificationText;
            notifyIcon1.BalloonTipIcon = isAlert ? ToolTipIcon.Error : ToolTipIcon.Warning;
            notifyIcon1.ShowBalloonTip(5000);
            isToolTipLoaded = true;
        }
    }

    private void showHighLevelToolStripMenuItem_Click(object sender, EventArgs e)
    {
        showHighLevelToolStripMenuItem.Checked = !showHighLevelToolStripMenuItem.Checked;
    }

    private void showLowLevelToolStripMenuItem_Click(object sender, EventArgs e)
    {
        showLowLevelToolStripMenuItem.Checked = !showLowLevelToolStripMenuItem.Checked;
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}