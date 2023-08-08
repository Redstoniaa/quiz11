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
        bool ValidateInput(string input);
        void OnCorrectAnswer();
        void OnIncorrectAnswer();
    }
}
