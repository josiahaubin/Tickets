using Ticket.Interfaces;

namespace Ticket.Models
{
  public class Ticket : ITicket
  {
    public string Title { get; set; }
    public string Description { get; set; }

    public void GetTemplate()
    {

    }

    public Ticket(string title, string description)
    {
      Title = title;
      Description = description;

    }
  }
}