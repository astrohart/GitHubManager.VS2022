
namespace GitHubManager
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
            this.okayButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.tabs = new System.Windows.Forms.TabControl();
            this.startupPage = new System.Windows.Forms.TabPage();
            this.loginOnStartupCheckBox = new System.Windows.Forms.CheckBox();
            this.tabs.SuspendLayout();
            this.startupPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // okayButton
            // 
            this.okayButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okayButton.Location = new System.Drawing.Point(84, 419);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(87, 27);
            this.okayButton.TabIndex = 1;
            this.okayButton.Text = "OK";
            this.okayButton.UseVisualStyleBackColor = true;
            this.okayButton.Click += new System.EventHandler(this.OnClickOK);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(177, 419);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(87, 27);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // applyButton
            // 
            this.applyButton.Enabled = false;
            this.applyButton.Location = new System.Drawing.Point(270, 419);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(87, 27);
            this.applyButton.TabIndex = 3;
            this.applyButton.Text = "&Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.startupPage);
            this.tabs.Location = new System.Drawing.Point(13, 13);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(344, 400);
            this.tabs.TabIndex = 0;
            // 
            // startupPage
            // 
            this.startupPage.Controls.Add(this.loginOnStartupCheckBox);
            this.startupPage.Location = new System.Drawing.Point(4, 24);
            this.startupPage.Name = "startupPage";
            this.startupPage.Padding = new System.Windows.Forms.Padding(3);
            this.startupPage.Size = new System.Drawing.Size(336, 372);
            this.startupPage.TabIndex = 0;
            this.startupPage.Text = "Startup";
            this.startupPage.UseVisualStyleBackColor = true;
            // 
            // loginOnStartupCheckBox
            // 
            this.loginOnStartupCheckBox.Location = new System.Drawing.Point(6, 6);
            this.loginOnStartupCheckBox.Name = "loginOnStartupCheckBox";
            this.loginOnStartupCheckBox.Size = new System.Drawing.Size(324, 26);
            this.loginOnStartupCheckBox.TabIndex = 0;
            this.loginOnStartupCheckBox.Text = "&Login on startup";
            this.loginOnStartupCheckBox.UseVisualStyleBackColor = true;
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

        private System.Windows.Forms.Button okayButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage startupPage;
        private System.Windows.Forms.CheckBox loginOnStartupCheckBox;
    }
}
