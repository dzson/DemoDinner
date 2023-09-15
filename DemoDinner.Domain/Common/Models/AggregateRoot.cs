﻿namespace DemoDinner.Domain.Common.Models;

public abstract class AggregateRoot<TId> : Entity<TId>
    where TId : notnull
{
    public AggregateRoot(TId id) : base(id)
    {
        
    }
}
