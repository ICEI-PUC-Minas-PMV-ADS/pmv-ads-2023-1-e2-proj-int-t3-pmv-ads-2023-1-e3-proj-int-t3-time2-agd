using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace WebAPIAgendAI.Models
{
    public class Funcionario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Nome { get; set; }

        [Key]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        [EmailAddress(ErrorMessage = "Entre com um email válido")]
        [DataType(DataType.EmailAddress)]
        public string EmailInstitucional { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [DataType(DataType.Password)]
        public string senha { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        public FuncionarioPerfil Perfil { get; set; }

        public ICollection<Agendamento> Agendamentos { get; set; } = new List<Agendamento>();

        public Funcionario()
        {

        }

        public Funcionario(int id, string emailInstitucional, string nome)
        {
            Id = id;
            EmailInstitucional = emailInstitucional;
            Nome = nome;
        }

        public void AddAgendamento(Agendamento agendamento)
        {
            Agendamentos.Add(agendamento);
        }
        public void RemoverAgendamento(Agendamento agendamento)
        {
            Agendamentos.Remove(agendamento);
        }
    }
        
    public enum FuncionarioPerfil
    {
        Administrador,
        Professor
    }
}
