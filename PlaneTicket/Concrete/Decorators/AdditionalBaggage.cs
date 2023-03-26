using PlaneTicket.Abstract;

namespace PlaneTicket.Concrete.Decorators;

public class AdditionalBaggage : ExtraDecorator
{
    public override string? Description
    {
        get
        {
            return $"{base.Description}, Additional Baggage";
        }
    }
    public AdditionalBaggage(Ticket ticket)
    {
        this.Ticket = ticket;
    }
    public override decimal Cost() => (Ticket?.Cost() ?? 0m) + 3.99m;
}