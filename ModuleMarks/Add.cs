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
    public partial class Add : Form
    {
        
        ModuleData moduleMarks = new ModuleData();
        Form1 mainform = new Form1();

        public Add()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            mainform.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Declaring the variables
            string stuID, stuMark;
            int mark;

            // The inputted data is equal to the variables
            stuID = txtstuID.Text;
            mark = int.Parse(txtstuMark.Text);
            stuMark = mark.ToString();

            // the variables are equal to a global variable allowing data to be accessed globally
            Memory.total = stuID + ", " + stuMark;
            moduleMarks.marks.Add(Memory.total);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            // when clicked the current window hides and the main menu loads again
            this.Hide();
            mainform.ShowDialog();     
        }

        public static class AddMemory
        {
            public static string stuID;
            public static int stuMarks;
        }
    }
}
