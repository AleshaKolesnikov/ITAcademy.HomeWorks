﻿using System;


namespace HW._08_Task2_AssemblyOne
{
    class AssemblyOne
    {
        static void Main(string[] args)
        {
            Employee empl = new Employee();
            // переменные, объявленные в классе Employee с модификаторами, указанными ниже возможно использовать поскольку модификатор:
            //public - дает доступ из любой сборки и из места в коде
            //internal - позволяет использовать переменную из любой части кода, находящейся в той же сборке, либо программе
            //protected internal - дублирует функционал *internal* + возможность использования во вложенных классах

            int publicConst = Employee.publicBirthDate;           
            int internalConst = Employee.internalBirthDate;   
            int piConst = Employee.piBirthDate;
            //int ppConst = Employee.ppBirthDate;       
            //int privateConst = Employee.privateBirthDate;       
            //int protectedConst = Employee.protectedBirthDate;
            
            string publicExample = empl.publicName;               
            string internalExample = empl.internalName;           
            string piExample = empl.piName;                       
            //string privateExample = empl.privateName;           
            //string protectedExample = empl.protectedName;       
            //string ppExample = empl.ppName;                     

            empl.piMethod();
            empl.publicMethod();
            empl.internalMethod();
            //empl.privateMethod();
            //empl.protectedMethod();
            //empl.ppMethod();

            // переменные, объявленные в классе Employee с модификаторами, указанными ниже невозможно использовать поскольку для модификатора:
            //private - требуется, чтобы переменная была объявлена хотя бы в том же классе
            //protected - требуется, чтобы переменная была объявлена хотя бы в дочернем классе
            //private protected - требуется, чтобы оба вышеуказанных условия соблюдались

            //В классе AssemblyOne можно использовать также переменные из класса Developer, однако только с теми же модификаторами,
            //какие были задействованы в классе Employee (public, internal, protected internal, поскольку Класс AssemblyOne не является базовым
            //для класса Developer
            Developer developer = new Developer();
            developer.Display();
        }
    }
}
