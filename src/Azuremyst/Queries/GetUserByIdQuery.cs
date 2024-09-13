using Azuremyst.Models;
using MediatR;

namespace Azuremyst.Queries;

public record GetUserByIdQuery(ulong Id) : IRequest<User?> { }
