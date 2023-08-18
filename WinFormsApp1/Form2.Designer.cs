namespace WinFormsApp1
{
    partial class Form2
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
            btnlogin = new Button();
            tboxsenha = new TextBox();
            tboxnome = new TextBox();
            lblsenha = new Label();
            lblnome = new Label();
            btncadastrar = new Button();
            label1 = new Label();
            tboxemail = new TextBox();
            lblemail = new Label();
            SuspendLayout();
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(324, 335);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(75, 23);
            btnlogin.TabIndex = 0;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // tboxsenha
            // 
            tboxsenha.Location = new Point(350, 268);
            tboxsenha.Name = "tboxsenha";
            tboxsenha.Size = new Size(100, 23);
            tboxsenha.TabIndex = 1;
            // 
            // tboxnome
            // 
            tboxnome.Location = new Point(350, 180);
            tboxnome.Name = "tboxnome";
            tboxnome.Size = new Size(100, 23);
            tboxnome.TabIndex = 2;
            // 
            // lblsenha
            // 
            lblsenha.AutoSize = true;
            lblsenha.Location = new Point(350, 250);
            lblsenha.Name = "lblsenha";
            lblsenha.Size = new Size(39, 15);
            lblsenha.TabIndex = 3;
            lblsenha.Text = "Senha";
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.Location = new Point(350, 162);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(98, 15);
            lblnome.TabIndex = 4;
            lblnome.Text = "Nome de usuário";
            // 
            // btncadastrar
            // 
            btncadastrar.Location = new Point(405, 335);
            btncadastrar.Name = "btncadastrar";
            btncadastrar.Size = new Size(75, 23);
            btncadastrar.TabIndex = 5;
            btncadastrar.Text = "Cadastrar";
            btncadastrar.UseVisualStyleBackColor = true;
            btncadastrar.Click += btncadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(311, 43);
            label1.Name = "label1";
            label1.Size = new Size(180, 28);
            label1.TabIndex = 6;
            label1.Text = "Efetue seu cadastro";
            // 
            // tboxemail
            // 
            tboxemail.Location = new Point(350, 224);
            tboxemail.Name = "tboxemail";
            tboxemail.Size = new Size(100, 23);
            tboxemail.TabIndex = 7;
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Location = new Point(350, 206);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(36, 15);
            lblemail.TabIndex = 8;
            lblemail.Text = "Email";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblemail);
            Controls.Add(tboxemail);
            Controls.Add(label1);
            Controls.Add(btncadastrar);
            Controls.Add(lblnome);
            Controls.Add(lblsenha);
            Controls.Add(tboxnome);
            Controls.Add(tboxsenha);
            Controls.Add(btnlogin);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnlogin;
        private TextBox tboxsenha;
        private TextBox tboxnome;
        private Label lblsenha;
        private Label lblnome;
        private Button btncadastrar;
        private Label label1;
        private TextBox tboxemail;
        private Label lblemail;
    }
}