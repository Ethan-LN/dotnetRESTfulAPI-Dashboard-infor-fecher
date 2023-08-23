using Microsoft.AspNetCore.Mvc;
using ManageStaff.Models;
using ManageStaff.Data;

[ApiController]
[Route("[controller]")]
public class ManageStaffController : ControllerBase
{
    private readonly ManageStaffContext _DBContext;

    public ManageStaffController(ManageStaffContext dbcontext)
    {
        this._DBContext=dbcontext;
    }

    [HttpGet("GETALL")]
    public IActionResult GetAll()
    {
        var staff=this._DBContext.Staff.ToList();
        return Ok(staff);
    }
}