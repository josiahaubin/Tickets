using System;
using Ticket.Controllers;

namespace Ticket
{
  class Program
  {
    static void Main(string[] args)
    {
      new TicketController().Run();
    }
  }
}
