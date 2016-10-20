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
            this.PrincipalStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.TopPanel = new MetroFramework.Controls.MetroPanel();
            this.TopUserInfoPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAuthUserEmail = new MetroFramework.Controls.MetroLabel();
            this.linkChangePassword = new MetroFramework.Controls.MetroLink();
            this.tableLayoutAdminMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutLeft = new System.Windows.Forms.TableLayoutPanel();
            this.MainTabControl = new MetroFramework.Controls.MetroTabControl();
            this.UsersTabPage = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.RolesTabPage = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.TravelProblemsTabPage = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.GraphTabPage = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnUsers = new MetroFramework.Controls.MetroTile();
            this.btnRoles = new MetroFramework.Controls.MetroTile();
            this.btnTravelProblems = new MetroFramework.Controls.MetroTile();
            this.btnGraph = new MetroFramework.Controls.MetroTile();
            this.avatarPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PrincipalStyleManager)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.TopUserInfoPanel.SuspendLayout();
            this.tableLayoutAdminMain.SuspendLayout();
            this.tableLayoutLeft.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.UsersTabPage.SuspendLayout();
            this.RolesTabPage.SuspendLayout();
            this.TravelProblemsTabPage.SuspendLayout();
            this.GraphTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
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
            this.UsersTabPage.Controls.Add(this.metroLabel1);
            this.UsersTabPage.HorizontalScrollbarBarColor = true;
            this.UsersTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.UsersTabPage.HorizontalScrollbarSize = 10;
            this.UsersTabPage.Location = new System.Drawing.Point(4, 5);
            this.UsersTabPage.Name = "UsersTabPage";
            this.UsersTabPage.Size = new System.Drawing.Size(506, 351);
            this.UsersTabPage.TabIndex = 0;
            this.UsersTabPage.VerticalScrollbarBarColor = true;
            this.UsersTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.UsersTabPage.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(171, 166);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(97, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "CRUD Usuarios";
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
            this.tableLayoutAdminMain.ResumeLayout(false);
            this.tableLayoutLeft.ResumeLayout(false);
            this.MainTabControl.ResumeLayout(false);
            this.UsersTabPage.ResumeLayout(false);
            this.UsersTabPage.PerformLayout();
            this.RolesTabPage.ResumeLayout(false);
            this.RolesTabPage.PerformLayout();
            this.TravelProblemsTabPage.ResumeLayout(false);
            this.TravelProblemsTabPage.PerformLayout();
            this.GraphTabPage.ResumeLayout(false);
            this.GraphTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
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
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}