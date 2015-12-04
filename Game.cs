using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeGraphics
{
    class Game
    {
        private Field _field;

        public Game(int fieldSize)
        {
            _field = new Field(fieldSize);
        }

        public void Update()
        {
            Logic.generateNewGeneration(_field);
        }

        public Field getField()
        {
            return _field;
        }
    }
}
