namespace Cotiizador_Villa_Coral
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
            lblHuesped = new Label();
            lblNoches = new Label();
            lblTarifa = new Label();
            lblTasa = new Label();
            txtHuesped = new TextBox();
            nudNoches = new NumericUpDown();
            nudTarifa = new NumericUpDown();
            nudTasa = new NumericUpDown();
            btnPesos = new Button();
            checkBox1 = new CheckBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            lblSubtotal = new Label();
            lblDescuento = new Label();
            lblITBIS = new Label();
            lblServicio = new Label();
            lblTotal = new Label();
            lbl_Descuento = new Label();
            lbl_Subtotal = new Label();
            lbl_Servicio = new Label();
            lbl_ITBIS = new Label();
            lbl_Total = new Label();
            gbCotizador = new GroupBox();
            gbTotales = new GroupBox();
            lstResultados = new ListBox();
            btnImperativo = new Button();
            BtnCopiar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudNoches).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTarifa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTasa).BeginInit();
            gbCotizador.SuspendLayout();
            gbTotales.SuspendLayout();
            SuspendLayout();
            // 
            // lblHuesped
            // 
            lblHuesped.AutoSize = true;
            lblHuesped.Location = new Point(35, 54);
            lblHuesped.Name = "lblHuesped";
            lblHuesped.Size = new Size(71, 20);
            lblHuesped.TabIndex = 0;
            lblHuesped.Text = "Huesped:";
            // 
            // lblNoches
            // 
            lblNoches.AutoSize = true;
            lblNoches.Location = new Point(35, 93);
            lblNoches.Name = "lblNoches";
            lblNoches.Size = new Size(61, 20);
            lblNoches.TabIndex = 1;
            lblNoches.Text = "Noches:";
            // 
            // lblTarifa
            // 
            lblTarifa.AutoSize = true;
            lblTarifa.Location = new Point(35, 128);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(159, 20);
            lblTarifa.TabIndex = 2;
            lblTarifa.Text = "Tarifa por noche (USD)";
            // 
            // lblTasa
            // 
            lblTasa.AutoSize = true;
            lblTasa.Location = new Point(35, 169);
            lblTasa.Name = "lblTasa";
            lblTasa.Size = new Size(104, 20);
            lblTasa.TabIndex = 3;
            lblTasa.Text = "Tasa del dolar:";
            // 
            // txtHuesped
            // 
            txtHuesped.ForeColor = SystemColors.WindowFrame;
            txtHuesped.Location = new Point(112, 51);
            txtHuesped.Name = "txtHuesped";
            txtHuesped.PlaceholderText = "Identifiquese";
            txtHuesped.Size = new Size(187, 27);
            txtHuesped.TabIndex = 4;
            txtHuesped.Tag = "";
            // 
            // nudNoches
            // 
            nudNoches.Location = new Point(102, 91);
            nudNoches.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            nudNoches.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNoches.Name = "nudNoches";
            nudNoches.Size = new Size(150, 27);
            nudNoches.TabIndex = 5;
            nudNoches.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudTarifa
            // 
            nudTarifa.DecimalPlaces = 2;
            nudTarifa.Location = new Point(200, 128);
            nudTarifa.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudTarifa.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudTarifa.Name = "nudTarifa";
            nudTarifa.Size = new Size(150, 27);
            nudTarifa.TabIndex = 6;
            nudTarifa.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudTasa
            // 
            nudTasa.DecimalPlaces = 2;
            nudTasa.Location = new Point(145, 167);
            nudTasa.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudTasa.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudTasa.Name = "nudTasa";
            nudTasa.Size = new Size(150, 27);
            nudTasa.TabIndex = 7;
            nudTasa.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnPesos
            // 
            btnPesos.Location = new Point(35, 210);
            btnPesos.Name = "btnPesos";
            btnPesos.Size = new Size(159, 29);
            btnPesos.TabIndex = 8;
            btnPesos.Text = "Total en RD$";
            btnPesos.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(35, 268);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(188, 24);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Temporada alta (+25%)";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(35, 327);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(104, 32);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(166, 327);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(104, 32);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(28, 58);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(65, 20);
            lblSubtotal.TabIndex = 12;
            lblSubtotal.Text = "Subtotal";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(26, 97);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(79, 20);
            lblDescuento.TabIndex = 13;
            lblDescuento.Text = "Descuento";
            // 
            // lblITBIS
            // 
            lblITBIS.AutoSize = true;
            lblITBIS.Location = new Point(28, 136);
            lblITBIS.Name = "lblITBIS";
            lblITBIS.Size = new Size(42, 20);
            lblITBIS.TabIndex = 14;
            lblITBIS.Text = "ITBIS";
            // 
            // lblServicio
            // 
            lblServicio.AutoSize = true;
            lblServicio.Location = new Point(28, 177);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(61, 20);
            lblServicio.TabIndex = 15;
            lblServicio.Text = "Servicio";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(227, 58);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 20);
            lblTotal.TabIndex = 16;
            lblTotal.Text = "Total";
            // 
            // lbl_Descuento
            // 
            lbl_Descuento.AutoSize = true;
            lbl_Descuento.Location = new Point(111, 97);
            lbl_Descuento.Name = "lbl_Descuento";
            lbl_Descuento.Size = new Size(17, 20);
            lbl_Descuento.TabIndex = 17;
            lbl_Descuento.Text = "0";
            // 
            // lbl_Subtotal
            // 
            lbl_Subtotal.AutoSize = true;
            lbl_Subtotal.Location = new Point(111, 58);
            lbl_Subtotal.Name = "lbl_Subtotal";
            lbl_Subtotal.Size = new Size(17, 20);
            lbl_Subtotal.TabIndex = 18;
            lbl_Subtotal.Text = "0";
            // 
            // lbl_Servicio
            // 
            lbl_Servicio.AutoSize = true;
            lbl_Servicio.Location = new Point(95, 177);
            lbl_Servicio.Name = "lbl_Servicio";
            lbl_Servicio.Size = new Size(17, 20);
            lbl_Servicio.TabIndex = 19;
            lbl_Servicio.Text = "0";
            // 
            // lbl_ITBIS
            // 
            lbl_ITBIS.AutoSize = true;
            lbl_ITBIS.Location = new Point(76, 136);
            lbl_ITBIS.Name = "lbl_ITBIS";
            lbl_ITBIS.Size = new Size(17, 20);
            lbl_ITBIS.TabIndex = 20;
            lbl_ITBIS.Text = "0";
            // 
            // lbl_Total
            // 
            lbl_Total.AutoSize = true;
            lbl_Total.Location = new Point(275, 58);
            lbl_Total.Name = "lbl_Total";
            lbl_Total.Size = new Size(17, 20);
            lbl_Total.TabIndex = 21;
            lbl_Total.Text = "0";
            // 
            // gbCotizador
            // 
            gbCotizador.Controls.Add(btnImperativo);
            gbCotizador.Controls.Add(BtnCopiar);
            gbCotizador.Controls.Add(lblHuesped);
            gbCotizador.Controls.Add(lblNoches);
            gbCotizador.Controls.Add(lblTarifa);
            gbCotizador.Controls.Add(lblTasa);
            gbCotizador.Controls.Add(txtHuesped);
            gbCotizador.Controls.Add(nudNoches);
            gbCotizador.Controls.Add(nudTarifa);
            gbCotizador.Controls.Add(nudTasa);
            gbCotizador.Controls.Add(btnPesos);
            gbCotizador.Controls.Add(checkBox1);
            gbCotizador.Controls.Add(btnCalcular);
            gbCotizador.Controls.Add(btnLimpiar);
            gbCotizador.Location = new Point(10, 12);
            gbCotizador.Name = "gbCotizador";
            gbCotizador.Size = new Size(554, 407);
            gbCotizador.TabIndex = 22;
            gbCotizador.TabStop = false;
            gbCotizador.Text = "Cotizador";
            // 
            // gbTotales
            // 
            gbTotales.Controls.Add(lblSubtotal);
            gbTotales.Controls.Add(lblDescuento);
            gbTotales.Controls.Add(lbl_Total);
            gbTotales.Controls.Add(lblITBIS);
            gbTotales.Controls.Add(lbl_ITBIS);
            gbTotales.Controls.Add(lblServicio);
            gbTotales.Controls.Add(lbl_Servicio);
            gbTotales.Controls.Add(lblTotal);
            gbTotales.Controls.Add(lbl_Subtotal);
            gbTotales.Controls.Add(lbl_Descuento);
            gbTotales.Location = new Point(10, 441);
            gbTotales.Name = "gbTotales";
            gbTotales.Size = new Size(354, 226);
            gbTotales.TabIndex = 23;
            gbTotales.TabStop = false;
            gbTotales.Text = "Totales";
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.Location = new Point(570, 29);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(615, 624);
            lstResultados.TabIndex = 24;
            // 
            // btnImperativo
            // 
            btnImperativo.Location = new Point(250, 369);
            btnImperativo.Name = "btnImperativo";
            btnImperativo.Size = new Size(104, 32);
            btnImperativo.TabIndex = 12;
            btnImperativo.Text = "Imperativo";
            btnImperativo.UseVisualStyleBackColor = true;
            btnImperativo.Click += btnImperativo_Click;
            // 
            // BtnCopiar
            // 
            BtnCopiar.Location = new Point(35, 369);
            BtnCopiar.Name = "BtnCopiar";
            BtnCopiar.Size = new Size(188, 32);
            BtnCopiar.TabIndex = 12;
            BtnCopiar.Text = "Copiar por Whatsapp";
            BtnCopiar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1308, 688);
            Controls.Add(lstResultados);
            Controls.Add(gbTotales);
            Controls.Add(gbCotizador);
            Name = "Form1";
            Text = "Cotizador Villa Coral - Kimberly Ashley, 2025-0505";
            Load += Kimberly_Load;
            ((System.ComponentModel.ISupportInitialize)nudNoches).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTarifa).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTasa).EndInit();
            gbCotizador.ResumeLayout(false);
            gbCotizador.PerformLayout();
            gbTotales.ResumeLayout(false);
            gbTotales.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblHuesped;
        private Label lblNoches;
        private Label lblTarifa;
        private Label lblTasa;
        private TextBox txtHuesped;
        private NumericUpDown nudNoches;
        private NumericUpDown nudTarifa;
        private NumericUpDown nudTasa;
        private Button btnPesos;
        private CheckBox checkBox1;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Label lblSubtotal;
        private Label lblDescuento;
        private Label lblITBIS;
        private Label lblServicio;
        private Label lblTotal;
        private Label lbl_Descuento;
        private Label lbl_Subtotal;
        private Label lbl_Servicio;
        private Label lbl_ITBIS;
        private Label lbl_Total;
        private GroupBox gbCotizador;
        private GroupBox gbTotales;
        private ListBox lstResultados;
        private Button btnImperativo;
        private Button BtnCopiar;
    }
}
