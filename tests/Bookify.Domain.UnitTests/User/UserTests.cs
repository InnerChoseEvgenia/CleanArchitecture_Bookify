using Bookify.Domain.UnitTests.Infrastructure;
using Bookify.Doman.Users.Events;
using Bookify.Doman.Users;
using System.Data;
using Shouldly;

namespace Bookify.Domain.UnitTests.User;

public class UserTests : BaseTest
{
    [Fact]
    public void Create_Should_SetPropertyValue()
    {
        // Act
        var user = Bookify.Doman.Users.User.Create(UserData.FirstName, UserData.LastName, UserData.Email);

        // Assert
        user.FirstName.ShouldBe(UserData.FirstName);
        user.LastName.ShouldBe(UserData.LastName);
        user.Email.ShouldBe(UserData.Email);
    }

    [Fact]
    public void Create_Should_RaiseUserCreatedDomainEvent()
    {
        // Act
        var user = Bookify.Doman.Users.User.Create(UserData.FirstName, UserData.LastName, UserData.Email);

        // Assert
        var userCreatedDomainEvent = AssertDomainEventWasPublished<UserCreatedDomainEvent>(user);

        userCreatedDomainEvent.UserId.ShouldBe(user.Id);
    }
}
