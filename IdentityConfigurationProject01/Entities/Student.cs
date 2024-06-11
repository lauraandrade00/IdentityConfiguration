using System.ComponentModel.DataAnnotations;

namespace IdentityConfigurationProject01.Entities
{
    // Entity name: singular, while table we put it in plural
    public class Student
    {
        // EF uses a convention: while mapping entities, the id column (primary key) must have int type and be estabilished like  “Id”  or  “entityId” 
        public int StudentId { get; set; }
        [Required]
        public string? Name { get; set; }
        [EmailAddress]
        [Required, MaxLength(120)]
        public string? Email { get; set; }
        public int Age { get; set; }
        public string? Class { get; set; }
        // It`s recommended to make the definitions on OnModelCreating to keep the domain model clean
    }
}
