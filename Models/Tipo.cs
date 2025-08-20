using System.ComponentModel.DataAnnotations;
namespace GerTar.Models;

public class Tipo
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "O campo Nome é obrigatório")]
    [MinLength(2, ErrorMessage = "Mínimo 2 caracteres.")]
    [MaxLength(100, ErrorMessage = "Máximo 100 caracteres.")]
    public string Nome { get; set; } = null!;
    [Required(ErrorMessage = "O campo Descrição é obrigatório")]
    [MinLength(2, ErrorMessage = "Mínimo 2 caracteres.")]
    [MaxLength(200, ErrorMessage = "Máximo 200 caracteres.")]
    public string Descricao { get; set; } = null!;
    public ICollection<Tarefa> Tarefas { get; set; } = new List<Tarefa>();
}