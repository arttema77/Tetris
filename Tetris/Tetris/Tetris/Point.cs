﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
     public class Point
    {
       public int x;
       public int y;
       public char c;

        public Point(int a, int b, char sym)
        {
            x = a;
            y = b;
            c= sym;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
    }
}
