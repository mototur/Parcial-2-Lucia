namespace Prestamo
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
            Monto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Interes = new TextBox();
            Periodo = new TextBox();
            label4 = new Label();
            Calcular = new Button();
            Salir = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // Monto
            // 
            Monto.BackColor = Color.RosyBrown;
            Monto.Location = new Point(319, 103);
            Monto.Name = "Monto";
            Monto.Size = new Size(114, 23);
            Monto.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(260, 28);
            label1.Name = "label1";
            label1.Size = new Size(249, 32);
            label1.TabIndex = 1;
            label1.Text = "Prestamo Adquirido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(307, 80);
            label2.Name = "label2";
            label2.Size = new Size(162, 20);
            label2.TabIndex = 2;
            label2.Text = "Monto del Prestamo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(353, 139);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 3;
            label3.Text = "lnteres";
            // 
            // Interes
            // 
            Interes.BackColor = SystemColors.WindowFrame;
            Interes.Location = new Point(287, 163);
            Interes.Name = "Interes";
            Interes.Size = new Size(182, 23);
            Interes.TabIndex = 4;
            // 
            // Periodo
            // 
            Periodo.BackColor = Color.MistyRose;
            Periodo.Location = new Point(317, 235);
            Periodo.Name = "Periodo";
            Periodo.Size = new Size(116, 23);
            Periodo.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(307, 217);
            label4.Name = "label4";
            label4.Size = new Size(128, 15);
            label4.TabIndex = 6;
            label4.Text = "Cantidad de meses ";
            // 
            // Calcular
            // 
            Calcular.BackColor = Color.Indigo;
            Calcular.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Calcular.Location = new Point(210, 291);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(71, 29);
            Calcular.TabIndex = 7;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = false;
            Calcular.Click += Calcular_Click;
            // 
            // Salir
            // 
            Salir.BackColor = Color.Red;
            Salir.Location = new Point(576, 291);
            Salir.Name = "Salir";
            Salir.Size = new Size(53, 29);
            Salir.TabIndex = 9;
            Salir.Text = "Salir";
            Salir.UseVisualStyleBackColor = false;
            Salir.Click += Salir_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(105, 299);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 10;
            label5.Text = "Total a pagar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrchid;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(Salir);
            Controls.Add(Calcular);
            Controls.Add(label4);
            Controls.Add(Periodo);
            Controls.Add(Interes);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Monto);
            Name = "Form1";
            Text = "Calcuradora de Prestamos";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Monto;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Interes;
        private TextBox Periodo;
        private Label label4;
        private Button Calcular;
        private Button Salir;
        private Label label5;
    }
}
