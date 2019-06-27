﻿using System;
using System.Collections.Generic;

namespace TicketReservation.WebAPI.Reservations.Requests
{
    public class ReserveTicketsRequest
    {
        public Guid ShowId { get; set; }
        public List<Place> Tickets { get; set; } = new List<Place>();
    }
}