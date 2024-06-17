using System.ComponentModel.DataAnnotations;

namespace machinist.Models;

public class Company
{
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? Logo { get; set; }

    [Required]
    public string? Address { get; set; }

    [Required]
    public string? Phone { get; set; }

    [Required]
    public string? Desc { get; set; }

    public List<Machine>? Machines { get; } = [];
}
