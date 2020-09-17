using Mathletes2020.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mathletes2020.Areas.Multiplication.Models
{
    public class AnswersRepository : IAnswersRepository
    {
        private readonly AppDbContext context;

        public AnswersRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Answers GetAnswers(int TestLevel)
        {
            return context.Answers.Find(TestLevel);
        }

        
    }
}
