using PlaneTicket.Abstract;

namespace PlaneTicket.Concrete.TicketTypes;

public class BusinessTicket : Ticket
{
    public override string Description { get; }
    public BusinessTicket()
    {
        Description = "Business Class Ticket";
    }
    public override decimal Cost()
    {
        return 499.99m;
    }
}