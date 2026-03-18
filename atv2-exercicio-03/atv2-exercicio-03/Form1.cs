namespace atv2_exercicio_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonVerificar_Click(object sender, EventArgs e)
        {
           int numero = Convert.ToInt32(textNumero.Text); // tive que converter o valor do TextBox para inteiro novamente como fiz no exercicio 1  ===> referencia https://pt.stackoverflow.com/questions/7053/convertendo-uma-string-para-int
            if (numero % 2 == 0 && numero >= 100)
            {
                MessageBox.Show($"O número é par e maior que 100. Seu numero é {numero}");
            }
            if (numero % 2 == 0 )
            {
                MessageBox.Show($"O número é par e menor que 100. Seu numero é {numero}");
            }
            else
            {
                MessageBox.Show("O número é ímpar.");
            }
        }
    }
}
