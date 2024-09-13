using Azuremyst.Commands;
using Azuremyst.Models;
using Azuremyst.Services;
using MediatR;

namespace Azuremyst.CommandHandlers;

public class AddUserCommandHandler(UserService userService) : IRequestHandler<AddUserCommand, User?>
{
    private readonly UserService _userService = userService;

    public async Task<User?> Handle(AddUserCommand request, CancellationToken cancellationToken)
    {
        var user = await _userService.UpsertUserAsync(request.User);
        return user;
    }
}
