using System.Collections.Generic;

namespace Ticket.Services
{
  public class TicketService
  {
    List<string> Messages { get; set; }



    public TicketService()
    {
      Messages = new List<string>();
    }
  }
}