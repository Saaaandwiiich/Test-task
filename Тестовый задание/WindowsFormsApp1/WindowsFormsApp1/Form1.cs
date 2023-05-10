using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        Methods Methods = new Methods();

        public Form1()
        {
            InitializeComponent();
        }

        private void BigRedButton_Click(object sender, EventArgs e)
        {
            string folderPath = FilePath.Text;
            int minLength = (int)MinNumWords.Value;
            int maxLength = (int)MaxNumWords.Value;
            int fileCount = (int)NumFiles.Value;

            //Проверка введённых данных
            Methods.CreateFiles(folderPath, minLength, maxLength, fileCount);
            //Создание файлов
            Methods.GenerateFiles(folderPath, fileCount, @"C:\ИЖГТУ\3 курс\Практика\Тестовый залание 1\RUS.txt", minLength, maxLength);
        }


    }
}
