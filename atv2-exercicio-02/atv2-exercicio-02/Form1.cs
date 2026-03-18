namespace atv2_exercicio_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Name = textName.Text,
                Email = textEmail.Text,
                Senha = textSenha.Text
            };
            
            Login login = new Login(user);
            login.Show();

        }
    }
}
