using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceSource
{
    class Functions
    {
        public static OpenFileDialog openfiledialog = new OpenFileDialog
        {
            Filter = "File Txt (*.txt)|*.txt|All files (*.*)|*.*",
            FilterIndex = 1,
            RestoreDirectory = true,
            Title = "Open File"
        };
    }
}
