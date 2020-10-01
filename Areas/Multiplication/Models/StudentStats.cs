using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mathletes2020.Areas.Multiplication.Models
{
    [Table("StudentStats")]
    public partial class StudentStats
    {
        [Key]
        public int StudentId { get; set; }
        public int FirstName { get; set; }
        public int LastName { get; set; }
        public int Attempts { get; set; }
        public int HighestScore { get; set; }
        public int CurrentTimeLimit { get; set; }
        public int CurrentTest { get; set; }

    }
}
