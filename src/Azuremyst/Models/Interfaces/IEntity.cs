// Copyright (c) Balanced Solutions Software.  All Rights Reserved.  Licensed under the MIT license.  See LICENSE in the project root for license information.

namespace Azuremyst.Models.Interfaces;

public interface IEntity<TId>
    where TId : IEquatable<TId>
{
    TId Id { get; set; }
    string? Guid { get; set; }
    DateTime? CreatedAt { get; set; }
    TId? CreatedBy { get; set; }
    DateTime? UpdatedAt { get; set; }
    TId? UpdatedBy { get; set; }
}
