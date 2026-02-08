using Bookify.Doman.Abstractions;

namespace Bookify.Doman.Users.Events;

public sealed record UserCreatedDomainEvent(Guid UserId) : IDomainEvent;
