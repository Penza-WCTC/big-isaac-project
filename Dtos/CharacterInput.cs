using System.ComponentModel.DataAnnotations;

namespace big_isaac_project.Dtos;

// What the API accepts for a truck. The same rules as the Truck class, and
// only the properties a client may send: no Id, and no Specials.
public class CharacterInput
{
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

    public string? FavoriteDetails{get; set;}
}