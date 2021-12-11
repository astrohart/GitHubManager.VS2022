
namespace GitHubManager
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fileLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.sep4 = new System.Windows.Forms.ToolStripSeparator();
            this.fileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolbarsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewNavigateToolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.sep5 = new System.Windows.Forms.ToolStripSeparator();
            this.viewStatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.navigateToolBar = new System.Windows.Forms.ToolStrip();
            this.moveFirstButton = new System.Windows.Forms.ToolStripButton();
            this.movePreviousButton = new System.Windows.Forms.ToolStripButton();
            this.sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.positionTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.countLabel = new System.Windows.Forms.ToolStripLabel();
            this.sep2 = new System.Windows.Forms.ToolStripSeparator();
            this.moveNextButton = new System.Windows.Forms.ToolStripButton();
            this.moveLastButton = new System.Windows.Forms.ToolStripButton();
            this.sep3 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteButton = new System.Windows.Forms.ToolStripButton();
            this.addNewButton = new System.Windows.Forms.ToolStripButton();
            this.reposDataGridView = new System.Windows.Forms.DataGridView();
            this.reposListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cloneUrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainMenu.SuspendLayout();
            this.navigateToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reposDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.viewMenu,
            this.toolsMenu});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(858, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileLogin,
            this.sep4,
            this.fileExit});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // fileLogin
            // 
            this.fileLogin.Name = "fileLogin";
            this.fileLogin.Size = new System.Drawing.Size(113, 22);
            this.fileLogin.Text = "&Login...";
            this.fileLogin.Click += new System.EventHandler(this.OnFileLogin);
            // 
            // sep4
            // 
            this.sep4.Name = "sep4";
            this.sep4.Size = new System.Drawing.Size(110, 6);
            // 
            // fileExit
            // 
            this.fileExit.Name = "fileExit";
            this.fileExit.Size = new System.Drawing.Size(113, 22);
            this.fileExit.Text = "E&xit";
            this.fileExit.Click += new System.EventHandler(this.OnFileExit);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolbarsMenu,
            this.sep5,
            this.viewStatusBar});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(44, 20);
            this.viewMenu.Text = "&View";
            this.viewMenu.DropDownOpening += new System.EventHandler(this.OnDropDownOpeningViewMenu);
            // 
            // viewToolbarsMenu
            // 
            this.viewToolbarsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewNavigateToolbar});
            this.viewToolbarsMenu.Name = "viewToolbarsMenu";
            this.viewToolbarsMenu.Size = new System.Drawing.Size(126, 22);
            this.viewToolbarsMenu.Text = "&Toolbars";
            this.viewToolbarsMenu.DropDownOpening += new System.EventHandler(this.OnDropDownOpeningViewToolbarsMenu);
            // 
            // viewNavigateToolbar
            // 
            this.viewNavigateToolbar.Checked = true;
            this.viewNavigateToolbar.CheckOnClick = true;
            this.viewNavigateToolbar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewNavigateToolbar.Name = "viewNavigateToolbar";
            this.viewNavigateToolbar.Size = new System.Drawing.Size(121, 22);
            this.viewNavigateToolbar.Text = "&Navigate";
            this.viewNavigateToolbar.Click += new System.EventHandler(this.OnViewNavigateToolbar);
            // 
            // sep5
            // 
            this.sep5.Name = "sep5";
            this.sep5.Size = new System.Drawing.Size(123, 6);
            // 
            // viewStatusBar
            // 
            this.viewStatusBar.Checked = true;
            this.viewStatusBar.CheckOnClick = true;
            this.viewStatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewStatusBar.Name = "viewStatusBar";
            this.viewStatusBar.Size = new System.Drawing.Size(126, 22);
            this.viewStatusBar.Text = "&Status Bar";
            this.viewStatusBar.Click += new System.EventHandler(this.OnViewStatusBar);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsOptions});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(46, 20);
            this.toolsMenu.Text = "&Tools";
            // 
            // toolsOptions
            // 
            this.toolsOptions.Name = "toolsOptions";
            this.toolsOptions.Size = new System.Drawing.Size(116, 22);
            this.toolsOptions.Text = "&Options";
            this.toolsOptions.Click += new System.EventHandler(this.OnToolsOptions);
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 580);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(858, 22);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusStrip1";
            // 
            // navigateToolBar
            // 
            this.navigateToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.navigateToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveFirstButton,
            this.movePreviousButton,
            this.sep1,
            this.positionTextBox,
            this.countLabel,
            this.sep2,
            this.moveNextButton,
            this.moveLastButton,
            this.sep3,
            this.deleteButton,
            this.addNewButton});
            this.navigateToolBar.Location = new System.Drawing.Point(0, 24);
            this.navigateToolBar.Name = "navigateToolBar";
            this.navigateToolBar.Size = new System.Drawing.Size(858, 25);
            this.navigateToolBar.TabIndex = 2;
            this.navigateToolBar.Text = "toolStrip1";
            // 
            // moveFirstButton
            // 
            this.moveFirstButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.moveFirstButton.Image = ((System.Drawing.Image)(resources.GetObject("moveFirstButton.Image")));
            this.moveFirstButton.Name = "moveFirstButton";
            this.moveFirstButton.RightToLeftAutoMirrorImage = true;
            this.moveFirstButton.Size = new System.Drawing.Size(23, 22);
            this.moveFirstButton.Text = "Move first";
            // 
            // movePreviousButton
            // 
            this.movePreviousButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.movePreviousButton.Image = ((System.Drawing.Image)(resources.GetObject("movePreviousButton.Image")));
            this.movePreviousButton.Name = "movePreviousButton";
            this.movePreviousButton.RightToLeftAutoMirrorImage = true;
            this.movePreviousButton.Size = new System.Drawing.Size(23, 22);
            this.movePreviousButton.Text = "Move previous";
            // 
            // sep1
            // 
            this.sep1.Name = "sep1";
            this.sep1.Size = new System.Drawing.Size(6, 25);
            // 
            // positionTextBox
            // 
            this.positionTextBox.AccessibleName = "Position";
            this.positionTextBox.AutoSize = false;
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(50, 23);
            this.positionTextBox.Text = "0";
            this.positionTextBox.ToolTipText = "Current position";
            // 
            // countLabel
            // 
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(35, 22);
            this.countLabel.Text = "of {0}";
            this.countLabel.ToolTipText = "Total number of items";
            // 
            // sep2
            // 
            this.sep2.Name = "sep2";
            this.sep2.Size = new System.Drawing.Size(6, 25);
            // 
            // moveNextButton
            // 
            this.moveNextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.moveNextButton.Image = ((System.Drawing.Image)(resources.GetObject("moveNextButton.Image")));
            this.moveNextButton.Name = "moveNextButton";
            this.moveNextButton.RightToLeftAutoMirrorImage = true;
            this.moveNextButton.Size = new System.Drawing.Size(23, 22);
            this.moveNextButton.Text = "Move next";
            // 
            // moveLastButton
            // 
            this.moveLastButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.moveLastButton.Image = ((System.Drawing.Image)(resources.GetObject("moveLastButton.Image")));
            this.moveLastButton.Name = "moveLastButton";
            this.moveLastButton.RightToLeftAutoMirrorImage = true;
            this.moveLastButton.Size = new System.Drawing.Size(23, 22);
            this.moveLastButton.Text = "Move last";
            // 
            // sep3
            // 
            this.sep3.Name = "sep3";
            this.sep3.Size = new System.Drawing.Size(6, 25);
            // 
            // deleteButton
            // 
            this.deleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.RightToLeftAutoMirrorImage = true;
            this.deleteButton.Size = new System.Drawing.Size(23, 22);
            this.deleteButton.Text = "Delete";
            // 
            // addNewButton
            // 
            this.addNewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addNewButton.Image = ((System.Drawing.Image)(resources.GetObject("addNewButton.Image")));
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.RightToLeftAutoMirrorImage = true;
            this.addNewButton.Size = new System.Drawing.Size(23, 22);
            this.addNewButton.Text = "Add new";
            // 
            // reposDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.reposDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.reposDataGridView.AutoGenerateColumns = false;
            this.reposDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reposDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reposDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.cloneUrlDataGridViewTextBoxColumn});
            this.reposDataGridView.DataSource = this.reposListBindingSource;
            this.reposDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reposDataGridView.Location = new System.Drawing.Point(0, 49);
            this.reposDataGridView.Name = "reposDataGridView";
            this.reposDataGridView.Size = new System.Drawing.Size(858, 531);
            this.reposDataGridView.TabIndex = 3;
            // 
            // reposListBindingSource
            // 
            this.reposListBindingSource.DataSource = typeof(GitHubManager.Repo);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // cloneUrlDataGridViewTextBoxColumn
            // 
            this.cloneUrlDataGridViewTextBoxColumn.DataPropertyName = "CloneUrl";
            this.cloneUrlDataGridViewTextBoxColumn.HeaderText = "CloneUrl";
            this.cloneUrlDataGridViewTextBoxColumn.Name = "cloneUrlDataGridViewTextBoxColumn";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(858, 602);
            this.Controls.Add(this.reposDataGridView);
            this.Controls.Add(this.navigateToolBar);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xyLOGIX GitHub Manager";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.navigateToolBar.ResumeLayout(false);
            this.navigateToolBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reposDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStrip navigateToolBar;
        private System.Windows.Forms.ToolStripButton moveFirstButton;
        private System.Windows.Forms.ToolStripButton movePreviousButton;
        private System.Windows.Forms.ToolStripSeparator sep1;
        private System.Windows.Forms.ToolStripTextBox positionTextBox;
        private System.Windows.Forms.ToolStripLabel countLabel;
        private System.Windows.Forms.ToolStripSeparator sep2;
        private System.Windows.Forms.ToolStripButton moveNextButton;
        private System.Windows.Forms.ToolStripButton moveLastButton;
        private System.Windows.Forms.ToolStripSeparator sep3;
        private System.Windows.Forms.ToolStripButton deleteButton;
        private System.Windows.Forms.ToolStripButton addNewButton;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem fileExit;
        private System.Windows.Forms.ToolStripMenuItem fileLogin;
        private System.Windows.Forms.ToolStripSeparator sep4;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem viewToolbarsMenu;
        private System.Windows.Forms.ToolStripMenuItem viewNavigateToolbar;
        private System.Windows.Forms.ToolStripSeparator sep5;
        private System.Windows.Forms.ToolStripMenuItem viewStatusBar;
        private System.Windows.Forms.DataGridView reposDataGridView;
        private System.Windows.Forms.BindingSource reposListBindingSource;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem toolsOptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cloneUrlDataGridViewTextBoxColumn;
    }
}

