using System.ComponentModel.DataAnnotations;

namespace machinist.Models;

public class Machine
{
    public int Id { get; set; }
    public Guid MachineId { get; private set; } = Guid.NewGuid();

    [Required]
    public string? Name { get; set; }

    [Required]
    public string? Desc { get; set; }

    [Required]
    public string? RoomNr { get; set; }

    public string? Status { get; set; }

    public DateTime? StatusChanged { get; set;}

    public List<Commando>? Commandos { get; } = [];

    public int? CompanyId { get; set; }
    public Company? Company { get; set; }


    public void UpdateStatus(string status, DateTime statusChanged)
    {
        Status = status;
        StatusChanged = statusChanged;
    }
}
