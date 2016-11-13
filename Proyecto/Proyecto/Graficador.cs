using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Proyecto.Data;
using Proyecto.Properties;
using System.Drawing.Drawing2D;

namespace Proyecto
{
    public partial class Graficador : MetroForm
    {
        User AuthUser; //Variable que almacenara el usuario logeado
        ILC IlcSet; //Variable que alamacena la base de datos
        private CGrafo grafo; // instanciamos la clase CGrafo
        private Graph miGrafo; // instanciamos la clase Graph
        private CVertice nuevoNodo; // instanciamos la clase CVertice
        private CVertice NodoOrigen; // instanciamos la clase CVertice
        private CVertice NodoDestino; // instanciamos la clase CVertice
        private VMultiple frmVentanaMultiple; // Ventana para crear vertices, aristas, etc.
        private int var_control = 0; // la utilizaremos para determinar el estado en la pizarra:
        // 0 -> sin acción, 1 -> Dibujando arco, 2 -> Nuevo vértice
        // variables para el control de ventanas modales
        private int aristas = 0, nodos = 0; //Enteros para almacenar cantidad de nodos y aristas en el grafo
        private int numeronodos = 0, opc; //Enteros para definir las diferentes opciones y el numero de nodos
        private int tiempo; //Tiempo para la simulacion
        public Graficador()
        {
            InitializeComponent();
        }

        public Graficador(User AuthUser)
        {
            this.AuthUser = AuthUser;
            InitializeComponent();
            nuevoNodo = null;
            var_control = 0;
            frmVentanaMultiple = null;
            tiempo = 100;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            IlcSet = new ILC();
            miGrafo = IlcSet.Graphs.Where(u => u.Tipo == "Activo").FirstOrDefault();
            if (miGrafo != null)
            {
                grafo = new CGrafo();
                if (miGrafo.Background != null)
                    pbCanvas.BackgroundImage = Operaciones.byteArrayToImage(miGrafo.Background);
                if (miGrafo.NodeIcon != null)
                    grafo.NodoIcon = Operaciones.byteArrayToImage(miGrafo.NodeIcon);
                foreach (Node miNodo in miGrafo.Nodes)
                {
                    nuevoNodo = new CVertice(miNodo.Name);
                    nuevoNodo.Posicion = new Point(miNodo.X, miNodo.Y);
                    grafo.AgregarVertice(nuevoNodo);
                }
                foreach (Edge miArista in miGrafo.Edges)
                {
                    grafo.AgregarArco(grafo.BuscarVertice(miArista.NodoSalida), grafo.BuscarVertice(miArista.NodoLlegada), miArista.Value);
                }
                nuevoNodo = null;
                pbCanvas.Refresh();
            }
            else
            {
                miGrafo = new Graph();
                miGrafo.Tipo = "Activo";
                grafo = new CGrafo();
                IlcSet.Graphs.Add(miGrafo);
                IlcSet.SaveChanges();
            }
        }

        private void Graficador_Load(object sender, EventArgs e)
        {
            this.StyleManager = graficadorStyleManager;
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
            }
            else if (AuthUser.Role.Name == "Operator")
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

        private void pbCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left) // Si se ha presionado el botón
            // izquierdo del mouse
            {
                if ((NodoOrigen = grafo.DetectarPunto(e.Location)) != null)
                {
                    var_control = 1; // recordemos que es usado para indicar el estado en la pizarra:
                    // 0 -> sin accion, 1 -> Dibujando arco, 2 -> Nuevo vértice
                }
                if (nuevoNodo != null && NodoOrigen == null) //Si hay un nodo origen pero no hay nuevonodo
                {
                    grafo.AgregarVertice(nuevoNodo); //Se agrega un nuevo nodo al grafo
                    numeronodos = grafo.nodos.Count;//cuenta cuantos nodos hay en el grafo
                    frmVentanaMultiple = new VMultiple("Agregar Vertice", "Valor del vertice", graficadorStyleManager);
                    frmVentanaMultiple.ShowDialog(this);
                    if (frmVentanaMultiple.DialogResult == DialogResult.OK) //Si todo fue bien
                    {
                        if (grafo.BuscarVertice(frmVentanaMultiple.txtValor.Text) == null) //Si un nodo con el mismo valor no existe en el grafo
                        {
                            Node newNode = new Node();
                            newNode.Graph = miGrafo;
                            newNode.GraphId = miGrafo.Id;
                            newNode.X = nuevoNodo.Posicion.X;
                            newNode.Y = nuevoNodo.Posicion.Y;
                            newNode.Name = frmVentanaMultiple.txtValor.Text;
                            miGrafo.Nodes.Add(newNode);
                            IlcSet.Graphs.Where(v => v.Id == miGrafo.Id).FirstOrDefault().Nodes.Add(newNode);
                            nuevoNodo.Valor = frmVentanaMultiple.txtValor.Text; //Se agrega el nuevo valor nuevo nodo
                            IlcSet.SaveChanges();
                        }
                        else //sino Error
                        {
                            MetroMessageBox.Show(this, "El Nodo " + frmVentanaMultiple.txtValor.Text + " ya existe en el grafo ", "Error nuevo Nodo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            grafo.ELiminarNodo("");
                        }
                    }
                    else //Si no fue bien
                    {
                        grafo.ELiminarNodo(string.Empty);  //Se elimina el nodo recien creado
                        grafo.RestablecerGrafo(pbCanvas.CreateGraphics()); //Se reestablece el grafo
                        pbCanvas.Refresh(); //Se refresca el canvas
                    }
                    var_control = 0; //variable de control con valor 0
                    nuevoNodo = null; //nuevoNodo se setea con null
                    this.Cursor = Cursors.Default; //Se cambia el cursor al default
                    pbCanvas.Refresh(); //Se refresca el canvas
                }
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right) // Si se ha presionado el botón
            // derecho del mouse
            {
                if (var_control == 0) //Si la variable de control es 0
                {
                    if ((NodoOrigen = grafo.DetectarPunto(e.Location)) != null)
                    {
                        CMSMenu.Text = "Nodo " + NodoOrigen.Valor;
                    }
                    else
                        pbCanvas.ContextMenuStrip = this.CMSMenu; //Se abre el menu strip cmscrear vertice
                }
            }
        }

        private void pbCanvas_MouseLeave(object sender, EventArgs e)
        {
            pbCanvas.Refresh(); //Refrescar el canvas cuando se deja el canvas
            this.Cursor = Cursors.Default; //Se cambia el cursos a default
        }

        private void pbCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            switch (var_control)
            {
                case 2: //Creando nuevo nodo
                    if (nuevoNodo != null) //Si el nuevoNodo no es nulo
                    {
                        int posX = e.Location.X; //PosX es igual a la posicion x del mouse
                        int posY = e.Location.Y; //PosY es igual a la posicion y del mouse
                        if (posX < nuevoNodo.Dimensiones.Width / 2) //Si la posicion en x es menor que las dimensiones del nuevonodo
                            posX = nuevoNodo.Dimensiones.Width / 2; //La nueva posicionX es la anchura del form entre 2
                        else if (posX > pbCanvas.Size.Width - nuevoNodo.Dimensiones.Width / 2) //Sino Si la posicionX es mayor que tamaño del cambas menos el de las nuevas dimensiones
                            posX = pbCanvas.Size.Width - nuevoNodo.Dimensiones.Width / 2; //La nueva posicionX es igual a el tamaño del canvas menos las dimensiones del nodo entre dos
                        if (posY < nuevoNodo.Dimensiones.Height / 2) //Si la posicion en Y es menor que las dimensiones height del nodo
                            posY = nuevoNodo.Dimensiones.Height / 2; //La nueva posicion Y es igual a las dimensiones height del nodo entre dos
                        else if (posY > pbCanvas.Size.Height - nuevoNodo.Dimensiones.Width / 2) //Sino si la posicionY es mayor que tamaño height del canvas menos la dimension width del nodo entre 2
                            posY = pbCanvas.Size.Height - nuevoNodo.Dimensiones.Width / 2; //La nueva posicionY es igual al tamaño height del cambas menos la dimension width del nodo entre dos
                        nuevoNodo.Posicion = new Point(posX, posY); //La posicion del nuevo nodo es igual a un punto (posicionX, posicionY)
                        pbCanvas.Refresh(); //Se refresca el canvas
                        nuevoNodo.DibujarVertice(pbCanvas.CreateGraphics(), grafo.NodoIcon); //Se dibuja el nuevo vertice
                    }
                    break;
                case 1: // Dibujar arco
                    this.Cursor = Cursors.Cross; //Se cambia el cursor a una cruz
                    AdjustableArrowCap bigArrow = new AdjustableArrowCap(4, 4, true); //Crear una flecha
                    bigArrow.BaseCap = System.Drawing.Drawing2D.LineCap.Triangle; //Triangular
                    pbCanvas.Refresh(); //Refrescar en c#
                    pbCanvas.CreateGraphics().DrawLine(new Pen(Brushes.Black, 2) //Crear la linea
                    {
                        CustomEndCap = bigArrow //Con punta rectangular
                    },
                        NodoOrigen.Posicion, e.Location); //La posicion del nodoOrigen
                    //this.Cursor = Cursors.Default;
                    break;
            }
        }

        private void pbCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            switch (var_control)
            {
                case 1: // Dibujando arco
                    this.Cursor = Cursors.Cross; //Se cambia el cursos a una cruz
                    if ((NodoDestino = grafo.DetectarPunto(e.Location)) != null && NodoOrigen != NodoDestino) //Si el nodoDestino esta donde se encuentra el mouse y el nodo origen es distinto del nodo destino
                    {
                        frmVentanaMultiple = new VMultiple("Agregar Arco", "Valor del arco", graficadorStyleManager);
                        frmVentanaMultiple.ShowDialog(this);
                        if (frmVentanaMultiple.DialogResult == DialogResult.OK) //Si todo fue bien
                        {
                            if (grafo.AgregarArco(NodoOrigen, NodoDestino)) //Se procede a crear la arista
                            {
                                int distancia = int.Parse(frmVentanaMultiple.txtValor.Text); //Se guarda el peso de la arista
                                Edge miArista = new Edge();
                                miArista.NodoSalida = NodoOrigen.Valor;
                                miArista.NodoLlegada = NodoDestino.Valor;
                                miArista.Value = distancia;
                                miGrafo.Edges.Add(miArista);
                                IlcSet.Graphs.Where(v => v.Id == miGrafo.Id).FirstOrDefault().Edges.Add(miArista);
                                NodoOrigen.ListaAdyacencia.Find(v => v.nDestino == NodoDestino).peso = distancia; //Se busca la arista recien creada y se le aisigna el peso anterior
                                IlcSet.SaveChanges();
                            }
                        }

                    }
                    var_control = 0; //Origen set = 0
                    NodoOrigen = null; //NodoORigen se setea con null
                    NodoDestino = null; //NodoDestino se setea con nodo null
                    pbCanvas.Refresh(); //Se refresca el canvas
                    break;
            }
        }

        private void nuevoVerticeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Cross;
            nuevoNodo = new CVertice();
            var_control = 2; // recordemos que es usado para indicar el estado en la pizarra: 0 ->
            // sin accion, 1 -> Dibujando arco, 2 -> Nuevo vértice
        }

        private void linkChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePassword frmChangePassword = new ChangePassword(AuthUser,  graficadorStyleManager);
            frmChangePassword.ShowDialog(this);
            this.Show();
            this.Focus();
            if (frmChangePassword.DialogResult == DialogResult.OK)
            {
                MetroFramework.MetroMessageBox.Show(this, "Contraseña modificada satisfactoriamente.\nSe procedera a cerrar la sesion.", "Cambio de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality; //Seleccionamos el modo Smoothing
                grafo.DibujarGrafo(e.Graphics); //Dibujamos el grafo desde el metodo de la clase CGrafo enviando el Graphics
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //Se muestra el error si da error
            }
        }
    }
}
