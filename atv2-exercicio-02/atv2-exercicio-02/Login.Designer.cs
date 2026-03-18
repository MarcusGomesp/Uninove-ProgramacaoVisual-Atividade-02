namespace atv2_exercicio_02
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            textValidarSenha = new TextBox();
            label2 = new Label();
            textValidarEmail = new TextBox();
            buttonCadastrar = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(192, 202);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 10;
            label3.Text = "Senha";
            // 
            // textValidarSenha
            // 
            textValidarSenha.Location = new Point(192, 245);
            textValidarSenha.Name = "textValidarSenha";
            textValidarSenha.Size = new Size(150, 31);
            textValidarSenha.TabIndex = 9;
            textValidarSenha.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 110);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 8;
            label2.Text = "Email";
            // 
            // textValidarEmail
            // 
            textValidarEmail.Location = new Point(192, 153);
            textValidarEmail.Name = "textValidarEmail";
            textValidarEmail.Size = new Size(150, 31);
            textValidarEmail.TabIndex = 7;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(201, 309);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(112, 46);
            buttonCadastrar.TabIndex = 11;
            buttonCadastrar.Text = "Entrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 450);
            Controls.Add(buttonCadastrar);
            Controls.Add(label3);
            Controls.Add(textValidarSenha);
            Controls.Add(label2);
            Controls.Add(textValidarEmail);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox textValidarSenha;
        private Label label2;
        private TextBox textValidarEmail;
        private Button buttonCadastrar;
    }
}