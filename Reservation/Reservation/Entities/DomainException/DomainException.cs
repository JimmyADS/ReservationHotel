using System;

namespace ReservationHotel.Entities.DomainException
{
     class DomainException : ApplicationException
    {
        public DomainException (string message) : base(message)
        {
        }
    }
}
