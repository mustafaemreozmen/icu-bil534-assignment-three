namespace PlaneTicket.Abstract;

public abstract class Ticket
{
    public abstract decimal Cost();
    public abstract string? Description { get; }
}