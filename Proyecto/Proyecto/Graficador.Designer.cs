namespace Proyecto
{
    partial class Graficador
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
            this.TopPanel = new MetroFramework.Controls.MetroPanel();
            this.TopUserInfoPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAuthUserEmail = new MetroFramework.Controls.MetroLabel();
            this.linkChangePassword = new MetroFramework.Controls.MetroLink();
            this.avatarPictureBox = new System.Windows.Forms.PictureBox();
            this.pbCanvas = new System.Windows.Forms.Panel();
            this.graficadorStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.CMSMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoVerticeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TopPanel.SuspendLayout();
            this.TopUserInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficadorStyleManager)).BeginInit();
            this.CMSMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.TopUserInfoPanel);
            this.TopPanel.Controls.Add(this.avatarPictureBox);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.HorizontalScrollbarBarColor = true;
            this.TopPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.TopPanel.HorizontalScrollbarSize = 10;
            this.TopPanel.Location = new System.Drawing.Point(20, 60);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(733, 54);
            this.TopPanel.TabIndex = 1;
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
            this.TopUserInfoPanel.Location = new System.Drawing.Point(554, 0);
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
            this.avatarPictureBox.Location = new System.Drawing.Point(685, 0);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.Size = new System.Drawing.Size(48, 54);
            this.avatarPictureBox.TabIndex = 3;
            this.avatarPictureBox.TabStop = false;
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCanvas.Location = new System.Drawing.Point(20, 114);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(733, 441);
            this.pbCanvas.TabIndex = 2;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
            this.pbCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbCanvas_MouseDown);
            this.pbCanvas.MouseLeave += new System.EventHandler(this.pbCanvas_MouseLeave);
            this.pbCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbCanvas_MouseMove);
            this.pbCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbCanvas_MouseUp);
            // 
            // graficadorStyleManager
            // 
            this.graficadorStyleManager.Owner = this;
            // 
            // CMSMenu
            // 
            this.CMSMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoVerticeToolStripMenuItem});
            this.CMSMenu.Name = "CMSMenu";
            this.CMSMenu.Size = new System.Drawing.Size(148, 26);
            // 
            // nuevoVerticeToolStripMenuItem
            // 
            this.nuevoVerticeToolStripMenuItem.Name = "nuevoVerticeToolStripMenuItem";
            this.nuevoVerticeToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.nuevoVerticeToolStripMenuItem.Text = "Nuevo Vertice";
            this.nuevoVerticeToolStripMenuItem.Click += new System.EventHandler(this.nuevoVerticeToolStripMenuItem_Click);
            // 
            // Graficador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 575);
            this.Controls.Add(this.pbCanvas);
            this.Controls.Add(this.TopPanel);
            this.Name = "Graficador";
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Graficador";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Graficador_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.TopUserInfoPanel.ResumeLayout(false);
            this.TopUserInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficadorStyleManager)).EndInit();
            this.CMSMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel TopPanel;
        private System.Windows.Forms.FlowLayoutPanel TopUserInfoPanel;
        private MetroFramework.Controls.MetroLabel lblAuthUserEmail;
        private MetroFramework.Controls.MetroLink linkChangePassword;
        private System.Windows.Forms.PictureBox avatarPictureBox;
        private System.Windows.Forms.Panel pbCanvas;
        private MetroFramework.Components.MetroStyleManager graficadorStyleManager;
        private System.Windows.Forms.ContextMenuStrip CMSMenu;
        private System.Windows.Forms.ToolStripMenuItem nuevoVerticeToolStripMenuItem;
    }
}