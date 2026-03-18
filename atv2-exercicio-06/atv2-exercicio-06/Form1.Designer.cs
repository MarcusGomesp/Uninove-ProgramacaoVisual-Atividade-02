namespace atv2_exercicio_06
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
            label1 = new Label();
            textIdade = new TextBox();
            buttonLogin = new Button();
            textUsuario = new TextBox();
            label2 = new Label();
            textSenha = new TextBox();
            checkBoxAutorizacao = new CheckBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(185, 25);
            label1.Name = "label1";
            label1.Size = new Size(57, 25);
            label1.TabIndex = 0;
            label1.Text = "Idade";
            // 
            // textIdade
            // 
            textIdade.Location = new Point(161, 53);
            textIdade.Name = "textIdade";
            textIdade.Size = new Size(150, 31);
            textIdade.TabIndex = 1;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(173, 343);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(112, 34);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textUsuario
            // 
            textUsuario.Location = new Point(161, 131);
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(150, 31);
            textUsuario.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 103);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 3;
            label2.Text = "Usuario";
            // 
            // textSenha
            // 
            textSenha.Location = new Point(161, 208);
            textSenha.Name = "textSenha";
            textSenha.Size = new Size(150, 31);
            textSenha.TabIndex = 6;
            // 
            // checkBoxAutorizacao
            // 
            checkBoxAutorizacao.AutoSize = true;
            checkBoxAutorizacao.Location = new Point(132, 280);
            checkBoxAutorizacao.Name = "checkBoxAutorizacao";
            checkBoxAutorizacao.Size = new Size(207, 29);
            checkBoxAutorizacao.TabIndex = 7;
            checkBoxAutorizacao.Text = "Autorização especial?";
            checkBoxAutorizacao.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(185, 180);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 5;
            label3.Text = "Senha";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 476);
            Controls.Add(checkBoxAutorizacao);
            Controls.Add(textSenha);
            Controls.Add(label3);
            Controls.Add(textUsuario);
            Controls.Add(label2);
            Controls.Add(buttonLogin);
            Controls.Add(textIdade);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textIdade;
        private Button buttonLogin;
        private TextBox textUsuario;
        private Label label2;
        private TextBox textSenha;
        private CheckBox checkBoxAutorizacao;
        private Label label3;
    }
}
