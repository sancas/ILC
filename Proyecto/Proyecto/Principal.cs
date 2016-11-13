using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Proyecto.Data;
using Proyecto.Properties;

namespace Proyecto
{
    public partial class Principal : MetroForm
    {
        User AuthUser; //Variable que almacenara el usuario logeado
        ILC IlcSet; //Variable que alamacena la base de datos
        public Principal()
        {
            //InitializeComponent();
        }

        public Principal(User AuthUser) //Constructor que recibe usuario autenticada como parametro
        {
            this.AuthUser = AuthUser;
            this.IlcSet = new ILC();
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            this.StyleManager = PrincipalStyleManager;
            this.MainTabControl.ItemSize = new Size(0, 1);
            this.MainTabControl.Appearance = TabAppearance.FlatButtons;
            this.MainTabControl.SizeMode = TabSizeMode.Fixed;
            foreach (TabPage tb in MainTabControl.TabPages)
            {
                tb.ResetText();
            }
            this.lblAuthUserEmail.Text = AuthUser.Email;
            this.Text = "Bienvenido " + this.AuthUser.Name.ToString();
            if (AuthUser.Role.Name == "Admin")
            {
                if (AuthUser.Gender == "M")
                {
                    this.avatarPictureBox.Image = ((System.Drawing.Image)(Resources.AdminMale));
                }
                else if (AuthUser.Gender == "F")
                {
                    this.avatarPictureBox.Image = ((System.Drawing.Image)(Resources.AdminFemale));
                }
                this.ActiveControl = RolesTabPage;
            }
            else if(AuthUser.Role.Name == "Operator")
            {
                if (AuthUser.Gender == "M")
                {
                    this.avatarPictureBox.Image = ((System.Drawing.Image)(Resources.UserMale));
                }
                else if (AuthUser.Gender == "F")
                {
                    this.avatarPictureBox.Image = ((System.Drawing.Image)(Resources.UserFemale));
                }
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.MainTabControl.SelectedIndex = 0;
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            this.MainTabControl.SelectedIndex = 1;
        }

        private void btnTravelProblems_Click(object sender, EventArgs e)
        {
            this.MainTabControl.SelectedIndex = 2;
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            this.MainTabControl.SelectedIndex = 3;
        }

        private void Principal_Resize(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (control.Size.Width >= 1080 && control.Size.Height >= 720)
            {
                this.btnUsers.TileImage = ((Image)(Resources.Users96));
                this.btnRoles.TileImage = ((Image)(Resources.Roles96));
                this.btnTravelProblems.TileImage = ((Image)(Resources.TravelProblems96));
                this.btnGraph.TileImage = ((Image)(Resources.Graph96));
            }
            else
            {
                this.btnUsers.TileImage = ((Image)(Resources.Users));
                this.btnRoles.TileImage = ((Image)(Resources.Roles));
                this.btnTravelProblems.TileImage = ((Image)(Resources.TravelProblems));
                this.btnGraph.TileImage = ((Image)(Resources.Graph));
            }
        }

        async private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (await this.IlcSet.SaveChangesAsync() == 1)
                MetroFramework.MetroMessageBox.Show(this, "Base de datos guardada correctamente", "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MetroFramework.MetroMessageBox.Show(this, "No se pudo guardar la base", "Error Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void UsersTabPage_Enter(object sender, EventArgs e)
        {
            this.userBindingSource.DataSource = this.IlcSet.Users.ToList();
            this.roleBindingSource.DataSource = this.IlcSet.Roles.ToList();
        }

        private void userBindingNavigatorAddNew_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUser frmAddUser = new AddUser(AuthUser, PrincipalStyleManager);
            frmAddUser.ShowDialog(this);
            this.Show();
            this.Focus();
            if (frmAddUser.DialogResult == DialogResult.OK)
                MetroFramework.MetroMessageBox.Show(this, "Usuario creado correctamente", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MetroFramework.MetroMessageBox.Show(this, "No se creo el usuario", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.userBindingSource.DataSource = this.IlcSet.Users.ToList();
        }

        private void userDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Console.WriteLine(e.Exception.ToString());
        }

        private void userBindingNavigatorDelete_Click(object sender, EventArgs e)
        {
            if (this.userDataGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow dgvw in userDataGridView.SelectedRows)
                {
                    IlcSet.Users.Remove(IlcSet.Users.Find(dgvw.Cells[0].Value));
                    this.userDataGridView.Rows.RemoveAt(dgvw.Index);
                }
                IlcSet.SaveChanges();
            }
        }

        private void linkChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePassword frmChangePassword = new ChangePassword(AuthUser, PrincipalStyleManager);
            frmChangePassword.ShowDialog(this);
            this.Show();
            this.Focus();
            if (frmChangePassword.DialogResult == DialogResult.OK)
            {
                MetroFramework.MetroMessageBox.Show(this, "Contraseña modificada satisfactoriamente.\nSe procedera a cerrar la sesion.", "Cambio de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void RolesTabPage_Enter(object sender, EventArgs e)
        {
            this.roleBindingSource.DataSource = IlcSet.Roles.ToList();
        }

        async private void roleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (await this.IlcSet.SaveChangesAsync() == 1)
                MetroFramework.MetroMessageBox.Show(this, "Base de datos guardada correctamente", "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MetroFramework.MetroMessageBox.Show(this, "No se pudo guardar la base", "Error Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void roleBindingNavigatorNewItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddRole frmAddRole = new AddRole();
            frmAddRole.ShowDialog(this);
            this.Show();
            this.Focus();
            if (frmAddRole.DialogResult == DialogResult.OK)
                MetroFramework.MetroMessageBox.Show(this, "Rol creado correctamente", "Role", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MetroFramework.MetroMessageBox.Show(this, "No se creo el rol", "Role", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.roleBindingSource.DataSource = this.IlcSet.Roles.ToList();
        }

        private void roleBindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (this.roleDataGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow dgvw in roleDataGridView.SelectedRows)
                {
                    IlcSet.Roles.Remove(IlcSet.Roles.Find(dgvw.Cells[0].Value));
                    this.roleDataGridView.Rows.RemoveAt(dgvw.Index);
                }
                IlcSet.SaveChanges();
            }
        }

        private void btnCambiarBackground_Click(object sender, EventArgs e)
        {
            OpenFileDialog changeBackground = new OpenFileDialog();
            changeBackground.ShowDialog(this);
            pbGraphBackground.Image = Image.FromFile(changeBackground.FileName);
            Graph miGrafo = (Graph)graphBindingSource.Current;
            IlcSet.Graphs.Where(v => v.Id == miGrafo.Id).FirstOrDefault().Background = System.IO.File.ReadAllBytes(changeBackground.FileName);
            IlcSet.SaveChanges();
        }

        private void GraphTabPage_Enter(object sender, EventArgs e)
        {
            this.graphBindingSource.DataSource = IlcSet.Graphs.ToList();
        }

        private void graphBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Graph miGrafo = (Graph)graphBindingSource.Current;
            if (miGrafo.Background != null)
                pbGraphBackground.Image = Operaciones.byteArrayToImage(miGrafo.Background);
            if (miGrafo.NodeIcon != null)
                pbNodo.Image = Operaciones.byteArrayToImage(miGrafo.NodeIcon);
            if (miGrafo.Tipo == "Activo")
                activoMetroToggle.Checked = true;
            else
                activoMetroToggle.Checked = false;
        }

        private void btnCambiarNodo_Click(object sender, EventArgs e)
        {
            OpenFileDialog changeNode = new OpenFileDialog();
            changeNode.ShowDialog(this);
            pbNodo.Image = Image.FromFile(changeNode.FileName);
            Graph miGrafo = (Graph)graphBindingSource.Current;
            IlcSet.Graphs.Where(v => v.Id == miGrafo.Id).FirstOrDefault().NodeIcon = System.IO.File.ReadAllBytes(changeNode.FileName);
            IlcSet.SaveChanges();
        }

        private void bindingNavigatorAddNewGraph_Click(object sender, EventArgs e)
        {
            Graph miGrafo = new Graph();
            miGrafo.Tipo = "Inactivo";
            IlcSet.Graphs.Add(miGrafo);
            IlcSet.SaveChanges();
            this.graphBindingSource.DataSource = IlcSet.Graphs.ToList();
        }

        private void toolStripDeleteGraph_Click(object sender, EventArgs e)
        {
            Graph miGrafo = (Graph)graphBindingSource.Current;
            IlcSet.Graphs.Remove(IlcSet.Graphs.Where(v => v.Id == miGrafo.Id).FirstOrDefault());
            IlcSet.SaveChanges();
            this.graphBindingSource.DataSource = IlcSet.Graphs.ToList();
        }

        private void lnkActivar_Click(object sender, EventArgs e)
        {
            if (!activoMetroToggle.Checked)
            {
                this.Cursor = Cursors.WaitCursor;
                Graph miGrafo = (Graph)graphBindingSource.Current;
                foreach (Graph Grafo in IlcSet.Graphs)
                {
                    Grafo.Tipo = "Inactivo";
                }
                IlcSet.Graphs.Where(v => v.Id == miGrafo.Id).FirstOrDefault().Tipo = "Activo";
                IlcSet.SaveChanges();
                activoMetroToggle.Checked = true;
                this.Cursor = Cursors.Default;
            }
        }
    }
}
