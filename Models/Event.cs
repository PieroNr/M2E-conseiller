namespace M2E_conseiller.Models;

public class Event
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public DateTime Date { get; set; }
    public int Capacity { get; set; }
    public List<Registered> Registered { get; set; }
    
}