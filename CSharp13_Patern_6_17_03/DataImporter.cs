using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp13_Patern_6_17_03
{
    abstract class DataImporter
    {
        
        public void ImportData()
        {
            ConnectToDataSource();
            ExtractData();
            TransformData();
            LoadData();
            Console.WriteLine("Дані імпортовано успішно.");
        }

      
        protected abstract void ConnectToDataSource();
        protected abstract void ExtractData();
        protected abstract void TransformData();
        protected abstract void LoadData();
    }
}
