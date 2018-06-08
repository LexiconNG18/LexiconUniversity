namespace LexiconUniversity.Migrations
{
    using LexiconUniversity.Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Models.UniversityContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "LexiconUniversity.Models.UniversityContext";
        }

        protected override void Seed(UniversityContext context)
        {
            var students = new[] {
                new Student { FirstName = "Adam", LastName = "Anderson" },
                new Student { FirstName = "Berit", LastName = "Bosson" },
                new Student { FirstName = "Cecilia", LastName = "Carlsson" },
                new Student { FirstName = "Dave", LastName = "Duke" }
            };
            context.Students.AddOrUpdate(s => new { s.FirstName, s.LastName }, students);

            context.Courses.AddOrUpdate(
               c => c.CourseId,
               new Course { CourseId = "NET18", Name = ".NET", Credits = 30 },
               new Course { CourseId = "JAVA17", Name = "Java", Credits = 25 },
               new Course { CourseId = "H18", Name = "Haskell", Credits = 40 }
            );

            context.SaveChanges();

            context.Enrollments.AddOrUpdate(
                e => new { e.CourseId, e.StudentId },
                new Enrollment { StudentId = students[0].Id, CourseId = "NET18", Grade = Grade.A },
                new Enrollment { StudentId = students[1].Id, CourseId = "JAVA17" },
                new Enrollment { StudentId = students[1].Id, CourseId = "NET18" }
            );
        }
    }
}
