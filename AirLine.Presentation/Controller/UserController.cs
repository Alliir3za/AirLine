﻿using MassTransit.Mediator;
using Microsoft.AspNetCore.Mvc;

namespace AirLine.Presentation.Controller;
public class UserController : ControllerBase
{
    private readonly IMediator _mediator;

    public UserController(IMediator mediator)
    {
        _mediator = mediator;
    }


    //[HttpGet]
    //public async Task<IActionResult> GetUsers()
    //{

    //}
}
