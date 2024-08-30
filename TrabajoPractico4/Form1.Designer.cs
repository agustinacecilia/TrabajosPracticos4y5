namespace TrabajosPracticos4y5
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LDesde = new System.Windows.Forms.Label();
            this.LHasta = new System.Windows.Forms.Label();
            this.textBoxDesde = new System.Windows.Forms.TextBox();
            this.textBoxHasta = new System.Windows.Forms.TextBox();
            this.BGFuncion = new System.Windows.Forms.Button();
            this.LListanumeros = new System.Windows.Forms.Label();
            this.listBoxNumeros = new System.Windows.Forms.ListBox();
            this.BNumerosPares = new System.Windows.Forms.Button();
            this.BNumerosImpares = new System.Windows.Forms.Button();
            this.BNumerosPrimos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BLimpiar = new System.Windows.Forms.Button();
            this.BSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // LDesde
            // 
            this.LDesde.AutoSize = true;
            this.LDesde.Location = new System.Drawing.Point(15, 65);
            this.LDesde.Name = "LDesde";
            this.LDesde.Size = new System.Drawing.Size(38, 13);
            this.LDesde.TabIndex = 0;
            this.LDesde.Text = "Desde";
            // 
            // LHasta
            // 
            this.LHasta.AutoSize = true;
            this.LHasta.Location = new System.Drawing.Point(15, 130);
            this.LHasta.Name = "LHasta";
            this.LHasta.Size = new System.Drawing.Size(35, 13);
            this.LHasta.TabIndex = 1;
            this.LHasta.Text = "Hasta";
            // 
            // textBoxDesde
            // 
            this.textBoxDesde.Location = new System.Drawing.Point(53, 63);
            this.textBoxDesde.Name = "textBoxDesde";
            this.textBoxDesde.Size = new System.Drawing.Size(100, 20);
            this.textBoxDesde.TabIndex = 2;
            // 
            // textBoxHasta
            // 
            this.textBoxHasta.Location = new System.Drawing.Point(53, 127);
            this.textBoxHasta.Name = "textBoxHasta";
            this.textBoxHasta.Size = new System.Drawing.Size(100, 20);
            this.textBoxHasta.TabIndex = 3;
            // 
            // BGFuncion
            // 
            this.BGFuncion.Location = new System.Drawing.Point(53, 181);
            this.BGFuncion.Name = "BGFuncion";
            this.BGFuncion.Size = new System.Drawing.Size(114, 24);
            this.BGFuncion.TabIndex = 4;
            this.BGFuncion.Text = "Generar Funcion";
            this.BGFuncion.UseVisualStyleBackColor = true;
            this.BGFuncion.Click += new System.EventHandler(this.BGFuncion_Click);
            // 
            // LListanumeros
            // 
            this.LListanumeros.AutoSize = true;
            this.LListanumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LListanumeros.Location = new System.Drawing.Point(175, 11);
            this.LListanumeros.Name = "LListanumeros";
            this.LListanumeros.Size = new System.Drawing.Size(305, 39);
            this.LListanumeros.TabIndex = 5;
            this.LListanumeros.Text = "Lista de Numeros";
            // 
            // listBoxNumeros
            // 
            this.listBoxNumeros.FormattingEnabled = true;
            this.listBoxNumeros.Location = new System.Drawing.Point(173, 62);
            this.listBoxNumeros.Name = "listBoxNumeros";
            this.listBoxNumeros.Size = new System.Drawing.Size(186, 316);
            this.listBoxNumeros.TabIndex = 6;
            this.listBoxNumeros.SelectedIndexChanged += new System.EventHandler(this.listBoxNumeros_SelectedIndexChanged);
            // 
            // BNumerosPares
            // 
            this.BNumerosPares.Location = new System.Drawing.Point(53, 222);
            this.BNumerosPares.Name = "BNumerosPares";
            this.BNumerosPares.Size = new System.Drawing.Size(114, 23);
            this.BNumerosPares.TabIndex = 7;
            this.BNumerosPares.Text = "Numeros Pares";
            this.BNumerosPares.UseVisualStyleBackColor = true;
            this.BNumerosPares.Click += new System.EventHandler(this.BNumerosPares_Click);
            // 
            // BNumerosImpares
            // 
            this.BNumerosImpares.Location = new System.Drawing.Point(53, 261);
            this.BNumerosImpares.Name = "BNumerosImpares";
            this.BNumerosImpares.Size = new System.Drawing.Size(114, 23);
            this.BNumerosImpares.TabIndex = 8;
            this.BNumerosImpares.Text = "Numeros Impares";
            this.BNumerosImpares.UseVisualStyleBackColor = true;
            this.BNumerosImpares.Click += new System.EventHandler(this.BNumerosImpares_Click);
            // 
            // BNumerosPrimos
            // 
            this.BNumerosPrimos.Location = new System.Drawing.Point(53, 301);
            this.BNumerosPrimos.Name = "BNumerosPrimos";
            this.BNumerosPrimos.Size = new System.Drawing.Size(114, 23);
            this.BNumerosPrimos.TabIndex = 9;
            this.BNumerosPrimos.Text = "Numeros Primos";
            this.BNumerosPrimos.UseVisualStyleBackColor = true;
            this.BNumerosPrimos.Click += new System.EventHandler(this.BNumerosPrimos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.BNumerosPrimos);
            this.panel1.Controls.Add(this.LListanumeros);
            this.panel1.Controls.Add(this.listBoxNumeros);
            this.panel1.Controls.Add(this.BNumerosPares);
            this.panel1.Controls.Add(this.BNumerosImpares);
            this.panel1.Controls.Add(this.textBoxHasta);
            this.panel1.Controls.Add(this.BGFuncion);
            this.panel1.Controls.Add(this.textBoxDesde);
            this.panel1.Controls.Add(this.LDesde);
            this.panel1.Controls.Add(this.LHasta);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(12, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 395);
            this.panel1.TabIndex = 10;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(391, 62);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(369, 315);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // BLimpiar
            // 
            this.BLimpiar.Location = new System.Drawing.Point(175, 441);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(132, 43);
            this.BLimpiar.TabIndex = 11;
            this.BLimpiar.Text = "Limpiar";
            this.BLimpiar.UseVisualStyleBackColor = true;
            this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click);
            // 
            // BSalir
            // 
            this.BSalir.Location = new System.Drawing.Point(473, 441);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(132, 43);
            this.BSalir.TabIndex = 12;
            this.BSalir.Text = "Salir";
            this.BSalir.UseVisualStyleBackColor = true;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.BLimpiar);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Formulario4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LDesde;
        private System.Windows.Forms.Label LHasta;
        private System.Windows.Forms.TextBox textBoxDesde;
        private System.Windows.Forms.TextBox textBoxHasta;
        private System.Windows.Forms.Button BGFuncion;
        private System.Windows.Forms.Label LListanumeros;
        private System.Windows.Forms.ListBox listBoxNumeros;
        private System.Windows.Forms.Button BNumerosPares;
        private System.Windows.Forms.Button BNumerosImpares;
        private System.Windows.Forms.Button BNumerosPrimos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button BLimpiar;
        private System.Windows.Forms.Button BSalir;
    }
}

