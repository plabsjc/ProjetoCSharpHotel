namespace AppHotelForms
{
    partial class FormReserva
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
            this.lblNomeUsuarioBusca = new System.Windows.Forms.Label();
            this.lblEmailBusca = new System.Windows.Forms.Label();
            this.txtBuscaNomeCliente = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscarReserva = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeUsuarioBusca
            // 
            this.lblNomeUsuarioBusca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNomeUsuarioBusca.AutoSize = true;
            this.lblNomeUsuarioBusca.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeUsuarioBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuarioBusca.Location = new System.Drawing.Point(411, 92);
            this.lblNomeUsuarioBusca.Name = "lblNomeUsuarioBusca";
            this.lblNomeUsuarioBusca.Size = new System.Drawing.Size(157, 25);
            this.lblNomeUsuarioBusca.TabIndex = 1;
            this.lblNomeUsuarioBusca.Text = "Nome do Cliente";
            // 
            // lblEmailBusca
            // 
            this.lblEmailBusca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmailBusca.AutoSize = true;
            this.lblEmailBusca.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailBusca.Location = new System.Drawing.Point(458, 168);
            this.lblEmailBusca.Name = "lblEmailBusca";
            this.lblEmailBusca.Size = new System.Drawing.Size(60, 25);
            this.lblEmailBusca.TabIndex = 2;
            this.lblEmailBusca.Text = "Email";
            // 
            // txtBuscaNomeCliente
            // 
            this.txtBuscaNomeCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBuscaNomeCliente.BackColor = System.Drawing.Color.Aquamarine;
            this.txtBuscaNomeCliente.Location = new System.Drawing.Point(344, 120);
            this.txtBuscaNomeCliente.Name = "txtBuscaNomeCliente";
            this.txtBuscaNomeCliente.Size = new System.Drawing.Size(287, 22);
            this.txtBuscaNomeCliente.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.BackColor = System.Drawing.Color.Aquamarine;
            this.textBox1.Location = new System.Drawing.Point(344, 196);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 22);
            this.textBox1.TabIndex = 4;
            // 
            // btnBuscarReserva
            // 
            this.btnBuscarReserva.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarReserva.BackColor = System.Drawing.Color.Aquamarine;
            this.btnBuscarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarReserva.Location = new System.Drawing.Point(390, 256);
            this.btnBuscarReserva.Name = "btnBuscarReserva";
            this.btnBuscarReserva.Size = new System.Drawing.Size(208, 42);
            this.btnBuscarReserva.TabIndex = 5;
            this.btnBuscarReserva.Text = "Buscar Reserva";
            this.btnBuscarReserva.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 355);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(863, 273);
            this.dataGridView1.TabIndex = 6;
            // 
            // FormReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::AppHotelForms.Properties.Resources._6122609;
            this.ClientSize = new System.Drawing.Size(986, 673);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscarReserva);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtBuscaNomeCliente);
            this.Controls.Add(this.lblEmailBusca);
            this.Controls.Add(this.lblNomeUsuarioBusca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReserva";
            this.Text = "FormReserva";
            this.Load += new System.EventHandler(this.FormReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNomeUsuarioBusca;
        private System.Windows.Forms.Label lblEmailBusca;
        private System.Windows.Forms.TextBox txtBuscaNomeCliente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuscarReserva;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}