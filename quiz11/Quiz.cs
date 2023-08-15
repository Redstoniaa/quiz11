using quiz11.Question;
using quiz11.Question.MultiChoice;

namespace quiz11
{
    public static class Quiz
    {
        public static IRawQuestion[] Questions =
        {
            new MultiChoiceRawQuestion()
            {
                Question = "What is life?",
                CorrectAnswer = new MultiChoiceAnswer("Yes"),
                IncorrectAnswers = new MultiChoiceAnswer[]
                {
                    new MultiChoiceAnswer("No")
                }
            }
        };

        public static Random Random = new();

        public static void Run()
        {
            IQuestion question = getRandomQuestion();
            question.DisplayQuestion();
        }

        private static IQuestion getRandomQuestion()
        {
            return Questions[new Random().Next(Questions.Length)]
                .Create();
        }
    }
}
