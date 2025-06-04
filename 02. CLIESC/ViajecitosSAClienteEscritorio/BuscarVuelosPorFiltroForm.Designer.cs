namespace ViajecitosSAClienteEscritorio
{
    partial class BuscarVuelosPorFiltroForm
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
            this.comboFiltro = new System.Windows.Forms.ComboBox();
            this.txtValorFiltro = new System.Windows.Forms.TextBox();
            this.btnBuscar_Click = new System.Windows.Forms.Button();
            this.gridVuelos = new System.Windows.Forms.DataGridView();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // comboFiltro
            // 
            this.comboFiltro.FormattingEnabled = true;
            this.comboFiltro.Location = new System.Drawing.Point(173, 67);
            this.comboFiltro.Name = "comboFiltro";
            this.comboFiltro.Size = new System.Drawing.Size(179, 24);
            this.comboFiltro.TabIndex = 0;
            // 
            // txtValorFiltro
            // 
            this.txtValorFiltro.Location = new System.Drawing.Point(523, 69);
            this.txtValorFiltro.Name = "txtValorFiltro";
            this.txtValorFiltro.Size = new System.Drawing.Size(167, 22);
            this.txtValorFiltro.TabIndex = 1;
            // 
            // btnBuscar_Click
            // 
            this.btnBuscar_Click.Location = new System.Drawing.Point(304, 121);
            this.btnBuscar_Click.Name = "btnBuscar_Click";
            this.btnBuscar_Click.Size = new System.Drawing.Size(177, 39);
            this.btnBuscar_Click.TabIndex = 2;
            this.btnBuscar_Click.Text = "BUSCAR";
            this.btnBuscar_Click.UseVisualStyleBackColor = true;
            this.btnBuscar_Click.Click += new System.EventHandler(this.btnBuscar_Click_Click);
            // 
            // gridVuelos
            // 
            this.gridVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVuelos.Location = new System.Drawing.Point(91, 195);
            this.gridVuelos.Name = "gridVuelos";
            this.gridVuelos.RowHeadersWidth = 51;
            this.gridVuelos.RowTemplate.Height = 24;
            this.gridVuelos.Size = new System.Drawing.Size(661, 113);
            this.gridVuelos.TabIndex = 3;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(110, 357);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 16);
            this.lblMensaje.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "TIPO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "VALOR";
            // 
            // BuscarVuelosPorFiltroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.gridVuelos);
            this.Controls.Add(this.btnBuscar_Click);
            this.Controls.Add(this.txtValorFiltro);
            this.Controls.Add(this.comboFiltro);
            this.Name = "BuscarVuelosPorFiltroForm";
            this.Text = "BuscarVuelosPorFiltroForm";
            this.Load += new System.EventHandler(this.BuscarVuelosPorFiltroForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridVuelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboFiltro;
        private System.Windows.Forms.TextBox txtValorFiltro;
        private System.Windows.Forms.Button btnBuscar_Click;
        private System.Windows.Forms.DataGridView gridVuelos;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}