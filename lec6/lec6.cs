using System;
class lec6
{
    static void Main()
    {
        // int AvailableTicket;
        // // Console.WriteLine(AvailableTicket);
        // // error use of unassigned local variable
        // int? TicketsOnSale=null;
        // if(TicketsOnSale==null){
        //     AvailableTicket=0;
        // }
        // else{
        //     AvailableTicket=(int)TicketsOnSale;
        // }
        // Console.WriteLine(AvailableTicket);

        int AvailableTicket;
        int? TicketsOnSale=null;
        AvailableTicket=TicketsOnSale??0;
        Console.WriteLine(AvailableTicket);

    }
}