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
using System.Reflection;
using WinFormAnimation;

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
        private VMultiple frmVentanaMultiple; // Ventana multiple
        private FMultiple frmFMultiple; // Formulario multiple
        private int var_control = 0; // la utilizaremos para determinar el estado en la pizarra:
        // 0 -> sin acción, 1 -> Dibujando arco, 2 -> Nuevo vértice
        // variables para el control de ventanas modales
        private int aristas = 0, nodos = 0; //Enteros para almacenar cantidad de nodos y aristas en el grafo
        private int tiempo; //Tiempo para la simulacion
        private bool buscarRuta = false; //Auxiliar para el algoritmo de Warshall
        public Graficador()
        {
            InitializeComponent();
        }
        public Graficador(User AuthUser, Graph miGrafo = null)
        {
            this.AuthUser = AuthUser;
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, pbCanvas, new object[] { true }); //Proceso importante para no parpadeé al dibujar
            nuevoNodo = null;
            var_control = 0;
            frmVentanaMultiple = null;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            IlcSet = new ILC();
            if (miGrafo == null)
                this.miGrafo = IlcSet.Graphs.Where(u => u.Tipo == "Activo").FirstOrDefault();
            else
                this.miGrafo = IlcSet.Graphs.Where(u => u.Id == miGrafo.Id).FirstOrDefault();
            if (this.miGrafo != null)
            {
                grafo = new CGrafo();
                if (this.miGrafo.Background != null)
                    pbCanvas.Image = Operaciones.byteArrayToImage(this.miGrafo.Background);
                if (this.miGrafo.NodeIcon != null)
                    grafo.NodoIcon = Operaciones.byteArrayToImage(this.miGrafo.NodeIcon);
                tiempo = this.miGrafo.Tiempo;
                foreach (Node miNodo in this.miGrafo.Nodes)
                {
                    nuevoNodo = new CVertice(miNodo.Name);
                    nuevoNodo.Posicion = new Point(miNodo.X, miNodo.Y);
                    grafo.AgregarVertice(nuevoNodo);
                }
                foreach (Edge miArista in this.miGrafo.Edges)
                {
                    grafo.AgregarArco(grafo.BuscarVertice(miArista.NodoSalida), grafo.BuscarVertice(miArista.NodoLlegada), miArista.Value);
                }
                nuevoNodo = null;
                pbCanvas.Refresh();
            }
            else
            {
                this.miGrafo = new Graph();
                this.miGrafo.Tipo = "Activo";
                grafo = new CGrafo();
                IlcSet.Graphs.Add(this.miGrafo);
                IlcSet.SaveChanges();
            }
        }

        private void Graficador_Load(object sender, EventArgs e)
        {
            this.StyleManager = graficadorStyleManager;
            this.lblAuthUserEmail.Text = AuthUser.Username;
            this.Text = "Bienvenido " + this.AuthUser.Name.ToString();
            if (AuthUser.Role.Name == "Admin")
            {
                administrarToolStripMenuItem.Visible = true;
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
                    nodos = grafo.nodos.Count;//cuenta cuantos nodos hay en el grafo
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
                        NuevoArco frmNuevoArco = new NuevoArco(graficadorStyleManager, NodoOrigen, NodoDestino);
                        List<string> miLista = new List<string>(); //Se crea una lista de tipo string
                        foreach (CVertice cv in grafo.nodos)
                        {
                            miLista.Add(cv.Valor.ToString()); //Se agregan los valores de los vertices
                        }
                        frmNuevoArco.Refresh(miLista);
                        frmNuevoArco.ShowDialog(this);
                        if (frmNuevoArco.DialogResult == DialogResult.OK) //Si todo fue bien
                        {
                            if (grafo.AgregarArco(NodoOrigen, NodoDestino)) //Se procede a crear la arista
                            {
                                int distancia = int.Parse(frmNuevoArco.txtPeso.Text); //Se guarda el peso de la arista
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

        private void trackBarTime_Scroll(object sender, ScrollEventArgs e)
        {
            MetroFramework.Controls.MetroTrackBar trackBarTime = (MetroFramework.Controls.MetroTrackBar)sender;
            tiempo = trackBarTime.Value;
        }

        private async void recorridoAnchuraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grafo.RestablecerGrafo(pbCanvas.CreateGraphics());
            frmFMultiple = new FMultiple("Recorrido en Anchura", new string[] { "Valor nodo inicial", "" }, graficadorStyleManager, true);
            List<string> miLista = new List<string>(); //Se crea una lista de tipo string
            foreach (CVertice cv in grafo.nodos)
            {
                miLista.Add(cv.Valor.ToString()); //Se agregan los valores de los vertices
            }
            frmFMultiple.Refresh(miLista);
            frmFMultiple.ShowDialog(this);
            if (frmFMultiple.DialogResult == DialogResult.OK)
            {
                string NodoOrigen = frmFMultiple.cmbInicial.SelectedItem.ToString();
                Velocidad frmVelocidad = new Velocidad(graficadorStyleManager, tiempo);
                frmVelocidad.trackBarTime.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackBarTime_Scroll);
                frmVelocidad.Show(this);
                bool yaTermino = await RecorridoAnchura(grafo.BuscarVertice(NodoOrigen)); //Se hace el recorrido en anchura
                if (yaTermino)
                {
                    tiempo = miGrafo.Tiempo;
                    frmVelocidad.Close();
                    this.Focus();
                }
            }
            pbCanvas.Refresh();
        }

        private async void recorridoProfundidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grafo.RestablecerGrafo(pbCanvas.CreateGraphics());
            frmFMultiple = new FMultiple("Recorrido en Profundidad", new string[] { "Valor nodo inicial", "" }, graficadorStyleManager, true);
            List<string> miLista = new List<string>(); //Se crea una lista de tipo string
            foreach (CVertice cv in grafo.nodos)
            {
                miLista.Add(cv.Valor.ToString()); //Se agregan los valores de los vertices
            }
            frmFMultiple.Refresh(miLista);
            frmFMultiple.ShowDialog(this);
            if (frmFMultiple.DialogResult == DialogResult.OK)
            {
                string NodoOrigen = frmFMultiple.cmbInicial.SelectedItem.ToString();
                Velocidad frmVelocidad = new Velocidad(graficadorStyleManager, tiempo);
                frmVelocidad.trackBarTime.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackBarTime_Scroll);
                frmVelocidad.Show(this);
                bool yaTermino = await RecorridoProfundidad(grafo.BuscarVertice(NodoOrigen)); //Se hace el recorrido en anchura
                if (yaTermino)
                {
                    tiempo = miGrafo.Tiempo;
                    frmVelocidad.Close();
                    this.Focus();
                }
            }
            pbCanvas.Refresh();
        }


        private async void dijkstraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            grafo.RestablecerGrafo(pbCanvas.CreateGraphics());
            frmFMultiple = new FMultiple("Algoritmo Dijkstra", new string[] { "Valor nodo inicial", "" }, graficadorStyleManager, true);
            List<string> miLista = new List<string>(); //Se crea una lista de tipo string
            foreach (CVertice cv in grafo.nodos)
            {
                miLista.Add(cv.Valor.ToString()); //Se agregan los valores de los vertices
            }
            frmFMultiple.Refresh(miLista);
            frmFMultiple.ShowDialog(this);
            if (frmFMultiple.DialogResult == DialogResult.OK)
            {
                string NodoOrigen = frmFMultiple.cmbInicial.SelectedItem.ToString();
                Velocidad frmVelocidad = new Velocidad(graficadorStyleManager, tiempo);
                frmVelocidad.trackBarTime.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackBarTime_Scroll);
                frmVelocidad.Show(this);
                grafo.Desmarcar();
                bool yaTermino = await dijkstra(grafo.BuscarVertice(NodoOrigen)); //Se hace el recorrido en anchura
                if (yaTermino)
                {
                    tiempo = miGrafo.Tiempo;
                    frmVelocidad.Close();
                    this.Focus();
                }
            }
            pbCanvas.Refresh();
        }

        private async void floydToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            grafo.RestablecerGrafo(pbCanvas.CreateGraphics());
            frmFMultiple = new FMultiple("Algoritmo Floyd Warshall", new string[] { "Valor nodo inicial", "Valor nodo final" }, graficadorStyleManager);
            List<string> miLista = new List<string>(); //Se crea una lista de tipo string
            foreach (CVertice cv in grafo.nodos)
            {
                miLista.Add(cv.Valor.ToString()); //Se agregan los valores de los vertices
            }
            frmFMultiple.Refresh(miLista);
            frmFMultiple.ShowDialog(this);
            if (frmFMultiple.DialogResult == DialogResult.OK)
            {
                string NodoOrigen = frmFMultiple.cmbInicial.SelectedItem.ToString();
                string NodoDestino = frmFMultiple.cmbFinal.SelectedItem.ToString();
                string mensaje = "Ruta:\n";
                Velocidad frmVelocidad = new Velocidad(graficadorStyleManager, tiempo);
                frmVelocidad.trackBarTime.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackBarTime_Scroll);
                frmVelocidad.Show(this);
                calcularMatricesIniciales();
                algoritmoWarshall();
                obtenerRutaPesoWarshall(NodoOrigen, NodoDestino);
                if (buscarRuta)
                {
                    pbCamion.Location = new Point(nodosRuta[0].Posicion.X - 20, nodosRuta[0].Posicion.Y - 20);
                    pbCamion.Parent = pbCanvas;
                    pbCanvas.BackColor = Color.Transparent;
                    pbCamion.Visible = true;
                    for (int x = 0; x < nodosRuta.Count; x++)
                    {
                        if (x!=0) await Task.Delay(tiempo);
                        grafo.Colorear(nodosRuta[x]);
                        pbCanvas.Refresh();
                        if (x + 1 < nodosRuta.Count)
                        {
                            mensaje += nodosRuta[x].Valor + " > ";
                            new Animator2D(new Path2D(pbCamion.Location.X, nodosRuta[x + 1].Posicion.X - 20, pbCamion.Location.Y, nodosRuta[x + 1].Posicion.Y - 20, (ulong)tiempo)).Play(pbCamion, Animator2D.KnownProperties.Location);
                            grafo.ColoArista(nodosRuta[x].Valor, nodosRuta[x + 1].Valor);
                            if (!grafo.DiGrafo)
                                grafo.ColoArista(nodosRuta[x + 1].Valor, nodosRuta[x].Valor);
                            pbCanvas.Refresh();
                        }
                        else
                            mensaje += nodosRuta[x].Valor;
                    }
                    buscarRuta = false;
                }
                pbCanvas.Refresh();
                tiempo = miGrafo.Tiempo;
                frmVelocidad.Close();
                this.Focus();
                mensaje += "\nEl peso minimo entre el nodo " + NodoOrigen + " y el nodo " + NodoDestino + " es: " + peso.ToString();
                MetroMessageBox.Show(this, mensaje, "Floyd Warshall", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            pbCanvas.Refresh();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentanaMultiple = new VMultiple("Eliminar Vertice", "Valor del vertice", graficadorStyleManager);
            frmVentanaMultiple.ShowDialog(this);
            if (frmVentanaMultiple.DialogResult == DialogResult.OK) //Si todo fue bien
            {
                string valorNodo = frmVentanaMultiple.txtValor.Text.Trim();
                if (grafo.BuscarVertice(valorNodo) != null) //si se encuentra el nodo
                {
                    grafo.ELiminarNodo(frmVentanaMultiple.txtValor.Text.Trim()); //Elimina un nodo con tener el valor string de este
                    foreach (Edge miArista in IlcSet.Edges)
                    {
                        if (miArista.NodoLlegada == valorNodo || miArista.NodoSalida == valorNodo)
                        {
                            IlcSet.Edges.Remove(miArista);
                        }
                    }
                    foreach (Node miNodo in IlcSet.Nodes)
                    {
                        if (miNodo.Name == valorNodo)
                        {
                            IlcSet.Nodes.Remove(miNodo);
                            break;
                        }
                    }
                    IlcSet.SaveChanges();
                    pbCanvas.Refresh(); //Se refresca el canvas
                }
                else //si no
                {
                    MetroMessageBox.Show(this, "El nodo No se encuentra en el grafo",
                   "Error Nodo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void nuevaAristaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoArco frmNuevoArco = new NuevoArco(graficadorStyleManager);
            List<string> miLista = new List<string>(); //Se crea una lista de tipo string
            foreach (CVertice cv in grafo.nodos)
            {
                miLista.Add(cv.Valor.ToString()); //Se agregan los valores de los vertices
            }
            frmNuevoArco.Refresh(miLista);
            frmNuevoArco.ShowDialog(this);
            if (frmNuevoArco.DialogResult == DialogResult.OK) //Si todo fue bien
            {
                NodoOrigen = grafo.BuscarVertice(frmNuevoArco.cmbNodoInicial.SelectedItem.ToString());
                NodoDestino = grafo.BuscarVertice(frmNuevoArco.cmbNodoFinal.SelectedItem.ToString());
                if (grafo.AgregarArco(NodoOrigen, NodoDestino)) //Se procede a crear la arista
                {
                    int distancia = int.Parse(frmNuevoArco.txtPeso.Text); //Se guarda el peso de la arista
                    Edge miArista = new Edge();
                    miArista.NodoSalida = NodoOrigen.Valor;
                    miArista.NodoLlegada = NodoDestino.Valor;
                    miArista.Value = distancia;
                    miGrafo.Edges.Add(miArista);
                    IlcSet.Graphs.Where(v => v.Id == miGrafo.Id).FirstOrDefault().Edges.Add(miArista);
                    NodoOrigen.ListaAdyacencia.Find(v => v.nDestino == NodoDestino).peso = distancia; //Se busca la arista recien creada y se le aisigna el peso anterior
                    IlcSet.SaveChanges();
                    pbCanvas.Refresh();
                }
            }
        }

        private void eliminarAristaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFMultiple = new FMultiple("Eliminar Arista", new string[] { "Nodo origen", "Nodo Final" }, graficadorStyleManager);
            List<string> miLista = new List<string>(); //Se crea una lista de tipo string
            foreach (CVertice cv in grafo.nodos)
            {
                miLista.Add(cv.Valor.ToString()); //Se agregan los valores de los vertices
            }
            frmFMultiple.Refresh(miLista);
            frmFMultiple.ShowDialog(this);
            if (frmFMultiple.DialogResult == DialogResult.OK)
            {
                string NodoOrigen = frmFMultiple.cmbInicial.SelectedItem.ToString();
                string NodoDestino = frmFMultiple.cmbFinal.SelectedItem.ToString();
                if (grafo.AristaExist(NodoOrigen, NodoDestino))
                {
                    grafo.ElimiarArco(NodoOrigen, NodoDestino);
                    foreach (Edge miArista in IlcSet.Edges.Where(v => v.GraphId == miGrafo.Id))
                    {
                        if (miArista.NodoLlegada == NodoDestino && miArista.NodoSalida == NodoOrigen)
                        {
                            IlcSet.Edges.Remove(miArista);
                            break;
                        }
                    }
                    IlcSet.SaveChanges();
                    pbCanvas.Refresh();
                }
            }
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

        /*****************************************************************************/
        /*                                 ALGORITMOS                                */
        /*****************************************************************************/
        //Recorrido en anchura
        private Queue<Label> c = new Queue<Label>();
        async private Task<bool> RecorridoAnchura(CVertice nodo)
        {
            CVertice temp = new CVertice();
            nodo.Visitado = true;
            Queue<CVertice> cola = new Queue<CVertice>();
            cola.Enqueue(nodo);
            grafo.Colorear(nodo);
            pbCanvas.Refresh();
            await Task.Delay(tiempo);
            while (cola.Count != 0)
            {
                temp = cola.Dequeue();
                foreach (CArco arco in temp.ListaAdyacencia)
                {
                    if (arco.nDestino.Visitado == false)
                    {
                        cola.Enqueue(arco.nDestino);
                    }
                }
                foreach (CArco arco in temp.ListaAdyacencia)
                {
                    if (arco.nDestino.Visitado == false)
                    {
                        arco.nDestino.Visitado = true;
                        grafo.Colorear(arco.nDestino);
                        pbCanvas.Refresh();
                        await Task.Delay(tiempo);
                    }
                }

            }
            return true;
        }
        //recorrido en Profundidad
        private async Task<bool> RecorridoProfundidad(CVertice nodo)
        {
            CVertice temp = new CVertice();
            Stack<CVertice> pila = new Stack<CVertice>();
            pila.Push(nodo);
            while (pila.Count != 0)
            {
                temp = pila.Pop();
                if (temp.Visitado == false)
                {
                    temp.Visitado = true;
                    grafo.Colorear(temp);
                    pbCanvas.Refresh();
                    await Task.Delay(tiempo);
                    foreach (CArco arco in temp.ListaAdyacencia)
                    {
                        pila.Push(arco.nDestino);
                    }
                }
            }
            return true;
        }

        private void reestablecerGrafoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbCamion.Visible = false;
            grafo.RestablecerGrafo(pbCanvas.CreateGraphics());
            pbCanvas.Refresh();
        }

        private async Task<bool> dijkstra(CVertice inicio)
        {
            if (inicio.ListaAdyacencia.Count != 0)
            {
                int n = grafo.nodos.Count;
                grafo.Colorear(inicio);
                pbCanvas.Refresh();
                await Task.Delay(tiempo);
                foreach (CVertice nodo in grafo.nodos)
                {
                    foreach (CArco a in nodo.ListaAdyacencia)
                    {
                        if (nodo == inicio)
                        {
                            a.nDestino.distancianodo = a.peso;
                            a.nDestino.pesoasignado = true;
                            a.color = Color.LimeGreen;
                            a.grosor_flecha = 4;
                            pbCanvas.Refresh();
                            await Task.Delay(tiempo);
                        }
                        else if (nodo != inicio && a.nDestino.pesoasignado == false)
                        {
                            a.nDestino.distancianodo = Int32.MaxValue;
                        }
                    }
                }
                inicio.distancianodo = 0;
                inicio.Visitado = true;
                while (grafo.nododistanciaminima() != null)
                {
                    CVertice nododismin = grafo.nododistanciaminima();
                    nododismin.Visitado = true;
                    grafo.Colorear(nododismin);
                    pbCanvas.Refresh();
                    await Task.Delay(tiempo);
                    foreach (CArco arco in nododismin.ListaAdyacencia)
                    {
                        if (arco.nDestino.distancianodo > nododismin.distancianodo + arco.peso)
                        {
                            if (arco.nDestino.pesoasignado)
                            { grafo.DibujarEntrantes(arco.nDestino); }
                            arco.nDestino.distancianodo = nododismin.distancianodo + arco.peso;
                            arco.nDestino.pesoasignado = true;
                            arco.color = Color.LimeGreen;
                            arco.grosor_flecha = 4;
                            pbCanvas.Refresh();
                            await Task.Delay(tiempo);
                        }
                    }
                    await Task.Delay(tiempo);
                }
                return true;
            }
            else
            {
                MetroMessageBox.Show(this, "El nodo que ha elegino no tiene nodos adyacentes"
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Algoritmo de Warshall
        private List<List<int>> matrizFord = new List<List<int>>(); // matriz para utilizar algoritmo de ford
        private List<List<int>> matrizDistanciaWarshall = new List<List<int>>(); //matriz de distancias de cada nodo con cada nodo si existe relacion entre ellos
        private List<List<int>> matrizNodosWarshall = new List<List<int>>(); //matriz de nodos
        private List<CVertice> nodosRuta; // Lista de nodos utilizada para almacenar la ruta
        private Queue<int> Cola = new Queue<int>(); //cola de nodos
        private int totalNodos; //lista de nodos
        int[] parent; // padre del nodo
        bool[] visitados;// variable para comprobar los nodos ya visitados
        private double peso = 0.0; //Peso minimo para Warshall

        private void calcularMatricesIniciales() // se calculan las matrices iniciales de distancia y de nodos
        {
            matrizDistanciaWarshall = new List<List<int>>();
            matrizFord = new List<List<int>>();
            matrizNodosWarshall = new List<List<int>>();
            nodosRuta = new List<CVertice>(); //lista de nodos
            totalNodos = grafo.nodos.Count; //cuenta el numero de nodos en la lista "nodos"
            parent = new int[totalNodos];
            visitados = new bool[totalNodos];
            //calculamos la matriz inicial de distancias
            for (int i = 0; i < totalNodos; i++)
            {
                List<int> filaDistancia = new List<int>();
                for (int j = 0; j < totalNodos; j++)
                {
                    //si el origen = al destino
                    if (i == j)
                    {
                        filaDistancia.Add(0);
                    }
                    else
                    {
                        //buscamos si existe la relacion i,j; de existir obtenemos la distancia
                        int distancia = -1;
                        for (int k = 0; k < grafo.nodos[i].ListaAdyacencia.Count; k++)
                        {
                            if (grafo.nodos[i].ListaAdyacencia[k].nDestino == grafo.nodos[j])
                                distancia = grafo.nodos[i].ListaAdyacencia[k].peso;
                        }
                        filaDistancia.Add(distancia);
                    }
                }
                matrizDistanciaWarshall.Add(filaDistancia);// obtenemos la matriz inicial de distancias
                matrizFord.Add(filaDistancia);
            }
            //calculamos la matriz inicial de nodos
            for (int i = 0; i < totalNodos; i++)
            {
                List<int> puntosIntermedios = new List<int>();
                for (int j = 0; j < totalNodos; j++)
                {
                    puntosIntermedios.Add(j);
                }
                matrizNodosWarshall.Add(puntosIntermedios);// obtenemos la matriz inicial de nodos
            }
        }

        private void algoritmoWarshall() //se declara el metodo de warshall
        {
            for (int k = 0; k < totalNodos; k++)
            {
                for (int i = 0; i < totalNodos; i++)
                {
                    for (int j = 0; j < totalNodos; j++)
                    {
                        //hacemos las operaciones siempre y cuando exista distancia con el intermediario k: [i,k,j]
                        //es decir,debe existir la distancia d(i,k) y d(k,j)
                        if (matrizDistanciaWarshall[i][k] > 0.0 && matrizDistanciaWarshall[k][j] > 0.0)
                        {
                            int distancia = matrizDistanciaWarshall[i][k] + matrizDistanciaWarshall[k][j];

                            if (matrizDistanciaWarshall[i][j] > 0.0)
                            {
                                if (matrizDistanciaWarshall[i][j] > distancia)
                                {
                                    matrizDistanciaWarshall[i][j] = distancia;
                                    matrizNodosWarshall[i][j] = k;
                                }
                            }
                            else
                            {
                                if (matrizDistanciaWarshall[i][j] < 0.0)
                                {
                                    matrizDistanciaWarshall[i][j] = distancia;
                                    matrizNodosWarshall[i][j] = k;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void obtenerRutaPesoWarshall(string nodoOrigen, string nodoDestino)
        {
            int indexNodoOrigen = 0;
            int indexNodoDestino = 0;
            for (int i = 0; i < totalNodos; i++)//para i menor que la cantidad de nodos agregados a la cola
            {
                if (grafo.nodos[i].Valor == nodoOrigen)
                {
                    indexNodoOrigen = i;// el valor i sera el indice del nodo origen
                }
                if (grafo.nodos[i].Valor == nodoDestino)
                {
                    indexNodoDestino = i;// el valor j sera el indice del nodo destino
                }
            }
            List<int> ruta = new List<int>(); // se declara la lista ruta
            ruta.Add(indexNodoOrigen); // se añade el indice origen
            ruta.Add(indexNodoDestino);// se añade el indice destino
            obtenerNodosIntermedios(indexNodoOrigen, indexNodoDestino, ruta, 1); // se obtienen los nodos intermedios

            foreach (int nodo in ruta) // para cada nodo en ruta
            {
                nodosRuta.Add(grafo.nodos[nodo]);// agregara en nodosRuta cada nodo en la cola nodos del grafo
            }
            //obtenemos el peso de la ruta
            peso = matrizDistanciaWarshall[ruta[0]][ruta[ruta.Count - 1]];
            if (peso > -1)
            {
                buscarRuta = true;
            }
            else
            {
                MessageBox.Show("No se puede trazar ruta entre los nodos seleccionados");
            }
        }

        private void obtenerNodosIntermedios(int nodoOrigen, int nodoDestino, List<int> ruta, int indice) //metodo para obtener nodos intermedios
        {
            int intermedio = matrizNodosWarshall[nodoOrigen][nodoDestino];// la variable intermedio tendra el valor de la matriznodoWarshall con los valores de origen y destino
            if (intermedio != nodoDestino) //mientras intermedio sea diferente de nodo destino
            {
                ruta.Insert(indice, intermedio);// insertara en la lista ruta en el indice indicado
                indice++; //indice aumenta
                obtenerNodosIntermedios(intermedio, nodoDestino, ruta, indice); //obtiene nodo intermedio
            }
            else
            {
                indice--; // si intermedio y nodoDestino son iguales indice disminuye
                if (indice - 1 == -1)
                {
                    return;
                }
                nodoOrigen = ruta[indice - 1]; // nodo origen tendra el valor que tiene la ruta en determinado indice -1.
                nodoDestino = ruta[indice];  // nodo destino tendra el valor que tiene la ruta en determinado indice
                obtenerNodosIntermedios(nodoOrigen, nodoDestino, ruta, indice); // obtiene el nodo intermedio 
            }
        }
    }
}
