// Copyright (c) Balanced Solutions Software.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

using Azuremyst.Models.Interfaces;

namespace Azuremyst.Models.Abstractions;

public abstract class Entity<TId> : IEntity<TId>
    where TId : IEquatable<TId>
{
    public TId Id { get; set; } = default!;
    public string? Guid { get; set; }
    public DateTime? CreatedAt { get; set; }
    public TId? CreatedBy { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public TId? UpdatedBy { get; set; }
}
