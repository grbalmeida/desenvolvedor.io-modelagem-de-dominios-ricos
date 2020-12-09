using NerdStore.Core.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NerdStore.Catalogo.Application.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = MensagensValidacao.Obrigatorio)]
        public Guid CategoriaId { get; set; }

        [Required(ErrorMessage = MensagensValidacao.Obrigatorio)]
        public string Nome { get; set; }

        [Required(ErrorMessage = MensagensValidacao.Obrigatorio)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = MensagensValidacao.Obrigatorio)]
        public bool Ativo { get; set; }

        [Required(ErrorMessage = MensagensValidacao.Obrigatorio)]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = MensagensValidacao.Obrigatorio)]
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = MensagensValidacao.Obrigatorio)]
        public string Imagem { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = MensagensValidacao.ValorMinimo)]
        [Required(ErrorMessage = MensagensValidacao.Obrigatorio)]
        public int QuantidadeEstoque { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = MensagensValidacao.ValorMinimo)]
        [Required(ErrorMessage = MensagensValidacao.Obrigatorio)]
        public int Altura { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = MensagensValidacao.ValorMinimo)]
        [Required(ErrorMessage = MensagensValidacao.Obrigatorio)]
        public int Largura { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = MensagensValidacao.ValorMinimo)]
        [Required(ErrorMessage = MensagensValidacao.Obrigatorio)]
        public int Profundidade { get; set; }

        public IEnumerable<CategoriaViewModel> Categorias { get; set; }
    }
}
