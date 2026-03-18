namespace atv2_exercicio_05
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
            buttonValidar = new Button();
            label1 = new Label();
            textNumero = new TextBox();
            SuspendLayout();
            // 
            // buttonValidar
            // 
            buttonValidar.Location = new Point(154, 187);
            buttonValidar.Name = "buttonValidar";
            buttonValidar.Size = new Size(112, 34);
            buttonValidar.TabIndex = 0;
            buttonValidar.Text = "Vaidar";
            buttonValidar.UseVisualStyleBackColor = true;
            buttonValidar.Click += buttonValidar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 62);
            label1.Name = "label1";
            label1.Size = new Size(157, 25);
            label1.TabIndex = 1;
            label1.Text = "Digite um numero";
            // 
            // textNumero
            // 
            textNumero.Location = new Point(136, 105);
            textNumero.Name = "textNumero";
            textNumero.Size = new Size(150, 31);
            textNumero.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 362);
            Controls.Add(textNumero);
            Controls.Add(label1);
            Controls.Add(buttonValidar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonValidar;
        private Label label1;
        private TextBox textNumero;
    }
}
