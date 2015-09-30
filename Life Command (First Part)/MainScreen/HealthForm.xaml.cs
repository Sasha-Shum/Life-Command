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
	/// Interaction logic for HealthForm.xaml
	/// </summary>
	public partial class HealthForm : Window
	{
        SqlConnection cn = new SqlConnection(Singleton.connectionStringGlobal);
        SqlCommand cmd;
        SqlDataReader dr;
        Random r = new Random();
        const int max = 16;
        const int min = 0;


		public HealthForm()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
		}

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            int happiness = 0;
            int intelligence = 0;
            int appearance = 0;
            int musical = 0;
            int artistic = 0;
            int athletic = 0;
            int strength = 0;
            int endurance = 0;

            refresh_combobox();         //Refreshes the combobox
            
            //Gets all the attribute points for the current selected user, and changes the
            //rectangular shapes accordingly
            //*********************************************************************************
            getAllAttributeValues(ref happiness, ref intelligence, ref appearance, ref musical,
                                    ref artistic, ref athletic, ref strength, ref endurance);
            //*********************************************************************************

            randomActivities();         //Assigns random activity points


            refresh_health_listView();
        }

		private void exitButton_Click(object sender, System.Windows.RoutedEventArgs e)
		{
            ViewManager form = new ViewManager();

			this.Close();
            form.Show();
		}

		private void minimizeButton_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			 this.WindowState = WindowState.Minimized; 
		}

		private void Grid_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			DragMove();
		}

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            randomActivities();         //Assigns random activity points
        }

        private void selectCharComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int happiness = 0;
            int intelligence = 0;
            int appearance = 0;
            int musical = 0;
            int artistic = 0;
            int athletic = 0;
            int strength = 0;
            int endurance = 0;

            //Gets all the attribute points for the current selected user, and changes the
            //rectangular shapes accordingly
            //*********************************************************************************
            getAllAttributeValues(ref happiness, ref intelligence, ref appearance, ref musical,
                                    ref artistic, ref athletic, ref strength, ref endurance);
            //*********************************************************************************

            randomActivities();         //Assigns random activity points

            refresh_health_listView();
        }


        private void addJobsButton_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(jobsPointsLabel.Content);
            int AP = Convert.ToInt32(numberOfActivityPoints.Content);

            if (x < max)
            {
                x++;
                jobsPointsLabel.Content = x.ToString();
                numberOfActivityPoints.Content = (AP - 1).ToString();
            }

        }

        private void addReadingButton_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(readingStudyPointsLabel.Content);
            int AP = Convert.ToInt32(numberOfActivityPoints.Content);

            if ((x < max) && (AP != 0))
            {
                x++;
                readingStudyPointsLabel.Content = x.ToString();
                numberOfActivityPoints.Content = (AP - 1).ToString();
            }

        }

        private void addArtButton_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(artPointsLabel.Content);
            int AP = Convert.ToInt32(numberOfActivityPoints.Content);

            if ((x < max) && (AP != 0))
            {
                x++;
                artPointsLabel.Content = x.ToString();
                numberOfActivityPoints.Content = (AP - 1).ToString();
            }
        }

        private void addMusicButton_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(musicPointsLabel.Content);
            int AP = Convert.ToInt32(numberOfActivityPoints.Content);

            if ((x < max) && (AP != 0))
            {
                x++;
                musicPointsLabel.Content = x.ToString();
                numberOfActivityPoints.Content = (AP - 1).ToString();
            }
        }

        private void addSocializingButton_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(socializingPointsLabel.Content);
            int AP = Convert.ToInt32(numberOfActivityPoints.Content);

            if ((x < max) && (AP != 0))
            {
                x++;
                socializingPointsLabel.Content = x.ToString();
                numberOfActivityPoints.Content = (AP - 1).ToString();
            }
        }

        private void addAppearanceButton_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(imporvingAppearancePointsLabel.Content);
            int AP = Convert.ToInt32(numberOfActivityPoints.Content);

            if ((x < max) && (AP != 0))
            {
                x++;
                imporvingAppearancePointsLabel.Content = x.ToString();
                numberOfActivityPoints.Content = (AP - 1).ToString();
            }
        }

        private void addInvestmentButton_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(investmentPointsLabel.Content);
            int AP = Convert.ToInt32(numberOfActivityPoints.Content);

            if ((x < max) && (AP != 0))
            {
                x++;
                investmentPointsLabel.Content = x.ToString();
                numberOfActivityPoints.Content = (AP - 1).ToString();
            }
        }

        private void addSportButton_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(sportPointsLabel.Content);
            int AP = Convert.ToInt32(numberOfActivityPoints.Content);

            if ((x < max) && (AP != 0))
            {
                x++;
                sportPointsLabel.Content = x.ToString();
                numberOfActivityPoints.Content = (AP - 1).ToString();
            }
        }

        private void addPhysicalButton_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(physicalTrainingPointsLabel.Content);
            int AP = Convert.ToInt32(numberOfActivityPoints.Content);

            if ((x < max) && (AP != 0))
            {
                x++;
                physicalTrainingPointsLabel.Content = x.ToString();
                numberOfActivityPoints.Content = (AP - 1).ToString();
            }
        }



        private void subJobsButton_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(jobsPointsLabel.Content);
            int AP = Convert.ToInt32(numberOfActivityPoints.Content);

            if (x != min)
            {
                x--;
                jobsPointsLabel.Content = x.ToString();
                numberOfActivityPoints.Content = (AP + 1).ToString();
            }
        }

        private void subReadingButton_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(readingStudyPointsLabel.Content);
            int AP = Convert.ToInt32(numberOfActivityPoints.Content);

            if (x != min)
            {
                x--;
                readingStudyPointsLabel.Content = x.ToString();
                numberOfActivityPoints.Content = (AP + 1).ToString();
            }
        }

        private void subArtButton_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(artPointsLabel.Content);
            int AP = Convert.ToInt32(numberOfActivityPoints.Content);

            if (x != min)
            {
                x--;
                artPointsLabel.Content = x.ToString();
                numberOfActivityPoints.Content = (AP + 1).ToString();
            }
        }

        private void subMusicButton_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(musicPointsLabel.Content);
            int AP = Convert.ToInt32(numberOfActivityPoints.Content);

            if (x != min)
            {
                x--;
                musicPointsLabel.Content = x.ToString();
                numberOfActivityPoints.Content = (AP + 1).ToString();
            }
        }

        private void subSocializingButton_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(socializingPointsLabel.Content);
            int AP = Convert.ToInt32(numberOfActivityPoints.Content);

            if (x != min)
            {
                x--;
                socializingPointsLabel.Content = x.ToString();
                numberOfActivityPoints.Content = (AP + 1).ToString();
            }
        }

        private void subAppearanceButton_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(imporvingAppearancePointsLabel.Content);
            int AP = Convert.ToInt32(numberOfActivityPoints.Content);

            if (x != min)
            {
                x--;
                imporvingAppearancePointsLabel.Content = x.ToString();
                numberOfActivityPoints.Content = (AP + 1).ToString();
            }
        }

        private void subInvestmentButton_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(investmentPointsLabel.Content);
            int AP = Convert.ToInt32(numberOfActivityPoints.Content);

            if (x != min)
            {
                x--;
                investmentPointsLabel.Content = x.ToString();
                numberOfActivityPoints.Content = (AP + 1).ToString();
            }
        }

        private void subSportButton_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(sportPointsLabel.Content);
            int AP = Convert.ToInt32(numberOfActivityPoints.Content);

            if (x != min)
            {
                x--;
                sportPointsLabel.Content = x.ToString();
                numberOfActivityPoints.Content = (AP + 1).ToString();
            }
        }

        private void subPhysicalButton_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(physicalTrainingPointsLabel.Content);
            int AP = Convert.ToInt32(numberOfActivityPoints.Content);

            if (x != min)
            {
                x--;
                physicalTrainingPointsLabel.Content = x.ToString();
                numberOfActivityPoints.Content = (AP + 1).ToString();
            }
        }


//***************************************************************************************************************************************
//***************************************************************************************************************************************
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
//***************************************************************************************************************************************
//***************************************************************************************************************************************






        //Refreshes teh selectCharComboBox
        //*******************************************************************************************************************************
        public void refresh_combobox()
        {
            selectCharComboBox.Items.Clear();

            cn.Open();
            cmd = new SqlCommand("select * from healthTb", cn); //random to load db
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select name from peopleTb";
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
                while (dr.Read())
                {
                    selectCharComboBox.Items.Add(dr[0].ToString());      //dr[0], since name is at possition 0 of the selection (starting from 0)
                }

            cn.Close();

            if (selectCharComboBox.Items.Count >= 0)
                selectCharComboBox.SelectedIndex = 0;
        }
        //*******************************************************************************************************************************

        //Returns what person is in focus in the combobox on the form
        //*******************************************************************************************************************************
        public int currentIdSelected()
        {
            return selectCharComboBox.SelectedIndex + 1;
        }
        //*******************************************************************************************************************************

        //Function to randomly generate random activites for the user
        //*******************************************************************************************************************************
        public void randomActivities()
        {
            int id = 0;
            int jobs = 0;
            int reading = 0;
            int art = 0;
            int music = 0;
            int socializing = 0;
            int appearance = 0;
            int sports = 0;
            int training = 0;
            int investment = 0;
            int AP = 16;
            int APu = 0;

            //Calls getRandomActivities function in order to get random activities for the user
            //*********************************************************************************************************
            getRandomActivities(ref jobs, ref reading, ref art, ref music,
                                    ref socializing, ref appearance, ref sports, ref training, ref investment, ref AP);
            //*********************************************************************************************************

            //Calls assignValues function in order to assign all random values to the labels
            //*********************************************************************************************************
            assignValues(ref jobs, ref reading, ref art, ref music,
                                    ref socializing, ref appearance, ref sports, ref training, ref investment);
            //*********************************************************************************************************

        }
        //*******************************************************************************************************************************

        //Assigns all the random numbers to the labels
        //*******************************************************************************************************************************
        public void assignValues(ref int jobs, ref int reading, ref int art, ref int music, ref int socializing,
                                            ref int appearance, ref int sports, ref int training, ref int investment)
        {
            //Assigns the random values to the labels
            //*********************************************************************************************************
            jobsPointsLabel.Content = jobs.ToString();
            readingStudyPointsLabel.Content = reading.ToString();
            artPointsLabel.Content = art.ToString();
            musicPointsLabel.Content = music.ToString();
            socializingPointsLabel.Content = socializing.ToString();
            imporvingAppearancePointsLabel.Content = appearance.ToString();
            sportPointsLabel.Content = sports.ToString();
            physicalTrainingPointsLabel.Content = training.ToString();
            investmentPointsLabel.Content = investment.ToString();
            //*********************************************************************************************************
            numberOfActivityPoints.Content = "0";
        }
        //*******************************************************************************************************************************

        //Generates a random number in min and max
        //*******************************************************************************************************************************
        public int getRandomInt(int min, int max)
        {
            return r.Next(min, max);
        }
        //*******************************************************************************************************************************


        //Generates random values for each activity
        //*******************************************************************************************************************************
        public void getRandomActivities(ref int jobs, ref int reading, ref int art, ref int music, ref int socializing,
                                            ref int appearance, ref int sports, ref int training, ref int investment, ref int AP)
        {
            int x;

            x = getRandomInt(1, 4);


            if (x == 1)
                firstVar(ref jobs, ref reading, ref art, ref music,
                                        ref socializing, ref appearance, ref sports, ref training, ref investment, ref AP);
            else if (x == 2)
                secondVar(ref jobs, ref reading, ref art, ref music,
                                        ref socializing, ref appearance, ref sports, ref training, ref investment, ref AP);
            else
                thirdVar(ref jobs, ref reading, ref art, ref music,
                                        ref socializing, ref appearance, ref sports, ref training, ref investment, ref AP);

        }
        //*******************************************************************************************************************************


        //First variety
        //*******************************************************************************************************************************
        public void firstVar(ref int jobs, ref int reading, ref int art, ref int music, ref int socializing,
                                            ref int appearance, ref int sports, ref int training, ref int investment, ref int AP)
        {
            AP++;

            jobs = getRandomInt(0, AP);
            AP = AP - (jobs + 1);

            if (AP == 0)
            {
                reading = 0;
                art = 0;
                music = 0;
                socializing = 0;
                appearance = 0;
                sports = 0;
                training = 0;
                investment = 0;

            }
            else
            {
                ease(ref reading, ref AP);
                if (AP == 0)
                {
                    art = 0;
                    music = 0;
                    socializing = 0;
                    appearance = 0;
                    sports = 0;
                    training = 0;
                    investment = 0;

                }
                else
                {
                    ease(ref art, ref AP);
                    if (AP == 0)
                    {
                        music = 0;
                        socializing = 0;
                        appearance = 0;
                        sports = 0;
                        training = 0;
                        investment = 0;

                    }
                    else
                    {
                        ease(ref music, ref AP);
                        if (AP == 0)
                        {
                            socializing = 0;
                            appearance = 0;
                            sports = 0;
                            training = 0;
                            investment = 0;

                        }
                        else
                        {
                            ease(ref socializing, ref AP);
                            if (AP == 0)
                            {
                                appearance = 0;
                                sports = 0;
                                training = 0;
                                investment = 0;

                            }
                            else
                            {
                                ease(ref appearance, ref AP);
                                if (AP == 0)
                                {
                                    sports = 0;
                                    training = 0;
                                    investment = 0;

                                }
                                else
                                {
                                    ease(ref sports, ref AP);
                                    if (AP == 0)
                                    {
                                        training = 0;
                                        investment = 0;

                                    }
                                    else
                                    {
                                        ease(ref training, ref AP);
                                        if (AP == 0)
                                        {
                                            investment = 0;

                                        }
                                        else
                                        {
                                            do
                                            {
                                                ease(ref investment, ref AP);
                                            } while (AP != 0);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        //*******************************************************************************************************************************


        //Second variety
        //*******************************************************************************************************************************
        public void secondVar(ref int jobs, ref int reading, ref int art, ref int music, ref int socializing,
                                            ref int appearance, ref int sports, ref int training, ref int investment, ref int AP)
        {
            AP++;

            investment = getRandomInt(0, AP);
            AP = AP - (investment + 1);

            if (AP == 0)
            {
                jobs = 0;
                reading = 0;
                art = 0;
                music = 0;
                socializing = 0;
                appearance = 0;
                sports = 0;
                training = 0;
            }
            else
            {
                ease(ref training, ref AP);
                if (AP == 0)
                {
                    jobs = 0;
                    reading = 0;
                    art = 0;
                    music = 0;
                    socializing = 0;
                    appearance = 0;
                    sports = 0;
                }
                else
                {
                    ease(ref sports, ref AP);
                    if (AP == 0)
                    {
                        jobs = 0;
                        reading = 0;
                        art = 0;
                        music = 0;
                        socializing = 0;
                        appearance = 0;
                    }
                    else
                    {
                        ease(ref appearance, ref AP);
                        if (AP == 0)
                        {
                            jobs = 0;
                            reading = 0;
                            art = 0;
                            music = 0;
                            socializing = 0;
                        }
                        else
                        {
                            ease(ref socializing, ref AP);
                            if (AP == 0)
                            {
                                jobs = 0;
                                reading = 0;
                                art = 0;
                                music = 0;
                            }
                            else
                            {
                                ease(ref music, ref AP);
                                if (AP == 0)
                                {
                                    jobs = 0;
                                    reading = 0;
                                    art = 0;
                                }
                                else
                                {
                                    ease(ref art, ref AP);
                                    if (AP == 0)
                                    {
                                        jobs = 0;
                                        reading = 0;
                                    }
                                    else
                                    {
                                        ease(ref reading, ref AP);
                                        if (AP == 0)
                                        {
                                            jobs = 0;
                                        }
                                        else
                                        {
                                            do
                                            {
                                                ease(ref jobs, ref AP);
                                            } while (AP != 0);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        //*******************************************************************************************************************************



        //Third variety
        //*******************************************************************************************************************************
        public void thirdVar(ref int jobs, ref int reading, ref int art, ref int music, ref int socializing,
                                            ref int appearance, ref int sports, ref int training, ref int investment, ref int AP)
        {
            AP++;

            training = getRandomInt(0, AP);
            AP = AP - (training + 1);

            if (AP == 0)
            {
                jobs = 0;
                reading = 0;
                art = 0;
                music = 0;
                socializing = 0;
                appearance = 0;
                sports = 0;
                investment = 0;
            }
            else
            {
                ease(ref music, ref AP);
                if (AP == 0)
                {
                    jobs = 0;
                    reading = 0;
                    art = 0;
                    socializing = 0;
                    appearance = 0;
                    sports = 0;
                    investment = 0;
                }
                else
                {
                    ease(ref reading, ref AP);
                    if (AP == 0)
                    {
                        jobs = 0;
                        art = 0;
                        socializing = 0;
                        appearance = 0;
                        sports = 0;
                        investment = 0;
                    }
                    else
                    {
                        ease(ref appearance, ref AP);
                        if (AP == 0)
                        {
                            jobs = 0;
                            art = 0;
                            socializing = 0;
                            sports = 0;
                            investment = 0;
                        }
                        else
                        {
                            ease(ref socializing, ref AP);
                            if (AP == 0)
                            {
                                jobs = 0;
                                art = 0;
                                sports = 0;
                                investment = 0;
                            }
                            else
                            {
                                ease(ref investment, ref AP);
                                if (AP == 0)
                                {
                                    jobs = 0;
                                    art = 0;
                                    sports = 0;
                                }
                                else
                                {
                                    ease(ref sports, ref AP);
                                    if (AP == 0)
                                    {
                                        jobs = 0;
                                        art = 0;
                                    }
                                    else
                                    {
                                        ease(ref jobs, ref AP);
                                        if (AP == 0)
                                        {
                                            art = 0;
                                        }
                                        else
                                        {
                                            do
                                            {
                                                ease(ref art, ref AP);
                                            } while (AP != 0);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        //*******************************************************************************************************************************


        //Function to ease work
        //*******************************************************************************************************************************
        public void ease(ref int x, ref int AP)
        {
            x = getRandomInt(0, AP);
            x++;
            AP = AP - x;
        }
        //*******************************************************************************************************************************

        //Gets all the attributes values from database
        //*******************************************************************************************************************************
        public void getAllAttributeValues(ref int happiness, ref int intelligence, ref int appearance, ref int musical, ref int artistic,
                                                ref int athletic, ref int strength, ref int endurance)
        {
            //Gets all the attribute values from database
            //*****************************************************************
            happiness = get_attribute("happiness", currentIdSelected());
            intelligence = get_attribute("intelligence", currentIdSelected());
            appearance = get_attribute("appearance", currentIdSelected());
            musical = get_attribute("musical", currentIdSelected());
            artistic = get_attribute("artistic", currentIdSelected());
            athletic = get_attribute("athletic", currentIdSelected());
            strength = get_attribute("strength", currentIdSelected());
            endurance = get_attribute("endurance", currentIdSelected());
            //*****************************************************************

            //Fixes the rectangular shapes
            //*********************************************************************************
            fixAttributesShapes(ref happiness, ref intelligence, ref appearance, ref musical,
                                    ref artistic, ref athletic, ref strength, ref endurance);
            //*********************************************************************************

            //Fixes the attribute labels
            //*********************************************************************************
            fixAttributesLabels(ref happiness, ref intelligence, ref appearance, ref musical,
                                    ref artistic, ref athletic, ref strength, ref endurance);
            //*********************************************************************************
        }
        //*******************************************************************************************************************************

        // Gets value of attribute(intellegence, appearance...) according to id sent in
        //*******************************************************************************************************************************
        public int get_attribute(string attribute, int id)
        {
            int x = 0;
            cn.Open();
            cmd = new SqlCommand("select * from healthTb", cn); //random to load db
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select " + attribute + " from attributesTb where attributes_id = " + id;
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
                while (dr.Read())
                {
                    x = Convert.ToInt32(dr[0]);
                }

            cn.Close();
            return x;
        }
        //*******************************************************************************************************************************

        //Makes the rectangularshapes with according width
        //*******************************************************************************************************************************
        public void fixAttributesShapes(ref int happiness, ref int intelligence, ref int appearance, ref int musical, ref int artistic,
                                                    ref int athletic, ref int strength, ref int endurance)
        {
            //Edits the width for the rectangular shapes
            //******************************************************
            happinessRectangleShape.Width = happiness * 1.5;
            intelligenceRectangleShape.Width = intelligence * 1.5;
            appearanceRectangleShape.Width = appearance * 1.5;
            musicalRectangleShape.Width = musical * 1.5;
            artisticRectangleShape.Width = artistic * 1.5;
            athleticRectangleShape.Width = athletic * 1.5;
            strengthRectangleShape.Width = strength * 1.5;
            enduranceRectangleShape.Width = endurance * 1.5;
            //******************************************************
        }
        //*******************************************************************************************************************************

        public void fixAttributesLabels(ref int happiness, ref int intelligence, ref int appearance, ref int musical, ref int artistic,
                                                    ref int athletic, ref int strength, ref int endurance)
        {
            //Assigns all values to their labels
            //******************************************************
            happinessLabel.Content = happiness.ToString();
            intellegenceLabel.Content = intelligence.ToString();
            appearenceLabel.Content = appearance.ToString();
            musicalLabel.Content = musical.ToString();
            artisticLabel.Content = artistic.ToString();
            athleticLabel.Content = athletic.ToString();
            strengthLabel.Content = strength.ToString();
            enduranceLabel.Content = endurance.ToString();
            //******************************************************
        }


        //Gets health problems and assigns them to the listview
        //*******************************************************************************************************************************
        public void refresh_health_listView()
        {
            healthProblemsListView.Items.Clear();
            List<int> temp = getHealthIdStringInListIntForm(currentIdSelected());

            foreach (int x in temp)
            {
                string healthPbor = get_Health_Specifics_Condition_Name(x);
                healthProblemsListView.Items.Add(healthPbor);
            }
                 
        }
        //*******************************************************************************************************************************

        
        //Returns a list
        //*******************************************************************************************************************************
        public List<int> getHealthIdStringInListIntForm(int id)
        {
            List<int> ids = new List<int>();
            string x = "1,2,3,4,5";
            //string test = "1,2,3";

            //***********************************************************************************
            cn.Open();

            cmd = new SqlCommand("select * from healthTb", cn); //random to load db
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select health_specifics_id from healthTb where health_id = " + id;
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
                while (dr.Read())
                {
                    x = dr[0].ToString();
                }

            cn.Close();
            //***********************************************************************************

            string[] idStrings = x.Split(',');
            if (!(x == ""))
                foreach (string idString in idStrings)
                {
                    ids.Add(Convert.ToInt32(idString));
                }

            return ids;
        }
        //*******************************************************************************************************************************


        //*******************************************************************************************************************************
        public string get_Health_Specifics_Condition_Name(int id)
        {
            string x = "";
            cn.Open();
            cmd = new SqlCommand("select * from healthTb", cn); //random to load db
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select health_condition_name from healthSpecificsTb where health_specifics_id = " + id;
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
                while (dr.Read())
                {
                    x = dr[0].ToString();
                }

            cn.Close();
            return x;
        }
        //*******************************************************************************************************************************
	}
}