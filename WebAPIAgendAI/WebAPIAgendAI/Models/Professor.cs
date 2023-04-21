using System.ComponentModel.DataAnnotations;

namespace WebAPIAgendAI.Models
{
    public class Professor
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Obrigatório Informar o nome!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Obrigatório Informar o email")]
        [EmailAddress(ErrorMessage = "Entre com um email válido")]
        [DataType(DataType.EmailAddress)]
        public string EmailInstitucional { get; set; }
        [Required(ErrorMessage = "Obrigatório Informar a matéria!")]
        public  string Materia  { get; set; }

        public Professor(int id, string nome, string emailInstitucional, string materia)
        {
            Id = id;
            Nome = nome;
            EmailInstitucional = emailInstitucional;
            Materia = materia;
        }
    }

    

}
