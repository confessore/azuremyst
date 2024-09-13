using Azuremyst.Models;
using Azuremyst.Queries;
using Azuremyst.Services;
using MediatR;

namespace Azuremyst.QueryHandlers;

public class GetUserByIdQueryHandler(UserService _userService)
    : IRequestHandler<GetUserByIdQuery, User?>
{
    public async Task<User?> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
    {
        var user = await _userService.GetUserByIdAsync(request.Id);
        return user;
    }
}
