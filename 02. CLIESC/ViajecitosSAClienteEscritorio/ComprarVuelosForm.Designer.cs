namespace ViajecitosSAClienteEscritorio
{
    partial class ComprarVuelosForm
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
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gridVuelos = new System.Windows.Forms.DataGridView();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(80, 90);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(149, 22);
            this.txtOrigen.TabIndex = 0;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(288, 91);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(171, 22);
            this.txtDestino.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(513, 85);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(128, 35);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gridVuelos
            // 
            this.gridVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVuelos.Location = new System.Drawing.Point(35, 191);
            this.gridVuelos.Name = "gridVuelos";
            this.gridVuelos.RowHeadersWidth = 51;
            this.gridVuelos.RowTemplate.Height = 24;
            this.gridVuelos.Size = new System.Drawing.Size(704, 167);
            this.gridVuelos.TabIndex = 3;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(210, 144);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 16);
            this.lblMensaje.TabIndex = 4;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(285, 383);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(174, 46);
            this.btnComprar.TabIndex = 5;
            this.btnComprar.Text = "COMPRAR";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "ORIGEN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "DESTINO";
            // 
            // ComprarVuelosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.gridVuelos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtOrigen);
            this.Name = "ComprarVuelosForm";
            this.Text = "ComprarVuelosForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridVuelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView gridVuelos;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}