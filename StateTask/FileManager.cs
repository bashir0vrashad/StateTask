using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateTask
{
    internal class FileManager
    {
        private IFileState currentState;

        public FileManager()
        {
          
            currentState = new ClosedFileState();
        }

        public void OpenFile()
        {
            currentState.OpenFile();
            currentState = new OpenedFileState();
        }

        public void CloseFile()
        {
            currentState.CloseFile();
            currentState = new ClosedFileState(); 
        }

        public void ReadFile()
        {
            currentState.ReadFile();
        }
    }
}
