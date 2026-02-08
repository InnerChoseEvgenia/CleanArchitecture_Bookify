using Bookify.Doman.Abstractions;

namespace Bookify.Doman.Bookings.Events;

public sealed record BookingConfirmedDomainEvent(Guid BookingId) : IDomainEvent;
