using Bookify.Doman.Abstractions;

namespace Bookify.Doman.Bookings.Events;

public sealed record BookingRejectedDomainEvent(Guid BookingId) : IDomainEvent;
