using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_02.Image
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Создаём экземпляр класса StreamReader для чтения файла .txt  + c указателем метки порядка байтов в начале файла
            //2.Инициализируем строку textTeaderResult  и помещаем в нёё, считанное до конца, содердимое файла image.txt, совершаем это с помощью метода ReadToEnd экземпляра textReader
            //3.Создаём и заполняем массив строк, посредством разбиения строки textReaderResult, разбиваем ориентируясь на пробелы с помощью метода Split(' ')
            //4.Создаём массив байтов размером [arrayOfTextResult.Length - 1], так как исчисление в массиве начинается с 0 
            //5.цикл for, количество итераций rrayOfTextResult.Length - 1
            //6.В цикле считывам поэлементно массив строк arrayOfTextResult[], и каждый элемент конвертируем в байт и заполняем массив байтов imageBytes[]
            //7.записываем в файл все байты из массива байтов, файл с расширением .png
            //8.закрываем StreamReader, так как больше не используем его.
            

            StreamReader textReader = new StreamReader(@"D:\Work\C# Courses\HW_02.Image\HW_02.Image\image.txt", true);
            string textReaderResult = textReader.ReadToEnd();
            string[] arrayOfTextResult = textReaderResult.Split(' ');
            byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];

            for (int i = 0; i < arrayOfTextResult.Length - 1; i++)
            {
                
                byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
                imageBytes[i] = binary;
            }

            File.WriteAllBytes(@"D:\Work\C# Courses\HW_02.Image\HW_02.Image\image.png", imageBytes);

            textReader.Dispose();
        }
    }
}
