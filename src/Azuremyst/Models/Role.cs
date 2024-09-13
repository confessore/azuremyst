// Copyright (c) Balanced Solutions Software.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using Azuremyst.Models.Abstractions;
using Azuremyst.Models.Enums;
using Azuremyst.Models.Interfaces;

namespace Azuremyst.Models;

public sealed class Role : Entity<ulong>, IEntity<ulong>
{
    public RoleType RoleType { get; set; }
}
