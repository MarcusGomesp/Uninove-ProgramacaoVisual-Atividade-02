using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atv2_exercicio_02
{
    public partial class Login : Form
    {
        private User _user;
        public Login(User user)
        {
            InitializeComponent();

            _user = user;

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            

            if (textValidarEmail.Text == _user.Email && textValidarSenha.Text == _user.Senha)
            {
                MessageBox.Show($"Login bem-sucedido! bem vindo {_user.Name}");
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos. Tente novamente.");
            }
        }
    }
}
