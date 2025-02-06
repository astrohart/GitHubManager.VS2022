namespace GHM.Dialogs
{
    partial class OptionsDialogBox
    {
///  <summary> Required designer variable. </summary>
        private System.ComponentModel.IContainer components = null;

///  <summary> Clean up any resources being used. </summary> <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

///  <summary> Required method for Designer support - do not modify the contents of this method with the code editor. </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsDialogBox));
            this.okayButton = new xyLOGIX.UI.Dark.Controls.DarkButton();
            this.cancelButton = new xyLOGIX.UI.Dark.Controls.DarkButton();
            this.applyButton = new xyLOGIX.UI.Dark.Controls.DarkButton();
            this.tabs = new xyLOGIX.UI.Dark.Controls.DarkTabControl();
            this.startupPage = new System.Windows.Forms.TabPage();
            this.loginOnStartupCheckBox = new xyLOGIX.UI.Dark.Controls.DarkCheckBox();
            this.tabs.SuspendLayout();
            this.startupPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // okayButton
            // 
            this.okayButton.AcceptBorderColor = System.Drawing.SystemColors.Highlight;
            this.okayButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.okayButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okayButton.IsDarkTheme = true;
            this.okayButton.Location = new System.Drawing.Point(84, 419);
            this.okayButton.Name = "okayButton";
            this.okayButton.Padding = new System.Windows.Forms.Padding(5);
            this.okayButton.Size = new System.Drawing.Size(87, 27);
            this.okayButton.TabIndex = 1;
            this.okayButton.Text = "OK";
            this.okayButton.Click += new System.EventHandler(this.OnClickOK);
            // 
            // cancelButton
            // 
            this.cancelButton.AcceptBorderColor = System.Drawing.SystemColors.Highlight;
            this.cancelButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.IsDarkTheme = true;
            this.cancelButton.Location = new System.Drawing.Point(177, 419);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Padding = new System.Windows.Forms.Padding(5);
            this.cancelButton.Size = new System.Drawing.Size(87, 27);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            // 
            // applyButton
            // 
            this.applyButton.AcceptBorderColor = System.Drawing.SystemColors.Highlight;
            this.applyButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.applyButton.Enabled = false;
            this.applyButton.IsDarkTheme = true;
            this.applyButton.Location = new System.Drawing.Point(270, 419);
            this.applyButton.Name = "applyButton";
            this.applyButton.Padding = new System.Windows.Forms.Padding(5);
            this.applyButton.Size = new System.Drawing.Size(87, 27);
            this.applyButton.TabIndex = 3;
            this.applyButton.Text = "&Apply";
            // 
            // tabs
            // 
            this.tabs.ActiveTabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.tabs.ActiveTabTextColor = System.Drawing.SystemColors.Highlight;
            this.tabs.Controls.Add(this.startupPage);
            this.tabs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.tabs.InactiveTabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.tabs.InactiveTabTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.tabs.IsDarkTheme = true;
            this.tabs.ItemSize = new System.Drawing.Size(0, 18);
            this.tabs.Location = new System.Drawing.Point(13, 13);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(344, 400);
            this.tabs.TabBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.tabs.TabIndex = 0;
            this.tabs.TabWellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // startupPage
            // 
            this.startupPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.startupPage.Controls.Add(this.loginOnStartupCheckBox);
            this.startupPage.Location = new System.Drawing.Point(4, 22);
            this.startupPage.Name = "startupPage";
            this.startupPage.Padding = new System.Windows.Forms.Padding(3);
            this.startupPage.Size = new System.Drawing.Size(336, 374);
            this.startupPage.TabIndex = 0;
            this.startupPage.Text = "Startup";
            // 
            // loginOnStartupCheckBox
            // 
            this.loginOnStartupCheckBox.IsDarkTheme = false;
            this.loginOnStartupCheckBox.Location = new System.Drawing.Point(6, 6);
            this.loginOnStartupCheckBox.Name = "loginOnStartupCheckBox";
            this.loginOnStartupCheckBox.Size = new System.Drawing.Size(324, 26);
            this.loginOnStartupCheckBox.TabIndex = 0;
            this.loginOnStartupCheckBox.Text = "&Login on startup";
            this.loginOnStartupCheckBox.UseVisualStyleBackColor = false;
            this.loginOnStartupCheckBox.CheckedChanged += new System.EventHandler(this.OnCheckedChangedLoginOnStartupCheckBox);
            // 
            // OptionsDialogBox
            // 
            this.AcceptButton = this.okayButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(369, 458);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okayButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsDialogBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.tabs.ResumeLayout(false);
            this.startupPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private xyLOGIX.UI.Dark.Controls.DarkButton okayButton;
        private xyLOGIX.UI.Dark.Controls.DarkButton cancelButton;
        private xyLOGIX.UI.Dark.Controls.DarkButton applyButton;
        private xyLOGIX.UI.Dark.Controls.DarkTabControl tabs;
        private System.Windows.Forms.TabPage startupPage;
        private xyLOGIX.UI.Dark.Controls.DarkCheckBox loginOnStartupCheckBox;
    }
}