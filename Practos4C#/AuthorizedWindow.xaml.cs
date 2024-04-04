using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace Practos4C_
{
    /// <summary>
    /// Логика взаимодействия для AuthorizedWindow.xaml
    /// </summary>
    public partial class AuthorizedWindow : Window
    {
        private List<TestQuestion> testQuestions;

        public AuthorizedWindow()
        {
            InitializeComponent();
            LoadTestData();
        }

        private void LoadTestData()
        {
            if (File.Exists("testData.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<TestQuestion>));
                using (FileStream fileStream = new FileStream("testData.xml", FileMode.Open))
                {
                    testQuestions = (List<TestQuestion>)serializer.Deserialize(fileStream);
                }
            }
            else
            {
                NoTestPage.Visibility = Visibility.Visible;
            }
        }

        private void EditTestButton_Click(object sender, RoutedEventArgs e)
        {
            TestEditorPage.Visibility = Visibility.Visible;
            TestPassingPage.Visibility = Visibility.Collapsed;
            NoTestPage.Visibility = Visibility.Collapsed;
            LoadTestDataIntoGrid();
        }

        private void PassTestButton_Click(object sender, RoutedEventArgs e)
        {
            TestPassingPage.Visibility = Visibility.Visible;
            TestEditorPage.Visibility = Visibility.Collapsed;
            NoTestPage.Visibility = Visibility.Collapsed;
            LoadTestDataForPassing();
        }

        private void LoadTestDataIntoGrid()
        {
            TestGrid.ItemsSource = testQuestions;
        }

        private int currentQuestionIndex = 0;
        private int correctAnswersCount = 0;
        private void LoadTestDataForPassing()
        {
            if (testQuestions.Count > 0)
            {
                DisplayQuestion(testQuestions[currentQuestionIndex]);
            }
            else
            {
                NoTestPage.Visibility = Visibility.Visible;
            }
        }
        private void DisplayQuestion(TestQuestion question)
        {
            QuestionTitleTextBlock.Text = question.Title;
            DescriptionTextBlock.Text = question.Description;
            Answer1Button.Content = question.Answer1;
            Answer2Button.Content = question.Answer2;
            Answer3Button.Content = question.Answer3;
        }

        private void CheckAnswer(CorrectAnswer selectedAnswer)
        {
            TestQuestion currentQuestion = testQuestions[currentQuestionIndex];
            if (selectedAnswer == currentQuestion.CorrectAnswer)
            {
                correctAnswersCount++;
            }

            currentQuestionIndex++;

            if (currentQuestionIndex < testQuestions.Count)
            {
                DisplayQuestion(testQuestions[currentQuestionIndex]);
            }
            else
            {
                MessageBox.Show($"You answered {correctAnswersCount} out of {testQuestions.Count} questions correctly.");
            }
        }
        private void Answer1Button_Click(object sender, RoutedEventArgs e)
        {
            CheckAnswer(CorrectAnswer.First);
        }

        private void Answer2Button_Click(object sender, RoutedEventArgs e)
        {
            CheckAnswer(CorrectAnswer.Second);
        }

        private void Answer3Button_Click(object sender, RoutedEventArgs e)
        {
            CheckAnswer(CorrectAnswer.Third);
        }

        private void SaveTestData()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<TestQuestion>));
            using (FileStream fileStream = new FileStream("testData.xml", FileMode.Create))
            {
                serializer.Serialize(fileStream, testQuestions);
            }
        }

        private void ReturnToAuthorizationWindow()
        {
            MainWindow authWindow = new MainWindow();
            authWindow.Show();
            this.Close();
        }

    }
}
