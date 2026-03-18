namespace atv2_exercicio_01
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
            textName = new TextBox();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 76);
            label1.Name = "label1";
            label1.Size = new Size(269, 25);
            label1.TabIndex = 0;
            label1.Text = "Digite um Número entre 10 e 50";
            // 
            // textName
            // 
            textName.Location = new Point(175, 148);
            textName.Name = "textName";
            textName.Size = new Size(150, 31);
            textName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 213);
            label2.Name = "label2";
            label2.Size = new Size(266, 25);
            label2.TabIndex = 2;
            label2.Text = "Clique para verificar seu numero";
            // 
            // button1
            // 
            button1.Location = new Point(194, 269);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "Clique";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textName;
        private Label label2;
        private Button button1;
    }
}
