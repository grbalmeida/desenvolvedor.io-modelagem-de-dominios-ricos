using NerdStore.Core.Resources;
using System;
using System.ComponentModel.DataAnnotations;

namespace NerdStore.Catalogo.Application.ViewModels
{
    public class CategoriaViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = MensagensValidacao.Obrigatorio)]
        public string Nome { get; set; }

        [Required(ErrorMessage = MensagensValidacao.Obrigatorio)]
        public int Codigo { get; set; }
    }
}
