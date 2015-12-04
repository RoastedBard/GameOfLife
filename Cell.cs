using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeGraphics
{
    class Cell
    {
        private bool     _isAlive;
        private bool     _flagAlive;
        private Texture  _texture;
        private Position _position;
        private int      _neighbours;

        private byte     _changedParams;

        public Cell(int x, int y)
        {
            _isAlive = false;
            _position = new Position(x, y);
            _texture = Texture.DEAD;
            _changedParams = 0;
        }

        public Cell(int x, int y, Texture texture)
        {
            _position.X = x;
            _position.Y = y;

            _texture = texture;
        }

        public Position Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public bool IsAlive
        {
            get { return _isAlive; }
            set 
            {
                if (value != _isAlive)
                {
                    _isAlive = value;
                    _changedParams += 1;
                }
            }
        }

        public bool FlagAlive
        {
            get { return _flagAlive; }
            set 
            {
                if (value != _flagAlive)
                {
                    _flagAlive = value;
                    _changedParams += 1;
                }
            }
        }

        public Texture Texture
        {
            get { return _texture; }
            set 
            {
                if (value != _texture)
                {
                    _texture = value;
                    _changedParams += 1;
                }
            }
        }

        public int Neighbours
        {
            get { return _neighbours; }
            set 
            {
                if (value != _neighbours)
                {
                    _neighbours = value;
                    _changedParams += 1;
                }
            }
        }

        public bool IsChanged
        {
            get 
            {
                if (_changedParams > 0)
                {
                    _changedParams = 0;
                    return true;
                }
                else
                {
                    _changedParams = 0;
                    return false;
                }
            }
        }
    }
}
