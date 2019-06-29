﻿using System;

namespace TicketReservation.Domain
{
    public class MovieFactory
    {
        public static Movie Create(Guid id, string title)
        {
            return new Movie(id, title);
        }
    }
}
