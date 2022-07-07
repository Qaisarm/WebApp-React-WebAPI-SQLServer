using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ActivityController : ControllerBase
{

    private readonly MyAppContext _context; 
    public ActivityController(MyAppContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
       return Ok(_context.ActivityList);
    }
     [HttpPost]
     public async Task<IActionResult> Add(CreateModel request )
     {
         var activityModel = new ActivityModel() {
            Title = request.Title,
             Category = request.Category,
              DateOpened = request.DateOpened,
               ExpiryDate = request.ExpiryDate};
         _context.ActivityList.Add(activityModel);
                 await _context.SaveChangesAsync();
        return Ok(_context.ActivityList);
    }
}