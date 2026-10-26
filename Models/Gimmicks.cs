using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;

namespace big_isaac_project.Models;

public class Gimmicks{
    public int Id {get; set;}

    public DateTime ReleaseDate {get; set;}

    [Required(ErrorMessage = "What is the gimmick of this character?")]
    public string Gimmick {get; set;} = "";

    [Display(Name = "Character")]
    public int CharacterId {get; set;}

    public Character? Character {get; set;}
}
