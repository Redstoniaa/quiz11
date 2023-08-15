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
            Console.WriteLine(Question);
            for (int i = 0; i < Choices.Length; i++)
            {
                MultiChoiceAnswer answer = Choices[i];
                Console.WriteLine($"[{i}] {answer.Answer}");
            }
        }

        public bool ProcessInput(string input, out bool correct)
        {
            if (int.TryParse(input, out int answer)
                && answer > 0
                && answer <= Choices.Length)
            {
                if (answer == CorrectAnswerIndex)
                {
                    correct = true;
                    return true;
                }
                else
                {
                    correct = false;
                    return true;
                }
            }

            correct = false;
            return false;
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
