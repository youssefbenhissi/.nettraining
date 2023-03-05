using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final
{
    public partial class dataGridView : Form
    {
        DataTable availableCourses = new DataTable();
        DataTable selectedCourses = new DataTable();
        DataTable finalizedCourses = new DataTable();

        public dataGridView()
        {
            InitializeComponent();
            selectedCourses.Columns.Add("CourseID", typeof(int));
            selectedCourses.Columns.Add("CourseName");
            selectedCourses.Columns.Add("CourseDuration");
            finalizedCourses.Columns.Add("CourseID", typeof(int));
            finalizedCourses.Columns.Add("CourseName");
            finalizedCourses.Columns.Add("CourseDuration");
            availableCourses.Columns.Add("CourseID",typeof(int));
            availableCourses.Columns.Add("CourseName");
            availableCourses.Columns.Add("CourseDuration");
            availableCourses.Rows.Add(1, "Advance OOP", "6 Months");
            availableCourses.Rows.Add(2, "Graphics Designing", "3 Months");
            availableCourses.Rows.Add(3, "Human Computer Interection", "9 Months");
            availableCourses.Rows.Add(4, "Visual Programming C#", "9 Months");
            availableCourses.Rows.Add(5, "Android Apps Development", "9 Months");
            availableCourses.Rows.Add(6, "iOS Apps Development", "9 Months");
            availableCourses.Rows.Add(7, "Web Apps Development", "9 Months");
            availableCourses.Rows.Add(8, "Advance PHP", "9 Months");
            availableCourses.Rows.Add(9, "Java core", "9 Months");
            availableCourses.Rows.Add(10, "Desktop Apps Development", "9 Months");
            availableCourses.Rows.Add(11, "Xamarian Apps Development", "9 Months");
            availableCourses.Rows.Add(12, "Software Construction", "9 Months");
            availableCourses.Rows.Add(13, "Software Quality Engineering", "9 Months");
            availableCourses.Rows.Add(14, "Formal Methods", "9 Months");
            availableCourses.Rows.Add(15, "Introduction to Computing", "9 Months");
            availableCourses.Rows.Add(16, "Web Engineering", "9 Months");
            availableCourses.Rows.Add(17, "Web Designing", "9 Months");
            listBox2.DisplayMember = "CourseName";
            listBox2.DataSource = selectedCourses;
        }

        private void dataGridView_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = availableCourses;
            listBox1.DisplayMember = "CourseName";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(availableCourses.Rows.Count > 0)
            {

            DataRow selectedRow = availableCourses.Select("CourseID = " + availableCourses.Rows[listBox1.SelectedIndex]["CourseID"]).First();
            selectedCourses.ImportRow(selectedRow);
            availableCourses.Rows.Remove(selectedRow);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (selectedCourses.Rows.Count > 0)
            {

                DataRow selectedRow = selectedCourses.Select("CourseID = " + selectedCourses.Rows[listBox2.SelectedIndex]["CourseID"]).First();
            availableCourses.ImportRow(selectedRow);
            selectedCourses.Rows.Remove(selectedRow);
            }
        }

        private void addAllButton_Click(object sender, EventArgs e)
        {
            foreach(DataRow dr in availableCourses.Rows)
            {
                selectedCourses.ImportRow(dr);
            }
            
                availableCourses.Rows.Clear();
            
        }

        private void RemoveAllButton_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in selectedCourses.Rows)
            {
                availableCourses.ImportRow(dr);
            }

            selectedCourses.Rows.Clear();
        }

        private void finilazeButton_Click(object sender, EventArgs e)
        {
         DialogResult dialogResult =   MessageBox.Show("Are you sure you want to finalize it?","Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
         if(dialogResult == DialogResult.Yes)
            {
                dataGridView1.Enabled = false;
                dataGridView1.Columns[0].Visible = false;
                foreach (DataRow dr in selectedCourses.Rows)
                {
                    finalizedCourses.ImportRow(dr);
                }
               dataGridView1.DataSource = finalizedCourses;        
            }
        }
    }
}
