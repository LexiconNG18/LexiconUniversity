using System.ComponentModel.DataAnnotations;

namespace LexiconUniversity.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string FullName => FirstName + " " + LastName;

        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

    }
}