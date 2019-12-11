using System;
using System.IO;

namespace HW._02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Чтение файла по пути "C:\Users\Lex\Desktop\VS Projects\image.txt"
            // Создаем стринговый массив, для чтения всего текста.
            //  Создаем стринговый массив, который обособляет каждый байт с помощью пробела.
            // Создаем байтовый массив, который будет содержать в себе такую же длинну как у стрингового массива.
            // Создаем цикл, который будет конвертировать каждую последующую, начиная с первой, строку в байт
            // Создание файла, с помощью массива байтов.
            // Активация сборщика мусора

            StreamReader textReader = new StreamReader(@"C:\Users\Lex\Desktop\VS Projects\image.txt", true);

            string textReaderResult = textReader.ReadToEnd();

            string[] arrayOfTextResult = textReaderResult.Split(' ');

            byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];

            for (int i = 0; i < arrayOfTextResult.Length - 1; i++)
            {
                byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
                imageBytes[i] = binary;
            }

            File.WriteAllBytes(@"C:\Users\Lex\Desktop\VS Projects\image.png", imageBytes);

            textReader.Dispose();
        }
    }
}
