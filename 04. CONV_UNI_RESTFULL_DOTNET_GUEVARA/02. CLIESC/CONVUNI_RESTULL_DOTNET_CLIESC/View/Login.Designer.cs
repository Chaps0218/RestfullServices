namespace CONVUNI_RESTULL_DOTNET_CLIESC.View
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
            btnLogin = new Button();
            txtUser = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPassword = new MaskedTextBox();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SteelBlue;
            btnLogin.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(203, 257);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(122, 39);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Iniciar Sesión";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(183, 136);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(161, 23);
            txtUser.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label1.Location = new Point(100, 135);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label2.Location = new Point(70, 192);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 4;
            label2.Text = "Constraseña";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(183, 192);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(161, 23);
            txtPassword.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Indigo;
            label3.Location = new Point(291, 37);
            label3.Name = "label3";
            label3.Size = new Size(124, 25);
            label3.TabIndex = 6;
            label3.Text = "¡Bienvenido!";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label4.Location = new Point(183, 75);
            label4.Name = "label4";
            label4.Size = new Size(338, 20);
            label4.TabIndex = 7;
            label4.Text = "Para acceder, primero es necesario iniciar sesión";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.boo;
            pictureBox1.Location = new Point(421, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(281, 315);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            BackgroundImage = Properties.Resources._2;
            ClientSize = new Size(700, 364);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUser);
            Controls.Add(btnLogin);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtUser;
        private Label label1;
        private Label label2;
        private MaskedTextBox txtPassword;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
    }
}