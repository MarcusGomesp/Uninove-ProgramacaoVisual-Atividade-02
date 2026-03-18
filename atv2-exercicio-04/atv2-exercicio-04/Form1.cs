namespace atv2_exercicio_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonValidar_Click(object sender, EventArgs e)
        {
            int idade = Convert.ToInt32(textIdade.Text);

            if (idade >= 16)
            {

                if (idade >= 70)
                {
                    MessageBox.Show($"Você é possui {idade} de idade seu voto é opcional");
                }
                MessageBox.Show($"Você pode votar sua idade é {idade}.");
            }
            else
            {
                MessageBox.Show($"Você é menor de idade. Não pode votar sua idade é {idade}");
            }
        }
    }
}
