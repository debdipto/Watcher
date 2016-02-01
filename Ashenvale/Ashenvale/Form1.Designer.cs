namespace Ashenvale
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watcherPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutWatcherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtb_Display = new System.Windows.Forms.TextBox();
            this.lbl_ServerLink = new System.Windows.Forms.Label();
            this.lbl_Link = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.btn_Deploy = new System.Windows.Forms.Button();
            this.lbl_ServerStatus = new System.Windows.Forms.Label();
            this.btn_TestHeartbeat = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(912, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.watcherPropertiesToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // watcherPropertiesToolStripMenuItem
            // 
            this.watcherPropertiesToolStripMenuItem.Name = "watcherPropertiesToolStripMenuItem";
            this.watcherPropertiesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.watcherPropertiesToolStripMenuItem.Text = "&Watcher Properties";
            this.watcherPropertiesToolStripMenuItem.Click += new System.EventHandler(this.watcherPropertiesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutWatcherToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutWatcherToolStripMenuItem
            // 
            this.aboutWatcherToolStripMenuItem.Name = "aboutWatcherToolStripMenuItem";
            this.aboutWatcherToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.aboutWatcherToolStripMenuItem.Text = "About &Watcher";
            // 
            // txtb_Display
            // 
            this.txtb_Display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtb_Display.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtb_Display.Location = new System.Drawing.Point(5, 207);
            this.txtb_Display.Multiline = true;
            this.txtb_Display.Name = "txtb_Display";
            this.txtb_Display.Size = new System.Drawing.Size(895, 333);
            this.txtb_Display.TabIndex = 10;
            // 
            // lbl_ServerLink
            // 
            this.lbl_ServerLink.AutoSize = true;
            this.lbl_ServerLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ServerLink.Location = new System.Drawing.Point(219, 46);
            this.lbl_ServerLink.Name = "lbl_ServerLink";
            this.lbl_ServerLink.Size = new System.Drawing.Size(31, 16);
            this.lbl_ServerLink.TabIndex = 9;
            this.lbl_ServerLink.Text = "N/A";
            // 
            // lbl_Link
            // 
            this.lbl_Link.AutoSize = true;
            this.lbl_Link.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Link.Location = new System.Drawing.Point(12, 42);
            this.lbl_Link.Name = "lbl_Link";
            this.lbl_Link.Size = new System.Drawing.Size(201, 20);
            this.lbl_Link.TabIndex = 8;
            this.lbl_Link.Text = "Link to Amaranthine Server";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(16, 65);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(75, 23);
            this.btn_Browse.TabIndex = 11;
            this.btn_Browse.Text = "Browse..";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Deploy
            // 
            this.btn_Deploy.Location = new System.Drawing.Point(98, 65);
            this.btn_Deploy.Name = "btn_Deploy";
            this.btn_Deploy.Size = new System.Drawing.Size(75, 23);
            this.btn_Deploy.TabIndex = 12;
            this.btn_Deploy.Text = "Deploy";
            this.btn_Deploy.UseVisualStyleBackColor = true;
            this.btn_Deploy.Click += new System.EventHandler(this.btn_Deploy_Click);
            // 
            // lbl_ServerStatus
            // 
            this.lbl_ServerStatus.AutoSize = true;
            this.lbl_ServerStatus.Location = new System.Drawing.Point(13, 101);
            this.lbl_ServerStatus.Name = "lbl_ServerStatus";
            this.lbl_ServerStatus.Size = new System.Drawing.Size(71, 13);
            this.lbl_ServerStatus.TabIndex = 13;
            this.lbl_ServerStatus.Text = "Server Status";
            // 
            // btn_TestHeartbeat
            // 
            this.btn_TestHeartbeat.Location = new System.Drawing.Point(16, 117);
            this.btn_TestHeartbeat.Name = "btn_TestHeartbeat";
            this.btn_TestHeartbeat.Size = new System.Drawing.Size(101, 48);
            this.btn_TestHeartbeat.TabIndex = 14;
            this.btn_TestHeartbeat.Text = "Test heartbeat";
            this.btn_TestHeartbeat.UseVisualStyleBackColor = true;
            this.btn_TestHeartbeat.Click += new System.EventHandler(this.btn_TestHeartbeat_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 557);
            this.Controls.Add(this.btn_TestHeartbeat);
            this.Controls.Add(this.lbl_ServerStatus);
            this.Controls.Add(this.btn_Deploy);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtb_Display);
            this.Controls.Add(this.lbl_ServerLink);
            this.Controls.Add(this.lbl_Link);
            this.Controls.Add(this.btn_Browse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Main";
            this.Text = "Ashenvale Console";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Main_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem watcherPropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutWatcherToolStripMenuItem;
        private System.Windows.Forms.TextBox txtb_Display;
        private System.Windows.Forms.Label lbl_ServerLink;
        private System.Windows.Forms.Label lbl_Link;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.Button btn_Deploy;
        private System.Windows.Forms.Label lbl_ServerStatus;
        private System.Windows.Forms.Button btn_TestHeartbeat;
    }
}

