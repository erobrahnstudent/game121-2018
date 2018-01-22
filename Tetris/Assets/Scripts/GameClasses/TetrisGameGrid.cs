using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.GameClasses
{
    public class TetrisGameGrid
    {
        public Block[,] gridSpaces;
        public int Width;
        public int Height;

        private void Init()
        {
            gridSpaces = new Block[Width, Height];
        }

        // constructor
        public TetrisGameGrid(int desiredWidth, int desiredHeight)
        {
            this.Width = desiredWidth;
            this.Height = desiredHeight;
            Init();
        }
    }
}
