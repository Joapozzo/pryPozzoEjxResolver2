namespace pryPozzoEjxResolver2
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
            this.lblDias = new System.Windows.Forms.Label();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.mrcCosto = new System.Windows.Forms.GroupBox();
            this.lblTotalMostrar = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPrecioMostrar = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.numDias = new System.Windows.Forms.NumericUpDown();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.mrcCosto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(16, 43);
            this.lblDias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(35, 16);
            this.lblDias.TabIndex = 0;
            this.lblDias.Text = "Dias";
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Location = new System.Drawing.Point(16, 92);
            this.lblDistancia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(63, 16);
            this.lblDistancia.TabIndex = 1;
            this.lblDistancia.Text = "Distancia";
            // 
            // mrcCosto
            // 
            this.mrcCosto.Controls.Add(this.lblTotalMostrar);
            this.mrcCosto.Controls.Add(this.lblTotal);
            this.mrcCosto.Controls.Add(this.lblPrecioMostrar);
            this.mrcCosto.Controls.Add(this.lblPrecio);
            this.mrcCosto.Location = new System.Drawing.Point(20, 146);
            this.mrcCosto.Margin = new System.Windows.Forms.Padding(4);
            this.mrcCosto.Name = "mrcCosto";
            this.mrcCosto.Padding = new System.Windows.Forms.Padding(4);
            this.mrcCosto.Size = new System.Drawing.Size(333, 123);
            this.mrcCosto.TabIndex = 2;
            this.mrcCosto.TabStop = false;
            this.mrcCosto.Text = "Costo";
            this.mrcCosto.Enter += new System.EventHandler(this.mrcCosto_Enter);
            // 
            // lblTotalMostrar
            // 
            this.lblTotalMostrar.AutoSize = true;
            this.lblTotalMostrar.Location = new System.Drawing.Point(103, 76);
            this.lblTotalMostrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalMostrar.Name = "lblTotalMostrar";
            this.lblTotalMostrar.Size = new System.Drawing.Size(14, 16);
            this.lblTotalMostrar.TabIndex = 3;
            this.lblTotalMostrar.Text = "$";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(8, 76);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(38, 16);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total";
            // 
            // lblPrecioMostrar
            // 
            this.lblPrecioMostrar.AutoSize = true;
            this.lblPrecioMostrar.Location = new System.Drawing.Point(103, 33);
            this.lblPrecioMostrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioMostrar.Name = "lblPrecioMostrar";
            this.lblPrecioMostrar.Size = new System.Drawing.Size(14, 16);
            this.lblPrecioMostrar.TabIndex = 1;
            this.lblPrecioMostrar.Text = "$";
            this.lblPrecioMostrar.TextChanged += new System.EventHandler(this.lblPrecioMostrar_TextChanged);
            this.lblPrecioMostrar.Click += new System.EventHandler(this.lblPrecioMostrar_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(8, 33);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 16);
            this.lblPrecio.TabIndex = 0;
            this.lblPrecio.Text = "Precio";
            // 
            // numDias
            // 
            this.numDias.Location = new System.Drawing.Point(212, 43);
            this.numDias.Margin = new System.Windows.Forms.Padding(4);
            this.numDias.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numDias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDias.Name = "numDias";
            this.numDias.Size = new System.Drawing.Size(133, 22);
            this.numDias.TabIndex = 3;
            this.numDias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(212, 92);
            this.txtDistancia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(132, 22);
            this.txtDistancia.TabIndex = 4;
            this.txtDistancia.TextChanged += new System.EventHandler(this.txtDistancia_TextChanged);
            this.txtDistancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDistancia_KeyPress);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(278, 294);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 329);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.numDias);
            this.Controls.Add(this.mrcCosto);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.lblDias);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mrcCosto.ResumeLayout(false);
            this.mrcCosto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.GroupBox mrcCosto;
        private System.Windows.Forms.Label lblTotalMostrar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPrecioMostrar;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.NumericUpDown numDias;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.Button btnCalcular;
    }
}

