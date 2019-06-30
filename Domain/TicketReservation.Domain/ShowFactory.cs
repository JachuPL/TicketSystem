﻿using System;
using System.Collections.Generic;
using TicketReservation.Domain.Cinemas;
using TicketReservation.Domain.Movies;
using TicketReservation.Domain.Reservations;

namespace TicketReservation.Domain
{
    public static class ShowFactory
    {
        public static Show Create(Guid id, Cinema cinema, Movie movie, DateTime date, Dictionary<Ticket, decimal> priceList)
        {
            //validate everything

            return new Show(id, cinema, movie, date, priceList);
        }
    }
}