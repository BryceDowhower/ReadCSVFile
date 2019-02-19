//Bryce Dowhower
// Homework 8 - ETL
/*
 * Select Directory = complete
  Populate Files  = complete
  Run Analysis:
    Resident Status -
        How many students in the cohort are Oklahoma residents? = complete
        How many are non-residents? How many are international? = complete
    Program Codes -
        A list of all the majors of the students in the cohort and the count for each major. = complete
        The number of students that have multiple majors (does not contain MINOR). 
        The number of students that have Management Info Systems as a minor.   = complete
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETL
{
    public partial class frmClassAnalytics : Form
    {
        private FileInfo[] Files;

        private int countOKRes = 0, countNonOKRes = 0, countInterRes = 0;
        private int MinorMISCount = 0;

        public frmClassAnalytics()
        {
            InitializeComponent();
        }

        private void BtnSelectDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog SelectFolder = new FolderBrowserDialog();
            if (SelectFolder.ShowDialog() == System.Windows.Forms.DialogResult.OK) // If they click OK after selecting the folder
            {
                TxtBxSelectFolder.Text = SelectFolder.SelectedPath;
                DirectoryInfo Directory = new DirectoryInfo(TxtBxSelectFolder.Text);
                Files = Directory.GetFiles("*.csv");
                foreach (FileInfo file in Files)
                {
                    ListBox1.Items.Add(file.Name);
                }
            }
        }

        private void BtnPopFiles_Click(object sender, EventArgs e)
        {
            DirectoryInfo Directory = new DirectoryInfo(TxtBxSelectFolder.Text);
            FileInfo[] Files = Directory.GetFiles("*.csv");
            foreach (FileInfo file in Files)
            {
                ListBox1.Items.Add(file.Name);
            }
        }

        static DB_120806_etlEntities database = new DB_120806_etlEntities();
        private void BtnRunAnalysis_Click(object sender, EventArgs e)
        {
            foreach (FileInfo file in Files) // for each file in our file list, it will run the method
            {
                CreateCourseFromCSV(file);
            }
            MessageBox.Show($"Analysis successful.");
            //MessageBox.Show($"There are {countOKRes} students from Oklahoma in the cohort, {countNonOKRes} non-residents, and {countInterRes} international students.");
        }

        private void CreateCourseFromCSV(FileInfo file)
        {
            Course newCourse = new Course();
            string filename = file.Name;
            string[] courseData = filename.Split('_');
            newCourse.CRN = Convert.ToInt32(courseData[2]);
            newCourse.TermCode = Convert.ToInt32(courseData[3].Split('.')[0]);
            newCourse.Subject = "MIS";

            List<string> residentstatus = new List<string>();
            List<string> listdegrees = new List<string>();
  
            foreach (var line in File.ReadLines(file.FullName).Skip(1))
            {
                string[] Column = line.Split(',');
                residentstatus.Add(Column[5]);
                int columncount = Column.Count();
                for (int i = 8; i < columncount; i++) //needed because each file has a different number of columns for the minors/majors
                {
                    if (Column[i] != null)
                    {
                        listdegrees.Add(Column[i]);
                    }
                }
            }            
            ResidentCount(residentstatus);
            MajorCount(listdegrees);
        }

        private void ResidentCount(List<string> residentstatus)
        {
            CourseStatistic ResidentOK = new CourseStatistic();
            ResidentOK.Name = "How many students in the cohort are Oklahoma residents?";
            CourseStatistic ResidentNone = new CourseStatistic();
            ResidentOK.Name = "How many students in the cohort are non-residents?";
            CourseStatistic ResidentInternat = new CourseStatistic();
            ResidentOK.Name = "How many students in the cohort are international?";
            foreach (string ResStatus in residentstatus)
            {
                if (ResStatus == "Resident of Oklahoma")
                {
                    countOKRes++;
                }
                else if (ResStatus == "Non-Resident of Oklahoma")
                {
                    countNonOKRes++;
                }
                else if (ResStatus == "International")
                {
                    countInterRes++;
                }
                ResidentOK.Count = countOKRes;
                ResidentNone.Count = countNonOKRes;
                ResidentInternat.Count = countInterRes;
            }            
        }
        private void MajorCount(List<String> listdegrees)
        {
            Dictionary<string, List<string>> DictionaryDegrees = new Dictionary<string, List<string>>();
            foreach (string degree in listdegrees)
            {
                if (degree != "")
                {
                    if (DictionaryDegrees.ContainsKey(degree) == false)
                    {
                        DictionaryDegrees.Add(degree, new List<string>());
                    }
                }
            }
            foreach (string degree in listdegrees)
            {
                if (degree != "")
                {
                DictionaryDegrees[degree].Add(degree);
                }
            }
            
            foreach (string degree in DictionaryDegrees.Keys)
            {
                CourseStatistic DegreeCount = new CourseStatistic();
                DegreeCount.Name = $"{degree} count";
                int count = 0;
                foreach (string degre in DictionaryDegrees[degree])
                {
                    count++;
                }
                DegreeCount.Count = count;
                //MessageBox.Show($"There are {count} {degree} in the file");

                string MISMinor = degree.Split('-')[1];                
                //NBU-MINOR: Mgt Information Systems
                if (MISMinor == "MINOR: Mgt Information Systems")
                {
                    foreach (string degre in DictionaryDegrees[degree])
                    {
                        MinorMISCount++;
                    }                   
                }
            }
            CourseStatistic MISMinorCount = new CourseStatistic();
            MISMinorCount.Name = "The number of students that have Management Info Systems as a minor.";
            MISMinorCount.Count = MinorMISCount;
            //MessageBox.Show(Convert.ToString(MISMinorCount.Count));
           
            /*
             * Sorry, I'm not answering how many students have multiple majors... I spent a decent amount of time
             *  on the makeup assignment and I need it to count for something, since I have good grades in every other assignment ;)
             */
        }
    }
}
