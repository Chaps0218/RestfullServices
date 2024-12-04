namespace CONVUNI_RESTULL_DOTNET_CLIESC.View
{
    partial class Conversion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conversion));
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            valor = new TextBox();
            label3 = new Label();
            respuesta = new Label();
            label4 = new Label();
            btnConvertir = new Button();
            panel1 = new Panel();
            bienvenido = new Label();
            btn_logout = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(67, 241);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(283, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(67, 310);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(283, 28);
            comboBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 14.25F);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(63, 211);
            label1.Name = "label1";
            label1.Size = new Size(154, 21);
            label1.TabIndex = 2;
            label1.Text = "Unidad de Origen";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britannic Bold", 14.25F);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(63, 282);
            label2.Name = "label2";
            label2.Size = new Size(161, 21);
            label2.TabIndex = 3;
            label2.Text = "Unidad de Destino";
            // 
            // valor
            // 
            valor.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            valor.Location = new Point(66, 171);
            valor.Name = "valor";
            valor.Size = new Size(283, 27);
            valor.TabIndex = 4;
            valor.WordWrap = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Britannic Bold", 14.25F);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(66, 147);
            label3.Name = "label3";
            label3.Size = new Size(58, 21);
            label3.TabIndex = 5;
            label3.Text = "Valor:";
            // 
            // respuesta
            // 
            respuesta.AutoSize = true;
            respuesta.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            respuesta.ForeColor = Color.Teal;
            respuesta.Location = new Point(202, 396);
            respuesta.Name = "respuesta";
            respuesta.Size = new Size(15, 21);
            respuesta.TabIndex = 6;
            respuesta.Text = ".";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Britannic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(44, 18);
            label4.Name = "label4";
            label4.Size = new Size(342, 46);
            label4.TabIndex = 7;
            label4.Text = "Conversor de Unidades de Presión - \r\nGrupo 5";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnConvertir
            // 
            btnConvertir.BackColor = Color.MediumPurple;
            btnConvertir.Font = new Font("Britannic Bold", 12F);
            btnConvertir.ForeColor = Color.White;
            btnConvertir.Location = new Point(66, 354);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(287, 30);
            btnConvertir.TabIndex = 8;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = false;
            btnConvertir.Click += BtnConvertir_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(bienvenido);
            panel1.Controls.Add(btn_logout);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnConvertir);
            panel1.Controls.Add(valor);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(respuesta);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(162, 178);
            panel1.Name = "panel1";
            panel1.Size = new Size(426, 432);
            panel1.TabIndex = 9;
            // 
            // bienvenido
            // 
            bienvenido.AutoSize = true;
            bienvenido.Font = new Font("Britannic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bienvenido.ForeColor = Color.Teal;
            bienvenido.Location = new Point(198, 72);
            bienvenido.Name = "bienvenido";
            bienvenido.Size = new Size(16, 23);
            bienvenido.TabIndex = 10;
            bienvenido.Text = ".";
            bienvenido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.MediumPurple;
            btn_logout.Font = new Font("Britannic Bold", 12F);
            btn_logout.ForeColor = Color.White;
            btn_logout.Location = new Point(67, 103);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(287, 30);
            btn_logout.TabIndex = 9;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(197, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(365, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Conversion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            BackgroundImage = Properties.Resources._2;
            ClientSize = new Size(759, 622);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Conversion";
            Text = "Conversion";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
        private TextBox valor;
        private Label label3;
        private Label respuesta;
        private Label label4;
        private Button btnConvertir;
        private Panel panel1;
        private Button btn_logout;
        private PictureBox pictureBox1;
        private Label bienvenido;
    }
}