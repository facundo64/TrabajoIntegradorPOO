namespace UI
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
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnIngresar = new Button();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(201, 130);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(125, 27);
            txtUsuario.TabIndex = 0;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(201, 199);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(125, 27);
            txtPass.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 133);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 2;
            label1.Text = "Usuario: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 206);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 3;
            label2.Text = "Contraseña:";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(199, 309);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(94, 29);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIngresar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Name = "Form1";
            Text = "Login del Sistema";
            TopMost = true;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtPass;
        private Label label1;
        private Label label2;
        private Button btnIngresar;
    }
}
