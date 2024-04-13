using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    // Абстрактний клас Document
    abstract class Document
    {
        public abstract void Process();
    }

    // Клас для паперового документа, підклас Document
    class PaperDocument : Document
    {
        public override void Process()
        {
            Console.WriteLine("Обробка паперового документа...");
        }
    }

    // Клас для електронного документа, підклас Document
    class ElectronicDocument : Document
    {
        public override void Process()
        {
            Console.WriteLine("Обробка електронного документа...");
        }
    }
}