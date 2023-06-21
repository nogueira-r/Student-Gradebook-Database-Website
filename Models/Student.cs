using System.ComponentModel.DataAnnotations;

namespace GradesBooks.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a grade.")]
        [Range(0, 100, ErrorMessage = "Grade must be between 0 and 100.")]
        public decimal GradePercent { get; set; }
        public string Slug => Name.Replace(' ', '-');
    }
}