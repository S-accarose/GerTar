using System.ComponentModel.DataAnnotations;
namespace GerTar.Models;
public class Tarefa
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "O campo Nome é obrigatório")]
    [MinLength(2, ErrorMessage = "Mínimo 2 caracteres.")]
    [MaxLength(100, ErrorMessage = "Máximo 100 caracteres.")]
    [Display(Name = "Título")]
    public string Nome { get; set; } = string.Empty;
    [Required(ErrorMessage = "O campo Descrição é obrigatório")]
    [MinLength(5, ErrorMessage = "Mínimo 5 caracteres.")]
    [MaxLength(200, ErrorMessage = "Máximo 200 caracteres.")]
    [Display(Name = "Descrição")]
    public string Descricao { get; set; } = string.Empty;
    [DataType(DataType.DateTime)]
    [Display(Name = "Data de Criação")]
    public DateTime DataCriacao { get; set; }
    [DataType(DataType.DateTime)]
    [Display(Name = "Data de Conclusão")]
    public DateTime? DataConclusao { get; set; }
    public int TipoId { get; set; }
    public Tipo? Tipo { get; set; }
    public bool Concluida { get; set; } = false;
    public Tarefa() { DataCriacao = DateTime.Now; }
}