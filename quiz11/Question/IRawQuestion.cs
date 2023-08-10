using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz11.Question
{
    public interface IRawQuestion
    {
        IQuestion Create();
    }
}
