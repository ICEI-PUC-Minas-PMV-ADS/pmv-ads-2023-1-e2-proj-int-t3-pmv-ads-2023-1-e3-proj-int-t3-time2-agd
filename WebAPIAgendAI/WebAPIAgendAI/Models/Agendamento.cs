using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

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
        public string Turma { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [EmailAddress(ErrorMessage = "Entre com um email válido")]
        [DataType(DataType.EmailAddress)]
        public string EmailInstitucional { get; set; }

        [ForeignKey("EmailInstitucional")]
        public Funcionario Funcionario { get; set; }

    }
}
