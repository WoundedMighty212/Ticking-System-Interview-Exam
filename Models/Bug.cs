﻿namespace Ticking_System_Interview_Exam.Models
{
    public class Bug
    {
        public int BugId { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string Status { get; set; } = "Open"; // Open or Resolved
        public int CreatedByUserId { get; set; }
    }
}
