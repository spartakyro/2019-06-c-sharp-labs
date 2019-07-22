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

        public string Answers;

        public Wordjumble()
        {
            InitializeComponent();
            backgroundVid.Play();

            var WordMix = started(""); //bringing back origin*/

            Wordjumbler.Content = WordMix;

            string selectedplayer1 = (App.Current as App).player1;
            playerturn.Content = selectedplayer1;



        }

        public string started(string mixedOrigin)
        {

            string originalW = " ";
            Random random = new Random();
            int randomNumber = random.Next(0, 6);

            questions.Add("Asylum");
            questions.Add("Sparta");
            questions.Add("Audience");
            questions.Add("Peanut");
            questions.Add("Observation");
            questions.Add("Thesis");

            var quiz = new QuestionsBank("Ayslum", "Asylum", 100);
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
            AnswersForQuestions.Add(quiz05);

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

        public QuestionsBank(string questions, string answers, int points)
        {
            this.Questions = questions;
            this.Answers = answers;
            this.Points = points;


        }

    }

}
