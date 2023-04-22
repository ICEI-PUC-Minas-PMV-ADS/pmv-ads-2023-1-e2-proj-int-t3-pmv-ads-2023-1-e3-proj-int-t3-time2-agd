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
        [Required(ErrorMessage = "Obrigatório Informar o modelo!")]
        public int NumeroSerie { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o modelo!")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o status")]
        public StatusEquipamento Status { get; set; }
    }

    public enum StatusEquipamento
    {
        Disponivel,
        Indisponivel
    }
}
