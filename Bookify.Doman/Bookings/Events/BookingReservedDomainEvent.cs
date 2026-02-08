using Bookify.Doman.Abstractions;

namespace Bookify.Doman.Bookings.Events;

public sealed record BookingReservedDomainEvent(Guid BookingId) : IDomainEvent;
