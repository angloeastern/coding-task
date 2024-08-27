using System.Text.Json.Serialization;
using AEBackend.DomainModels;
using Microsoft.AspNetCore.Identity;

namespace AEBackend.DomainModels;

public class ApplicationUserRole : IdentityUserRole<string>
{
  [JsonIgnore]
  public override string UserId { get; set; }
  [JsonIgnore]
  public override string? RoleId { get; set; }

  [JsonIgnore]
  public virtual User? User { get; set; }
  public virtual ApplicationRole? Role { get; set; }
}