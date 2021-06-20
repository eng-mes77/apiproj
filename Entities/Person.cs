using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Person
    {
        [Column("PersonId")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Person name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "address is a required field.")]
        [MaxLength(70, ErrorMessage = "Maximum length for the Address is 60 characte")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Phone is a required field.")]
        public string Phone { get; set; }
    }
}
