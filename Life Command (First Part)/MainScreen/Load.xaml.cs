using System;
using System.Collections.Generic;
using System.Linq;
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
	/// Interaction logic for Load.xaml
	/// </summary>
	public partial class Load : Window
	{

        SqlConnection cn = new SqlConnection(Singleton.connectionStringGlobal);
        SqlCommand cmd;
        SqlDataReader dr;


		public Load()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
		}

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            householdsListBox.Items.Clear();
            string name = " test ";


            householdsListBox.Items.Add(name);

            cn.Open();
            cmd = new SqlCommand("select * from healthTb", cn); //random to load db
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select household_name from householdsTb";
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
                while (dr.Read())
                {
                    name = dr[0].ToString();    //dr[0], since we are selecting only household_name form the table
                    
                }

            

            cn.Close();

        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            string name = searchTextBox.Text.ToString();
            string test = " ";
            bool resutl = false;
                
            for ( int x = 0; x < householdsListBox.Items.Count; x++) 
            {
                test = householdsListBox.Items[x].ToString();

                if (name == test)
                {
                    resutl = true;
                    householdsListBox.SelectedIndex = x;
                }
            }

            if (resutl == false)
                MessageBox.Show("No matches.");
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



        //Displayes all people with the same household id
        //*******************************************************************************************************************************
        public void displayPeople(ref int id)
        {
            peopleListBox.Items.Clear();

            cn.Open();
            cmd = new SqlCommand("select * from healthTb", cn); //random to load db
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select name from peopleTb where household_id = " + id;
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
                while (dr.Read())
                {
                    peopleListBox.Items.Add(dr[0].ToString());    //dr[0], since we are selecting only household_name form the table
                }

            cn.Close();
        }
        //*******************************************************************************************************************************

	}
}