namespace Ticket.Interfaces
{
  public interface ITicket
  {
    string Title { get; set; }
    string Description { get; set; }

    /// <summary>Returns Ticket Information</summary>
    void GetTemplate();
  }
}