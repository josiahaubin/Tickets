using Ticket.Interfaces;

namespace Ticket.Models
{
  public class Tickets : ITicket
  {
    public string Title { get; set; }
    public string Description { get; set; }

    public string GetTemplate()
    {
      string template = $@"
Title: {Title}
Description: {Description}
      ";

      return template;
    }

    public Tickets(string title, string description)
    {
      Title = title;
      Description = description;

    }
  }
}