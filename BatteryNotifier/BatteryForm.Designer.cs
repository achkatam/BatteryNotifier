namespace BatteryNotifier
{
    partial class BatteryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatteryForm));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showHighLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLowLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Battery Informer Service";
            this.notifyIcon1.BalloonTipTitle = "Battery Informer";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon1.Text = "Battery Informer";
            this.notifyIcon1.Visible = true;
            // 
            // mainTimer
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showHighLevelToolStripMenuItem,
            this.showLowLevelToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(225, 104);
            // 
            // menuItemHighLevel
            // 
            this.showHighLevelToolStripMenuItem.Name = "menuItemHighLevel";
            this.showHighLevelToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.showHighLevelToolStripMenuItem.Text = "Show High Level Alert";
            this.showHighLevelToolStripMenuItem.Click += new System.EventHandler(this.showHighLevelToolStripMenuItem_Click);
            // 
            // menuItemLowLevel
            // 
            this.showLowLevelToolStripMenuItem.Name = "menuItemLowLevel";
            this.showLowLevelToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.showLowLevelToolStripMenuItem.Text = "Show Low Level Alert";
            this.showLowLevelToolStripMenuItem.Click += new System.EventHandler(this.showLowLevelToolStripMenuItem_Click);
            // 
            // menuItemExit
            // 
            this.exitToolStripMenuItem.Name = "menuItemExit";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Shown += new System.EventHandler(this.BatteryForm_Shown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            //this.components = new System.ComponentModel.Container();
            //this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            //this.showHighLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            //this.showLowLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            //this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            //this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            //this.timer1 = new System.Windows.Forms.Timer(this.components);
            //this.contextMenuStrip1.SuspendLayout();
            //this.SuspendLayout();
            //// 
            //// contextMenuStrip1
            //// 
            //this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            //this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            //this.showHighLevelToolStripMenuItem,
            //this.showLowLevelToolStripMenuItem,
            //this.exitToolStripMenuItem});
            //this.contextMenuStrip1.Name = "contextMenuStrip1";
            //this.contextMenuStrip1.Size = new System.Drawing.Size(211, 104);
            //// 
            //// showHighLevelToolStripMenuItem
            //// 
            //this.showHighLevelToolStripMenuItem.Name = "showHighLevelToolStripMenuItem";
            //this.showHighLevelToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            //this.showHighLevelToolStripMenuItem.Text = "Show High Level";
            //this.showHighLevelToolStripMenuItem.Click += new System.EventHandler(this.showHighLevelToolStripMenuItem_Click);
            //// 
            //// showLowLevelToolStripMenuItem
            //// 
            //this.showLowLevelToolStripMenuItem.Name = "showLowLevelToolStripMenuItem";
            //this.showLowLevelToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            //this.showLowLevelToolStripMenuItem.Text = "Show Low Level";
            //this.showLowLevelToolStripMenuItem.Click += new System.EventHandler(this.showLowLevelToolStripMenuItem_Click);
            //// 
            //// exitToolStripMenuItem
            //// 
            //this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            //this.exitToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            //this.exitToolStripMenuItem.Text = "Exit";
            //this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            //// 
            //// notifyIcon1
            //// 
            //this.notifyIcon1.Text = "notifyIcon1";
            //this.notifyIcon1.Visible = true;
            //// 
            //// BatteryForm
            //// 
            //this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.ClientSize = new System.Drawing.Size(800, 450);
            //this.Name = "BatteryForm";
            //this.Text = "BatteryForm";
            //this.Shown += new System.EventHandler(this.BatteryForm_Shown);
            //this.contextMenuStrip1.ResumeLayout(false);
            //this.ResumeLayout(false);

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showHighLevelToolStripMenuItem;
        private ToolStripMenuItem showLowLevelToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer1;
    }
}