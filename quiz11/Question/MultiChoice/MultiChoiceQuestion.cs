using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz11.Question.MultiChoice
{
    public class MultiChoiceQuestion : IQuestion
    {
        public string Question;
        MultiChoiceAnswer CorrectAnswer;
        public List<MultiChoiceAnswer> IncorrectAnswers = new List<MultiChoiceAnswer>();

        public MultiChoiceQuestion(string question, MultiChoiceAnswer correctAnswer, params MultiChoiceAnswer[] incorrectAnswers)
        {
            Question = question;
            CorrectAnswer = correctAnswer;
            IncorrectAnswers.AddRange(incorrectAnswers);
        }

        public void DisplayQuestion()
        {
            throw new NotImplementedException();
        }
        
        public bool ValidateInput(string input)
        {
            throw new NotImplementedException();
        }

        public void OnCorrectAnswer()
        {
            throw new NotImplementedException();
        }

        public void OnIncorrectAnswer()
        {
            throw new NotImplementedException();
        }
    }
}
