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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.userBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.userBindingNavigatorAddNew = new System.Windows.Forms.ToolStripButton();
            this.userBindingNavigatorDelete = new System.Windows.Forms.ToolStripButton();
            this.RolesTabPage = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.TravelProblemsTabPage = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.GraphTabPage = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PrincipalStyleManager)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.TopUserInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            this.tableLayoutAdminMain.SuspendLayout();
            this.tableLayoutLeft.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.UsersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingNavigator)).BeginInit();
            this.userBindingNavigator.SuspendLayout();
            this.RolesTabPage.SuspendLayout();
            this.TravelProblemsTabPage.SuspendLayout();
            this.GraphTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
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
            this.MainTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.MainTabControl.Controls.Add(this.UsersTabPage);
            this.MainTabControl.Controls.Add(this.RolesTabPage);
            this.MainTabControl.Controls.Add(this.TravelProblemsTabPage);
            this.MainTabControl.Controls.Add(this.GraphTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.ItemSize = new System.Drawing.Size(0, 1);
            this.MainTabControl.Location = new System.Drawing.Point(103, 3);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(514, 360);
            this.MainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
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
            this.UsersTabPage.Location = new System.Drawing.Point(4, 5);
            this.UsersTabPage.Name = "UsersTabPage";
            this.UsersTabPage.Size = new System.Drawing.Size(506, 351);
            this.UsersTabPage.TabIndex = 0;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.RoleId});
            this.userDataGridView.DataSource = this.userBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.userDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userDataGridView.EnableHeadersVisualStyles = false;
            this.userDataGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.userDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userDataGridView.Location = new System.Drawing.Point(0, 25);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.userDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.userDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userDataGridView.Size = new System.Drawing.Size(506, 326);
            this.userDataGridView.TabIndex = 5;
            this.userDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.userDataGridView_DataError);
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
            this.userBindingNavigator.Text = "bindingNavigator1";
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
            // userBindingNavigatorSaveItem
            // 
            this.userBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("userBindingNavigatorSaveItem.Image")));
            this.userBindingNavigatorSaveItem.Name = "userBindingNavigatorSaveItem";
            this.userBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.userBindingNavigatorSaveItem.Text = "Guardar datos";
            this.userBindingNavigatorSaveItem.Click += new System.EventHandler(this.userBindingNavigatorSaveItem_Click);
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
            // RolesTabPage
            // 
            this.RolesTabPage.Controls.Add(this.metroLabel2);
            this.RolesTabPage.HorizontalScrollbarBarColor = true;
            this.RolesTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.RolesTabPage.HorizontalScrollbarSize = 10;
            this.RolesTabPage.Location = new System.Drawing.Point(4, 5);
            this.RolesTabPage.Name = "RolesTabPage";
            this.RolesTabPage.Size = new System.Drawing.Size(506, 351);
            this.RolesTabPage.TabIndex = 1;
            this.RolesTabPage.VerticalScrollbarBarColor = true;
            this.RolesTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.RolesTabPage.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(168, 166);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(87, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "CRUD ROLES";
            // 
            // TravelProblemsTabPage
            // 
            this.TravelProblemsTabPage.Controls.Add(this.metroLabel3);
            this.TravelProblemsTabPage.HorizontalScrollbarBarColor = true;
            this.TravelProblemsTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.TravelProblemsTabPage.HorizontalScrollbarSize = 10;
            this.TravelProblemsTabPage.Location = new System.Drawing.Point(4, 5);
            this.TravelProblemsTabPage.Name = "TravelProblemsTabPage";
            this.TravelProblemsTabPage.Size = new System.Drawing.Size(506, 351);
            this.TravelProblemsTabPage.TabIndex = 2;
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
            this.GraphTabPage.Controls.Add(this.metroLabel4);
            this.GraphTabPage.HorizontalScrollbarBarColor = true;
            this.GraphTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.GraphTabPage.HorizontalScrollbarSize = 10;
            this.GraphTabPage.Location = new System.Drawing.Point(4, 5);
            this.GraphTabPage.Name = "GraphTabPage";
            this.GraphTabPage.Size = new System.Drawing.Size(506, 351);
            this.GraphTabPage.TabIndex = 3;
            this.GraphTabPage.VerticalScrollbarBarColor = true;
            this.GraphTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.GraphTabPage.VerticalScrollbarSize = 10;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(185, 166);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(53, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "GRAFO";
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
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // RoleId
            // 
            this.RoleId.DataPropertyName = "RoleId";
            this.RoleId.DataSource = this.roleBindingSource;
            this.RoleId.DisplayMember = "Name";
            this.RoleId.HeaderText = "Role ID";
            this.RoleId.Name = "RoleId";
            this.RoleId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RoleId.ValueMember = "Id";
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
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(Proyecto.Data.Role);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Proyecto.Data.User);
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
            ((System.ComponentModel.ISupportInitialize)(this.userBindingNavigator)).EndInit();
            this.userBindingNavigator.ResumeLayout(false);
            this.userBindingNavigator.PerformLayout();
            this.RolesTabPage.ResumeLayout(false);
            this.RolesTabPage.PerformLayout();
            this.TravelProblemsTabPage.ResumeLayout(false);
            this.TravelProblemsTabPage.PerformLayout();
            this.GraphTabPage.ResumeLayout(false);
            this.GraphTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
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
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn RoleId;
    }
}