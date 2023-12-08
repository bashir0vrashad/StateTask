using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateTask
{
    internal class ClosedFileState:IFileState
    {
        public void OpenFile()
        {
            Console.WriteLine("Fayl acilir..");
        }

        public void CloseFile()
        {
            Console.WriteLine("Fayl artiq baglidir..");
        }

        public void ReadFile()
        {
            Console.WriteLine("Fayl bagli oldugu ucun oxunulmur..");
        }
    }
}
