using AEBackend.Controllers;
using AEBackend.Controllers.Utils;
using AEBackend.DomainModels;
using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]

public class ShipsController : ApplicationController
{
  [HttpGet]
  [SwaggerOperation("See all ships in the system")]
  public Task<ApiResult<List<User>>> Get()
  {
    throw new Exception();
  }

  [HttpPost]
  [SwaggerOperation("Add a ship to the system")]
  public Task<ApiResult<List<User>>> Add()
  {
    throw new Exception();
  }

  [HttpPut("{0}/Velocity")]
  [SwaggerOperation("Update velocity of a ship")]
  public Task<ApiResult<List<User>>> UpdateVelocity()
  {
    throw new Exception();
  }
  [HttpGet("Unassigneds")]
  [SwaggerOperation("See ships unassigned in the system")]
  public Task<ApiResult<List<User>>> GetUnassigneds()
  {
    throw new Exception();
  }

  [HttpGet("NearestPort")]
  [SwaggerOperation("See the nearest port to a ship with estimated arrival time to the port together with relevant details")]
  public Task<ApiResult<NearestPortInfo>> GetNearest()
  {
    throw new Exception();
  }

}