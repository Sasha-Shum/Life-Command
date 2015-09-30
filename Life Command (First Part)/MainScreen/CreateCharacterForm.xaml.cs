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
    /// Interaction logic for CreateCharacterForm.xaml
    /// </summary>
    public partial class CreateCharacterForm : Window
    {
        //Establishes a connection to the dabase
        SqlConnection cn = new SqlConnection(Singleton.connectionStringGlobal);
        SqlCommand cmd;             //Creates commands that will work with the database
        SqlDataReader dr;
        Random r = new Random();
        int x = 1;

        public CreateCharacterForm()
        {
            InitializeComponent();
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
        //*******************************************************************************************************************************

        //Random Button
        //*******************************************************************************************************************************
        private void randomButton_Click(object sender, RoutedEventArgs e)
        {
            if (maleRadioButton.IsChecked == true)
            {
                x = r.Next(1, 297);
                //**********************************************************************************************
                ImageBrush myBrush = new ImageBrush();
                myBrush.ImageSource = new BitmapImage(new Uri(@"AvatarImages/AvatarMale/ImageMale (" + x + ").jpg",
                                                                    UriKind.Relative));
                //**********************************************************************************************
                imageEllipse.Fill = myBrush;                           //Fills the ellipse with the next picture
            }
            else
            {
                x = r.Next(1, 283);
                //**********************************************************************************************
                ImageBrush myBrush = new ImageBrush();
                myBrush.ImageSource = new BitmapImage(new Uri(@"AvatarImages/AvatarFemale/ImageFemale (" + x + ").jpg",
                                                                    UriKind.Relative));
                //**********************************************************************************************
                imageEllipse.Fill = myBrush;                           //Fills the ellipse with the next picture

            }
            
            //Random name
            //***********************************************************************************************************
            string fName, lName;

            //Generates a random first name which is dependent on the gender of the user
            //**************************************************************************************************************

            if (maleRadioButton.IsChecked == true)                                //If Male selected
            {
                firstNameTextBox.Text = generateMaleFirstName();        //Calls function to create a random male name
                lastNameTextBox.Text = generateLastName();              //Calls function to create a random last name
            }
            else if ((!maleRadioButton.IsChecked == true) && (!femaleRadioButton.IsChecked == true))    //If no geneder selected prompt
            {
                MessageBox.Show("Select your gender.");                             //for one
            }
            else                                                        //If female selected
            {
                firstNameTextBox.Text = generateFemaleFirstName();      //Calls function to create a random female name
                lastNameTextBox.Text = generateLastName();              //Calls function to create a random last name
            }

            //**************************************************************************************************************
            fName = firstNameTextBox.Text;                                  //Displayes the random name in the textBox
            lName = lastNameTextBox.Text;                                   //Displayes the random name in the textBox
            //***********************************************************************************************************


            //Random Stats
            //***********************************************************************************************************
            int happiness = r.Next(0, 101);                                  //Stores the value for happiness
            int intelligence = r.Next(0, 101);                              //Stores the value for intelligence
            int appearance = r.Next(0, 101);                                 //Stores the value for appearance
            int musical = r.Next(0, 101);                                     //Stores the value for musical
            int artistic = r.Next(0, 101);                                    //Stores the value for artistic
            int athletic = r.Next(0, 101);                                   //Stores the value for athletic
            int strength = r.Next(0, 101);                                   //Stores the value for strength
            int endurance = r.Next(0, 101);                                   //Stores teh value for endurance           

            //Assigns the random values to the attributes
            //********************************************************************
            happinessTextBox.Text = happiness.ToString();
            intelligenceTextBox.Text = intelligence.ToString();
            appearanceTextBox.Text = appearance.ToString();
            musicalTextBox.Text = musical.ToString();
            artisticTextBox.Text = artistic.ToString();
            athleticTextBox.Text = athletic.ToString();
            strengthTextBox.Text = strength.ToString();
            enduranceTextBox.Text = endurance.ToString();
            //********************************************************************

            //Fixes the size of all attribute shapes
            //********************************************************************
            changeShapes(ref happiness, ref intelligence,
                                    ref appearance, ref musical, ref artistic,
                                    ref athletic, ref strength, ref endurance);
            //********************************************************************
            //***********************************************************************************************************
        
        }
              //*******************************************************************************************************************************



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




        public void save(string saveName, int personId)
        {
            string currentTime = DateTime.Now.ToString("HH:mm:ss");
            string currentDate = DateTime.Today.ToString("d");
            //MessageBox.Show(currentTime + " at " + currentDate);
            //Establishes connection to database in order to store the user's input\
            //***********************************************************************************************************
            cn.Open();          //Opens connection
            //Tells which table to connect to and where to insert the data and in what order
            cmd = new SqlCommand("Insert into saveTb (save_name,person_id,save_date,save_time)" +
                                " values(@save_name,@person_id,@save_date,@save_time)", cn);

            cmd.Parameters.AddWithValue("@save_name", saveName);
            cmd.Parameters.AddWithValue("@person_id", personId);
            cmd.Parameters.AddWithValue("@save_date", currentTime);
            cmd.Parameters.AddWithValue("@save_time", currentDate);

            cmd.ExecuteNonQuery();
            cn.Close();         //Closes connection
            //***********************************************************************************************************

        }

        //Puts the attributes of the user into database
        void saveAttributes(ref int happiness, ref int intelligence, ref int appearance, ref int musical,
                                            ref int artistic, ref int athletic, ref int strength, ref int endurance)
        {
            //Establishes connection to database in order to store the user's input\
            //***********************************************************************************************************
            cn.Open();          //Opens connection
            //Tells which table to connect to and where to insert the data and in what order
            cmd = new SqlCommand("Insert into attributesTb (happiness,intelligence,appearance,musical,artistic,athletic,strength,endurance)" +
                                " values(@happiness,@intelligence,@appearance,@musical,@artistic,@athletic,@strength,@endurance)", cn);

            cmd.Parameters.AddWithValue("@happiness", happiness);
            cmd.Parameters.AddWithValue("@intelligence", intelligence);
            cmd.Parameters.AddWithValue("@appearance", appearance);
            cmd.Parameters.AddWithValue("@musical", musical);
            cmd.Parameters.AddWithValue("@artistic", artistic);
            cmd.Parameters.AddWithValue("@athletic", athletic);
            cmd.Parameters.AddWithValue("@strength", strength);
            cmd.Parameters.AddWithValue("@endurance", endurance);

            cmd.ExecuteNonQuery();
            cn.Close();         //Closes connection
            //***********************************************************************************************************
        }


        //Fills the ellipse with a random image from AvatarImages
        //**************************************************************************************************
        void fillElipse()
        {

            x = r.Next(0, 578);

            //Makes it possible ti fill the ellipse with a random picture from AvatarImages
            //**********************************************************************************************
            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource = new BitmapImage(new Uri(@"AvatarImages/Both/Image (" + x + ").jpg",
                                                                UriKind.Relative));
            //**********************************************************************************************
            imageEllipse.Fill = myBrush;
        }
        //**************************************************************************************************

        //Checks for values for each attribute and puts it in range if it is over
        //*******************************************************************************************************************************
        void changeShapes(ref int happiness, ref int intelligence, ref int appearance, ref int musical, ref int artistic,
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

        //Validates user input for custom stats
        //*******************************************************************************************************************************
        bool validateUserAttributes(ref int happiness, ref int intelligence, ref int appearance, ref int musical,
                                            ref int artistic, ref int athletic, ref int strength, ref int endurance)
        {
            //Checks if all textBoxes have values in them
            //************************************************************************************************************************
            if (!(int.TryParse(happinessTextBox.Text, out happiness)) || (happinessTextBox.Text == ""))
            {
                MessageBox.Show("Please input value for Happiness.");
                happinessTextBox.Focus();
                return false;
            }
            else if ((intelligenceTextBox.Text == "") || !(int.TryParse(intelligenceTextBox.Text, out intelligence)))
            {
                MessageBox.Show("Please input value for Intelligence.");
                intelligenceTextBox.Focus();
                return false;
            }
            else if ((appearanceTextBox.Text == "") || !(int.TryParse(appearanceTextBox.Text, out appearance)))
            {
                MessageBox.Show("Please input value for Appearance.");
                appearanceTextBox.Focus();
                return false;
            }
            else if ((musicalTextBox.Text == "") || !(int.TryParse(musicalTextBox.Text, out musical)))
            {
                MessageBox.Show("Please input value for Musical.");
                musicalTextBox.Focus();
                return false;
            }
            else if ((artisticTextBox.Text == "") || !(int.TryParse(artisticTextBox.Text, out artistic)))
            {
                MessageBox.Show("Please input value for Artistic.");
                artisticTextBox.Focus();
                return false;
            }
            else if ((athleticTextBox.Text == "") || !(int.TryParse(athleticTextBox.Text, out athletic)))
            {
                MessageBox.Show("Please input value for Athletic.");
                athleticTextBox.Focus();
                return false;
            }
            else if ((strengthTextBox.Text == "") || !(int.TryParse(strengthTextBox.Text, out strength)))
            {
                MessageBox.Show("Please input value for Strength.");
                strengthTextBox.Focus();
                return false;
            }
            else if ((enduranceTextBox.Text == "") || !(int.TryParse(enduranceTextBox.Text, out endurance)))
            {
                MessageBox.Show("Please input value for Endurance.");
                enduranceTextBox.Focus();
                return false;
            }
            else
            {
                //Getting all the values for each attribute from each textBox
                //********************************************************************************************************************
                happiness = inRange(int.Parse(happinessTextBox.Text));
                happinessTextBox.Text = happiness.ToString();                   //Corrects the input of the user if over the limit
                intelligence = inRange(int.Parse(intelligenceTextBox.Text));
                intelligenceTextBox.Text = intelligence.ToString();             //Corrects the input of the user if over the limit
                appearance = inRange(int.Parse(appearanceTextBox.Text));
                appearanceTextBox.Text = appearance.ToString();                 //Corrects the input of the user if over the limit
                musical = inRange(int.Parse(musicalTextBox.Text));
                musicalTextBox.Text = musical.ToString();                       //Corrects the input of the user if over the limit
                artistic = inRange(int.Parse(artisticTextBox.Text));
                artisticTextBox.Text = artistic.ToString();                     //Corrects the input of the user if over the limit
                athletic = inRange(int.Parse(athleticTextBox.Text));
                athleticTextBox.Text = athletic.ToString();                     //Corrects the input of the user if over the limit
                strength = inRange(int.Parse(strengthTextBox.Text));
                strengthTextBox.Text = strength.ToString();                     //Corrects the input of the user if over the limit
                endurance = inRange(int.Parse(enduranceTextBox.Text));
                enduranceTextBox.Text = endurance.ToString();                   //Corrects the input of the user if over the limit
                //********************************************************************************************************************

                //Fixes the size of all attribute shapes
                //********************************************************************
                changeShapes(ref happiness, ref intelligence,
                                        ref appearance, ref musical, ref artistic,
                                        ref athletic, ref strength, ref endurance);
                //********************************************************************
                return true;
            }
        }
        //*******************************************************************************************************************************



        public void InitializeAttributesForPerson()
        {
            //Establishes connection to database in order to store the user's input\
            //***********************************************************************************************************
            cn.Open();          //Opens connection
            //Tells which table to connect to and where to insert the data and in what order
            cmd = new SqlCommand("Insert into attributesTb (happiness,intelligence,appearance,musical,artistic,athletic,strength,endurance)" +
                                " values(@happiness,@intelligence,@appearance,@musical,@artistic,@athletic,@strength,@endurance)", cn);

            cmd.Parameters.AddWithValue("@happiness", getRandomInt(0, 100));
            cmd.Parameters.AddWithValue("@intelligence", getRandomInt(0, 100));
            cmd.Parameters.AddWithValue("@appearance", getRandomInt(0, 100));
            cmd.Parameters.AddWithValue("@musical", getRandomInt(0, 100));
            cmd.Parameters.AddWithValue("@artistic", getRandomInt(0, 100));
            cmd.Parameters.AddWithValue("@athletic", getRandomInt(0, 100));
            cmd.Parameters.AddWithValue("@strength", getRandomInt(0, 100));
            cmd.Parameters.AddWithValue("@endurance", getRandomInt(0, 100));

            cmd.ExecuteNonQuery();
            cn.Close();         //Closes connection
            //***********************************************************************************************************
        }

        public void InitializeActivitiesForPerson()
        {
            //Establishes connection to database in order to store the user's input\
            //***********************************************************************************************************
            cn.Open();          //Opens connection
            //Tells which table to connect to and where to insert the data and in what order
            cmd = new SqlCommand("Insert into activitiesTb (job_focus, readingstudying_focus, art_focus, music_focus, socializing_focus, appearance_focus, sports_focus, physical_training_focus, investment_focus, activity_points_amount)" +
                                                  " values(@job_focus,@readingstudying_focus,@art_focus,@music_focus,@socializing_focus,@appearance_focus,@sports_focus,@physical_training_focus,@investment_focus,@activity_points_amount)", cn);

            cmd.Parameters.AddWithValue("@job_focus", 0);
            cmd.Parameters.AddWithValue("@readingstudying_focus", 0);
            cmd.Parameters.AddWithValue("@art_focus", 0);
            cmd.Parameters.AddWithValue("@music_focus", 0);
            cmd.Parameters.AddWithValue("@socializing_focus", 0);
            cmd.Parameters.AddWithValue("@appearance_focus", 0);
            cmd.Parameters.AddWithValue("@sports_focus", 0);
            cmd.Parameters.AddWithValue("@physical_training_focus", 0);
            cmd.Parameters.AddWithValue("@investment_focus", 0);
            cmd.Parameters.AddWithValue("@activity_points_amount", getRandomInt(4, 20));
            cmd.ExecuteNonQuery();
            cn.Close();         //Closes connection
            //***********************************************************************************************************
        }

        public void InitializeJobForPerson()
        {
            string job1 = getRandomJob();
            string job2 = getRandomJob();
            float rand1 = getRandomFloat(0, 2);
            float rand2 = getRandomFloat(0, 2);
            //Establishes connection to database in order to store the user's input
            //***********************************************************************************************************
            cn.Open();          //Opens connection
            //Tells which table to connect to and where to insert the data and in what order
            cmd = new SqlCommand("Insert into jobsTb (full_time_job1, full_time_job1_raise_modifier, part_time_job1, part_time_job1_raise_modifier)" +
                                                  " values(@full_time_job1,@full_time_job1_raise_modifier,@part_time_job1,@part_time_job1_raise_modifier)", cn);
            int x = 16;
            cmd.Parameters.AddWithValue("@full_time_job1", job1);
            cmd.Parameters.AddWithValue("@full_time_job1_raise_modifier", rand1);
            cmd.Parameters.AddWithValue("@part_time_job1", job2);
            cmd.Parameters.AddWithValue("@part_time_job1_raise_modifier", rand2);
            cmd.ExecuteNonQuery();
            cn.Close();         //Closes connection
            //***********************************************************************************************************
        }

        public void InitializeSchoolingForPerson()
        {
            string job1 = getRandomSchool();
            string job2 = getRandomSchool();
            float rand1 = getRandomFloat(0, 2);
            float rand2 = getRandomFloat(0, 2);
            //Establishes connection to database in order to store the user's input
            //***********************************************************************************************************
            cn.Open();          //Opens connection
            //Tells which table to connect to and where to insert the data and in what order
            cmd = new SqlCommand("Insert into schoolingTb (trade_deplomas, associates_deplomas, bachelor_deplomas, master_deplomas, doctorate_deplomas, full_time_school1, full_time_school1_years_left, part_time_school1, part_time_school1_years_left)" +
                                                  " values(@trade_deplomas,@associates_deplomas,@bachelor_deplomas,@master_deplomas,@doctorate_deplomas,@full_time_school1,@full_time_school1_years_left,@part_time_school1,@part_time_school1_years_left)", cn);
            int x = 16;
            cmd.Parameters.AddWithValue("@trade_deplomas", getRandomInt(0, 5));
            cmd.Parameters.AddWithValue("@associates_deplomas", getRandomInt(0, 5));
            cmd.Parameters.AddWithValue("@bachelor_deplomas", getRandomInt(0, 5));
            cmd.Parameters.AddWithValue("@master_deplomas", getRandomInt(0, 5));
            cmd.Parameters.AddWithValue("@doctorate_deplomas", getRandomInt(0, 5));
            cmd.Parameters.AddWithValue("@full_time_school1", job1);
            cmd.Parameters.AddWithValue("@full_time_school1_years_left", getRandomInt(0, 5));
            cmd.Parameters.AddWithValue("@part_time_school1", job2);
            cmd.Parameters.AddWithValue("@part_time_school1_years_left", getRandomInt(0, 5));
            cmd.ExecuteNonQuery();
            cn.Close();         //Closes connection
            //***********************************************************************************************************
        }

        public void InitializeBankForPerson()
        {

            //Establishes connection to database in order to store the user's input
            //***********************************************************************************************************
            cn.Open();          //Opens connection
            //Tells which table to connect to and where to insert the data and in what order
            cmd = new SqlCommand("Insert into bankAccountTb (balance, loan_debt, credit_score, high_risk_stocks_owned)" +
                                                   " values(@balance,@loan_debt,@credit_score,@high_risk_stocks_owned)", cn);

            cmd.Parameters.AddWithValue("@balance", getRandomInt(0, 1000000));
            cmd.Parameters.AddWithValue("@loan_debt", getRandomInt(0, 50000));
            cmd.Parameters.AddWithValue("@credit_score", getRandomInt(0, 1000));
            cmd.Parameters.AddWithValue("@high_risk_stocks_owned", getRandomInt(0, 5));

            cmd.ExecuteNonQuery();
            cn.Close();         //Closes connection
            //***********************************************************************************************************
        }

        public string getRandomJob()
        {
            string randJob = "";
            int maxID = getLastIdInTable("jobStorageTb", "job_storage_id");
            int randId = getRandomInt(1, maxID);
            cn.Open();
            cmd = new SqlCommand("select * from healthTb", cn); //random to load db
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select job_name from jobStorageTb where job_storage_id =" + randId;
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
                while (dr.Read())
                {
                    randJob = dr[0].ToString();
                }

            cn.Close();

            return randJob;
        }

        public string getRandomSchool()
        {
            string randSchool = "";
            int maxID = getLastIdInTable("schoolingStorageTb", "schooling_storage_id");
            int randId = getRandomInt(1, maxID);
            cn.Open();
            cmd = new SqlCommand("select * from healthTb", cn); //random to load db
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select name from schoolingStorageTb where schooling_storage_id =" + randId;
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
                while (dr.Read())
                {
                    randSchool = dr[0].ToString();
                }

            cn.Close();

            return randSchool;
        }

        //Puts the passed number in range under or equal to 100
        //*******************************************************************************************************************************
        int inRange(int x)
        {
            while ((x > 100) || (x < 0))
            {
                if (x > 100)
                    x = x / 2;
                else
                    x = 0;
            }
            return x;
        }
        //*******************************************************************************************************************************

        //Returns a random male name from file           "census-dist-male-first.txt"
        //*******************************************************************************************************************************
        public string generateMaleFirstName()
        {
            string fileName = @"census-dist-male-first.txt";                //Path of the file

            return getRandomLineFromTextFile(fileName);                     //Calls a function to get a random name from the file
            //and returns the result
        }
        //*******************************************************************************************************************************

        //Returns a random female name from file          "census-dist-female-first.txt"
        //*******************************************************************************************************************************
        public string generateFemaleFirstName()
        {
            string fileName = @"census-dist-female-first.txt";              //Path of the file

            return getRandomLineFromTextFile(fileName);                     //Calls a function to get a random name from the file 
            //and returns the result
        }
        //*******************************************************************************************************************************

        //Generates a random last name from file           "surnames.txt"
        //*******************************************************************************************************************************
        public string generateLastName()
        {
            string fileName = @"surnames.txt";                              //Path of the file

            return getRandomLineFromTextFile(fileName);                     //Calls a function to get a random name from the file 
            //and returns the result
        }
        //*******************************************************************************************************************************

        //Generates a Random name
        //*******************************************************************************************************************************
        public string getRandomLineFromTextFile(string filename)
        {
            StreamReader f;
            string line = "initialized";                                        //Holds a name from the file
            int lineCount = File.ReadLines(filename).Count();                   //Gets amount of lines(names)

            int randomNameNumber = getRandomInt(0, lineCount);                  //Gets a random intiger by calling a function

            f = File.OpenText(filename);                                        //Opens the file
            for (int i = 0; i <= randomNameNumber; i++)
            {
                if (i == randomNameNumber)
                    line = f.ReadLine();
                else
                    f.ReadLine();
            }
            f.Close();                                                          //Closes the file

            return line;
        }
        //*******************************************************************************************************************************

        //Generates a random number in min and max
        //*******************************************************************************************************************************
        public int getRandomInt(int min, int max)
        {
            return r.Next(min, max);
        }

        //*******************************************************************************************************************************

        // Avatar Picture 
        //*******************************************************************************************************************************
        private void moveForwardArrow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (maleRadioButton.IsChecked == true)
            {
                if (x < 297)
                    x++;
                else
                    x = 1;

                //**********************************************************************************************
                ImageBrush myBrush = new ImageBrush();
                myBrush.ImageSource = new BitmapImage(new Uri(@"AvatarImages/AvatarMale/ImageMale (" + x + ").jpg",
                                                                    UriKind.Relative));
                //**********************************************************************************************
                imageEllipse.Fill = myBrush;                           //Fills the ellipse with the next picture
            }
            else
            {
                if (x < 283)
                    x++;
                else
                    x = 1;
                
                //**********************************************************************************************
                ImageBrush myBrush = new ImageBrush();
                myBrush.ImageSource = new BitmapImage(new Uri(@"AvatarImages/AvatarFemale/ImageFemale (" + x + ").jpg",
                                                                    UriKind.Relative));
                //**********************************************************************************************
                imageEllipse.Fill = myBrush;                           //Fills the ellipse with the next picture
            }
        }

        private void moveBackwardsArrow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (maleRadioButton.IsChecked == true)
            {
                if (x > 1)
                    x--;
                else
                    x = 296;

                //**********************************************************************************************
                ImageBrush myBrush = new ImageBrush();
                myBrush.ImageSource = new BitmapImage(new Uri(@"AvatarImages/AvatarMale/ImageMale (" + x + ").jpg",
                                                                    UriKind.Relative));
                //**********************************************************************************************
                imageEllipse.Fill = myBrush;                           //Fills the ellipse with the next picture
            }
            else
            {
                if (x > 1)
                    x--;
                else
                    x = 282;
                //**********************************************************************************************
                ImageBrush myBrush = new ImageBrush();
                myBrush.ImageSource = new BitmapImage(new Uri(@"AvatarImages/AvatarFemale/ImageFemale (" + x + ").jpg",
                                                                    UriKind.Relative));
                //**********************************************************************************************
                imageEllipse.Fill = myBrush;                           //Fills the ellipse with the next picture
            }
        }

        private void imageEllipse_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (maleRadioButton.IsChecked == true)
            {
                x = r.Next(1, 297);
                //**********************************************************************************************
                ImageBrush myBrush = new ImageBrush();
                myBrush.ImageSource = new BitmapImage(new Uri(@"AvatarImages/AvatarMale/ImageMale (" + x + ").jpg",
                                                                    UriKind.Relative));
                //**********************************************************************************************
                imageEllipse.Fill = myBrush;                           //Fills the ellipse with the next picture
            }
            else
            {
                x = r.Next(1, 283);
                //**********************************************************************************************
                ImageBrush myBrush = new ImageBrush();
                myBrush.ImageSource = new BitmapImage(new Uri(@"AvatarImages/AvatarFemale/ImageFemale (" + x + ").jpg",
                                                                    UriKind.Relative));
                //**********************************************************************************************
                imageEllipse.Fill = myBrush;                           //Fills the ellipse with the next picture

            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            fillElipse();       //Assigns a random picture for an avatar
           
        }

        private void createButton_Click(object sender, RoutedEventArgs e)
        {
            reset_identity(); // clears DB

            bool validated = false;                                                      //Stores the value for whether textboxes are correct
            int happiness = 0;                                                           //Stores the value for happiness
            int intelligence = 0;                                                        //Stores the value for intelligence
            int appearance = 0;                                                          //Stores the value for appearance
            int musical = 0;                                                             //Stores the value for musical
            int artistic = 0;                                                            //Stores the value for artistic
            int athletic = 0;                                                            //Stores the value for athletic
            int strength = 0;                                                            //Stores the value for strength
            int endurance = 0;                                                           //Stores teh value for endurance

            string firstName, lastName;                                                  //Store first and second name of the user
            bool personGender = false;                                                   //Used for person gender

            firstName = firstNameTextBox.Text;                                           //Gets the input from the user for first name
            lastName = lastNameTextBox.Text;                                             //Gets the input from the user for second name

            if ((!maleRadioButton.IsChecked == true) && (!femaleRadioButton.IsChecked == true))              //If no gender selected
                MessageBox.Show("Select a gender.");                                     //Prompt again
            else if (maleRadioButton.IsChecked == true)                                            //If user selected male as gender
                personGender = true;                                                     //set the bool to true ( make him male )
            else                                                                         //If user selected female as gender
                personGender = false;                                                    //set the bool to false ( make her female )

            //Validates the user input
            //*******************************************************************
            validated = validateUserAttributes(ref happiness, ref intelligence,
                                      ref appearance, ref musical, ref artistic,
                                      ref athletic, ref strength, ref endurance);
            if (validated)
            {
                //*******************************************************************

                //Puts the attributes data into the correct table
                //*******************************************************************
                saveAttributes(ref happiness, ref intelligence,
                                        ref appearance, ref musical, ref artistic,
                                        ref athletic, ref strength, ref endurance);
                //*******************************************************************
                create_households("!generateName!", "!generateName!", 30, 3);
                create_households(firstName, lastName, 1, 1);

                /*
                //Establishes connection to database in order to store the user's input\
                //***********************************************************************************************************
                cn.Open();          //Opens connection
                //Tells which table to connect to and where to insert the data and in what order
                cmd = new SqlCommand("Insert into peopleTb (name,gender) values(@name,@gender)", cn);
                cmd.Parameters.AddWithValue("@name", firstName);                //Insert the first name at the proper place
                cmd.Parameters.AddWithValue("@gender", personGender);           //Insert the gender in the proper place
                //cmd.Parameters.AddWithValue("household_id",
                cmd.ExecuteNonQuery();
                cn.Close();         //Closes connection
                //***********************************************************************************************************
                */


                save("autoSave", getLastIdInTable("peopleTb", "person_id")); // Creates save and sends person_id

                ViewManager form = new ViewManager();
                this.Close();
                form.Show();
            
               
            }
        }
        //*******************************************************************************************************************************


        public int getLastIdInTable(string table, string idName)
        {
            int x = 100000;
            //Establishes connection to database in order to store the user's input\
            //***********************************************************************************************************
            cn.Open();          //Opens connection
            //Tells which table to connect to and where to insert the data and in what order
            cmd = new SqlCommand("select * from healthTb", cn); //random to load db
            cmd.ExecuteNonQuery();

            cmd.CommandText = "select max(" + idName + ") from " + table;
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
                while (dr.Read())
                {
                    //columnNames(ref vectornames,"playerDb");
                    //listView1.Columns.AddRange();
                    if (dr[0] == DBNull.Value)
                        x = 1;
                    else
                        x = Convert.ToInt32(dr[0]);
                    //else
                    //  x = 1;
                }
            //listView1.a
            //listBox1.Items.Add(dr[8].ToString());

            //cmd.ExecuteNonQuery();
            cn.Close();         //Closes connection
            //***********************************************************************************************************

            return x;

        }

        public float getRandomFloat(int min, int max)
        {
            return (float)(getRandomInt(min, max - 1)) + (float)(.100 * getRandomInt(0, 9)); //Creates random float in range
        }

        public void create_person(string firstName, bool gender, int household_id)       //Create a person and insert them into database
        {
            if (gender)                                                                  // Female == true
                if (firstName == "!generateName!")
                    insertPersonIntoDb(generateFemaleFirstName(), true, household_id);   //Generate the first name for female
                else                                                                     // otherwise
                    insertPersonIntoDb(firstName, true, household_id);                   //Use first name given
            else                                                                         // Male == true
                if (firstName == "!generateName!")
                    insertPersonIntoDb(generateMaleFirstName(), false, household_id);    //Generate the first name for male
                else                                                                         // otherwise
                    insertPersonIntoDb(firstName, false, household_id);                  //Use first name given
        }

        public void create_households(string firstName, string lastName, int amountOfHouseholds, int maxPerHousehold) //sending in First name and last name is useful when you have one household being made
        {                                                                                             //Generates a bulk of people and places them
            //into households(families)
            for (int i = 0; i < amountOfHouseholds; i++)                                              // Runs through however many households wanted
            {
                if (lastName == "!generateName!")
                    insertHouseholdIntoDb(generateLastName(), i + 1);                                        //Generate the last name
                else                                                                                  // otherwise
                    insertHouseholdIntoDb(lastName, i + 1);                                                  //Use last name given

                for (int x = 0; x < getRandomInt(1, maxPerHousehold); x++)
                {
                    initialize_other_tables_for_person();

                    if (firstName == "!generateName!")
                    {
                        create_person("!generateName!", Convert.ToBoolean(getRandomInt(0, 1)), i + 1);    //Generate people for a household within range given

                        insertHealthIntoDb(getLastIdInTable("healthTb", "health_id"), getRandomInt(0, 100)
                                         , getRandomBool(), getRandomBool()); //generates a health row for person
                    }
                    else
                    {
                        create_person(firstName, Convert.ToBoolean(getRandomInt(0, 1)), i + 1);

                        insertHealthIntoDb(getLastIdInTable("healthTb", "health_id"), getRandomInt(0, 100)
                                         , getRandomBool(), getRandomBool()); //generates a health row for person
                    }

                }
            }
        }

        public void initialize_other_tables_for_person()
        {
            //Puts the Attributes data into the correct table
            //*******************************************************************
            InitializeAttributesForPerson();
            //*******************************************************************

            //Puts the Activities data into the correct table
            //*******************************************************************
            InitializeActivitiesForPerson();
            //*******************************************************************

            //Puts the jobs data into the correct table
            //*******************************************************************
            InitializeJobForPerson();
            //*******************************************************************

            //Puts the Schooling data into the correct table
            //*******************************************************************
            InitializeSchoolingForPerson();
            //*******************************************************************

            //Puts the bank data into the correct table
            //*******************************************************************
            InitializeBankForPerson();
            //*******************************************************************

        }

        public void insertHouseholdIntoDb(string lastName, int bank_id)
        {
            cn.Open();

            cmd = new SqlCommand("Insert into householdsTb (bank_account_id, household_name) values(@bank_account_id,@household_name)", cn);
            cmd.Parameters.AddWithValue("@household_name", lastName);
            cmd.Parameters.AddWithValue("@bank_account_id", bank_id);
            cmd.ExecuteNonQuery();

            cn.Close();
        }

        public void insertPersonIntoDb(string firstName, bool gender, int household_id)
        {
            cn.Open();

            cmd = new SqlCommand("Insert into peopleTb (name, gender, household_id) values(@name, @gender, @household_id)", cn);
            cmd.Parameters.AddWithValue("@name", firstName);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@household_id", household_id);
            cmd.ExecuteNonQuery();

            cn.Close();
        }

        public void insertHealthIntoDb(int id, int healthConditionPercent, bool isAlive, bool isPregnant)
        {
            string healthString = generateHealthString();
            cn.Open();

            cmd = new SqlCommand("Insert into healthTb (health_specifics_id, health_condition_percent, is_alive, is_pregnant) values(@health_specifics_id, @health_condition_percent, @is_alive, @is_pregnant)", cn);
            cmd.Parameters.AddWithValue("@health_specifics_id", healthString);
            cmd.Parameters.AddWithValue("@health_condition_percent", healthConditionPercent);
            cmd.Parameters.AddWithValue("@is_alive", isAlive);
            cmd.Parameters.AddWithValue("@is_pregnant", isPregnant);
            cmd.ExecuteNonQuery();

            cn.Close();
        }

        //health specifics amount of id's creates long string variable for healthTb made with a for loop

        public string generateHealthString()
        {
            string x = "";
            int size = getLastIdInTable("healthSpecificsTb", "health_specifics_id");
            if (getRandomBool()) //Random - Whether any health problems generated
                for (int i = 1; i <= size; i++)           //Goes through each health problem in healthSpecificsTb(diabetes,depression,ect..)
                {
                    if (getRandomBool()) //Random - whether health problem added
                    {
                        if (x == "")                           //If it's the first time through
                            x = i.ToString();
                        else
                            x = x + "," + i;                   //otherwise append
                    }
                }
            return x;
        }

        public List<int> getHealthIdString(int id)
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

            foreach (string idString in idStrings)
            {
                ids.Add(Convert.ToInt32(idString));
            }

            return ids;
        }

        public bool getRandomBool()
        {
            int x = getRandomInt(0, 100);
            int y = getRandomInt(0, 100);
            int r = getRandomInt(0, 100);
            int b = getRandomInt(0, 100);

            if (x > b || y < r)
            {
                return true; //Convert.ToBoolean(getRandomInt(50, 100) > getRandomInt(0, 100));
            }
            else
                return false;
        }


        public void reset_identity()
        {
            //Clears the data from People Table
            cn.Open();                                                                      //Opens connection
            cmd = new SqlCommand("DBCC CHECKIDENT ('peopleTb', RESEED, 0)", cn);
            cmd.ExecuteNonQuery();                                                          //Executes the cmd
            cn.Close();                                                                     //Closes connection

            cn.Open();                                                                      //Opens connection
            cmd = new SqlCommand("DELETE FROM peopleTb", cn);                               //Deletes from the table
            cmd.ExecuteNonQuery();                                                          //Executes the cmd
            cn.Close();                                                                     //Closes connection

            //CLears the data from Attributes table
            cn.Open();                                                                      //Opens connection
            cmd = new SqlCommand("DBCC CHECKIDENT ('attributesTb', RESEED, 0)", cn);
            cmd.ExecuteNonQuery();                                                          //Executes the cmd
            cn.Close();                                                                     //Closes connection

            cn.Open();                                                                      //Opens connection
            cmd = new SqlCommand("DELETE FROM attributesTb", cn);                            //Deletes from the table
            cmd.ExecuteNonQuery();                                                          //Executes the cmd
            cn.Close();                                                                     //Closes connection

            // Clears the data form Household table
            cn.Open();                                                                      //Opens connection
            cmd = new SqlCommand("DBCC CHECKIDENT ('householdsTb', RESEED, 0)", cn);
            cmd.ExecuteNonQuery();                                                          //Executes the cmd
            cn.Close();                                                                     //Closes connection

            cn.Open();                                                                      //Opens connection
            cmd = new SqlCommand("DELETE FROM householdsTb", cn);                           //Deletes from the table
            cmd.ExecuteNonQuery();                                                          //Executes the cmd
            cn.Close();                                                                     //Closes connection

            // Clears the data form Activities table
            cn.Open();                                                                      //Opens connection
            cmd = new SqlCommand("DBCC CHECKIDENT ('activitiesTb', RESEED, 0)", cn);
            cmd.ExecuteNonQuery();                                                          //Executes the cmd
            cn.Close();                                                                     //Closes connection

            cn.Open();                                                                      //Opens connection
            cmd = new SqlCommand("DELETE FROM activitiesTb", cn);                           //Deletes from the table
            cmd.ExecuteNonQuery();                                                          //Executes the cmd
            cn.Close();                                                                     //Closes connection


            // Clears the data form health table
            cn.Open();                                                                      //Opens connection
            cmd = new SqlCommand("DBCC CHECKIDENT ('healthTb', RESEED, 0)", cn);
            cmd.ExecuteNonQuery();                                                          //Executes the cmd
            cn.Close();                                                                     //Closes connection

            cn.Open();                                                                      //Opens connection
            cmd = new SqlCommand("DELETE FROM healthTb", cn);                               //Deletes from the table
            cmd.ExecuteNonQuery();                                                          //Executes the cmd
            cn.Close();                                                                     //Closes connection

            // Clears the data form health table
            cn.Open();                                                                      //Opens connection
            cmd = new SqlCommand("DBCC CHECKIDENT ('jobsTb', RESEED, 0)", cn);
            cmd.ExecuteNonQuery();                                                          //Executes the cmd
            cn.Close();                                                                     //Closes connection

            cn.Open();                                                                      //Opens connection
            cmd = new SqlCommand("DELETE FROM jobsTb", cn);                               //Deletes from the table
            cmd.ExecuteNonQuery();                                                          //Executes the cmd
            cn.Close();                                                                     //Closes connection

            // Clears the data form health table
            cn.Open();                                                                      //Opens connection
            cmd = new SqlCommand("DBCC CHECKIDENT ('schoolingTb', RESEED, 0)", cn);
            cmd.ExecuteNonQuery();                                                          //Executes the cmd
            cn.Close();                                                                     //Closes connection

            cn.Open();                                                                      //Opens connection
            cmd = new SqlCommand("DELETE FROM schoolingTb", cn);                                 //Deletes from the table
            cmd.ExecuteNonQuery();                                                          //Executes the cmd
            cn.Close();                                                                     //Closes connection

      
        }
    }
}
