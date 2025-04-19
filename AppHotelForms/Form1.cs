using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace AppHotelForms
{
    public partial class Form1 : Form
    {
        private Form frmAtivo;
        public Form1()
        {
            var screenWidth = Screen.PrimaryScreen.Bounds.Width;
            var screenHeight = Screen.PrimaryScreen.Bounds.Height;
            this.Width = (int)(screenWidth * 0.8);
            this.Height = (int)(screenHeight * 0.8);
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
        }

        private void pnlPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pnlSide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            FormShow(new FormCliente());
        }

        private void FormShow(Form frm) 
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            pnlPrincipal.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void ActiveFormClose()
        {
            if(frmAtivo != null)
            {
                frmAtivo.Close();
            }
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            FormShow(new FormReserva());
        }

        private void btnQuartos_Click(object sender, EventArgs e)
        {
            FormShow(new FormQuartos());
        }
    }
}
