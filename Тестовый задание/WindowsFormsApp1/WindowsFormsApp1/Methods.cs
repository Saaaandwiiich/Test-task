using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    internal class Methods
    {
             // Проверяем корректность входных данных
            public static void CreateFiles(string folderPath, int minLength, int maxLength, int fileCount)
            {
                if (maxLength <= minLength)
                {
                    MessageBox.Show("Максимальное количество символов должно быть больше минимального количества символов");
                    return;
                }

                if (fileCount < 1)
                {
                    MessageBox.Show("Количество файлов должно быть больше нуля");
                    return;
                }

                if (!Directory.Exists(folderPath))
                {
                    MessageBox.Show($"Папка {folderPath} не найдена");
                    return;
                }
            }

        //Создаём файлы
        public static void GenerateFiles(string outputPath, int numFiles, string inputFilePath, int min, int max)
        {
            var rand = new Random();

            // Проверяем существование файла
            if (!File.Exists(inputFilePath))
            {
                MessageBox.Show($"Файл {inputFilePath} не найден.");
            }

            // Читаем файл с входным текстом
            string[] words = File.ReadAllLines(inputFilePath, Encoding.Default);

            // Генерируем указанное количество файлов
            for (int i = 0; i < numFiles; i++)
            {
                // Генерируем случайный текст для файла

                var text = new StringBuilder();
                int sentencesCount = rand.Next(min, max + 1);
                for (int s = 0; s < sentencesCount; s++)
                {
                    int wordsCount = rand.Next(min, (max / sentencesCount) + 1);
                    for (int w = 0; w < wordsCount; w++)
                    {
                        // Добавляем случайное слово
                        text.Append(words[rand.Next(words.Length)]);

                        // Добавляем случайный знак препинания (или пробел)
                        if (w == wordsCount - 1)
                        {
                            text.Append(rand.Next(2) == 0 ? ". " : "! ");
                        }
                        else
                        {
                            text.Append(rand.Next(5) == 0 ? ", " : " ");
                        }
                    }
                }

                var filePath = Path.Combine(outputPath, $"file{i + 1}.docx");

                // Создаем документ
                using (var document = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
                {
                    // Создаем основную часть документа (Document)
                    var doc = document.AddMainDocumentPart().Document = new Document();
                    var body = doc.AppendChild(new Body());

                    // Создаем параграфы
                    var paragraphs = text.ToString().Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var paragraphText in paragraphs)
                    {
                        var paragraph = body.AppendChild(new Paragraph());
                        paragraph.AppendChild(new Run(new Text(paragraphText)));
                    }
                }

                MessageBox.Show($"Файл {filePath} создан в папке {outputPath}");              
            }
        }


    }
}





