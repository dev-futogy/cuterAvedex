using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace HighlighterDll.Highlighter
{
    
    /// <summary>
    /// Picture box engine.
    /// </summary>
    public class ControlHigh : IDisposable
    {
        public ControlHigh(PictureBox picture)
        {
            Picture = picture;
            _height = picture.Height;
            _width = picture.Width;
        }

        private int _height;

        private int _width;

        public PictureBox Picture { get; set; }

        public Bitmap Layout;

        /// <summary>
        /// Load image in memory computer.
        /// </summary>
        public void LoadImage(Bitmap image) {
            Picture.Image = BitmapConverter(image);
            Layout = BitmapConverter(image);
        }

        public void RepairImage() {
            Picture.Image = Layout;
        }

        public Bitmap BitmapConverter(Bitmap original) => new Bitmap(original, _width, _height);

        public void Dispose()
        {
            Picture.Dispose();
            Layout.Dispose();
        }
    }
}
