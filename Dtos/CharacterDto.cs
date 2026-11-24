namespace big_isaac_project.Dtos;

// What the API says about a truck. A DTO is a class whose only job is the
// shape of the JSON, so the JSON stops being whatever the table looks like.
public class CharacterDto
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public double Health { get; set; }
    public double Speed { get; set; }
    public double Damage { get; set; }
    public List<GimmickDto> Gimmicks { get; set; } = new();
}