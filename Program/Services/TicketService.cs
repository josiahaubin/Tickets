using System.Collections.Generic;
using Ticket.Models;

namespace Ticket.Services
{
  public class TicketService
  {
    public List<string> Messages { get; set; }

    public List<Tickets> UserTickets { get; set; }

    public void CreateTicket(string title, string desc)
    {
      Tickets ticket = new Tickets(title, desc);
      UserTickets.Add(ticket);
    }
    public void ViewTicket(int index)
    {
      string info = UserTickets[index].GetTemplate();
      Messages.Add(info);
    }
    public TicketService()
    {
      Messages = new List<string>();
      UserTickets = new List<Tickets>();
    }
  }
}