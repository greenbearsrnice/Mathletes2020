using Mathletes2020.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mathletes2020.Areas.Multiplication.Models
{
    public class StudentStatsRepository : IStudentStatsRepository
    {
        private readonly AppDbContext context;

        public StudentStatsRepository(AppDbContext context)
        {
            this.context = context;
        }
        public StudentStats GetStats(string StudentId)
        {
            return context.StudentStats.Find(StudentId);
        }

        
    }
}
