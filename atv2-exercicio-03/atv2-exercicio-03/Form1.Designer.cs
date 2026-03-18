namespace atv2_exercicio_03
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textNumero = new TextBox();
            label1 = new Label();
            buttonVerificar = new Button();
            SuspendLayout();
            // 
            // textNumero
            // 
            textNumero.Location = new Point(172, 191);
            textNumero.Name = "textNumero";
            textNumero.Size = new Size(150, 31);
            textNumero.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 92);
            label1.Name = "label1";
            label1.Size = new Size(162, 25);
            label1.TabIndex = 1;
            label1.Text = "Digite um numero ";
            // 
            // buttonVerificar
            // 
            buttonVerificar.Location = new Point(160, 275);
            buttonVerificar.Name = "buttonVerificar";
            buttonVerificar.Size = new Size(169, 38);
            buttonVerificar.TabIndex = 2;
            buttonVerificar.Text = "Verificar Numero";
            buttonVerificar.UseVisualStyleBackColor = true;
            buttonVerificar.Click += buttonVerificar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 450);
            Controls.Add(buttonVerificar);
            Controls.Add(label1);
            Controls.Add(textNumero);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNumero;
        private Label label1;
        private Button buttonVerificar;
    }
}
