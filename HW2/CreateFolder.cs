using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    public class CreateFolder
    {
        public string outPutPath = Path.Combine("d:\\", "newPapka\\");

        internal void CreateNewFolder()
        {
            DirectoryInfo folder = new DirectoryInfo(outPutPath);
            if (!folder.Exists)
            {
                folder.Create();
            }
        }
    }
}
