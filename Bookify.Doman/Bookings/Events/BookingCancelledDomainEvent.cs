using Bookify.Doman.Abstractions;

namespace Bookify.Doman.Bookings.Events;

public sealed record BookingCancelledDomainEvent(Guid BookingId) : IDomainEvent;
