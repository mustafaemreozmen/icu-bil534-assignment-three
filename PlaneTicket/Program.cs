using System;
using PlaneTicket.Abstract;
using PlaneTicket.Concrete.Decorators;
using PlaneTicket.Concrete.TicketTypes;

//This region for standard business ticket
Ticket ticket = new BusinessTicket();
Console.WriteLine($"Cost for {ticket.Description} - ${ticket.Cost()}");

//This region for standard economy ticket
Ticket secondTicket = new EconomyTicket();
Console.WriteLine($"Cost for {secondTicket.Description} - ${secondTicket.Cost()}");

//This region for standard business ticket + additional baggage
Ticket thirdTicket = new BusinessTicket();
thirdTicket = new AdditionalBaggage(thirdTicket);
Console.WriteLine($"Cost for {thirdTicket.Description} - ${thirdTicket.Cost()}");

//This region for standard business ticket + additional baggage + additional food
Ticket fourthTicket = new BusinessTicket();
fourthTicket = new AdditionalBaggage(fourthTicket);
fourthTicket = new AdditionalFood(fourthTicket);
Console.WriteLine($"Cost for {fourthTicket.Description} - ${fourthTicket.Cost()}");

//This region for standard economy ticket + additional baggage
Ticket fifthTicket = new EconomyTicket();
fifthTicket = new AdditionalBaggage(fifthTicket);
Console.WriteLine($"Cost for {fifthTicket.Description} - ${fifthTicket.Cost()}");

//This region for standard economy ticket + additional baggage + additional food
Ticket sixthTicket = new EconomyTicket();
sixthTicket = new AdditionalBaggage(sixthTicket);
sixthTicket = new AdditionalFood(sixthTicket);
Console.WriteLine($"Cost for {sixthTicket.Description} - ${sixthTicket.Cost()}");

