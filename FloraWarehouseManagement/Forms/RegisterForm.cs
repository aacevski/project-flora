using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FloraWarehouseManagement.Classes.Utilities;

namespace FloraWarehouseManagement.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            CenterControlSingleton.Instance.CenterControl(pnlLogo);
            CenterControlSingleton.Instance.CenterControl(pnlButtons);

        }

        private void RegisterForm_SizeChanged(object sender, EventArgs e)
        {
            CenterControlSingleton.Instance.CenterControl(pnlLogo);
        }
    }
}
