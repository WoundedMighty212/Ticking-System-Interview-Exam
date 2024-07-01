using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ticking_System_Interview_Exam.Models;

namespace Ticking_System_Interview_Exam.Data
{
    public class Ticking_System_Interview_ExamContext : DbContext
    {
        public Ticking_System_Interview_ExamContext (DbContextOptions<Ticking_System_Interview_ExamContext> options)
            : base(options)
        {
        }

        public DbSet<Ticking_System_Interview_Exam.Models.Bug> Bug { get; set; } = default!;
    }
}
