﻿namespace Endpoint.DTO.Resources;

public class QueryResultResource<T>
{
    public int TotalItems { get; set; }
    public IEnumerable<T> Items { get; set; }
}
