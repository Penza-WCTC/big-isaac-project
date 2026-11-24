namespace big_isaac_project.Dtos;

// One line of a truck's menu, as the API says it. The dish's name instead of
// a Dish object, and no way back to the truck.
public class GimmickDto
{
    public DateTime ReleaseDate { get; set; }
    public string Gimmick { get; set; } = "";

}