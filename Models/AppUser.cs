using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace big_isaac_project.Models;

public class AppUser : IdentityUser
{
    [StringLength(40)]
    public string DisplayName {get;set;} = "";
}