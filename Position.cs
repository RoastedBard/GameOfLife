﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeGraphics
{
    class Position
    {
        private int _x;
        private int _y;

        public Position()
        {
            _x = 0;
            _y = 0;
        }

        public Position(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
    }
}
