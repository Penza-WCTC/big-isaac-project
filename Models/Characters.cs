using System.ComponentModel.DataAnnotations;

namespace big_isaac_project.Models;

public class Character
{
    public int Id{ get; set;}

    [Required(ErrorMessage = "Every Character has to have a name!")]
    [StringLength(50)]
    public string Name {get; set;} = "";

    [Required]
    [Range(-1,5, ErrorMessage = "Health goes from {1} to {2}.")]
    public double Health{get; set;}

    [Required]
    [Range(-1,5, ErrorMessage = "Speed goes from {1} to {2}.")]
    public double Speed{get; set;}

    [Required]
    [Range(-1,5, ErrorMessage = "Damage goes from {1} to {2}.")]
    public double Damage{get; set;}
}