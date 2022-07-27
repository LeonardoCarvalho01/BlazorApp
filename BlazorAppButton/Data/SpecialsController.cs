﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppButton.Data;

[Route("specials")]
[ApiController]
public class SpecialsController : Controller
{
    private readonly PizzaStoreContext _db;

    public SpecialsController(PizzaStoreContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<List<Pizza>>> GetSpecials()
    {
        return (await _db.Pizza.ToListAsync()).OrderByDescending(s => s.BasePrice).ToList();
    }
}