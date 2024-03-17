using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp13_Patern_6_17_03
{
    class ExcelDataImporter : DataImporter
    {
        protected override void ConnectToDataSource()
        {
            Console.WriteLine("Підключення до джерела даних Excel...");
        }

        protected override void ExtractData()
        {
            Console.WriteLine("Витягнення даних з Excel...");
        }

        protected override void TransformData()
        {
            Console.WriteLine("Трансформація даних з Excel...");
        }

        protected override void LoadData()
        {
            Console.WriteLine("Завантаження даних з Excel...");
        }
    }
}
