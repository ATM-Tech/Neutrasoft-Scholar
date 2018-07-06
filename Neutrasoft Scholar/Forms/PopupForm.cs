using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neutrasoft_Scholar
{
    public partial class PopupForm : Form
    {
        public PopupForm(string text)
        {
            InitializeComponent();
            lblText.Text = text;
            this.Text = "Neutrasoft Scholar";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
