using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    // Абстрактна фабрика документів
    abstract class DocumentFactory
    {
        public abstract Document CreateDocument();
    }

    // Фабрика для створення паперових документів
    class PaperDocumentFactory : DocumentFactory
    {
        public override Document CreateDocument()
        {
            return new PaperDocument();
        }
    }

    // Фабрика для створення електронних документів
    class ElectronicDocumentFactory : DocumentFactory
    {
        public override Document CreateDocument()
        {
            return new ElectronicDocument();
        }
    }
}