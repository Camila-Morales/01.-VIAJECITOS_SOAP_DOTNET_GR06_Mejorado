namespace ViajecitosSAClienteEscritorio
{
    partial class BuscarVuelosForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(119, 92);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(129, 22);
            this.txtOrigen.TabIndex = 0;
            this.txtOrigen.TextChanged += new System.EventHandler(this.txtOrigen_TextChanged);
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(323, 92);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(131, 22);
            this.txtDestino.TabIndex = 1;
            this.txtDestino.TextChanged += new System.EventHandler(this.txtDestino_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(518, 89);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(97, 28);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "button1";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gridVuelos
            // 
            this.gridVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVuelos.Location = new System.Drawing.Point(33, 209);
            this.gridVuelos.Name = "gridVuelos";
            this.gridVuelos.RowHeadersWidth = 51;
            this.gridVuelos.RowTemplate.Height = 24;
            this.gridVuelos.Size = new System.Drawing.Size(667, 122);
            this.gridVuelos.TabIndex = 3;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(191, 157);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 16);
            this.lblMensaje.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "ORIGEN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "DESTINO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.gridVuelos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtOrigen);
            this.Name = "buscar";
            this.Text = "Buscar";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}