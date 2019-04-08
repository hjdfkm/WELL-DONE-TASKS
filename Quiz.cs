using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    struct Question
    {
        private string[] questionList;
        private string[] arswerList;
        private int[] correctAnswer;

        public string[] QuestionList
        {
            get { return questionList; }
            set { questionList = value; }
        }

        public string[] AnswerList
        {
            get { return arswerList; }
            set { arswerList = value; }
        }

        public int[] CorrectAnswer
        {
            get { return correctAnswer; }
            set { correctAnswer = value; }
        }
        public void SuperQuiz(string[] questionList, string[] answerList, int[] correctAnswer)
        {
            int j = 0;
            int k = 0;
            int answer = 0;
            int counter = 0;

            Console.WriteLine("Здравствуйте! Добро пожаловать в викторину. Для ответа введите число от 1 до 4.");

            for (int i = 0; i < questionList.Length; i++)
            {
                Console.WriteLine(questionList[i]);
                for (; j < answerList.Length; j++)
                {
                    if (j - 1 == i)
                        break;
                    Console.WriteLine(answerList[j]);
                    try
                    {
                        Console.Write("Ваш ответ: ");
                        answer = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Недопустимый ответ! Введите число от 1 до 4.");
                        Console.Write("Ваш ответ: ");
                        answer = int.Parse(Console.ReadLine());
                    }
                    for (; k < correctAnswer.Length; k++)
                    {
                        if (k - 1 == j)
                            break;
                        if (answer == correctAnswer[k])
                            counter++;
                    }
                }
            }
            Console.WriteLine("Количество правильных ответов: " + counter);
        }
    }

    class Program
    {
        static void Main()
        {
            Question question = new Question();

            question.QuestionList = new string[5];

            question.QuestionList[0] = "1)Столица Греции?";
            question.QuestionList[1] = "2)Столица Иордании?";
            question.QuestionList[2] = "3)Столица Канады?";
            question.QuestionList[3] = "4)Столица Австралии?";
            question.QuestionList[4] = "5)Столица Чехии?";

            question.AnswerList = new string[5];
            question.AnswerList[0] = "1: Солоники\n2: Патры\n3: Афины\n4: Скопье";
            question.AnswerList[1] = "1: Ирбид\n2: Амман\n3: Алеппо\n4: Хомс";
            question.AnswerList[2] = "1: Торонто\n2: Квебек\n3: Монреаль\n4: Оттава";
            question.AnswerList[3] = "1: Сидней\n2: Мельбурн\n3: Канберра\n4: Брисбен";
            question.AnswerList[4] = "1: Прага\n2: Брно\n3: Вена\n4: Братислава";

            question.CorrectAnswer = new int[] { 3, 2, 4, 3, 1 };

            question.SuperQuiz(question.QuestionList, question.AnswerList, question.CorrectAnswer);

            Console.ReadKey();
        }
    }
}
