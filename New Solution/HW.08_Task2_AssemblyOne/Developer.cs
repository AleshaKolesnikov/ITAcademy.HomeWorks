using System;
using System.Collections.Generic;
using System.Text;

namespace HW._08_Task2_AssemblyOne
{
   public class Developer:Employee
    {
        void Main()
        {
            Developer developer = new Developer();
            //в классе Developer можно использовать переменные, объявленные в классе Employee со всеми модификатроми кроме *private*
            int developerConstPublic = Developer.publicBirthDate;
            int developerConstInternal = Developer.internalBirthDate;
            int developerConstProtected = Developer.protectedBirthDate;         //модификатор *protected* можно использовать во вложенном классе
            int developerConstProtectedInternal = Developer.piBirthDate;
            int developerConstPrivateProtected = Developer.ppBirthDate;

            //поля
            string developerField1 = developer.publicName;
            string developerField2 = developer.internalName;
            string developerField3 = developer.protectedName;
            string developerField4 = developer.piName;              //модификатор *protected internal* можно использовать в той же сборке,
                                                                    //поскольку переменная piName находится в базовом классе
            string developerField5 = developer.ppName;              //модификатор *private protected* можно использовать во вложенном классе, 
                                                                    //поскольку переменная ppName находится в той же сборке
            //методы
            developer.publicMethod();
            developer.internalMethod();
            developer.protectedMethod();
            developer.ppMethod();
            developer.piMethod();
            // модификатор private нельзя использовать, поскольку класс Developer - является вложенным.
        }
       internal void Display()
        {
            Developer developer = new Developer();
            string developerField2 = developer.internalName;
            Console.WriteLine(developerField2);
        }
    }
}
