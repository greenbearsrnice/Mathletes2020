using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mathletes2020.Areas.Multiplication.Models
{
    public interface IStudentStatsRepository
    {
        StudentStats GetStats(string StudentId);
        IEnumerable<StudentStats> GetAllStats();
        StudentStats Update(StudentStats statChanges);
    }
}
