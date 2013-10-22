using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace ImageEffectswithGUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ladenToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Stream loadstream;
           if (openFileDialog1.ShowDialog() == DialogResult.OK) 
           {
               if ((loadstream=openFileDialog1.OpenFile())!= null) 
               {
                  DirectImage.Image = new Bitmap(loadstream);
               }
           }
        }

        private void ButtonGreyscale_Click(object sender, EventArgs e)
        {
            Greyscale gs =new Greyscale(DirectImage.Image as Bitmap);
            DirectImage.Image = gs.startgreyscale();
        }
    }
}
