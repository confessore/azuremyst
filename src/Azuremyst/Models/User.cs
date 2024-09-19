// Copyright (c) Balanced Solutions Software.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using Azuremyst.Models.Abstractions;
using Azuremyst.Models.Interfaces;

namespace Azuremyst.Models;

public class User : Entity<ulong>, IEntity<ulong>
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public int Soj { get; set; } // stone of jordan
}
