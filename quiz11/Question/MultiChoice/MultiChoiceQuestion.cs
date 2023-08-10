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
        public MultiChoiceAnswer[] Choices;
        public int CorrectAnswerIndex;

        public void DisplayQuestion()
        {
            throw new NotImplementedException();
        }

        public bool ProcessInput(string input, out bool correct)
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
