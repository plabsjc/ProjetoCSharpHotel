namespace AppHotelForms
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlSide = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlClients = new System.Windows.Forms.Panel();
            this.pnlReserva = new System.Windows.Forms.Panel();
            this.pnlQuartos = new System.Windows.Forms.Panel();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlBaixo = new System.Windows.Forms.Panel();
            this.btnQuartos = new System.Windows.Forms.Button();
            this.btnReserva = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlSide.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlClients.SuspendLayout();
            this.pnlReserva.SuspendLayout();
            this.pnlQuartos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.Transparent;
            this.pnlSide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSide.Controls.Add(this.pnlBaixo);
            this.pnlSide.Controls.Add(this.pnlQuartos);
            this.pnlSide.Controls.Add(this.pnlReserva);
            this.pnlSide.Controls.Add(this.pnlClients);
            this.pnlSide.Controls.Add(this.pnlLogo);
            this.pnlSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSide.Location = new System.Drawing.Point(0, 0);
            this.pnlSide.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(276, 673);
            this.pnlSide.TabIndex = 0;
            this.pnlSide.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSide_Paint);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(276, 165);
            this.pnlLogo.TabIndex = 0;
            this.pnlLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogo_Paint);
            // 
            // pnlClients
            // 
            this.pnlClients.BackColor = System.Drawing.Color.Transparent;
            this.pnlClients.Controls.Add(this.btnClient);
            this.pnlClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlClients.Location = new System.Drawing.Point(0, 165);
            this.pnlClients.Name = "pnlClients";
            this.pnlClients.Size = new System.Drawing.Size(276, 100);
            this.pnlClients.TabIndex = 1;
            // 
            // pnlReserva
            // 
            this.pnlReserva.Controls.Add(this.btnReserva);
            this.pnlReserva.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReserva.Location = new System.Drawing.Point(0, 265);
            this.pnlReserva.Name = "pnlReserva";
            this.pnlReserva.Size = new System.Drawing.Size(276, 100);
            this.pnlReserva.TabIndex = 2;
            // 
            // pnlQuartos
            // 
            this.pnlQuartos.Controls.Add(this.btnQuartos);
            this.pnlQuartos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuartos.Location = new System.Drawing.Point(0, 365);
            this.pnlQuartos.Name = "pnlQuartos";
            this.pnlQuartos.Size = new System.Drawing.Size(276, 100);
            this.pnlQuartos.TabIndex = 3;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.AutoSize = true;
            this.pnlPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.pnlPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(276, 0);
            this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(986, 673);
            this.pnlPrincipal.TabIndex = 1;
            this.pnlPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPrincipal_Paint);
            // 
            // pnlBaixo
            // 
            this.pnlBaixo.BackgroundImage = global::AppHotelForms.Properties.Resources.vivid_blurred_colorful_wallpaper_background;
            this.pnlBaixo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBaixo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBaixo.Location = new System.Drawing.Point(0, 465);
            this.pnlBaixo.Name = "pnlBaixo";
            this.pnlBaixo.Size = new System.Drawing.Size(276, 208);
            this.pnlBaixo.TabIndex = 4;
            // 
            // btnQuartos
            // 
            this.btnQuartos.BackgroundImage = global::AppHotelForms.Properties.Resources.vivid_blurred_colorful_wallpaper_background;
            this.btnQuartos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuartos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuartos.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnQuartos.FlatAppearance.BorderSize = 3;
            this.btnQuartos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnQuartos.Location = new System.Drawing.Point(0, 0);
            this.btnQuartos.Name = "btnQuartos";
            this.btnQuartos.Size = new System.Drawing.Size(276, 100);
            this.btnQuartos.TabIndex = 0;
            this.btnQuartos.Text = "Quartos";
            this.btnQuartos.UseVisualStyleBackColor = true;
            this.btnQuartos.Click += new System.EventHandler(this.btnQuartos_Click);
            // 
            // btnReserva
            // 
            this.btnReserva.BackgroundImage = global::AppHotelForms.Properties.Resources.vivid_blurred_colorful_wallpaper_background;
            this.btnReserva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReserva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReserva.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnReserva.FlatAppearance.BorderSize = 3;
            this.btnReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReserva.Location = new System.Drawing.Point(0, 0);
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Size = new System.Drawing.Size(276, 100);
            this.btnReserva.TabIndex = 0;
            this.btnReserva.Text = "Reserva";
            this.btnReserva.UseVisualStyleBackColor = true;
            this.btnReserva.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // btnClient
            // 
            this.btnClient.BackgroundImage = global::AppHotelForms.Properties.Resources.vivid_blurred_colorful_wallpaper_background;
            this.btnClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClient.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnClient.FlatAppearance.BorderSize = 3;
            this.btnClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.Location = new System.Drawing.Point(0, 0);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(276, 100);
            this.btnClient.TabIndex = 0;
            this.btnClient.Text = "Cliente";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App Hotel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlSide.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlClients.ResumeLayout(false);
            this.pnlReserva.ResumeLayout(false);
            this.pnlQuartos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlClients;
        private System.Windows.Forms.Panel pnlQuartos;
        private System.Windows.Forms.Button btnQuartos;
        private System.Windows.Forms.Panel pnlReserva;
        private System.Windows.Forms.Button btnReserva;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Panel pnlBaixo;
    }
}

