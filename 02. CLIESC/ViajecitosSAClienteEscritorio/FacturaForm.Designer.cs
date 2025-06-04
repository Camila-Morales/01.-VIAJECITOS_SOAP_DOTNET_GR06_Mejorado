namespace ViajecitosSAClienteEscritorio
{
    partial class FacturaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdFactura = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.txtOrigenDestino = new System.Windows.Forms.TextBox();
            this.txtHoraSalida = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.txtPrecioTotal = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID FACTURA";
            // 
            // txtIdFactura
            // 
            this.txtIdFactura.Location = new System.Drawing.Point(173, 32);
            this.txtIdFactura.Name = "txtIdFactura";
            this.txtIdFactura.Size = new System.Drawing.Size(177, 22);
            this.txtIdFactura.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(419, 29);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(131, 28);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nacionalidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Origen - Destino";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "HoraSalida";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Cantidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(260, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "PrecioUnitario";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(501, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "PrecioTotal";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 339);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Fecha emisión";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(135, 117);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(100, 22);
            this.txtUsuario.TabIndex = 12;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(437, 111);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.ReadOnly = true;
            this.txtEdad.Size = new System.Drawing.Size(100, 22);
            this.txtEdad.TabIndex = 13;
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(150, 154);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.ReadOnly = true;
            this.txtNacionalidad.Size = new System.Drawing.Size(100, 22);
            this.txtNacionalidad.TabIndex = 14;
            // 
            // txtOrigenDestino
            // 
            this.txtOrigenDestino.Location = new System.Drawing.Point(165, 196);
            this.txtOrigenDestino.Name = "txtOrigenDestino";
            this.txtOrigenDestino.ReadOnly = true;
            this.txtOrigenDestino.Size = new System.Drawing.Size(100, 22);
            this.txtOrigenDestino.TabIndex = 15;
            // 
            // txtHoraSalida
            // 
            this.txtHoraSalida.Location = new System.Drawing.Point(138, 242);
            this.txtHoraSalida.Name = "txtHoraSalida";
            this.txtHoraSalida.ReadOnly = true;
            this.txtHoraSalida.Size = new System.Drawing.Size(100, 22);
            this.txtHoraSalida.TabIndex = 16;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(123, 279);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 17;
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Location = new System.Drawing.Point(358, 285);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.ReadOnly = true;
            this.txtPrecioUnitario.Size = new System.Drawing.Size(100, 22);
            this.txtPrecioUnitario.TabIndex = 18;
            // 
            // txtPrecioTotal
            // 
            this.txtPrecioTotal.Location = new System.Drawing.Point(584, 286);
            this.txtPrecioTotal.Name = "txtPrecioTotal";
            this.txtPrecioTotal.ReadOnly = true;
            this.txtPrecioTotal.Size = new System.Drawing.Size(100, 22);
            this.txtPrecioTotal.TabIndex = 19;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(157, 339);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(100, 22);
            this.txtFecha.TabIndex = 20;
            // 
            // FacturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtPrecioTotal);
            this.Controls.Add(this.txtPrecioUnitario);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtHoraSalida);
            this.Controls.Add(this.txtOrigenDestino);
            this.Controls.Add(this.txtNacionalidad);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtIdFactura);
            this.Controls.Add(this.label1);
            this.Name = "FacturaForm";
            this.Text = "FacturaForm";
            this.Load += new System.EventHandler(this.FacturaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdFactura;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.TextBox txtOrigenDestino;
        private System.Windows.Forms.TextBox txtHoraSalida;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.TextBox txtPrecioTotal;
        private System.Windows.Forms.TextBox txtFecha;
    }
}