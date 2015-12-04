using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace LifeGraphics
{
    class GDIRenderer : Renderer
    {
        private Bitmap     _bitmap;
        private Graphics   _graphics;
        private PictureBox _pictureBox;
        private Pen        _pen;
        private float      _offset;

        public GDIRenderer(PictureBox pictureBox, float offset)
        {
            _pictureBox = pictureBox;
            _offset = offset;
            _initialize();
        }

        private void _initialize()
        {
            _bitmap = new Bitmap(_pictureBox.Height, _pictureBox.Width);
            _pictureBox.Image = _bitmap;
            _graphics = Graphics.FromImage(_pictureBox.Image);
            _pen = new Pen(Color.Red, _offset);
        }

        public void Draw(Field field)
        {
            for (int i = 0; i < field.getSize(); i++)
            {
                for (int j = 0; j < field.getSize(); j++)
                {
                    if (field.getField()[i, j].IsChanged == true)
                    {
                        switch (field.getField()[i, j].Texture)
                        {
                            case Texture.ALIVE:
                                _pen.Color = Color.Red;
                                _graphics.DrawRectangle(_pen, i * _offset, j * _offset, _offset, _offset);
                                break;

                            case Texture.DEAD:
                                _pen.Color = Color.Black;
                                _graphics.DrawRectangle(_pen, i * _offset, j * _offset, _offset, _offset);
                                break;
                        }
                    }
                }
            }
        }
    }
}
