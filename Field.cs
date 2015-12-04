using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeGraphics
{
    class Field
    {
        private Cell[,] _field;
        private int      _size;

        public Field(int size)
        {
            _size = size+2;

            _field = new Cell[_size, _size];

            Random rnd = new Random();
            
            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                {   
                    _field[i,j] = new Cell(i, j);
                }
            }

            for (int i = 1; i < _size-1; i++)
            {
                for (int j = 1; j < _size-1; j++)
                {
                    int n = rnd.Next(2);

                    if (n == 1)
                    {
                        _field[i, j].IsAlive = true;
                        _field[i, j].Texture = Texture.ALIVE;
                    }
                }
            }
        }

        public Cell[,] getField()
        {
            return _field;
        }

        public int getSize()
        {
            return _size;
        }
    }
}
