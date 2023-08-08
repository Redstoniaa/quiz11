using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace quiz11.Question.MultiChoice
{
    public class MultiChoiceAnswer
    {
        public string Answer;
        public string? Feedback;

        public MultiChoiceAnswer(string answer, string? feedback = null)
        {
            Answer = answer;
            Feedback = feedback;
        }
    }
}
