namespace WinFormsApp1
{
    partial class form_calculo
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
            btn_somar = new Button();
            tboxsegundonum = new TextBox();
            tboxprimeironum = new TextBox();
            lblprimeironum = new Label();
            lblsegundonum = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btn_somar
            // 
            btn_somar.Location = new Point(340, 318);
            btn_somar.Name = "btn_somar";
            btn_somar.Size = new Size(100, 23);
            btn_somar.TabIndex = 0;
            btn_somar.Text = "Somar";
            btn_somar.UseVisualStyleBackColor = true;
            btn_somar.Click += btn_somar_Click;
            // 
            // tboxsegundonum
            // 
            tboxsegundonum.Location = new Point(340, 241);
            tboxsegundonum.Name = "tboxsegundonum";
            tboxsegundonum.Size = new Size(100, 23);
            tboxsegundonum.TabIndex = 1;
            // 
            // tboxprimeironum
            // 
            tboxprimeironum.Location = new Point(340, 153);
            tboxprimeironum.Name = "tboxprimeironum";
            tboxprimeironum.Size = new Size(100, 23);
            tboxprimeironum.TabIndex = 2;
            // 
            // lblprimeironum
            // 
            lblprimeironum.AutoSize = true;
            lblprimeironum.Location = new Point(340, 135);
            lblprimeironum.Name = "lblprimeironum";
            lblprimeironum.Size = new Size(97, 15);
            lblprimeironum.TabIndex = 3;
            lblprimeironum.Text = "Primeiro número";
            // 
            // lblsegundonum
            // 
            lblsegundonum.AutoSize = true;
            lblsegundonum.Location = new Point(340, 223);
            lblsegundonum.Name = "lblsegundonum";
            lblsegundonum.Size = new Size(98, 15);
            lblsegundonum.TabIndex = 4;
            lblsegundonum.Text = "Segunda número";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(318, 52);
            label1.Name = "label1";
            label1.Size = new Size(147, 30);
            label1.TabIndex = 5;
            label1.Text = "Calcular soma";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(258, 369);
            label2.Name = "label2";
            label2.Size = new Size(265, 15);
            label2.TabIndex = 6;
            label2.Text = "Obs: apenas números impares menores que 1000";
            // 
            // form_calculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblsegundonum);
            Controls.Add(lblprimeironum);
            Controls.Add(tboxprimeironum);
            Controls.Add(tboxsegundonum);
            Controls.Add(btn_somar);
            Name = "form_calculo";
            Text = "FormCalcular";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_somar;
        private TextBox tboxsegundonum;
        private TextBox tboxprimeironum;
        private Label lblprimeironum;
        private Label lblsegundonum;
        private Label label1;
        private Label label2;
    }
}