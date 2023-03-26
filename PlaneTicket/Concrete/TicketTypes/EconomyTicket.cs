using PlaneTicket.Abstract;

namespace PlaneTicket.Concrete.TicketTypes;

public class EconomyTicket : Ticket
{
    public override string Description { get; }

    public EconomyTicket()
    {
        Description = "Economy Class Ticket";
    }
    public override decimal Cost()
    {
        return 199.99m;
    }
}