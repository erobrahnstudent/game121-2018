using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.GameClasses
{
    public enum BlockColor
    {
        Null,
        Red,
        Orange,
        Yellow,
        Green,
        Blue,
        Indigo,
        White
    }
    public class Block
    {
        public BlockColor color;
        public int x;
        public int y;

        public Block(int Xpos, int Ypos)
        {
            this.x = Xpos;
            this.y = Ypos;
        }

        public Block(int Xpos, int Ypos, BlockColor desiredColor)
        {
            this.x = Xpos;
            this.y = Ypos;
            this.color = desiredColor;
        }
    }
}
