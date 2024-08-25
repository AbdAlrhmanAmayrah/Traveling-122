﻿




using Booking.Domain.Entities;
using Booking.Domain.Interfaces.Persistence.Repositories;
using Booking.Infrastrature.Data;

namespace Booking.Infrastrature.Persistence.Repositories;
public class RoomBookingRepository : Repository<RoomBooking>, IRoomBookingRepository
{
    public RoomBookingRepository(ApplicationDbContext Context) : base(Context)
    {
    }
}