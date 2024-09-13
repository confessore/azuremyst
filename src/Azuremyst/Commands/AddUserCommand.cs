using Azuremyst.Models;
using MediatR;

namespace Azuremyst.Commands;

public record AddUserCommand(User User) : IRequest<User?> { }
