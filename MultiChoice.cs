using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuilderPattern
{
     public interface MultiChoice
    {
        ArrayList getSelected();
        void clear();
        Panel getWindow();
    }
}
