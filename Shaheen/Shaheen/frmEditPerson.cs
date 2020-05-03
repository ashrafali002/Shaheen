using Shaheen.BLL;
using Shaheen.ShaheenDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shaheen
{
    public partial class frmEditPerson : BaseForm
    {
        private int _personid;
        private string _subscriptionCode;
        private PersonBLL personBll;
        public int PersonId
        {
            get { return _personid; }
            set { _personid = value; }
        }
        public string SubscriptionCode
        {
            get { return _subscriptionCode; }
            set { _subscriptionCode = value; }
        }

        public frmEditPerson()
        {
            InitializeComponent();
            personBll = new PersonBLL ();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void frmEditPerson_Load(object sender, EventArgs e)
        {
            var person = new Person();
            txtCode.Text = SubscriptionCode;
            txtName.Text = person.personName;
            txtAddress.Text = person.personAddress;                        
        }
    }
}
