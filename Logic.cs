using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeGraphics
{
    static class Logic
    {
        private static void checkForNeighbours(Field field, Cell cell)
        {
            cell.Neighbours = 0;

            for (int i = cell.Position.X - 1; i <= cell.Position.X + 1; i++)
            {
                for (int j = cell.Position.Y - 1; j <= cell.Position.Y + 1; j++)
                {
                    if (field.getField()[i, j].IsAlive == true)
                    {
                        cell.Neighbours++;
                    }
                }
            }

            if (cell.IsAlive == true)
                cell.Neighbours--;

            setFlag(cell);
        }

        private static void setFlag(Cell cell)
        {
            if (cell.IsAlive == false && cell.Neighbours == 3)
            {
                cell.FlagAlive = true;
                return;
            }

            if (cell.IsAlive == true)
            {
                if (cell.Neighbours > 3 || cell.Neighbours < 2)
                {
                    cell.FlagAlive = false;
                    return;
                }

                if (cell.Neighbours == 2 || cell.Neighbours == 3)
                {
                    cell.FlagAlive = true;
                    return;
                }
            }
        }

        private static void setAliveOrDead(Cell cell)
        {
            if (cell.FlagAlive == false)
            {
                cell.IsAlive = false;
                cell.Texture = Texture.DEAD;
            }
            else if (cell.FlagAlive == true)
            {
                cell.IsAlive = true;
                cell.Texture = Texture.ALIVE;
            }
        }

        public static void generateNewGeneration(Field field)
        {
            for (int i = 1; i < field.getSize() - 1; i++)
                for (int j = 1; j < field.getSize() - 1; j++)
                {
                    checkForNeighbours(field, field.getField()[i, j]);
                    //setAliveOrDead(field.getField()[i, j]);
                }

            for (int i = 1; i < field.getSize() - 1; i++)
                for (int j = 1; j < field.getSize() - 1; j++)
                    setAliveOrDead(field.getField()[i, j]);
        }
    }
}
