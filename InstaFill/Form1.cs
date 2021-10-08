using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaFill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void open_Click(object sender, EventArgs e)
        {
            string rutaArchivo = string.Empty; //cadena vacia

            OpenFileDialog ofd = new OpenFileDialog(); //instancia de OpenFileDialog
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }

        }


        // Ordenar el código: CTRL K + CTRL D


        private void saveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog(); //instancia de SaveFileDialog
            sfd.Filter = "PNG Files|*.png";
            sfd.FileName = "InstaFill.png";

            Bitmap bm = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height); //Mapa de bits
            pictureBox1.DrawToBitmap(bm, pictureBox1.ClientRectangle); //capturo la imagen

            if (sfd.ShowDialog(this) == DialogResult.OK)
            {
                bm.Save(sfd.FileName);
                MessageBox.Show("Guardado ✓");
            }
        }

    }
}