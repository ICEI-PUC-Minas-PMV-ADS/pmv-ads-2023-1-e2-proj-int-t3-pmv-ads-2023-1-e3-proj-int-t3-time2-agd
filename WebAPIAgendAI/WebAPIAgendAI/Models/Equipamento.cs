using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIAgendAI.Models
{
    public class Equipamento
    {
        [Key]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public int NumeroSerie { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string HostName { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        public StatusEquipamento Status { get; set; }
    }

    public enum StatusEquipamento
    {
        Disponivel,
        Indisponivel
    }
}
