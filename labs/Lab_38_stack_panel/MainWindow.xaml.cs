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

namespace Lab_38_stack_panel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> questions = new List<string>();
        public List<QuestionBank> questionsWithAnswers = new List<QuestionBank>();
        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }

        void Initialise()
        {
           
            questions.Add("what is 12");
            questions.Add("what is the capital of england");
            questions.Add("who is the president of singapore");
            questions.Add("what is 12 / 2 * 2");
            questions.Add("what is 45 X 45");
            questions.Add("what is my birthday");

            var quiz = new QuestionBank("what is 12", "a number", 100);
            var quiz01 = new QuestionBank("what is the capital of england", "london", 100);
            var quiz02 = new QuestionBank("who is the president of singapore", "halimah Yacob", 100);
            var quiz03 = new QuestionBank("what is 12 / 2 * 2 + 2 + 1 - 4 + 1", "12", 100);
            var quiz04 = new QuestionBank("what is 45 X 45", "2025", 100);
            var quiz05 = new QuestionBank("what is my birthday", "dont know", 100);

            questionsWithAnswers.Add(quiz);
            questionsWithAnswers.Add(quiz01);
            questionsWithAnswers.Add(quiz02);
            questionsWithAnswers.Add(quiz03);
            questionsWithAnswers.Add(quiz04);
            questionsWithAnswers.Add(quiz05);

            Random randomize = new Random();
            //var rand = randomize.Next(0,5);
            int Index = randomize.Next(questions.Count);
            var showq = questions[Index];

            questionB.Content = showq;


            






            /* classwork and homework
             
             create a game to randomly show one of the questions 
             have a text box recieve the answer.
             if it is right display appropriate message and add the total points
             if wrong zero points and appripriate message
             create a winning condition
             add some image
             
             */

        }

        private void ShowPanel01(object sender, RoutedEventArgs e)
        {
            Random randomize = new Random();
            //var rand = randomize.Next(0,5);
            int Index = randomize.Next(questions.Count);
            var showq = questions[Index];

            questionB.Content = showq;
        }

        private void ShowPanel02(object sender, RoutedEventArgs e)
        {
            int counter = 0;

            counter++;
            counter01.Content = counter;
            switch(counter)
            {
                case 1:
                    Button02.Content = "Hey!! DONT CLICK";
                   
                    break;
                case 2:
                    Button02.Content = "you've done it now";
                    break;
                case 3:
                    Button02.Content = "here he comes";
                    break;
                case 4:
                    Button02.Content = "";
                    break;
                case 5:
                    Button02.Content = "blah";
                    break;
            }
            
        }

        private void ShowPanel03(object sender, RoutedEventArgs e)
        {

        }
    }

    public class QuestionBank
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public int Points { get; set; }


        public QuestionBank(string question, string answer,int points)
        {
            this.Question = question;
            this.Answer = answer;
            this.Points = points;

            

        }
    }
}
