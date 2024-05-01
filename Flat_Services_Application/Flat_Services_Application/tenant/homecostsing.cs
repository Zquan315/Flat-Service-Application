using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flat_Services_Application.tenant
{
    public partial class homecostsing : Form
    {
        public homecostsing()
        {
            InitializeComponent();
        }

        private void homecostsing_Load(object sender, EventArgs e)
        {
            this.costsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)41))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.costsBtn.ForeColor = Color.White;
        }
    }
}
