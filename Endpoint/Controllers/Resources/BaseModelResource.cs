﻿using System.ComponentModel.DataAnnotations;

namespace Endpoint.Controllers.Resources;

public class BaseModelResource
{
    private Guid? _id { get; set; }

    [Required(ErrorMessage = "Id mangler")]
    public Guid Id
    {
        get { return (Guid)_id; }
        set { _id = value; }
    }
    public BaseModelResource()
    {
        _id = Guid.NewGuid();
    }
}
