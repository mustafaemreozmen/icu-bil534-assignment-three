using PlaneTicket.Abstract;

namespace PlaneTicket.Concrete.Decorators;

public class AdditionalFood : ExtraDecorator
{
    public override string Description
    {
        get
        {
            return $"{base.Description}, Additional Food";
        }
    }
    public AdditionalFood(Ticket ticket)
    {
        this.Ticket = ticket;
    }
    public override decimal Cost() => (Ticket?.Cost() ?? 0m) + 5.99m;
}