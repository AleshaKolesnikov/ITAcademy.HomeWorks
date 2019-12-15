using System;

namespace HW03.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // implicit conversion
            byte bNum1 = 10;
            int iNum1 = bNum1 + 15;
            ulong ulNum1 = 18;
            decimal decNum1 = ulNum1 + 45;
            short shNum1 = -23;
            long lNum1 = shNum1 * 44;

            // explicit cast
            double dNum1 = 77.87;
            float fNum1 = 47.77f / (float)dNum1;
            float fNum2 = 765;
            uint uiNum1 = (uint)(1000.22/fNum2);
            long lNum2 = -299;
            byte sbNum1 = (byte)lNum2;

            // boxing
            object obj1 = ulNum1;
            object obj2 = fNum2;
            object obj3 = decNum1;

            //unboxing
            ulong unBox1 = (ulong)obj1;
            float unBox2 = (float)obj2;
            decimal unBox3 = (decimal)obj3;
            Console.ReadKey();

        }
    }
}
