﻿using System;

namespace PolymorphismInter
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            //base.Draw();
            Console.WriteLine("Draw a Circle");
        }
    }
}
