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
using System.Drawing.Imaging;

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
           Stream loadStream;
           if (openFileDialog1.ShowDialog() == DialogResult.OK) 
           {
               if ((loadStream=openFileDialog1.OpenFile())!= null) 
               {
                  DirectImage.Image = new Bitmap(loadStream);
               }
           }
        }

        private void ButtonGreyscale_Click(object sender, EventArgs e)
        {
            Greyscale.startgreyscale(DirectImage.Image as Bitmap,(manipulatedimage)=>DirectImage.Image=manipulatedimage);
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* if (saveFileDialog1.ShowDialog == DialogResult.OK) 
            {
                
            }*/
        }
    }
}
