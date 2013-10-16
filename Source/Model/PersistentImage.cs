using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace ImageEffects.Model
{
    class PersistentImage
    {
        private string path;
        private Bitmap bitmap;


        private FileStream imagestream;
        /// <summary>
        /// Initalisize a Image from a HDD 
        /// </summary>
        /// <param name="path">Filepath for the selected Image</param>
        public PersistentImage(string path) 
        {
            this.path = path;
        }
        #region Properties
        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        public Bitmap Bitmap
        {
            get { return bitmap; }
            set { bitmap = value; }
        }
        #endregion

        public void save(string newpath) 
        {
            bitmap.Save(newpath);
        }

        public Bitmap load() 
        {
            bitmap = new Bitmap(path);
          return bitmap;
        }


    }
}
