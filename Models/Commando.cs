using System.ComponentModel.DataAnnotations;
namespace machinist.Models;
public class Commando
{
    public int CommandoId { get; set; }

    [Required]
    public string? Name { get; set; }

    [Required]
    public string? Desc { get; set; }

    [Required]
    public int ExeTime { get; set; }

    public int? MachineId { get; set; }
    public Machine? Machine { get; set; }
}
