using System;
using System.ComponentModel.DataAnnotations;

namespace MvcEscola.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        [Required]
        [StringLength(35, MinimumLength = 5)]
        public string Nome { get; set; }

        public string Rg { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }
    }
}