﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _2_OpenClosePrinciple.Post_Principle.Shapes.Pre_Principle
{
    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        /// <summary>
        /// we can ommit the this keyword in front of the Width/Height properties as its infered by the property names on the object
        /// </summary>
        /// <returns></returns>
        public double CalculateArea() {
            return Width * Height;
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
