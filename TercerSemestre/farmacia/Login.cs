using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace farmacia
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public struct User
        {
            public string name;
            public string passwd;
        }


        private StreamReader reader;
        private StreamWriter writer;
        private string file = "usuarios.txt";
        private List<User> users = new List<User>();

        private void button1_Click(object sender, EventArgs e)
        {
            if (boxUserName.Text != "" && boxPassword.Text != "")
            {
                //login
                bool login = false;
                foreach (var user in users)
                {
                    if (user.name == boxUserName.Text && user.passwd == boxPassword.Text)
                    {
                        login = true;
                        break;
                    }
                }
                if (login)
                {
                    //close windows
                    this.Close();
                }
                else
                {
                    labelWarning.Text = "Usuario o contrasena incorrecta";
                }
            }
            else
            {
                labelWarning.Text = "Ingrese su usuario y contrasena";
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                reader = new StreamReader(file);
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    string[] data = line.Split(',');
                    User u = new User();
                    u.name = data[0];
                    u.passwd = data[1];
                    users.Add(u);
                }
                reader.Close();
            }

            catch (Exception ex)
            {
                writer = new StreamWriter(file);
                writer.WriteLine("admin,123");
                writer.Close();
            }
        }
    }
}
