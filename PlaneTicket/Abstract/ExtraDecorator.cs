namespace PlaneTicket.Abstract;

public abstract class ExtraDecorator : Ticket
{
    public Ticket? Ticket { get; set; }
    public override string? Description
    {
        get => Ticket?.Description;
    }
}