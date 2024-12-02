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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            valor = new TextBox();
            label3 = new Label();
            respuesta = new Label();
            label4 = new Label();
            btnConvertir = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(396, 161);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(229, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(396, 239);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(229, 28);
            comboBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label1.Location = new Point(400, 138);
            label1.Name = "label1";
            label1.Size = new Size(225, 20);
            label1.TabIndex = 2;
            label1.Text = "Seleccionar la unidad de origen";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label2.Location = new Point(396, 207);
            label2.Name = "label2";
            label2.Size = new Size(230, 20);
            label2.TabIndex = 3;
            label2.Text = "Seleccionar la unidad de destino";
            // 
            // valor
            // 
            valor.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            valor.Location = new Point(396, 91);
            valor.Name = "valor";
            valor.Size = new Size(229, 27);
            valor.TabIndex = 4;
            valor.WordWrap = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label3.Location = new Point(417, 68);
            label3.Name = "label3";
            label3.Size = new Size(192, 20);
            label3.TabIndex = 5;
            label3.Text = "Ingrese el valor a convertir";
            // 
            // respuesta
            // 
            respuesta.AutoSize = true;
            respuesta.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            respuesta.Location = new Point(396, 284);
            respuesta.Name = "respuesta";
            respuesta.Size = new Size(14, 21);
            respuesta.TabIndex = 6;
            respuesta.Text = ".";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(212, 30);
            label4.Name = "label4";
            label4.Size = new Size(350, 25);
            label4.TabIndex = 7;
            label4.Text = "CONVERSIÓN UNIDADES DE PRESIÓN";
            // 
            // btnConvertir
            // 
            btnConvertir.BackColor = Color.SeaGreen;
            btnConvertir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConvertir.Location = new Point(452, 325);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(110, 41);
            btnConvertir.TabIndex = 8;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = false;
            btnConvertir.Click += BtnConvertir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sulley2;
            pictureBox1.Location = new Point(48, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(309, 319);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Conversion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(711, 409);
            Controls.Add(pictureBox1);
            Controls.Add(btnConvertir);
            Controls.Add(label4);
            Controls.Add(respuesta);
            Controls.Add(label3);
            Controls.Add(valor);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "Conversion";
            Text = "Conversion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private PictureBox pictureBox1;
    }
}