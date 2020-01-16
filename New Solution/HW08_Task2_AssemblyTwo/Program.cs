using System;
using HW._08_Task2_AssemblyOne;

namespace HW08_Task2_AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            // здесь возможно использовать только те переменные, которые объявлены с модификатором public,
            //поскольку мы находимся в сборке отличной от той, в которой объявлены переменные
            Employee employee = new Employee();
            employee.publicMethod();
            string display = employee.publicName;
            Program2 prog = new Program2();
            prog.Display();
        }
    }
    class Program2 : Employee
    {
        public void Display()
        {
            //помимо переменных с модификатором public 
            //здесь можно воспользоватся переменными с модификатором protected, объявленными в классе Employee
            Employee employee = new Employee();
            Console.WriteLine(protectedName);
        }
    }
}
