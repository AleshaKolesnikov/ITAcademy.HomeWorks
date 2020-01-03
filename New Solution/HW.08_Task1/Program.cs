using System;
using System.Text;

namespace HW._08_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string str = "1a!2.3!!.. 4.!.?6? 7! ..?";
            Console.WriteLine($"Строка до выполнения операции:\n{str}");
            string [] newstr = str.Split('?', 2);
                // работа со строкой до первого ?
            sb.Append(newstr[0]); 
            sb.Replace("!", "");
            sb.Replace(".", "");
            string str1 = sb.ToString();
            sb.Clear();
                // работа со строкой после первого ?
            sb.Append(newstr[1]);
            sb.Replace(" ", "_");
            string str2 = sb.ToString();
            sb.Clear();
                // возвращение первоначального варианта с изменениями
            sb.AppendJoin('?', str1, str2);
            str = sb.ToString();
            Console.WriteLine($"Строка после выполнения операций:\n{str}");
        }
    }
}
