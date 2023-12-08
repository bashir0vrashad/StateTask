using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateTask
{
    internal interface IFileState
    {
        void OpenFile();
        void CloseFile();
        void ReadFile();
    }
}
