using System;
using System.IO;
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
    public partial class Form1 : Form
    {
        ModuleData moduleMarks = new ModuleData();

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            // Read record from file and populate List structure 
            // ...

            string studentRec;

            StreamReader inputFile = new StreamReader(@"C:\temp\Assignment 2 C#\COM122.csv");

            while (inputFile.EndOfStream == false) 
            {
                studentRec = inputFile.ReadLine();
                // ==> Declare a class, e.g. ModuleData, to declare and store the List structure named, e.g. moduleMarks

                // ==> along with any other global variables needed.

                moduleMarks.marks.Add(studentRec);
            }

            RefreshListBox();
            // Call RefreshListBox() to populate the list box
        }

        public void RefreshListBox()
        {
            // Code below clears the listbox and iterates through the list structure and will then find the added records to the listbox 
            lstModuleMarks.Items.Clear();
            foreach (string rec in moduleMarks.marks)
            {
                lstModuleMarks.Items.Add(rec);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Closes the program entirely
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Opens up the Add Form 
            Add addform = new Add();
            addform.ShowDialog();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Opens up the edit form
            Edit editForm = new Edit();
            editForm.ShowDialog();
            // Alsos the selected list item to be seen
            lstModuleMarks.SelectedItem.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Opens up the delete form
            Delete deleteForm = new Delete();
            deleteForm.ShowDialog();
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            //Saves the listbox items into a text file in the path  using the variable marks
            const string marks = @"C:\temp\New Marks.txt";

            StreamWriter updateMarks = new StreamWriter(marks, true);

            string newmarks = lstModuleMarks.Items.ToString();
            updateMarks.Write(newmarks);
            updateMarks.Close();

            MessageBox.Show("Marks Updated");            
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
            // Declared the Variables
            int studentMark = 0, count = 0, total = 0;
            string[] marks;
            double averagemarks;

            // If statement to declare if count is 0 nothing happens
            if (lstModuleMarks.Items.Count == 0)
            {
                lblOutput.Text = "There are no records in the list";
            }
            else
            {
                // while loop that if the count is less than listbox count, the program iterates through each record
                // it splits the records into two seperate array and we count the mark array
                while (count < lstModuleMarks.Items.Count)
                {
                    marks = lstModuleMarks.Items[count].ToString().Split(',');
                    studentMark = int.Parse(marks[1]);
                    total += studentMark;
                    count += 1;
                }
                averagemarks = (double)total / lstModuleMarks.Items.Count;
                lblOutput.Text = "The Average mark is:" + " " + averagemarks.ToString("N2");
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            // Declaring the variables
            int stumark = 0, count = 0, minum = 101;
            string[] marks;

            // While loop that declares if the count is less than listbox count, the program will iterate
            // through the listbox using a split method and it searches for the lowest value for the mark
            while (count < lstModuleMarks.Items.Count)
            {
                marks = lstModuleMarks.Items[count].ToString().Split(',');
                stumark = int.Parse(marks[1]);

                if (stumark < minum)
                {
                    minum = stumark;
                }
                count++;

                lblOutput.Text = " The lowest mark is: " + minum.ToString();


            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            // Declaring the variables
            int stuMark = 0, count = 0, maxnum = 0;
            string[] marks;

            // If statements that if the count is 0 nothing will happen and error message is outputted
            if (lstModuleMarks.Items.Count == 0)
            {
                lblOutput.Text = "There are no marks in the list box.";
            }

            // While loop that declares if the listbox count is less than the actual count then it iterates
            // through the code by referring back to the maxnum
            while (count < lstModuleMarks.Items.Count)
            {
                marks = lstModuleMarks.Items[count].ToString().Split(',');
                stuMark = int.Parse(marks[1]);
                if (stuMark > maxnum)
                {
                    maxnum = stuMark;
                }
                count++;

                lblOutput.Text = "The Higest Mark is: " + maxnum.ToString();


            }
        }

        public void lstModuleMarks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public string lstboxValue
        {
            // gets the value of thhe selected item within the listbox
            get { return lstModuleMarks.SelectedItem.ToString(); }
        }
    }
}
