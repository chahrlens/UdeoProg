using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlEducativo
{
    public partial class Login : Form
    {
        public Login(Action _doAction)
        {
            InitializeComponent();
            doAction = _doAction;

        }

        private Action doAction;
        List<User> users = new List<User>();
        private string store_usuarios = "usuarios.txt";

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader(store_usuarios);
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');
                    User u = new User()
                    {
                        id = int.Parse(line[0]),
                        Name = line[1],
                        Password = line[2]
                    };
                    users.Add(u);

                }
                sr.Close();
            }
            catch
            {
                StreamWriter sr = new StreamWriter(store_usuarios);
                sr.WriteLine("1,admin,1234");
                sr.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (boxUser.Text != "" && boxPassword.Text != "")
            {
                bool login = false;
                foreach (User u in users)
                {
                    if (u.Name == boxUser.Text)
                    {
                        login = (u.Password == boxPassword.Text);
                        doAction();
                        break;
                    }
                }
                if (login)
                {
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta!");
                }

            }
            else
            {
                MessageBox.Show("Ingrese un usuario y contraseña para continuar.");
            }
        }
    }
}
