using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz11.Question.MultiChoice
{
    public class MultiChoiceRawQuestion : IRawQuestion
    {
        public string Question;
        public MultiChoiceAnswer CorrectAnswer;
        public MultiChoiceAnswer[] IncorrectAnswers;

        public IQuestion Create()
        {
            List<MultiChoiceAnswer> answerList = new(IncorrectAnswers);

            int correctAnswerIndex = new Random().Next(answerList.Count);
            answerList.Insert(correctAnswerIndex, CorrectAnswer);

            return new MultiChoiceQuestion
            {
                Question = Question,
                Choices = answerList.ToArray(),
                CorrectAnswerIndex = correctAnswerIndex
            };
        }
    }
}
