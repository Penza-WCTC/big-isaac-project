using big_isaac_project.Models;

namespace big_isaac_project.ViewModels;

public class CharacterDetailsViewModel
{
    public Character Character {get; set;} = null!;
    public List<Character> AlsoHere {get; set;} = new();
}