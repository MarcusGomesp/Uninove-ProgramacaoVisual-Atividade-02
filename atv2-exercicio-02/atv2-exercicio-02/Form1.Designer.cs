namespace atv2_exercicio_02
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
            textName = new TextBox();
            label1 = new Label();
            buttonCadastrar = new Button();
            label2 = new Label();
            textEmail = new TextBox();
            label3 = new Label();
            textSenha = new TextBox();
            SuspendLayout();
            // 
            // textName
            // 
            textName.Location = new Point(254, 92);
            textName.Name = "textName";
            textName.Size = new Size(150, 31);
            textName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(254, 49);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(254, 350);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(112, 34);
            buttonCadastrar.TabIndex = 2;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(254, 152);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 4;
            label2.Text = "Email";
            // 
            // textEmail
            // 
            textEmail.Location = new Point(254, 195);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(150, 31);
            textEmail.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(254, 244);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 6;
            label3.Text = "Senha";
            // 
            // textSenha
            // 
            textSenha.Location = new Point(254, 287);
            textSenha.Name = "textSenha";
            textSenha.Size = new Size(150, 31);
            textSenha.TabIndex = 5;
            textSenha.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 450);
            Controls.Add(label3);
            Controls.Add(textSenha);
            Controls.Add(label2);
            Controls.Add(textEmail);
            Controls.Add(buttonCadastrar);
            Controls.Add(label1);
            Controls.Add(textName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textName;
        private Label label1;
        private Button buttonCadastrar;
        private Label label2;
        private TextBox textEmail;
        private Label label3;
        private TextBox textSenha;
    }
}
