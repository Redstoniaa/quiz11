using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz11.Question
{
    public interface IQuestion
    {
        void DisplayQuestion();
        bool ProcessInput(string input, out bool correct);
        void OnCorrectAnswer();
        void OnIncorrectAnswer();
    }
}
