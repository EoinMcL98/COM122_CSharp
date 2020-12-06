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
    public partial class Edit : Form
    {
        ModuleData moduleData = new ModuleData();
        Form1 mainForm = new Form1();

        public Edit()
        {
            InitializeComponent();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            // declaring the variables
            string[] stuRec = new string[2];
            string stuID, stuMark;
            int Mark;

            // splitting the stuRec into marks and student ID so they appear in each textbox
            stuRec = mainForm.lstboxValue.Split(',');
            stuID = stuRec[0];
            Mark = int.Parse(stuRec[1]);
            stuMark = Mark.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mainForm.ShowDialog();
            this.Close();
        }
    }
}
