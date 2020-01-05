using System;

namespace HW._08_Task2_AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee empl = new Employee();

            int publicConst = Employee.publicBirthDate;           //Можно использовать, т.к. public дает доступ из любой сборки и из места в коде
            int internalConst = Employee.internalBirthDate;       //Можно использовать, т.к. internal позволяет использовать переменную из 
            //                                                      любой части кода, однако не из другой сборки, либо программы;
            //int privateConst = Employee.privateBirthDate;         Нельзя использовать модификатор private вне используемого класса
            //int protectedConst = Employee.protectedBirthDate;     Нельзя использовать модификатор protected вне используемого класса,
            //                                                      либо класса наследника (независимо от сборки)
            // !!!!!!  int piConst = Employee.piBirthDate;          Странно, что константы необходимо вызывать по имени класса, а здесь
            int piConst = empl.piBirthDate;                       //модификатор protected internal позволяет работать только с объектом класса.
            //int ppConst = Employee.ppBirthDate;                   Нельзя использовать модификатор private protected вне производного либо текущего
            //                                                      класса вне сборки
            
            string publicExample = empl.publicName;               // модификатор public позволяет использовать переменную из любого места из любой сборки
            string internalExample = empl.internalName;           //класс Employee находится в той же сборке, что и используемый класс Program
            string piExample = empl.piName;                       //класс Employee находится в той же сборке, что и класс Program
            //string privateExample = empl.privateName;             privateName находится за пределами класса;
            //string protectedExample = empl.protectedName;         класс Program не является дочерним для класса Employee;
            //string ppExample = empl.ppName;                       класс Program не наследуется от класса Employee, хоть и находится в той же сборке  

            empl.piMethod();
            empl.publicMethod();
            empl.internalMethod();
            //empl.privateMethod();
            //empl.protectedMethod();
            //empl.ppMethod();
        }
    }
}
