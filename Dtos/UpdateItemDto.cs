using System.ComponentModel.DataAnnotations;

namespace RestAPI.Dtos
{
    public record UpdateItemDto
    {
        [Required(ErrorMessage = "Nome é um campo Obrigátorio")]
        public string Name { get; init; }
        [Required(ErrorMessage = "Preço é um campo Obrigátorio")]
        [Range(1, 1000, ErrorMessage = "Só são aceitos preços entre 1 e 1000")]
        public decimal Price { get; init; }
    }
}