using System;

namespace HW03.Task2
{
    class Program
    {
        
        static void Main(string[] args)
        {
                 
            sbyte sbNum1 = -127;
            System.SByte sbNum2 = 127;
            byte bNum1 = 0;
            System.Byte bNum2 = 255;
            short shNum1 = -32_768;
            System.Int16 shNum2 = 32_767;
            ushort ushNum1 = 0;
            System.UInt16 ushNum2 = 65535;
            int iNum1 = -2_147_483_648;
            System.Int32 iNum2 = 2_147_483_647;
            uint uiNum1 = 0;
            System.UInt32 uiNum2 = 4_294_967_295;
            long lNum1 = -9_223_372_036_854_775_808;
            System.Int64 lNum2 = 9_223_372_036_854_775_807;
            ulong ulNum1 = 0;
            System.UInt64 ulNum2 = 18_446_744_073_709_551_615;
            char unicode1 = 'a';
            System.Char unicode2 = 'A';
            float fNum1 = -3.14f;
            System.Single fNum2 = 3.14f;
            double dNum1 = -6.18;
            System.Double dNum2 = 6.28;
            decimal decNum1 = -0.00000000001M;
            System.Decimal decNum2 = 0.00000000001M;
            object obj1 = "QWERTY";
            System.Object obj2 = 123456;
            string str1 = "Ky";
            System.String str2 = "Posani";

            object[] array = new object[28] { sbNum1, sbNum2, bNum1, bNum2, shNum1, shNum2, ushNum1, ushNum2, iNum1, iNum2, uiNum1, uiNum2, lNum1, lNum2, ulNum1, ulNum2, unicode1, unicode2, fNum1, fNum2, dNum1, dNum2, decNum1, decNum2, obj1, obj2, str1, str2  };
                                   
            foreach (object types in array)             
            {
                Console.WriteLine(types.GetType());
            }
        }
    }
}
