using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuleMarks
{
    public partial class Delete : Form
    {
        ModuleData moduleMarks = new ModuleData();
        Form1 mainform = new Form1();

        public Delete()
        {
            InitializeComponent();
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            // declaring the variables
            string stuRec;
            string stuID, stuMark;
            int mark;

            // split the lstboxvalue allow marks and student ID to appear in individual forms
            stuRec = mainform.lstboxValue;
            stuRec.Split(',');

            stuID = stuRec[0].ToString();
            mark = stuRec[1];
            stuMark = mark.ToString();

            // debugging method to see where code breaks down
            Console.WriteLine(stuID + ',' + stuMark);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform.ShowDialog();
        }
    }
}
