using System;
using System.Collections.Generic;
using System.Text;

namespace HW._08_Task2_AssemblyOne
{
    public class Employee
    {
        //working with consts
        public const int publicBirthDate = 1993;
        private const int privateBirthDate = 1994;
        protected const int protectedBirthDate = 1995;
        internal const int internalBirthDate = 1996;
        protected internal int piBirthDate = 1997;
        private protected int ppBirthDate = 1998;
        //working with variables
        public string publicName = "public";
        private string privateName = "private";
        protected string protectedName = "protected";
        internal string internalName = "internal";
        protected internal string piName = "protected internal";
        private protected string ppName = "private protected";
        //working with method
        private void privateMethod() { }
        public void publicMethod() { }
        internal void internalMethod() { }
        protected void protectedMethod() { }
        protected internal void piMethod() { }
        private protected void ppMethod() { }
    }
}
