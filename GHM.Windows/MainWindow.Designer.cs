using xyLOGIX.OAuth.GitHub.Models;

namespace GHM.Windows
{
    public partial class MainWindow
    {

        private System.Windows.Forms.DataGridViewTextBoxColumn cloneUrlDataGridViewTextBoxColumn;

        ///  <summary> Required designer variable. </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ToolStripLabel countLabel;

        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;

        private xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem fileExit;

        private xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem fileLogin;

        private xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem fileMenu;

        private xyLOGIX.UI.Dark.Controls.DarkMenuStrip mainMenu;

        private System.Windows.Forms.ToolStripButton moveFirstButton;

        private System.Windows.Forms.ToolStripButton moveLastButton;

        private System.Windows.Forms.ToolStripButton moveNextButton;

        private System.Windows.Forms.ToolStripButton movePreviousButton;

        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;

        private xyLOGIX.UI.Dark.Controls.DarkBindingNavigator navigateToolBar;

        private System.Windows.Forms.ToolStripTextBox positionTextBox;

        private System.Windows.Forms.DataGridView reposDataGridView;

        private System.Windows.Forms.BindingSource reposListBindingSource;

        private xyLOGIX.UI.Dark.Controls.DarkToolStripSeparator sep1;

        private xyLOGIX.UI.Dark.Controls.DarkToolStripSeparator sep2;

        private xyLOGIX.UI.Dark.Controls.DarkToolStripSeparator sep4;

        private xyLOGIX.UI.Dark.Controls.DarkToolStripSeparator sep5;

        private xyLOGIX.UI.Dark.Controls.DarkStatusStrip statusBar;

        private xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem toolsMenu;

        private xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem toolsOptions;

        private xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem viewMenu;

        private xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem viewNavigateToolbar;

        private xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem viewStatusBar;

        private xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem viewToolbarsMenu;

        private System.Windows.Forms.Panel workspacePanel;

        ///  <summary> Clean up any resources being used. </summary> <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        ///  <summary> Required method for Designer support - do not modify the contents of this method with the code editor. </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainMenu = new xyLOGIX.UI.Dark.Controls.DarkMenuStrip();
            this.fileMenu = new xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem();
            this.fileLogin = new xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem();
            this.sep4 = new xyLOGIX.UI.Dark.Controls.DarkToolStripSeparator();
            this.fileExit = new xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem();
            this.viewMenu = new xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem();
            this.viewToolbarsMenu = new xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem();
            this.viewNavigateToolbar = new xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem();
            this.sep5 = new xyLOGIX.UI.Dark.Controls.DarkToolStripSeparator();
            this.viewStatusBar = new xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem();
            this.toolsMenu = new xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem();
            this.toolsOptions = new xyLOGIX.UI.Dark.Controls.DarkToolStripMenuItem();
            this.statusBar = new xyLOGIX.UI.Dark.Controls.DarkStatusStrip();
            this.navigateToolBar = new xyLOGIX.UI.Dark.Controls.DarkBindingNavigator(this.components);
            this.reposListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countLabel = new System.Windows.Forms.ToolStripLabel();
            this.moveFirstButton = new System.Windows.Forms.ToolStripButton();
            this.movePreviousButton = new System.Windows.Forms.ToolStripButton();
            this.sep1 = new xyLOGIX.UI.Dark.Controls.DarkToolStripSeparator();
            this.positionTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.sep2 = new xyLOGIX.UI.Dark.Controls.DarkToolStripSeparator();
            this.moveNextButton = new System.Windows.Forms.ToolStripButton();
            this.moveLastButton = new System.Windows.Forms.ToolStripButton();
            this.reposDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cloneUrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workspacePanel = new System.Windows.Forms.Panel();
            this.fileSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigateToolBar)).BeginInit();
            this.navigateToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reposListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.Transparent;
            this.mainMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.mainMenu.IsDarkTheme = false;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.viewMenu,
            this.toolsMenu});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(858, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            this.mainMenu.ToggleUppercase = false;
            // 
            // fileMenu
            // 
            this.fileMenu.BackColor = System.Drawing.Color.Transparent;
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileLogin,
            this.fileSignOut,
            this.sep4,
            this.fileExit});
            this.fileMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            this.fileMenu.DropDownOpening += new System.EventHandler(this.OnFileMenuDropDownOpening);
            // 
            // fileLogin
            // 
            this.fileLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.fileLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.fileLogin.Name = "fileLogin";
            this.fileLogin.Size = new System.Drawing.Size(180, 22);
            this.fileLogin.Text = "&Login...";
            this.fileLogin.Click += new System.EventHandler(this.OnFileLogin);
            // 
            // sep4
            // 
            this.sep4.Name = "sep4";
            this.sep4.Size = new System.Drawing.Size(177, 6);
            // 
            // fileExit
            // 
            this.fileExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.fileExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.fileExit.Name = "fileExit";
            this.fileExit.Size = new System.Drawing.Size(180, 22);
            this.fileExit.Text = "E&xit";
            this.fileExit.Click += new System.EventHandler(this.OnFileExit);
            // 
            // viewMenu
            // 
            this.viewMenu.BackColor = System.Drawing.Color.Transparent;
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolbarsMenu,
            this.sep5,
            this.viewStatusBar});
            this.viewMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(44, 20);
            this.viewMenu.Text = "&View";
            this.viewMenu.DropDownOpening += new System.EventHandler(this.OnDropDownOpeningViewMenu);
            // 
            // viewToolbarsMenu
            // 
            this.viewToolbarsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.viewToolbarsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewNavigateToolbar});
            this.viewToolbarsMenu.Name = "viewToolbarsMenu";
            this.viewToolbarsMenu.Size = new System.Drawing.Size(126, 22);
            this.viewToolbarsMenu.Text = "&Toolbars";
            this.viewToolbarsMenu.DropDownOpening += new System.EventHandler(this.OnDropDownOpeningViewToolbarsMenu);
            // 
            // viewNavigateToolbar
            // 
            this.viewNavigateToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
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
            this.viewStatusBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
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
            this.toolsMenu.BackColor = System.Drawing.Color.Transparent;
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsOptions});
            this.toolsMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(46, 20);
            this.toolsMenu.Text = "&Tools";
            // 
            // toolsOptions
            // 
            this.toolsOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.toolsOptions.Name = "toolsOptions";
            this.toolsOptions.Size = new System.Drawing.Size(116, 22);
            this.toolsOptions.Text = "&Options";
            this.toolsOptions.Click += new System.EventHandler(this.OnToolsOptions);
            // 
            // statusBar
            // 
            this.statusBar.AutoSize = false;
            this.statusBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.statusBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.statusBar.IsDarkTheme = true;
            this.statusBar.Location = new System.Drawing.Point(0, 580);
            this.statusBar.Name = "statusBar";
            this.statusBar.PrimaryBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.statusBar.SecondaryBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.statusBar.Size = new System.Drawing.Size(858, 22);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusStrip1";
            // 
            // navigateToolBar
            // 
            this.navigateToolBar.AddNewItem = null;
            this.navigateToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.navigateToolBar.BindingSource = this.reposListBindingSource;
            this.navigateToolBar.CountItem = this.countLabel;
            this.navigateToolBar.DeleteItem = null;
            this.navigateToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.navigateToolBar.IsDarkTheme = false;
            this.navigateToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveFirstButton,
            this.movePreviousButton,
            this.sep1,
            this.positionTextBox,
            this.countLabel,
            this.sep2,
            this.moveNextButton,
            this.moveLastButton});
            this.navigateToolBar.Location = new System.Drawing.Point(0, 24);
            this.navigateToolBar.MoveFirstItem = this.moveFirstButton;
            this.navigateToolBar.MoveLastItem = this.moveLastButton;
            this.navigateToolBar.MoveNextItem = this.moveNextButton;
            this.navigateToolBar.MovePreviousItem = this.movePreviousButton;
            this.navigateToolBar.Name = "navigateToolBar";
            this.navigateToolBar.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.navigateToolBar.PositionItem = this.positionTextBox;
            this.navigateToolBar.Size = new System.Drawing.Size(858, 25);
            this.navigateToolBar.TabIndex = 2;
            this.navigateToolBar.Text = "toolStrip1";
            // 
            // reposListBindingSource
            // 
            this.reposListBindingSource.DataSource = typeof(xyLOGIX.OAuth.GitHub.Models.RemoteRepo);
            // 
            // countLabel
            // 
            this.countLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.countLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(35, 22);
            this.countLabel.Text = "of {0}";
            this.countLabel.ToolTipText = "Total number of items";
            // 
            // moveFirstButton
            // 
            this.moveFirstButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.moveFirstButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.moveFirstButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.moveFirstButton.Image = ((System.Drawing.Image)(resources.GetObject("moveFirstButton.Image")));
            this.moveFirstButton.Name = "moveFirstButton";
            this.moveFirstButton.RightToLeftAutoMirrorImage = true;
            this.moveFirstButton.Size = new System.Drawing.Size(23, 22);
            this.moveFirstButton.Text = "Move first";
            // 
            // movePreviousButton
            // 
            this.movePreviousButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.movePreviousButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.movePreviousButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.movePreviousButton.Image = ((System.Drawing.Image)(resources.GetObject("movePreviousButton.Image")));
            this.movePreviousButton.Name = "movePreviousButton";
            this.movePreviousButton.RightToLeftAutoMirrorImage = true;
            this.movePreviousButton.Size = new System.Drawing.Size(23, 22);
            this.movePreviousButton.Text = "Move previous";
            // 
            // sep1
            // 
            this.sep1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.sep1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sep1.Name = "sep1";
            this.sep1.Size = new System.Drawing.Size(6, 25);
            // 
            // positionTextBox
            // 
            this.positionTextBox.AccessibleName = "Position";
            this.positionTextBox.AutoSize = false;
            this.positionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.positionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.positionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(50, 23);
            this.positionTextBox.Text = "0";
            this.positionTextBox.ToolTipText = "Current position";
            // 
            // sep2
            // 
            this.sep2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.sep2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sep2.Name = "sep2";
            this.sep2.Size = new System.Drawing.Size(6, 25);
            // 
            // moveNextButton
            // 
            this.moveNextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.moveNextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.moveNextButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.moveNextButton.Image = ((System.Drawing.Image)(resources.GetObject("moveNextButton.Image")));
            this.moveNextButton.Name = "moveNextButton";
            this.moveNextButton.RightToLeftAutoMirrorImage = true;
            this.moveNextButton.Size = new System.Drawing.Size(23, 22);
            this.moveNextButton.Text = "Move next";
            // 
            // moveLastButton
            // 
            this.moveLastButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.moveLastButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.moveLastButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.moveLastButton.Image = ((System.Drawing.Image)(resources.GetObject("moveLastButton.Image")));
            this.moveLastButton.Name = "moveLastButton";
            this.moveLastButton.RightToLeftAutoMirrorImage = true;
            this.moveLastButton.Size = new System.Drawing.Size(23, 22);
            this.moveLastButton.Text = "Move last";
            // 
            // reposDataGridView
            // 
            this.reposDataGridView.AllowUserToAddRows = false;
            this.reposDataGridView.AllowUserToDeleteRows = false;
            this.reposDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.reposDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.reposDataGridView.AutoGenerateColumns = false;
            this.reposDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reposDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.reposDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reposDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.reposDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reposDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.cloneUrlDataGridViewTextBoxColumn});
            this.reposDataGridView.DataSource = this.reposListBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.reposDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.reposDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reposDataGridView.EnableHeadersVisualStyles = false;
            this.reposDataGridView.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.reposDataGridView.Location = new System.Drawing.Point(0, 49);
            this.reposDataGridView.Name = "reposDataGridView";
            this.reposDataGridView.ReadOnly = true;
            this.reposDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reposDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.reposDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.reposDataGridView.Size = new System.Drawing.Size(858, 531);
            this.reposDataGridView.TabIndex = 3;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cloneUrlDataGridViewTextBoxColumn
            // 
            this.cloneUrlDataGridViewTextBoxColumn.DataPropertyName = "CloneUrl";
            this.cloneUrlDataGridViewTextBoxColumn.HeaderText = "CloneUrl";
            this.cloneUrlDataGridViewTextBoxColumn.Name = "cloneUrlDataGridViewTextBoxColumn";
            this.cloneUrlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workspacePanel
            // 
            this.workspacePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.workspacePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workspacePanel.Location = new System.Drawing.Point(0, 49);
            this.workspacePanel.Name = "workspacePanel";
            this.workspacePanel.Size = new System.Drawing.Size(858, 531);
            this.workspacePanel.TabIndex = 4;
            // 
            // fileSignOut
            // 
            this.fileSignOut.BackColor = System.Drawing.Color.Transparent;
            this.fileSignOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.fileSignOut.Name = "fileSignOut";
            this.fileSignOut.Size = new System.Drawing.Size(180, 22);
            this.fileSignOut.Text = "Sign Out";
            this.fileSignOut.Click += new System.EventHandler(this.OnFileSignOut);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(858, 602);
            this.Controls.Add(this.workspacePanel);
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
            ((System.ComponentModel.ISupportInitialize)(this.navigateToolBar)).EndInit();
            this.navigateToolBar.ResumeLayout(false);
            this.navigateToolBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reposListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ToolStripMenuItem fileSignOut;
    }
}