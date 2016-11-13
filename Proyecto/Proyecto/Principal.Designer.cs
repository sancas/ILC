namespace Proyecto
{
    partial class Principal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.PrincipalStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.TopPanel = new MetroFramework.Controls.MetroPanel();
            this.TopUserInfoPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAuthUserEmail = new MetroFramework.Controls.MetroLabel();
            this.linkChangePassword = new MetroFramework.Controls.MetroLink();
            this.avatarPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutAdminMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutLeft = new System.Windows.Forms.TableLayoutPanel();
            this.btnUsers = new MetroFramework.Controls.MetroTile();
            this.btnRoles = new MetroFramework.Controls.MetroTile();
            this.btnTravelProblems = new MetroFramework.Controls.MetroTile();
            this.btnGraph = new MetroFramework.Controls.MetroTile();
            this.MainTabControl = new MetroFramework.Controls.MetroTabControl();
            this.UsersTabPage = new MetroFramework.Controls.MetroTabPage();
            this.userDataGridView = new MetroFramework.Controls.MetroGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.userBindingNavigatorAddNew = new System.Windows.Forms.ToolStripButton();
            this.userBindingNavigatorDelete = new System.Windows.Forms.ToolStripButton();
            this.userBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.RolesTabPage = new MetroFramework.Controls.MetroTabPage();
            this.roleDataGridView = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.roleBindingNavigatorNewItem = new System.Windows.Forms.ToolStripButton();
            this.roleBindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.roleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.TravelProblemsTabPage = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.GraphTabPage = new MetroFramework.Controls.MetroTabPage();
            this.btnCambiarNodo = new MetroFramework.Controls.MetroButton();
            this.btnCambiarBackground = new MetroFramework.Controls.MetroButton();
            this.lblNodoImage = new MetroFramework.Controls.MetroLabel();
            this.pbNodo = new System.Windows.Forms.PictureBox();
            this.lblGraphActivo = new MetroFramework.Controls.MetroLabel();
            this.activoMetroToggle = new MetroFramework.Controls.MetroToggle();
            this.lblGraphBackground = new MetroFramework.Controls.MetroLabel();
            this.pbGraphBackground = new System.Windows.Forms.PictureBox();
            this.graphBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.graphBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewGraph = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem2 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstGraph = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousGraph = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem2 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextGraph = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastGraph = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDeleteGraph = new System.Windows.Forms.ToolStripButton();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnkActivar = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.PrincipalStyleManager)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.TopUserInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            this.tableLayoutAdminMain.SuspendLayout();
            this.tableLayoutLeft.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.UsersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingNavigator)).BeginInit();
            this.userBindingNavigator.SuspendLayout();
            this.RolesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingNavigator)).BeginInit();
            this.roleBindingNavigator.SuspendLayout();
            this.TravelProblemsTabPage.SuspendLayout();
            this.GraphTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGraphBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphBindingNavigator)).BeginInit();
            this.graphBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrincipalStyleManager
            // 
            this.PrincipalStyleManager.Owner = this;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.TopUserInfoPanel);
            this.TopPanel.Controls.Add(this.avatarPictureBox);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.HorizontalScrollbarBarColor = true;
            this.TopPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.TopPanel.HorizontalScrollbarSize = 10;
            this.TopPanel.Location = new System.Drawing.Point(0, 60);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(620, 54);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.VerticalScrollbarBarColor = true;
            this.TopPanel.VerticalScrollbarHighlightOnWheel = false;
            this.TopPanel.VerticalScrollbarSize = 10;
            // 
            // TopUserInfoPanel
            // 
            this.TopUserInfoPanel.AutoSize = true;
            this.TopUserInfoPanel.Controls.Add(this.lblAuthUserEmail);
            this.TopUserInfoPanel.Controls.Add(this.linkChangePassword);
            this.TopUserInfoPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.TopUserInfoPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.TopUserInfoPanel.Location = new System.Drawing.Point(441, 0);
            this.TopUserInfoPanel.Name = "TopUserInfoPanel";
            this.TopUserInfoPanel.Size = new System.Drawing.Size(131, 54);
            this.TopUserInfoPanel.TabIndex = 2;
            // 
            // lblAuthUserEmail
            // 
            this.lblAuthUserEmail.AutoSize = true;
            this.lblAuthUserEmail.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAuthUserEmail.Location = new System.Drawing.Point(3, 0);
            this.lblAuthUserEmail.Name = "lblAuthUserEmail";
            this.lblAuthUserEmail.Size = new System.Drawing.Size(125, 25);
            this.lblAuthUserEmail.TabIndex = 2;
            this.lblAuthUserEmail.Text = "AuthUser.Email";
            this.lblAuthUserEmail.UseStyleColors = true;
            // 
            // linkChangePassword
            // 
            this.linkChangePassword.Location = new System.Drawing.Point(10, 28);
            this.linkChangePassword.Name = "linkChangePassword";
            this.linkChangePassword.Size = new System.Drawing.Size(118, 23);
            this.linkChangePassword.TabIndex = 1;
            this.linkChangePassword.Text = "Cambiar contraseña";
            this.linkChangePassword.UseSelectable = true;
            this.linkChangePassword.UseStyleColors = true;
            this.linkChangePassword.Click += new System.EventHandler(this.linkChangePassword_Click);
            // 
            // avatarPictureBox
            // 
            this.avatarPictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.avatarPictureBox.InitialImage = null;
            this.avatarPictureBox.Location = new System.Drawing.Point(572, 0);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.Size = new System.Drawing.Size(48, 54);
            this.avatarPictureBox.TabIndex = 3;
            this.avatarPictureBox.TabStop = false;
            // 
            // tableLayoutAdminMain
            // 
            this.tableLayoutAdminMain.ColumnCount = 2;
            this.tableLayoutAdminMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.14F));
            this.tableLayoutAdminMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.86F));
            this.tableLayoutAdminMain.Controls.Add(this.tableLayoutLeft, 0, 0);
            this.tableLayoutAdminMain.Controls.Add(this.MainTabControl, 1, 0);
            this.tableLayoutAdminMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutAdminMain.Location = new System.Drawing.Point(0, 114);
            this.tableLayoutAdminMain.Name = "tableLayoutAdminMain";
            this.tableLayoutAdminMain.RowCount = 1;
            this.tableLayoutAdminMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutAdminMain.Size = new System.Drawing.Size(620, 366);
            this.tableLayoutAdminMain.TabIndex = 1;
            // 
            // tableLayoutLeft
            // 
            this.tableLayoutLeft.BackColor = System.Drawing.Color.White;
            this.tableLayoutLeft.ColumnCount = 1;
            this.tableLayoutLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutLeft.Controls.Add(this.btnUsers, 0, 0);
            this.tableLayoutLeft.Controls.Add(this.btnRoles, 0, 1);
            this.tableLayoutLeft.Controls.Add(this.btnTravelProblems, 0, 2);
            this.tableLayoutLeft.Controls.Add(this.btnGraph, 0, 3);
            this.tableLayoutLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutLeft.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutLeft.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutLeft.Name = "tableLayoutLeft";
            this.tableLayoutLeft.RowCount = 4;
            this.tableLayoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutLeft.Size = new System.Drawing.Size(100, 366);
            this.tableLayoutLeft.TabIndex = 3;
            // 
            // btnUsers
            // 
            this.btnUsers.ActiveControl = null;
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsers.Location = new System.Drawing.Point(0, 0);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(0);
            this.btnUsers.MinimumSize = new System.Drawing.Size(100, 0);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(100, 91);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "Usuarios";
            this.btnUsers.TileImage = ((System.Drawing.Image)(resources.GetObject("btnUsers.TileImage")));
            this.btnUsers.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUsers.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnUsers.UseSelectable = true;
            this.btnUsers.UseStyleColors = true;
            this.btnUsers.UseTileImage = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnRoles
            // 
            this.btnRoles.ActiveControl = null;
            this.btnRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRoles.Location = new System.Drawing.Point(0, 91);
            this.btnRoles.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoles.MinimumSize = new System.Drawing.Size(100, 0);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(100, 91);
            this.btnRoles.Style = MetroFramework.MetroColorStyle.Green;
            this.btnRoles.TabIndex = 1;
            this.btnRoles.Text = "Roles";
            this.btnRoles.TileImage = ((System.Drawing.Image)(resources.GetObject("btnRoles.TileImage")));
            this.btnRoles.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRoles.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnRoles.UseSelectable = true;
            this.btnRoles.UseStyleColors = true;
            this.btnRoles.UseTileImage = true;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // btnTravelProblems
            // 
            this.btnTravelProblems.ActiveControl = null;
            this.btnTravelProblems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTravelProblems.Location = new System.Drawing.Point(0, 182);
            this.btnTravelProblems.Margin = new System.Windows.Forms.Padding(0);
            this.btnTravelProblems.MinimumSize = new System.Drawing.Size(100, 0);
            this.btnTravelProblems.Name = "btnTravelProblems";
            this.btnTravelProblems.Size = new System.Drawing.Size(100, 91);
            this.btnTravelProblems.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnTravelProblems.TabIndex = 2;
            this.btnTravelProblems.Text = "Problemas";
            this.btnTravelProblems.TileImage = ((System.Drawing.Image)(resources.GetObject("btnTravelProblems.TileImage")));
            this.btnTravelProblems.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTravelProblems.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnTravelProblems.UseSelectable = true;
            this.btnTravelProblems.UseStyleColors = true;
            this.btnTravelProblems.UseTileImage = true;
            this.btnTravelProblems.Click += new System.EventHandler(this.btnTravelProblems_Click);
            // 
            // btnGraph
            // 
            this.btnGraph.ActiveControl = null;
            this.btnGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGraph.Location = new System.Drawing.Point(0, 273);
            this.btnGraph.Margin = new System.Windows.Forms.Padding(0);
            this.btnGraph.MinimumSize = new System.Drawing.Size(100, 0);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(100, 93);
            this.btnGraph.Style = MetroFramework.MetroColorStyle.Red;
            this.btnGraph.TabIndex = 3;
            this.btnGraph.Text = "Grafo";
            this.btnGraph.TileImage = ((System.Drawing.Image)(resources.GetObject("btnGraph.TileImage")));
            this.btnGraph.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGraph.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnGraph.UseSelectable = true;
            this.btnGraph.UseStyleColors = true;
            this.btnGraph.UseTileImage = true;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.UsersTabPage);
            this.MainTabControl.Controls.Add(this.RolesTabPage);
            this.MainTabControl.Controls.Add(this.TravelProblemsTabPage);
            this.MainTabControl.Controls.Add(this.GraphTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.ItemSize = new System.Drawing.Size(54, 20);
            this.MainTabControl.Location = new System.Drawing.Point(103, 3);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 3;
            this.MainTabControl.Size = new System.Drawing.Size(514, 360);
            this.MainTabControl.TabIndex = 4;
            this.MainTabControl.UseSelectable = true;
            // 
            // UsersTabPage
            // 
            this.UsersTabPage.Controls.Add(this.userDataGridView);
            this.UsersTabPage.Controls.Add(this.userBindingNavigator);
            this.UsersTabPage.HorizontalScrollbar = true;
            this.UsersTabPage.HorizontalScrollbarBarColor = false;
            this.UsersTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.UsersTabPage.HorizontalScrollbarSize = 0;
            this.UsersTabPage.Location = new System.Drawing.Point(4, 24);
            this.UsersTabPage.Name = "UsersTabPage";
            this.UsersTabPage.Size = new System.Drawing.Size(506, 332);
            this.UsersTabPage.TabIndex = 0;
            this.UsersTabPage.Text = "Users";
            this.UsersTabPage.VerticalScrollbar = true;
            this.UsersTabPage.VerticalScrollbarBarColor = false;
            this.UsersTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.UsersTabPage.VerticalScrollbarSize = 0;
            this.UsersTabPage.Enter += new System.EventHandler(this.UsersTabPage_Enter);
            // 
            // userDataGridView
            // 
            this.userDataGridView.AllowUserToAddRows = false;
            this.userDataGridView.AllowUserToOrderColumns = true;
            this.userDataGridView.AllowUserToResizeRows = false;
            this.userDataGridView.AutoGenerateColumns = false;
            this.userDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.userDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.userDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.RoleId});
            this.userDataGridView.DataSource = this.userBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.userDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userDataGridView.EnableHeadersVisualStyles = false;
            this.userDataGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.userDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userDataGridView.Location = new System.Drawing.Point(0, 25);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.userDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.userDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userDataGridView.Size = new System.Drawing.Size(506, 307);
            this.userDataGridView.TabIndex = 5;
            this.userDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.userDataGridView_DataError);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // RoleId
            // 
            this.RoleId.DataPropertyName = "RoleId";
            this.RoleId.DataSource = this.roleBindingSource;
            this.RoleId.DisplayMember = "Name";
            this.RoleId.HeaderText = "Role";
            this.RoleId.Name = "RoleId";
            this.RoleId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RoleId.ValueMember = "Id";
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(Proyecto.Data.Role);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Proyecto.Data.User);
            // 
            // userBindingNavigator
            // 
            this.userBindingNavigator.AddNewItem = null;
            this.userBindingNavigator.BindingSource = this.userBindingSource;
            this.userBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.userBindingNavigator.DeleteItem = null;
            this.userBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.userBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.userBindingNavigatorAddNew,
            this.userBindingNavigatorDelete,
            this.userBindingNavigatorSaveItem});
            this.userBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.userBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.userBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.userBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.userBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.userBindingNavigator.Name = "userBindingNavigator";
            this.userBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.userBindingNavigator.Size = new System.Drawing.Size(506, 25);
            this.userBindingNavigator.TabIndex = 4;
            this.userBindingNavigator.Text = "userBindingNavigator";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // userBindingNavigatorAddNew
            // 
            this.userBindingNavigatorAddNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userBindingNavigatorAddNew.Image = ((System.Drawing.Image)(resources.GetObject("userBindingNavigatorAddNew.Image")));
            this.userBindingNavigatorAddNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.userBindingNavigatorAddNew.Name = "userBindingNavigatorAddNew";
            this.userBindingNavigatorAddNew.Size = new System.Drawing.Size(23, 22);
            this.userBindingNavigatorAddNew.Text = "Agregar nuevo usuario";
            this.userBindingNavigatorAddNew.Click += new System.EventHandler(this.userBindingNavigatorAddNew_Click);
            // 
            // userBindingNavigatorDelete
            // 
            this.userBindingNavigatorDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userBindingNavigatorDelete.Image = ((System.Drawing.Image)(resources.GetObject("userBindingNavigatorDelete.Image")));
            this.userBindingNavigatorDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.userBindingNavigatorDelete.Name = "userBindingNavigatorDelete";
            this.userBindingNavigatorDelete.Size = new System.Drawing.Size(23, 22);
            this.userBindingNavigatorDelete.Text = "Eliminar usuario";
            this.userBindingNavigatorDelete.Click += new System.EventHandler(this.userBindingNavigatorDelete_Click);
            // 
            // userBindingNavigatorSaveItem
            // 
            this.userBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("userBindingNavigatorSaveItem.Image")));
            this.userBindingNavigatorSaveItem.Name = "userBindingNavigatorSaveItem";
            this.userBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.userBindingNavigatorSaveItem.Text = "Guardar datos";
            this.userBindingNavigatorSaveItem.Click += new System.EventHandler(this.userBindingNavigatorSaveItem_Click);
            // 
            // RolesTabPage
            // 
            this.RolesTabPage.Controls.Add(this.roleDataGridView);
            this.RolesTabPage.Controls.Add(this.roleBindingNavigator);
            this.RolesTabPage.HorizontalScrollbarBarColor = true;
            this.RolesTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.RolesTabPage.HorizontalScrollbarSize = 10;
            this.RolesTabPage.Location = new System.Drawing.Point(4, 24);
            this.RolesTabPage.Name = "RolesTabPage";
            this.RolesTabPage.Size = new System.Drawing.Size(506, 332);
            this.RolesTabPage.TabIndex = 1;
            this.RolesTabPage.Text = "Roles";
            this.RolesTabPage.VerticalScrollbarBarColor = true;
            this.RolesTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.RolesTabPage.VerticalScrollbarSize = 10;
            this.RolesTabPage.Enter += new System.EventHandler(this.RolesTabPage_Enter);
            // 
            // roleDataGridView
            // 
            this.roleDataGridView.AllowUserToOrderColumns = true;
            this.roleDataGridView.AllowUserToResizeRows = false;
            this.roleDataGridView.AutoGenerateColumns = false;
            this.roleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.roleDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.roleDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.roleDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roleDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.roleDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roleDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.roleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1});
            this.roleDataGridView.DataSource = this.roleBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.roleDataGridView.DefaultCellStyle = dataGridViewCellStyle11;
            this.roleDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roleDataGridView.EnableHeadersVisualStyles = false;
            this.roleDataGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.roleDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.roleDataGridView.Location = new System.Drawing.Point(0, 25);
            this.roleDataGridView.Name = "roleDataGridView";
            this.roleDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roleDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.roleDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.roleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.roleDataGridView.Size = new System.Drawing.Size(506, 307);
            this.roleDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // roleBindingNavigator
            // 
            this.roleBindingNavigator.AddNewItem = null;
            this.roleBindingNavigator.BindingSource = this.roleBindingSource;
            this.roleBindingNavigator.CountItem = this.bindingNavigatorCountItem1;
            this.roleBindingNavigator.DeleteItem = null;
            this.roleBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.roleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.roleBindingNavigatorNewItem,
            this.roleBindingNavigatorDeleteItem,
            this.roleBindingNavigatorSaveItem});
            this.roleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.roleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.roleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.roleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.roleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.roleBindingNavigator.Name = "roleBindingNavigator";
            this.roleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem1;
            this.roleBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.roleBindingNavigator.Size = new System.Drawing.Size(506, 25);
            this.roleBindingNavigator.TabIndex = 3;
            this.roleBindingNavigator.Text = "roleBindingNavigator";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem1.Text = "de {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Mover último";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // roleBindingNavigatorNewItem
            // 
            this.roleBindingNavigatorNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.roleBindingNavigatorNewItem.Image = ((System.Drawing.Image)(resources.GetObject("roleBindingNavigatorNewItem.Image")));
            this.roleBindingNavigatorNewItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.roleBindingNavigatorNewItem.Name = "roleBindingNavigatorNewItem";
            this.roleBindingNavigatorNewItem.Size = new System.Drawing.Size(23, 22);
            this.roleBindingNavigatorNewItem.Text = "Agregar role";
            this.roleBindingNavigatorNewItem.Click += new System.EventHandler(this.roleBindingNavigatorNewItem_Click);
            // 
            // roleBindingNavigatorDeleteItem
            // 
            this.roleBindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.roleBindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("roleBindingNavigatorDeleteItem.Image")));
            this.roleBindingNavigatorDeleteItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.roleBindingNavigatorDeleteItem.Name = "roleBindingNavigatorDeleteItem";
            this.roleBindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.roleBindingNavigatorDeleteItem.Text = "toolStripButton1";
            this.roleBindingNavigatorDeleteItem.Click += new System.EventHandler(this.roleBindingNavigatorDeleteItem_Click);
            // 
            // roleBindingNavigatorSaveItem
            // 
            this.roleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.roleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("roleBindingNavigatorSaveItem.Image")));
            this.roleBindingNavigatorSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.roleBindingNavigatorSaveItem.Name = "roleBindingNavigatorSaveItem";
            this.roleBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.roleBindingNavigatorSaveItem.Text = "Guardar base";
            this.roleBindingNavigatorSaveItem.Click += new System.EventHandler(this.roleBindingNavigatorSaveItem_Click);
            // 
            // TravelProblemsTabPage
            // 
            this.TravelProblemsTabPage.Controls.Add(this.metroLabel3);
            this.TravelProblemsTabPage.HorizontalScrollbarBarColor = true;
            this.TravelProblemsTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.TravelProblemsTabPage.HorizontalScrollbarSize = 10;
            this.TravelProblemsTabPage.Location = new System.Drawing.Point(4, 24);
            this.TravelProblemsTabPage.Name = "TravelProblemsTabPage";
            this.TravelProblemsTabPage.Size = new System.Drawing.Size(506, 332);
            this.TravelProblemsTabPage.TabIndex = 2;
            this.TravelProblemsTabPage.Text = "Travel Problems";
            this.TravelProblemsTabPage.VerticalScrollbarBarColor = true;
            this.TravelProblemsTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.TravelProblemsTabPage.VerticalScrollbarSize = 10;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(130, 166);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(163, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "CRUD TRAVEL PROBLEMS";
            // 
            // GraphTabPage
            // 
            this.GraphTabPage.AutoScroll = true;
            this.GraphTabPage.Controls.Add(this.lnkActivar);
            this.GraphTabPage.Controls.Add(this.btnCambiarNodo);
            this.GraphTabPage.Controls.Add(this.btnCambiarBackground);
            this.GraphTabPage.Controls.Add(this.lblNodoImage);
            this.GraphTabPage.Controls.Add(this.pbNodo);
            this.GraphTabPage.Controls.Add(this.lblGraphActivo);
            this.GraphTabPage.Controls.Add(this.activoMetroToggle);
            this.GraphTabPage.Controls.Add(this.lblGraphBackground);
            this.GraphTabPage.Controls.Add(this.pbGraphBackground);
            this.GraphTabPage.Controls.Add(this.graphBindingNavigator);
            this.GraphTabPage.HorizontalScrollbar = true;
            this.GraphTabPage.HorizontalScrollbarBarColor = true;
            this.GraphTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.GraphTabPage.HorizontalScrollbarSize = 10;
            this.GraphTabPage.Location = new System.Drawing.Point(4, 24);
            this.GraphTabPage.Name = "GraphTabPage";
            this.GraphTabPage.Size = new System.Drawing.Size(506, 332);
            this.GraphTabPage.TabIndex = 3;
            this.GraphTabPage.Text = "Graph";
            this.GraphTabPage.VerticalScrollbar = true;
            this.GraphTabPage.VerticalScrollbarBarColor = true;
            this.GraphTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.GraphTabPage.VerticalScrollbarSize = 10;
            this.GraphTabPage.Enter += new System.EventHandler(this.GraphTabPage_Enter);
            // 
            // btnCambiarNodo
            // 
            this.btnCambiarNodo.Highlight = true;
            this.btnCambiarNodo.Location = new System.Drawing.Point(319, 141);
            this.btnCambiarNodo.Name = "btnCambiarNodo";
            this.btnCambiarNodo.Size = new System.Drawing.Size(118, 23);
            this.btnCambiarNodo.TabIndex = 11;
            this.btnCambiarNodo.Text = "Cambiar...";
            this.btnCambiarNodo.UseSelectable = true;
            this.btnCambiarNodo.UseStyleColors = true;
            this.btnCambiarNodo.Click += new System.EventHandler(this.btnCambiarNodo_Click);
            // 
            // btnCambiarBackground
            // 
            this.btnCambiarBackground.Highlight = true;
            this.btnCambiarBackground.Location = new System.Drawing.Point(116, 291);
            this.btnCambiarBackground.Name = "btnCambiarBackground";
            this.btnCambiarBackground.Size = new System.Drawing.Size(185, 23);
            this.btnCambiarBackground.TabIndex = 10;
            this.btnCambiarBackground.Text = "Cambiar...";
            this.btnCambiarBackground.UseSelectable = true;
            this.btnCambiarBackground.UseStyleColors = true;
            this.btnCambiarBackground.Click += new System.EventHandler(this.btnCambiarBackground_Click);
            // 
            // lblNodoImage
            // 
            this.lblNodoImage.AutoSize = true;
            this.lblNodoImage.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNodoImage.Location = new System.Drawing.Point(319, 60);
            this.lblNodoImage.Name = "lblNodoImage";
            this.lblNodoImage.Size = new System.Drawing.Size(118, 25);
            this.lblNodoImage.TabIndex = 9;
            this.lblNodoImage.Text = "Imagen nodo:";
            this.lblNodoImage.UseStyleColors = true;
            // 
            // pbNodo
            // 
            this.pbNodo.Location = new System.Drawing.Point(319, 88);
            this.pbNodo.Name = "pbNodo";
            this.pbNodo.Size = new System.Drawing.Size(54, 47);
            this.pbNodo.TabIndex = 8;
            this.pbNodo.TabStop = false;
            // 
            // lblGraphActivo
            // 
            this.lblGraphActivo.AutoSize = true;
            this.lblGraphActivo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblGraphActivo.Location = new System.Drawing.Point(319, 170);
            this.lblGraphActivo.Name = "lblGraphActivo";
            this.lblGraphActivo.Size = new System.Drawing.Size(103, 25);
            this.lblGraphActivo.TabIndex = 7;
            this.lblGraphActivo.Text = "Grafo activo";
            this.lblGraphActivo.UseStyleColors = true;
            // 
            // activoMetroToggle
            // 
            this.activoMetroToggle.AutoSize = true;
            this.activoMetroToggle.Enabled = false;
            this.activoMetroToggle.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.activoMetroToggle.Location = new System.Drawing.Point(319, 198);
            this.activoMetroToggle.Name = "activoMetroToggle";
            this.activoMetroToggle.Size = new System.Drawing.Size(80, 17);
            this.activoMetroToggle.TabIndex = 6;
            this.activoMetroToggle.Text = "Off";
            this.activoMetroToggle.UseSelectable = true;
            this.activoMetroToggle.UseStyleColors = true;
            // 
            // lblGraphBackground
            // 
            this.lblGraphBackground.AutoSize = true;
            this.lblGraphBackground.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblGraphBackground.Location = new System.Drawing.Point(3, 64);
            this.lblGraphBackground.Name = "lblGraphBackground";
            this.lblGraphBackground.Size = new System.Drawing.Size(107, 25);
            this.lblGraphBackground.TabIndex = 4;
            this.lblGraphBackground.Text = "Background:";
            this.lblGraphBackground.UseStyleColors = true;
            // 
            // pbGraphBackground
            // 
            this.pbGraphBackground.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.graphBindingSource, "Background", true));
            this.pbGraphBackground.Location = new System.Drawing.Point(116, 64);
            this.pbGraphBackground.Name = "pbGraphBackground";
            this.pbGraphBackground.Size = new System.Drawing.Size(185, 221);
            this.pbGraphBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGraphBackground.TabIndex = 3;
            this.pbGraphBackground.TabStop = false;
            // 
            // graphBindingSource
            // 
            this.graphBindingSource.DataSource = typeof(Proyecto.Data.Graph);
            this.graphBindingSource.CurrentChanged += new System.EventHandler(this.graphBindingSource_CurrentChanged);
            // 
            // graphBindingNavigator
            // 
            this.graphBindingNavigator.AddNewItem = this.bindingNavigatorAddNewGraph;
            this.graphBindingNavigator.BindingSource = this.graphBindingSource;
            this.graphBindingNavigator.CountItem = this.bindingNavigatorCountItem2;
            this.graphBindingNavigator.DeleteItem = null;
            this.graphBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.graphBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstGraph,
            this.bindingNavigatorMovePreviousGraph,
            this.bindingNavigatorSeparator6,
            this.bindingNavigatorPositionItem2,
            this.bindingNavigatorCountItem2,
            this.bindingNavigatorSeparator7,
            this.bindingNavigatorMoveNextGraph,
            this.bindingNavigatorMoveLastGraph,
            this.bindingNavigatorSeparator8,
            this.bindingNavigatorAddNewGraph,
            this.toolStripDeleteGraph});
            this.graphBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.graphBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstGraph;
            this.graphBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastGraph;
            this.graphBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextGraph;
            this.graphBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousGraph;
            this.graphBindingNavigator.Name = "graphBindingNavigator";
            this.graphBindingNavigator.PositionItem = this.bindingNavigatorPositionItem2;
            this.graphBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.graphBindingNavigator.Size = new System.Drawing.Size(506, 25);
            this.graphBindingNavigator.TabIndex = 2;
            this.graphBindingNavigator.Text = "graphBindingNavigator";
            // 
            // bindingNavigatorAddNewGraph
            // 
            this.bindingNavigatorAddNewGraph.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewGraph.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewGraph.Image")));
            this.bindingNavigatorAddNewGraph.Name = "bindingNavigatorAddNewGraph";
            this.bindingNavigatorAddNewGraph.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewGraph.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewGraph.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewGraph.Click += new System.EventHandler(this.bindingNavigatorAddNewGraph_Click);
            // 
            // bindingNavigatorCountItem2
            // 
            this.bindingNavigatorCountItem2.Name = "bindingNavigatorCountItem2";
            this.bindingNavigatorCountItem2.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem2.Text = "de {0}";
            this.bindingNavigatorCountItem2.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstGraph
            // 
            this.bindingNavigatorMoveFirstGraph.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstGraph.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstGraph.Image")));
            this.bindingNavigatorMoveFirstGraph.Name = "bindingNavigatorMoveFirstGraph";
            this.bindingNavigatorMoveFirstGraph.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstGraph.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstGraph.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousGraph
            // 
            this.bindingNavigatorMovePreviousGraph.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousGraph.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousGraph.Image")));
            this.bindingNavigatorMovePreviousGraph.Name = "bindingNavigatorMovePreviousGraph";
            this.bindingNavigatorMovePreviousGraph.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousGraph.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousGraph.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator6
            // 
            this.bindingNavigatorSeparator6.Name = "bindingNavigatorSeparator6";
            this.bindingNavigatorSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem2
            // 
            this.bindingNavigatorPositionItem2.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem2.AutoSize = false;
            this.bindingNavigatorPositionItem2.Name = "bindingNavigatorPositionItem2";
            this.bindingNavigatorPositionItem2.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem2.Text = "0";
            this.bindingNavigatorPositionItem2.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator7
            // 
            this.bindingNavigatorSeparator7.Name = "bindingNavigatorSeparator7";
            this.bindingNavigatorSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextGraph
            // 
            this.bindingNavigatorMoveNextGraph.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextGraph.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextGraph.Image")));
            this.bindingNavigatorMoveNextGraph.Name = "bindingNavigatorMoveNextGraph";
            this.bindingNavigatorMoveNextGraph.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextGraph.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextGraph.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastGraph
            // 
            this.bindingNavigatorMoveLastGraph.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastGraph.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastGraph.Image")));
            this.bindingNavigatorMoveLastGraph.Name = "bindingNavigatorMoveLastGraph";
            this.bindingNavigatorMoveLastGraph.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastGraph.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastGraph.Text = "Mover último";
            // 
            // bindingNavigatorSeparator8
            // 
            this.bindingNavigatorSeparator8.Name = "bindingNavigatorSeparator8";
            this.bindingNavigatorSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDeleteGraph
            // 
            this.toolStripDeleteGraph.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDeleteGraph.Image = global::Proyecto.Properties.Resources.Cancel;
            this.toolStripDeleteGraph.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDeleteGraph.Name = "toolStripDeleteGraph";
            this.toolStripDeleteGraph.Size = new System.Drawing.Size(23, 22);
            this.toolStripDeleteGraph.Text = "toolStripButton1";
            this.toolStripDeleteGraph.Click += new System.EventHandler(this.toolStripDeleteGraph_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 79;
            // 
            // roleIdDataGridViewTextBoxColumn
            // 
            this.roleIdDataGridViewTextBoxColumn.DataPropertyName = "RoleId";
            this.roleIdDataGridViewTextBoxColumn.HeaderText = "RoleId";
            this.roleIdDataGridViewTextBoxColumn.Name = "roleIdDataGridViewTextBoxColumn";
            this.roleIdDataGridViewTextBoxColumn.Width = 63;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.Width = 53;
            // 
            // lnkActivar
            // 
            this.lnkActivar.Location = new System.Drawing.Point(319, 221);
            this.lnkActivar.Name = "lnkActivar";
            this.lnkActivar.Size = new System.Drawing.Size(78, 23);
            this.lnkActivar.TabIndex = 12;
            this.lnkActivar.Text = "Activar";
            this.lnkActivar.UseSelectable = true;
            this.lnkActivar.UseStyleColors = true;
            this.lnkActivar.Click += new System.EventHandler(this.lnkActivar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.tableLayoutAdminMain);
            this.Controls.Add(this.TopPanel);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Principal";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 20, 0);
            this.Text = "Bienvenido + AuthUser.Name";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.Resize += new System.EventHandler(this.Principal_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.PrincipalStyleManager)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.TopUserInfoPanel.ResumeLayout(false);
            this.TopUserInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            this.tableLayoutAdminMain.ResumeLayout(false);
            this.tableLayoutLeft.ResumeLayout(false);
            this.MainTabControl.ResumeLayout(false);
            this.UsersTabPage.ResumeLayout(false);
            this.UsersTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingNavigator)).EndInit();
            this.userBindingNavigator.ResumeLayout(false);
            this.userBindingNavigator.PerformLayout();
            this.RolesTabPage.ResumeLayout(false);
            this.RolesTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingNavigator)).EndInit();
            this.roleBindingNavigator.ResumeLayout(false);
            this.roleBindingNavigator.PerformLayout();
            this.TravelProblemsTabPage.ResumeLayout(false);
            this.TravelProblemsTabPage.PerformLayout();
            this.GraphTabPage.ResumeLayout(false);
            this.GraphTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGraphBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphBindingNavigator)).EndInit();
            this.graphBindingNavigator.ResumeLayout(false);
            this.graphBindingNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager PrincipalStyleManager;
        private MetroFramework.Controls.MetroPanel TopPanel;
        private System.Windows.Forms.FlowLayoutPanel TopUserInfoPanel;
        private MetroFramework.Controls.MetroLabel lblAuthUserEmail;
        private MetroFramework.Controls.MetroLink linkChangePassword;
        private System.Windows.Forms.PictureBox avatarPictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutAdminMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutLeft;
        private MetroFramework.Controls.MetroTile btnUsers;
        private MetroFramework.Controls.MetroTile btnRoles;
        private MetroFramework.Controls.MetroTile btnTravelProblems;
        private MetroFramework.Controls.MetroTile btnGraph;
        private MetroFramework.Controls.MetroTabControl MainTabControl;
        private MetroFramework.Controls.MetroTabPage UsersTabPage;
        private MetroFramework.Controls.MetroTabPage RolesTabPage;
        private MetroFramework.Controls.MetroTabPage TravelProblemsTabPage;
        private MetroFramework.Controls.MetroTabPage GraphTabPage;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroGrid userDataGridView;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingNavigator userBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton userBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton userBindingNavigatorAddNew;
        private System.Windows.Forms.ToolStripButton userBindingNavigatorDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private System.Windows.Forms.BindingNavigator roleBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private MetroFramework.Controls.MetroGrid roleDataGridView;
        private System.Windows.Forms.ToolStripButton roleBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton roleBindingNavigatorNewItem;
        private System.Windows.Forms.ToolStripButton roleBindingNavigatorDeleteItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn RoleId;
        private System.Windows.Forms.BindingNavigator graphBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewGraph;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstGraph;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousGraph;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator6;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextGraph;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastGraph;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator8;
        private System.Windows.Forms.BindingSource graphBindingSource;
        private MetroFramework.Controls.MetroLabel lblGraphBackground;
        private System.Windows.Forms.PictureBox pbGraphBackground;
        private MetroFramework.Controls.MetroLabel lblGraphActivo;
        private MetroFramework.Controls.MetroToggle activoMetroToggle;
        private MetroFramework.Controls.MetroLabel lblNodoImage;
        private System.Windows.Forms.PictureBox pbNodo;
        private MetroFramework.Controls.MetroButton btnCambiarBackground;
        private MetroFramework.Controls.MetroButton btnCambiarNodo;
        private System.Windows.Forms.ToolStripButton toolStripDeleteGraph;
        private MetroFramework.Controls.MetroLink lnkActivar;
    }
}