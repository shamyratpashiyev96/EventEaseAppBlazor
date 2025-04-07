using System.ComponentModel.DataAnnotations;

namespace EventEaseApp.Data.Models;
public class Event
{
    [Required]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [DataType(DataType.DateTime)]
    public DateTime Date { get; set; }

    [Required]
    public string Location { get; set; }

    [Required]
    [StringLength(100, MinimumLength = 10)]
    public string Description { get; set; }

    [Required]
    public decimal TicketPrice { get; set; }

    public List<int> AttendeeIds { get; set; } = new();
}