using FinancasApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinancasApp.presentation.Models
{
    public class ContasConsultaViewModel
    {


        [Required(ErrorMessage = "Por favor, informe a data de início.")]
        public DateTime? DataInicio { get; set; }

        [Required(ErrorMessage = "Por favor, informe a data de término.")]
        public DateTime? DataFim { get; set; }

        public List<Conta>? ListagemContas { get; set; }


    }
}
