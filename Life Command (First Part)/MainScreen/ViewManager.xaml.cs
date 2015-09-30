using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using System.Data.SqlClient;

namespace MainScreen
{
	/// <summary>
	/// Interaction logic for ViewManager.xaml
	/// </summary>
	public partial class ViewManager : Window
	{
        SqlConnection cn = new SqlConnection(Singleton.connectionStringGlobal);
        SqlCommand cmd;
        SqlDataReader dr;

		public ViewManager()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
		}

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized; 
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void travelButton_Click(object sender, RoutedEventArgs e)
        {
            Map openMap = new Map();
            this.Close();
            openMap.Show();
        }

        private void fitnessButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	HealthForm openHealthForm = new HealthForm();
			this.Close();
			openHealthForm.Show();
        }

 //****************************************************************************************************************************************
//****************************************************************************************************************************************
/*
* **********    **        **    **       **     **********     **************    ****      **********      **       **     ***********
* **********    **        **    **      ***    ************    **************    ****    **************    **      ***    **************
 * **            **        **    **     ****    ***                   **                  **          **    **     ****    ***
* ******        **        **    **    *****    ***                   **          ****    **          **    **    *****    ***
* ******        **        **    **   **  **    ***                   **          ****    **          **    **   **  **     ***********
* **            **        **    **  **   **    ***                   **          ****    **          **    **  **   **      ************
* **            **        **    ******   **    ***                   **          ****    **          **    ******   **              ****
* **            ************    *****    **    ************          **          ****    **************    *****    **     *************
* **             **********     ****     **     **********           **          ****      **********      ****     **    *************
*/
//****************************************************************************************************************************************
//****************************************************************************************************************************************







        //Clears the listView
        //*******************************************************************************************************************************
        public void clearListView()
        {
            infoListView.Items.Clear();
        }
        //*******************************************************************************************************************************

        //Refreshes the listView
        //*******************************************************************************************************************************
        public void refresh_listView()
        {
            clearListView();
            string name = "Test Name";
            string fullTimeJob = "Test Job";
            string partTimeJob = "Test Job";
            string fullTimeSchool = "Test School";
            string partTimeSchool = "Test School";
            string location = "Test Location";
            double health = 97.95;
            double income = 25000.16;

            get_user_data(ref name, ref health, ref fullTimeJob, ref partTimeJob,
                                        ref fullTimeSchool, ref partTimeSchool, ref income, ref location);





            




            List<string> list = new List<string>();
            //Assigns the order of how to place the items ( rows )
            string[] row = { name, health.ToString("F"), fullTimeJob, partTimeJob, fullTimeSchool, partTimeSchool, income.ToString("F"), location };
            list.AddRange(row); 
            //Creates a listViewItem object and passes each row to it
            var listViewItem = new ListViewItem();
            listViewItem.DataContext = row;
            infoListView.Items.Add(name);

            infoListView.Items.Clear();
             //infoListView.ItemsSource = list;


            
            foreach (string item in list)
            {
                infoListView.Items.Add(item);

            }
           //row.ForEach(item => infoListView.Items.Add(item));
             

            

        }
        //*******************************************************************************************************************************

        //Gets all the data for the listView from database
        //Assigns it to the varibale passed by reference
        //*******************************************************************************************************************************
        public void get_user_data(ref string name, ref double health, ref string fullTimeJob, ref string partTimeJob,
                                        ref string fullTimeSchool, ref string partTimeSchool, ref double income, ref string location)
        {
            int id = currentIdSelected();
            string firstName = " ";
            string lastName = " ";
            double fullTime = 0;
            double partTime = 0;
            double fullModifier = 0;
            double partModifier = 0;




            //NAME
            //***************************************************************************************************************************
            //***************************************************************************************************************************

            //Getting the First Name (from peopleTb)
            //***************************************************************************************************************************
            cn.Open();
            cmd = new SqlCommand("select * from healthTb", cn); //random to load db
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select name from peopleTb where person_id =" + id;
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
                while (dr.Read())
                {
                    firstName = dr[0].ToString();      //dr[9], since name is at possition 9 (starting from 0)
                }
            cn.Close();
            //***************************************************************************************************************************

            //Getting the Last Name (from householdTb)
            //***************************************************************************************************************************
            GetLastName(ref lastName);                  //Calls a function to get the last name of the user
            //***************************************************************************************************************************

            name = firstName + " " + lastName;

            //***************************************************************************************************************************
            //***************************************************************************************************************************


            //JOB and INCOME
            //***************************************************************************************************************************
            //***************************************************************************************************************************

            //Finding the name of the jobs of the user
            //***************************************************************************************************************************
            //Full time job
            fullTimeJob = jobNameFromJobTb("full_time_job1", id);

            //Part time job
            partTimeJob = jobNameFromJobTb("part_time_job1", id);
            //***************************************************************************************************************************


            //Getting the salary of that job
            //***************************************************************************************************************************


            if (fullTimeJob == "President")
                getPresidentSalary(ref fullTime);
            else if (fullTimeJob == "Teacher")
                getTeacherSalary(ref fullTime);
            else if (fullTimeJob == "Fisherman")
                getFishermanSalary(ref fullTime);
            else if (fullTimeJob == "Programmer")
                getProgrammerSalary(ref fullTime);
            else
                fullTime = 0;


            if (partTimeJob == "President")
                getPresidentSalary(ref partTime);
            else if (partTimeJob == "Teacher")
                getTeacherSalary(ref partTime);
            else if (partTimeJob == "Fisherman")
                getFishermanSalary(ref partTime);
            else if (partTimeJob == "Programmer")
                getProgrammerSalary(ref partTime);
            else
                partTime = 0;

            //***************************************************************************************************************************


            //Getting the raise_modifier for the job
            //***************************************************************************************************************************
            //Full time
            cn.Open();
            cmd = new SqlCommand("select * from healthTb", cn); //random to load db
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select full_time_job1_raise_modifier from jobsTb where job_id = " + id;
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
                while (dr.Read())
                {
                    fullModifier = Convert.ToDouble(dr[0]);
                }

            cn.Close();

            //Part time
            cn.Open();
            cmd = new SqlCommand("select * from healthTb", cn); //random to load db
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select part_time_job1_raise_modifier from jobsTb where job_id = " + id;
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
                while (dr.Read())
                {
                    partModifier = Convert.ToDouble(dr[0]);
                }

            cn.Close();
            //***************************************************************************************************************************

            //Multiplying the salary by the raise_modifier to get the income
            fullTime = fullTime * fullModifier;                     //Gets the income for the Full Time Job
            partTime = partTime * partModifier;                     //Gets the income for the Part Time Job

            income = fullTime + partTime;                           //Gets the total income
            //***************************************************************************************************************************



            //SCHOOL
            //***************************************************************************************************************************
            //Full time
            fullTimeSchool = schoolNameFromSchoolingTb("full_time_school1", id);
            //Part time
            partTimeSchool = schoolNameFromSchoolingTb("part_time_school1", id);

            //***************************************************************************************************************************

            location = "TEST";

        }
        //*******************************************************************************************************************************


        //Gets the last name of the currently selected user (FOR EASIER READ OF CODE)
        //*******************************************************************************************************************************
        public void GetLastName(ref string lastName)
        {
            int lNameID = 0;
            int id = currentIdSelected();

            //Gets the id of the last name (id - from peopleTb)

            cn.Open();
            cmd = new SqlCommand("select * from healthTb", cn); //random to load db
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select household_id from peopleTb where person_id =" + id;
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
                while (dr.Read())
                {
                    lNameID = Convert.ToInt32(dr[0]);            //dr[1], since household_id is at possition 1
                }

            cn.Close();

            //Gets the last name (value)

            cn.Open();
            cmd = new SqlCommand("select * from healthTb", cn); //random to load db
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select household_name from householdsTb where household_id = " + lNameID;
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
                while (dr.Read())
                {
                    lastName = Convert.ToString(dr[0]);
                }

            cn.Close();
        }
        //*******************************************************************************************************************************

        //Gets the salaries for all proffesions
        //*******************************************************************************************************************************
        public void getPresidentSalary(ref double job)
        {
            cn.Open();
            cmd = new SqlCommand("select * from healthTb", cn); //random to load db
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select salary from jobStorageTb where job_storage_id = 2";
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
                while (dr.Read())
                {
                    job = Convert.ToDouble(dr[0]);
                }

            cn.Close();
        }

        public void getTeacherSalary(ref double job)
        {
            cn.Open();
            cmd = new SqlCommand("select * from healthTb", cn); //random to load db
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select salary from jobStorageTb where job_storage_id = 3";
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
                while (dr.Read())
                {
                    job = Convert.ToDouble(dr[0]);
                }

            cn.Close();
        }

        public void getFishermanSalary(ref double job)
        {
            cn.Open();
            cmd = new SqlCommand("select * from healthTb", cn); //random to load db
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select salary from jobStorageTb where job_storage_id = 4";
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
                while (dr.Read())
                {
                    job = Convert.ToDouble(dr[0]);
                }

            cn.Close();
        }

        public void getProgrammerSalary(ref double job)
        {
            cn.Open();
            cmd = new SqlCommand("select * from healthTb", cn); //random to load db
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select salary from jobStorageTb where job_storage_id = 5";
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
                while (dr.Read())
                {
                    job = Convert.ToDouble(dr[0]);
                }

            cn.Close();
        }
        //*******************************************************************************************************************************



        //*******************************************************************************************************************************
        public void refresh_combobox()
        {
            householdNameComboBox.Items.Clear();

            cn.Open();

            cmd = new SqlCommand("select * from healthTb", cn); //random to load db
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select name from peopleTb";
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
                while (dr.Read())
                {
                    householdNameComboBox.Items.Add(dr[0].ToString());
                }

            cn.Close();

            if (householdNameComboBox.Items.Count >= 0 && householdNameComboBox.SelectedIndex == -1)
                householdNameComboBox.SelectedIndex = 0;
        }
        //*******************************************************************************************************************************

        //Fills the comboBox for the jobs with all the jobStorageTb
        //*******************************************************************************************************************************
        public void refresh_jobs_combobox()
        {
            jobsComboBox.Items.Clear();

            cn.Open();
            cmd = new SqlCommand("select * from healthTb", cn); //random to load db avoids arror
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select * from jobStorageTb";
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
                while (dr.Read())
                {
                    jobsComboBox.Items.Add(dr[1].ToString());
                }

            cn.Close();

            if (partTimeJobsCheckBox.IsChecked == false)
                jobsComboBox.SelectedIndex = -1 + jobStorageIdFromjobStorageTb(jobNameFromJobTb("full_time_job1", currentIdSelected()));
            else
                if (partTimeJobsCheckBox.IsChecked == true)
                    jobsComboBox.SelectedIndex = -1 + jobStorageIdFromjobStorageTb(jobNameFromJobTb("part_time_job1", currentIdSelected()));
        }
        //*******************************************************************************************************************************


        //*******************************************************************************************************************************
        public void refresh_schools_combobox()
        {
            schoolComboBox.Items.Clear();

            cn.Open();
            cmd = new SqlCommand("select * from healthTb", cn); //random to load db
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select * from schoolingStorageTb";
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
                while (dr.Read())
                {
                    schoolComboBox.Items.Add(dr[1].ToString());
                }

            cn.Close();

            if (partTimeSchoolCheckBox.IsChecked == false)
                schoolComboBox.SelectedIndex = -1 + schoolStorageIdFromSchoolingStorageTb(schoolNameFromSchoolingTb("full_time_school1",
                                                                                                                        currentIdSelected()));
            else
                if (partTimeSchoolCheckBox.IsChecked == true)
                    schoolComboBox.SelectedIndex = -1 + schoolStorageIdFromSchoolingStorageTb(schoolNameFromSchoolingTb("part_time_school1",
                                                                                                                        currentIdSelected()));
        }
        //*******************************************************************************************************************************


        //Gets the job name from jobsTb
        //*******************************************************************************************************************************
        public string jobNameFromJobTb(string column, int id)
        {
            string x = "";

            if (column == "full_time_job1")
            {
                cn.Open();
                cmd = new SqlCommand("select * from healthTb", cn); //random to load db
                cmd.ExecuteNonQuery();
                cmd.CommandText = "select " + column + " from jobsTb where job_id =" + id;
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                    while (dr.Read())
                    {
                        x = dr[0].ToString();
                    }

                cn.Close();
            }
            else if (column == "part_time_job1")
            {
                cn.Open();
                cmd = new SqlCommand("select * from healthTb", cn); //random to load db
                cmd.ExecuteNonQuery();
                cmd.CommandText = "select " + column + " from jobsTb where job_id =" + id;
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                    while (dr.Read())
                    {
                        x = dr[0].ToString();
                    }

                cn.Close();
            }


            return x;
        }
        //*******************************************************************************************************************************



        public int jobStorageIdFromjobStorageTb(string jobName)
        {
            int x = 1;

            cn.Open();
            cmd = new SqlCommand("select * from healthTb", cn); //random to load db
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select job_storage_id from jobStorageTb where job_name =" + "'" + jobName + "'";
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
                while (dr.Read())
                {
                    x = (int)dr[0];
                }

            cn.Close();

            return x;
        }




        public void updatePersonJobChoice(string column, string amount, int id)
        {
            cn.Open();

            cmd = new SqlCommand("update jobsTb set " + column + '=' + "'" + amount + "'" + " where job_id=" + id, cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void updatePersonSchoolChoice(string column, string amount, int id)
        {
            cn.Open();

            cmd = new SqlCommand("update schoolingTb set " + column + '=' + "'" + amount + "'" + " where schooling_id=" + id, cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void updatePersonJobRaise(string column, float amount, int id)
        {
            cn.Open();

            cmd = new SqlCommand("update jobsTb set " + column + '=' + amount + " where job_id=" + id, cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        //*******************************************************************************************************************************
        public int schoolStorageIdFromSchoolingStorageTb(string schoolName)
        {
            int x = 1;

            cn.Open();
            cmd = new SqlCommand("select * from healthTb", cn); //random to load db
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select schooling_storage_id from schoolingStorageTb where name =" + "'" + schoolName + "'";
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
                while (dr.Read())
                {
                    x = (int)dr[0];
                }

            cn.Close();

            return x;
        }
        //*******************************************************************************************************************************

        //*******************************************************************************************************************************
        public string schoolNameFromSchoolingTb(string column, int id)
        {
            string x = "";
            if (column == "full_time_school1")
            {
                cn.Open();
                cmd = new SqlCommand("select * from healthTb", cn); //random to load db
                cmd.ExecuteNonQuery();
                cmd.CommandText = "select " + column + " from schoolingTb where schooling_id =" + id;
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                    while (dr.Read())
                    {
                        x = dr[0].ToString();
                    }

                cn.Close();
            }
            else if (column == "part_time_school1")
            {
                cn.Open();
                cmd = new SqlCommand("select * from healthTb", cn); //random to load db
                cmd.ExecuteNonQuery();
                cmd.CommandText = "select " + column + " from schoolingTb where schooling_id =" + id;
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                    while (dr.Read())
                    {
                        x = dr[0].ToString();
                    }

                cn.Close();
            }
            return x;
        }
        //*******************************************************************************************************************************

        //Returns what person is in focus in the combobox on the form
        //*******************************************************************************************************************************
        public int currentIdSelected()
        {
            return householdNameComboBox.SelectedIndex + 1;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh_listView();
        }

        private void mainMenuButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow getBack = new MainWindow();                          //Creates a main screen object
            getBack.Show();
            getBack.Focus();                                                //Changes the focus to the main form (avoids a second click)
            this.Close();    
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            refresh_combobox();
            refresh_jobs_combobox();
            refresh_schools_combobox();
            clearListView();
            refresh_listView();
        }

        private void partTimeJobsCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            refresh_jobs_combobox();
        }

        private void partTimeSchoolCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            refresh_schools_combobox();
        }
        //*******************************************************************************************************************************





        


	}
}