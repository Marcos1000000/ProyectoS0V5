using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics.Eventing.Reader;

namespace Cliente
{
    public partial class Form1 : Form
    {
        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse("192.168.56.102"), 9053);
        Thread atender;
        string invitados;
        int nInvitados = 0;
        bool listaC = false;
        int totalconectados;

        public Form1()
        {
            InitializeComponent();
            contextMenuStrip1.Show();
            button1.Visible = false;
            button2.Visible = false;
            button4.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            Invitar.Visible = false;
            listaConectados.Visible = false;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void atendermensaje()//esta funcion recibe los mensajes del servidor y manda los datos a la funcion necesaria
        {
            while (true)
            {
                byte[] respuesta = new byte[1024];
                socket.Receive(respuesta);
                string mensaje = Encoding.ASCII.GetString(respuesta).Split("\0")[0];
                string[] trozos = mensaje.Split("/");
                int codigo = Convert.ToInt32(trozos[0]);

                switch (codigo)
                {
                    case 0: // recibe la confirmacion del inicio de sesion
                        Invoke(new Action(() =>
                        {
                            string mensaje2 = trozos[1];
                            if (trozos[1] == "Conectado\n")
                            {
                                MessageBox.Show("has iniciado sesion con exito");

                            }
                            else
                            {
                                MessageBox.Show("No has podido iniciar sesion");
                            }
                        }
                        ));
                        break;
                    case 2: //Registrar
                        Invoke(new Action(() =>
                        {
                            string mensaje3 = trozos[1];
                            if (trozos[1] != "Error")
                            {
                                MessageBox.Show("has podido registrate");
                            }
                            else
                            {
                                MessageBox.Show("No se ha  podido registrasrse");
                            }
                        }
                        ));
                        break;
                    case 5://Desconectar
                        Invoke(new Action(() =>
                        {
                            socket.Shutdown(SocketShutdown.Both);
                            socket.Close();
                            MessageBox.Show("Desconectado del servidor");
                        }
                        ));
                        break;
                    case 6: //lista
                        /*                      int totalconectados = Convert.ToInt32(trozos[1]);
                                                int i = 2;
                                                string resultado;
                                                while (trozos[i] != null)
                                                {
                                                    resultado = trozos[i];

                                                    ActualizarListaConectados(resultado);
                                                    i++;
                                                }
                        */
                        Invoke(new Action(() =>
                            {
                                int c = Convert.ToInt32(trozos[1]);
                                string b = Convert.ToString(trozos[2]);

                                if (listaC == false)
                                {
                                    int id = 0;
                                    listaConectados.DropDownItems.Clear();
                                    foreach (String items in dameListaConectados(mensaje, c))
                                    {
                                        ToolStripMenuItem item = new ToolStripMenuItem(items);
                                        item.Tag = id;
                                        id++;
                                        listaConectados.DropDownItems.Add(item);
                                        item.Click += new EventHandler(item_Click);
                                    }
                                }
                            }
                            ));
                        break;
                    case 7://Recibir mensaje si hay partida
                        Invoke(new Action(() =>
                        {
                            MessageBox.Show(trozos[1]);
                        }
                        ));
                        break;
                }

            }

        }

        private void button1_Click(object sender, EventArgs e) // inicia sesion 
        {

            try
            {

                string usuario = textBox1.Text;
                string contraseña = textBox2.Text;
                string mensaje = ("0/" + usuario + "/" + contraseña); // envia al servidor el inicio de sesion 
                socket.Send(Encoding.ASCII.GetBytes(mensaje));
                //MessageBox.Show("Inicada la sesion correctamente");


            }
            catch (SocketException)
            {
                MessageBox.Show("No has podido iniciar sesion ");

            }
        }

        private void button2_Click(object sender, EventArgs e) //Cerrar sesion
        {
            try
            {
                string usuario = textBox1.Text;
                string sesion = ("5/" + usuario); //cierra sesion del usuario
                socket.Send(Encoding.ASCII.GetBytes(sesion));
            }
            catch (SocketException)
            {

            }

        }

        private void timer1_Tick(object sender, EventArgs e) //pide la lista de conectados cada 3 segundos
        {
            string mensaje = "6/";
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            socket.Send(msg);
        }

        private void comoFuncionaElProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El programa se conecta al servidor directamente cuando lo abres(si no va dele al boton conectarse)  y para iniciar sesion simplemente tienes que rellenar los textbox");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                socket.Connect(remoteEP);
                MessageBox.Show("Conectado al servidor");
                button1.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                button4.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                Invitar.Visible = true;
                listaConectados.Visible = true;
                button3.Visible = false;
                ThreadStart ts = delegate { atendermensaje(); };
                atender = new Thread(ts);
                atender.Start();
            }
            catch (Exception)
            {

            }

        }
        public void item_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            MessageBox.Show("Se enviara una invitacion a " + item.Text);
            listaInvitacion(item.Text);
        }
        private void button4_Click(object sender, EventArgs e) //registrarse
        {

            try
            {

                string usuario = textBox1.Text;
                string contraseña = textBox2.Text;
                string mensaje = ("4/" + usuario + "/" + contraseña); // envia al servidor el registro 
                socket.Send(Encoding.ASCII.GetBytes(mensaje));
                //MessageBox.Show("Registrado correctamente");



            }
            catch (SocketException)
            {
                MessageBox.Show("No has podido crear un usuario");

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;
            string mensaje = "6/"; // envia al servidor el registro 
            socket.Send(Encoding.ASCII.GetBytes(mensaje));
        }

        private void Invitar_Click(object sender, EventArgs e)
        {
            string invite = "7/" + nInvitados + invitados;
            byte[] mensaje = System.Text.Encoding.ASCII.GetBytes(invite);

            socket.Send(mensaje);
        }
        private void listaInvitacion(string nombre)
        {
            if (nInvitados < 4)
            {
                invitados = invitados + "/" + nombre;
                nInvitados++;
            }
            else
            {
                MessageBox.Show("Solo se puede invitar un maximo de 4 jugadores");
            }
        }
        private List<String> dameListaConectados(string lista, int nConectados)
        {
            {
                List<String> conectados = new List<String>();
                string[] lconectados = lista.Split('/');

                int numeroConectados = Convert.ToInt32(lconectados[1]);
                int i = 0;
                while (i < nConectados)
                {

                    string nombre = lconectados[i + 2];
                    string[] Nnombre;
                    Nnombre = nombre.Split('6');
                    conectados.Add(Nnombre[0]);
                    i++;
                }

                return conectados;

            }
        }


    }
}

