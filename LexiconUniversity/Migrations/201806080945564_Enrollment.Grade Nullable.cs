namespace LexiconUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EnrollmentGradeNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Enrollments", "Grade", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Enrollments", "Grade", c => c.Int(nullable: false));
        }
    }
}
