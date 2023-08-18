namespace WinFormsApp1
{
    partial class Form3
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
            lbl_email = new Label();
            tbox_email = new TextBox();
            label1 = new Label();
            btn_cadastrar = new Button();
            lbl_nome = new Label();
            lbl_senha = new Label();
            tbox_nome = new TextBox();
            tbox_senha = new TextBox();
            btn_login = new Button();
            SuspendLayout();
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(349, 231);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(36, 15);
            lbl_email.TabIndex = 17;
            lbl_email.Text = "Email";
            // 
            // tbox_email
            // 
            tbox_email.Location = new Point(349, 249);
            tbox_email.Name = "tbox_email";
            tbox_email.Size = new Size(100, 23);
            tbox_email.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(329, 66);
            label1.Name = "label1";
            label1.Size = new Size(150, 28);
            label1.TabIndex = 15;
            label1.Text = "Efetue seu login";
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Location = new Point(404, 360);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(75, 23);
            btn_cadastrar.TabIndex = 14;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Location = new Point(349, 187);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(98, 15);
            lbl_nome.TabIndex = 13;
            lbl_nome.Text = "Nome de usuário";
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Location = new Point(349, 275);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(39, 15);
            lbl_senha.TabIndex = 12;
            lbl_senha.Text = "Senha";
            // 
            // tbox_nome
            // 
            tbox_nome.Location = new Point(349, 205);
            tbox_nome.Name = "tbox_nome";
            tbox_nome.Size = new Size(100, 23);
            tbox_nome.TabIndex = 11;
            // 
            // tbox_senha
            // 
            tbox_senha.Location = new Point(349, 293);
            tbox_senha.Name = "tbox_senha";
            tbox_senha.Size = new Size(100, 23);
            tbox_senha.TabIndex = 10;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(323, 360);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(75, 23);
            btn_login.TabIndex = 9;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_email);
            Controls.Add(tbox_email);
            Controls.Add(label1);
            Controls.Add(btn_cadastrar);
            Controls.Add(lbl_nome);
            Controls.Add(lbl_senha);
            Controls.Add(tbox_nome);
            Controls.Add(tbox_senha);
            Controls.Add(btn_login);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_email;
        private TextBox tbox_email;
        private Label label1;
        private Button btn_cadastrar;
        private Label lbl_nome;
        private Label lbl_senha;
        private TextBox tbox_nome;
        private TextBox tbox_senha;
        private Button btn_login;
    }
}