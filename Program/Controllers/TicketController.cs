using System;
using Ticket.Services;

namespace Ticket.Controllers
{
  public class TicketController
  {
    private TicketService _ts = new TicketService();

    public void Run()
    {
      while (true)
      {
        GetUserInput();
      }
    }

    private void GetUserInput()
    {
      string welcome = @"
 __        __   _                            _          _   _            _____ _      _        _     ____            _                  
 \ \      / ___| | ___ ___  _ __ ___   ___  | |_ ___   | |_| |__   ___  |_   _(_) ___| | _____| |_  / ___| _   _ ___| |_ ___ _ __ ___   
  \ \ /\ / / _ | |/ __/ _ \| '_ ` _ \ / _ \ | __/ _ \  | __| '_ \ / _ \   | | | |/ __| |/ / _ | __| \___ \| | | / __| __/ _ | '_ ` _ \  
   \ V  V |  __| | (_| (_) | | | | | |  __/ | || (_) | | |_| | | |  __/   | | | | (__|   |  __| |_   ___) | |_| \__ | ||  __| | | | | | 
    \_/\_/ \___|_|\___\___/|_| |_| |_|\___|  \__\___/   \__|_| |_|\___|   |_| |_|\___|_|\_\___|\__| |____/ \__, |___/\__\___|_| |_| |_| 
                                                                                                           |___/                        
      
      ";
      Console.WriteLine(welcome);
      Console.WriteLine("Number       Title");
      Console.WriteLine("--------------------");
      for (int i = 0; i < _ts.UserTickets.Count; i++)
      {
        string TicketTitle = _ts.UserTickets[i].Title;
        Console.WriteLine($"{i + 1}.          {TicketTitle}");
      }

      Console.WriteLine("What would you like to do? (view/new/quit)");
      string input = Console.ReadLine().ToLower();

      switch (input)
      {
        case "q":
        case "quit":
          Console.Clear();
          Environment.Exit(0);
          break;
        case "n":
        case "new":
          NewTicket();
          break;
        case "v":
        case "view":
          ViewTicketDetails();
          break;

      }

    }
    private void NewTicket()
    {
      Console.WriteLine("Title:");
      string title = Console.ReadLine();
      Console.WriteLine("Description:");
      string desc = Console.ReadLine();
      Console.Clear();
      _ts.CreateTicket(title, desc);
    }

    private void ViewTicketDetails()
    {
      Console.WriteLine("What ticket number do you want to view?");
      string num = Console.ReadLine();
      if (int.TryParse(num, out int index))
      {
        _ts.ViewTicket(index - 1);
        Console.Clear();
        Update(index - 1);
      }
    }

    private void Update(int index)
    {
      foreach (string message in _ts.Messages)
      {
        Console.WriteLine(message);
      }
      CheckClose(index);
      _ts.Messages.Clear();
      Console.Clear();
    }
    private void CheckClose(int index)
    {
      Console.WriteLine("Type close to remove resovle ticket or any key to continue");
      string input = Console.ReadLine().ToLower();

      switch (input)
      {
        case "close":
          _ts.ResolveTicket(index);
          break;
      }
    }
    public TicketController()
    {

    }
  }
}