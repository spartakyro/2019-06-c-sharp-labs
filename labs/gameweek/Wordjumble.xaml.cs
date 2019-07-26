using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace gameweek
{
    /// <summary>
    /// Interaction logic for Wordjumble.xaml
    /// </summary>
    public partial class Wordjumble : Page
    {
       
        public List<string> questions = new List<string>();
        public List<QuestionsBank> AnswersForQuestions = new List<QuestionsBank>();
        static List<LB> Highscore = new List<LB>();
            
        //tic_tac_toe tic_Tac = new tic_tac_toe();

        public string Answers;

        public bool jumbleHide;
        public bool rejumble;

        public string selectedplayer1 = (App.Current as App).player1;
        public string selectedplayer2 = (App.Current as App).player2;

        public bool whosturn = true;

        public bool istictac;
        private static int counter;
        private int Score;
        private float P1S = 1;
        public int P1Score;
        public int P2Score;

        public Wordjumble()
        {
           
            InitializeComponent();
            backgroundVid.Play();
            
            
            tester();
            //string selectedplayer1 = (App.Current as App).player1;
            
            playerturn.Content = selectedplayer1;


            istictac = false;

           




        }

        void tester ()
        {

            
            var WordMix = started(""); //bringing back origin*/

            Wordjumbler.Content = WordMix;

           




        }

        public string started(string mixedOrigin)
        {

            string originalW = " ";
            Random random = new Random();
            int randomNumber = random.Next(0, 16);

            questions.Add("Asylum");
            questions.Add("Sparta");
            questions.Add("Audience");
            questions.Add("Peanut");
            questions.Add("Observation");
            questions.Add("Thesis");
            questions.Add("Hospital");
            questions.Add("Painter");
            questions.Add("Waterfall");
            questions.Add("Tired");
            questions.Add("Climate");
            questions.Add("Captivate");
            questions.Add("Imperial");
            questions.Add("Attachment");
            questions.Add("Reform");
            questions.Add("Mercy");
    

            /*var quiz = new QuestionsBank("Ayslum", "Asylum", 100);
            var quiz01 = new QuestionsBank("Sparta", "Sparta", 100);
            var quiz02 = new QuestionsBank("Audience", "Audience", 100);
            var quiz03 = new QuestionsBank("Peanut", "Peanut", 100);
            var quiz04 = new QuestionsBank("Observation", "Observation", 100);
            var quiz05 = new QuestionsBank("Thesis", "Thesis", 100);

            AnswersForQuestions.Add(quiz);
            AnswersForQuestions.Add(quiz01);
            AnswersForQuestions.Add(quiz02);
            AnswersForQuestions.Add(quiz03);
            AnswersForQuestions.Add(quiz04);
            AnswersForQuestions.Add(quiz05);*/


            Random randomize = new Random();
            //var rand = randomize.Next(0,5);
            int Index = randomize.Next(questions.Count);
            
            var showq = questions[Index];
            Answers = showq;
            
            string mixedOriginal = Shuffle.StringMixer(showq);

           
                


            return mixedOriginal;



        }

        private void Answertxt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Label_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            
        }

        void Nextwindow()
        {
            
        }

        public async void Checkbtn_Click(object sender, RoutedEventArgs e)
        {

            if (whosturn == true)
            {
                playerturn.Content = selectedplayer1;
                ScoreCount.Content = P1Score;

            }
            else
            {
                playerturn.Content = selectedplayer2;
                ScoreCount.Content = P2Score;
            }


            if (Answertxt.Text == Answers)
            {
                Correctping.Play();
                Answertxt.Background = Brushes.ForestGreen;
                //istictac = true;
                Answertxt.Text = "";
                Answertxt.Background = Brushes.Aqua;
                
                
                tester();



                if (whosturn == true)
                {
                    
                    P1Score += 100;
                    ScoreCount.Content = P1Score;
                }
                else
                {
                    
                    P2Score += 100;
                    ScoreCount.Content = P2Score;
                }



                //navwindow.Navigate(new tic_tac_toe().KeepAlive);


            } else           
            //if(Answertxt.Text != Answers)
            {
                incorrectping.Play();
                
                Answertxt.Background = Brushes.Red;
                await Task.Delay(500);
                Answertxt.Background = Brushes.Aqua;

                P1S+= 1f;

                finalp2Score_Copy.Content = P1S;
                if(P1S%2==0)
                {
                    if(whosturn == true)
                    {
                        whosturn = false;
                        tester();
                        Answertxt.Text = "";

                    }
                    else
                    {
                        whosturn = true;
                        tester();
                        Answertxt.Text = "";
                    }
                }

                if(P1S == 6)
                {
                    finalp1Score.Content = ($"{selectedplayer1}: {P1Score}");
                }

                if(P1S == 8)
                {
                    finalp2Score.Content = ($"{selectedplayer2}: {P2Score}");

                    if(P1Score > P2Score)
                    {
                        MessageBox.Show($"{selectedplayer1} Wins");

                    }
                    else
                    {
                        MessageBox.Show($"{selectedplayer2} Wins");
                    }

                    Answertxt.IsEnabled = false;
                    using (var db = new WordJumbleScoreBoardEntities3())
                    {
                        var updatePlayer = db.LBs.OrderByDescending(p => p.Id).Skip(1).First();
                        updatePlayer.Score = P1Score;
                        var updatePlayer2 = db.LBs.OrderByDescending(p => p.Id).First();
                        updatePlayer2.Score = P2Score;
                        db.SaveChanges();
                    }

                    //this.Content = new Wordjumble();
                }
               


                /*counter++;
                
                if(counter == 2 && whosturn == true)
                {
                    whosturn = false;

                    finalCount.Content = ($"{selectedplayer1}: {Score}");
                }
                else if(counter == 2 && whosturn == false)
                {

                    whosturn = true;
                   // counter = 0;
                    
                }*/

                

                
            }

           

        }

        private void Incorrectping_MediaEnded(object sender, RoutedEventArgs e)
        {
            incorrectping.Position = new TimeSpan(0);
            incorrectping.Stop();
        }

        private void BackgroundVid_MediaEnded(object sender, RoutedEventArgs e)
        {
            backgroundVid.Position = new TimeSpan(0);
        }
    
        

        private void Correctping_MediaEnded(object sender, RoutedEventArgs e)
        {
            Correctping.Position = new TimeSpan(0);
            Correctping.Stop();
        }

       

       

        
    }
    class Shuffle
    {
        static Random rnd = new Random();

        static void Randomizer(int[] array)
        {
            int wordsize = array.Length;
            int random;
            int temp;



            for (int i = 0; i < wordsize; i++)
            {
                random = i + (int)(rnd.NextDouble() * (wordsize - i));

                Console.WriteLine($"this is the word size: {wordsize}", -15);

                Console.WriteLine("this is the rnd.double: {0}", (rnd.NextDouble()));
                Console.WriteLine($"this is the random: {i} + {(rnd.NextDouble() * (wordsize - i))}", -15);



                temp = array[random];

                array[random] = array[i];

                array[i] = temp;


                //Console.WriteLine($"this is the last sum: {array[i] = temp}");

                /* randomizer for the words, wordsize = size of the words in switch, temp is the array holding a random number
                   */
            }
        }

        public static string StringMixer(string s)
        {
            string output = "";
            int arraysize = s.Length;
            int[] randomArray = new int[arraysize];

            Console.WriteLine($"this is the output: {output}");
            Console.WriteLine($"this is the array size: {s.Length}");


            for (int i = 0; i < arraysize; i++)
            {
                randomArray[i] = i;
                //Console.WriteLine($"this is the random array: {randomArray[i]}");

            }

            Randomizer(randomArray);

            Console.WriteLine($"\nthis is the word chosen: {s}");


            for (int i = 0; i < arraysize; i++)
            {
                output += s[randomArray[i]];
                Console.WriteLine($"output is -> {output} after {s} and {randomArray[i]} have been added\n");
            }

            return output;
        }
    }

    public class QuestionsBank
    {
        public string Questions { get; set; }
        public string Answers { get; set; }
        public int Points { get; set; }

        public QuestionsBank(string questions, string answers,  int points)
        {
            this.Questions = questions;
            this.Answers = answers;
            this.Points = points;


        }

        

    }

}
