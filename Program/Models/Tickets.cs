using Ticket.Interfaces;

namespace Ticket.Models
{
  public class Tickets : ITicket
  {
    public string Title { get; set; }
    public string Description { get; set; }

    public void GetTemplate()
    {

    }

    public Tickets(string title, string description)
    {
      Title = title;
      Description = description;

    }
  }
}