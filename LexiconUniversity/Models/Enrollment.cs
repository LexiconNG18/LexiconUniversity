using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LexiconUniversity.Models
{
    public class Enrollment
    {
        public int Id { get; set; }

        public Grade? Grade { get; set; }
        
        // Navigational properties
        public string CourseId { get; set; }
        public virtual Course Course { get; set; }

        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }

    public enum Grade
    {
        A, B, C, D, F
    }
}