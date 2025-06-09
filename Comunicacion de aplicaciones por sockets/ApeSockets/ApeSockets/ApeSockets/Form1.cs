using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApeSockets
{
    public partial class Form1 : Form
    {
        TcpListener servidor;
        TcpClient cliente;
        NetworkStream stream;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnServidor_Click(object sender, EventArgs e)
        {
            IniciarServidor();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            ConectarCliente();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            EnviarMensaje(txtMensaje.Text);
        }
        private void IniciarServidor()
        {
            int puerto = 5000;
            servidor = new TcpListener(IPAddress.Any, puerto);
            servidor.Start();
            txtMensajes.AppendText("Servidor iniciado...\r\n");

            Task.Run(() =>
            {
                cliente = servidor.AcceptTcpClient();
                stream = cliente.GetStream();
                txtMensajes.Invoke((MethodInvoker)(() =>
                {
                    txtMensajes.AppendText("Cliente conectado.\r\n");
                }));

                byte[] buffer = new byte[1024];
                int leido;
                while ((leido = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    string recibido = Encoding.UTF8.GetString(buffer, 0, leido);
                    string desencriptado = Criptografia.Desencriptar(recibido);
                    txtMensajes.Invoke((MethodInvoker)(() =>
                    {
                        txtMensajes.AppendText("Cliente: " + desencriptado + "\r\n");
                    }));
                }
            });
        }

        private void ConectarCliente()
        {
            cliente = new TcpClient();
            cliente.Connect("127.0.0.1", 5000); // Cambia IP si es otro equipo
            stream = cliente.GetStream();
            txtMensajes.AppendText("Conectado al servidor.\r\n");

            Task.Run(() =>
            {
                byte[] buffer = new byte[1024];
                int leido;
                while ((leido = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    string recibido = Encoding.UTF8.GetString(buffer, 0, leido);
                    string desencriptado = Criptografia.Desencriptar(recibido);
                    txtMensajes.Invoke((MethodInvoker)(() =>
                    {
                        txtMensajes.AppendText("Servidor: " + desencriptado + "\r\n");
                    }));
                }
            });
        }

        private void EnviarMensaje(string mensaje)
        {
            if (stream != null && stream.CanWrite)
            {
                string encriptado = Criptografia.Encriptar(mensaje);
                byte[] datos = Encoding.UTF8.GetBytes(encriptado);
                stream.Write(datos, 0, datos.Length);
                txtMensajes.AppendText("Yo: " + mensaje + "\r\n");
                txtMensaje.Clear();
            }
        }
    }
}
