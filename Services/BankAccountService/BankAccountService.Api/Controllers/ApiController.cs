using Microsoft.AspNetCore.Mvc;

namespace BankAccountService.Api.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
    }
}
