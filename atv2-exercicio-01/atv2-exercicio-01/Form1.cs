namespace atv2_exercicio_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nametxt = textName.Text;

            int.TryParse(textName.Text, out int validarNumero);  //pesquisei aqui https://pt.stackoverflow.com/questions/7053/convertendo-uma-string-para-int

            if (validarNumero >= 10 && validarNumero <= 50)
            {
                MessageBox.Show($"O número é válido, o numero é: {validarNumero}");
            }
            else
            {
                MessageBox.Show($"O número é inválido, o numero é: {validarNumero}");
            }



        }
    }
}
