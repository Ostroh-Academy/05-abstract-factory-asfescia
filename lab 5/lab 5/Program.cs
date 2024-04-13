using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створення паперового документа за допомогою фабрики
            DocumentFactory paperFactory = new PaperDocumentFactory();
            Document paperDocument = paperFactory.CreateDocument();
            paperDocument.Process();

            // Створення електронного документа за допомогою фабрики
            DocumentFactory electronicFactory = new ElectronicDocumentFactory();
            Document electronicDocument = electronicFactory.CreateDocument();
            electronicDocument.Process();

            // Очікування натискання кнопки для завершення програми
            Console.WriteLine("Натисніть будь-яку кнопку для виходу");
            Console.ReadKey();
        }
    }
}