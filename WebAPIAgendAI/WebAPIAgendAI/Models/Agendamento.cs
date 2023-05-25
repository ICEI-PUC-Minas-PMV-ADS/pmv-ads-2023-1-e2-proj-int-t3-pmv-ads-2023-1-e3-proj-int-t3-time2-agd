using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIAgendAI.Models
{
    public class Agendamento
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Sala { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [EmailAddress(ErrorMessage = "Entre com um email válido")]
        [DataType(DataType.EmailAddress)]
        public string EmailInstitucional { get; set; }
        public int FuncionarioId { get; set; }

        [ForeignKey("FuncionarioId")]
        public Funcionario Funcionario { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        public Tipo Tipo { get; set; }

    }
    public enum Tipo
    {
        Evento,
        Aula,
        Prova,
        Atualizacao
    }
}
