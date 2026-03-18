namespace atv2_exercicio_06
{
    public partial class Form1 : Form
    {

        const string USUARIO = "admin";
        const string SENHA = "123";
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var user = textUsuario.Text;
            var idade = Convert.ToInt32(textIdade.Text);
            var senha = textSenha.Text;



            bool autenticado = checkBoxAutorizacao.Checked;


            if (USUARIO == user && SENHA == senha && idade >= 18)
            {
                MessageBox.Show("Login realizado com sucesso!");
            }
            else if (autenticado is true && idade >=18)
            {
                MessageBox.Show("Autorização  Especial acesso permitido.");
            }
            else
            {
                MessageBox.Show("Falha no login. Verifique suas credenciais e idade.");
            }
        }

    }
}
