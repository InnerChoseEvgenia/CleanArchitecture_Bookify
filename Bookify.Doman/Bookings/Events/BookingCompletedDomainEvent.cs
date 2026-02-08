using Bookify.Doman.Abstractions;

namespace Bookify.Doman.Bookings.Events;

public sealed record BookingCompletedDomainEvent(Guid BookingId) : IDomainEvent;
