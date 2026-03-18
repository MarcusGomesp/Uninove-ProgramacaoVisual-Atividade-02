namespace atv2_exercicio_04
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
            textIdade = new TextBox();
            label1 = new Label();
            buttonValidar = new Button();
            SuspendLayout();
            // 
            // textIdade
            // 
            textIdade.Location = new Point(206, 145);
            textIdade.Name = "textIdade";
            textIdade.Size = new Size(150, 31);
            textIdade.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 88);
            label1.Name = "label1";
            label1.Size = new Size(404, 25);
            label1.TabIndex = 1;
            label1.Text = "Digite sua idade para validar seu você pode votar";
            // 
            // buttonValidar
            // 
            buttonValidar.Location = new Point(224, 226);
            buttonValidar.Name = "buttonValidar";
            buttonValidar.Size = new Size(112, 34);
            buttonValidar.TabIndex = 2;
            buttonValidar.Text = "button1";
            buttonValidar.UseVisualStyleBackColor = true;
            buttonValidar.Click += buttonValidar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 450);
            Controls.Add(buttonValidar);
            Controls.Add(label1);
            Controls.Add(textIdade);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textIdade;
        private Label label1;
        private Button buttonValidar;
    }
}
