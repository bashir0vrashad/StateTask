using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateTask
{
    internal class OpenedFileState:IFileState
    {
        public void OpenFile()
        {
            Console.WriteLine("Fayl artiq aciqdi..");
        }

        public void CloseFile()
        {
            Console.WriteLine("Fayl baglanilir..");
        }

        public void ReadFile()
        {
            Console.WriteLine("Fayl oxunulur.. ");
        }
    }
}
