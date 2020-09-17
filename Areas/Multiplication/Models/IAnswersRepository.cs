using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mathletes2020.Areas.Multiplication.Models
{
    public interface IAnswersRepository
    {
        Answers GetAnswers(int TestLevel);
    }
}
