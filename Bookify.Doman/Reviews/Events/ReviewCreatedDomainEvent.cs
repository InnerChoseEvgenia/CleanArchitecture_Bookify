using Bookify.Doman.Abstractions;

namespace Bookify.Doman.Reviews.Events;

public sealed record ReviewCreatedDomainEvent(Guid ReviewId) : IDomainEvent;
