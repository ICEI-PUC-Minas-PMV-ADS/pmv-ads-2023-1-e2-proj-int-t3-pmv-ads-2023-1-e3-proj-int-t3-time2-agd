using System.ComponentModel.DataAnnotations;

namespace WebAPIAgendAI.Models
{
    public class Administrador
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o email")]
        [EmailAddress(ErrorMessage = "Entre com um email válido")]
        [DataType(DataType.EmailAddress)]
        public string EmailInstitucional { get; set; }

        public Administrador(int id, string nome, string emailInstitucional)
        {
            Id = id;
            Nome = nome;
            EmailInstitucional = emailInstitucional;
        }
    }
}
