using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication.PL
{
    public partial class Report : MetroForm
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Users' table. You can move, or remove it, as needed.
         
            // TODO: This line of code loads data into the 'testDataSet.Users' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'dataSet1.Users' table. You can move, or remove it, as needed.
          

            this.reportViewer1.RefreshReport();
        }
    }
}
