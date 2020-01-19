using System;
using System.Collections.Generic;
using System.Text;

namespace HW._10.CodeWars
{
    //Link - https://www.codewars.com/kata/55b75fcf67e558d3750000a3
    
    //Write a class Block that creates a block (Duh..) 
    //The constructor should take an array as an argument, this will contain 
    //  3 integers of the form [width, length, height] from which the Block should be created.

    class Block
    {
        public int Width { get; set; } 
        public int Length { get; set; } 
        public int Height { get; set; } 

        public Block(int[] array)
        {
            Width = array[0];
            Length = array[1];
            Height = array[2];
        }
        public int GetWidth()
        {
            return Width;
        }
        public int GetLength()
        {
            return Length;
        }
        public int GetHeight()
        {
            return Height;
        }
        public int GetVolume()
        {
            return Width * Length * Height;
        }
        public int GetSurfaceArea()
        {
            return 2*(Width * Length + Length * Height + Height * Width);
        }
    }
}
