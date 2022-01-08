using System;
using System.Windows.Forms;

namespace Shaheen
{
    public partial class BaseForm : Form
    {
        public string _mode;
        public string Mode
        {
            get { return _mode; }
            set { _mode = value; }
        }
        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
