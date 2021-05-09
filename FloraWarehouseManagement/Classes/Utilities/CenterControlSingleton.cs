using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloraWarehouseManagement.Classes.Utilities
{
    public class CenterControlSingleton
    {
        public static CenterControlSingleton Instance { get; } = new CenterControlSingleton();
        public CenterControlSingleton() { }
        public void CenterControl(Control ctrlToCenter)
        {
            ctrlToCenter.Left = (ctrlToCenter.Parent.Width - ctrlToCenter.Width) / 2;
        }

    }
}
