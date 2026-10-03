namespace big_isaac_project.Models;

public static class CharacterData
{

    public static List<Character> All {get;} = new()
    {
        new Character {Id = 1, Name = "Isaac", Health = 3, Speed = 2, Damage = 2},
        new Character {Id = 2, Name = "Magdalene", Health = 4, Speed = 1, Damage = 2},
        new Character {Id = 3, Name = "Cain", Health = 2, Speed = 3, Damage = 3},
        new Character {Id = 4, Name = "Judas", Health = 1, Speed = 2, Damage = 4},
        new Character {Id = 5, Name = "???", Health = -1, Speed = 2, Damage = 2},
        new Character {Id = 6, Name = "Eve", Health = 2, Speed = 3, Damage = 1},
        new Character {Id = 7, Name = "Samson", Health = 3, Speed = 2, Damage = 2},
        new Character {Id = 8, Name = "Azazel", Health = -1, Speed = 3, Damage = 4},
        new Character {Id = 9, Name = "Lazarus", Health = 3, Speed = 2, Damage = 2},
        new Character {Id = 10, Name = "Eden", Health = 0, Speed = 0, Damage = 0},
        new Character {Id = 11, Name = "The Lost", Health = 0, Speed = 2, Damage = 2},
        new Character {Id = 12, Name = "Lilith", Health = 1, Speed = 2, Damage = 2},
        new Character {Id = 13, Name = "Apollyon", Health = 2, Speed = 2, Damage = 2},
        new Character {Id = 14, Name = "The Forgotten", Health = -1, Speed = 2, Damage = 4},
        new Character {Id = 15, Name = "Bethany", Health = 3, Speed = 2, Damage = 2},
        new Character {Id = 16, Name = "Jacob & Esau", Health = 3, Speed = 2, Damage = 3},

        new Character {Id = 17, Name = "Tainted Isaac", Health = 3, Speed = 2, Damage = 2},
        new Character {Id = 18, Name = "Tainted Magdalene", Health = 4, Speed = 2, Damage = 1},
        new Character {Id = 19, Name = "Tainted Cain", Health = 2, Speed = 3, Damage = 2},
        new Character {Id = 20, Name = "Tainted Judas", Health = -1, Speed = 3, Damage = 2},
        new Character {Id = 21, Name = "Tainted ???", Health = -1, Speed = 1, Damage = 1},
        new Character {Id = 22, Name = "Tainted Eve", Health = 2, Speed = 3, Damage = 1},
        new Character {Id = 23, Name = "Tainted Samson", Health = 3, Speed = 2, Damage = 1},
        new Character {Id = 24, Name = "Tainted Azazel", Health = -1, Speed = 2, Damage = 4},
        new Character {Id = 25, Name = "Tainted Lazarus", Health = 3, Speed = 2, Damage = 2},
        new Character {Id = 26, Name = "Tainted Eden", Health = 0, Speed = 0, Damage = 0},
        new Character {Id = 27, Name = "Tainted Lost", Health = 0, Speed = 2, Damage = 3},
        new Character {Id = 28, Name = "Tainted Lilith", Health = 1, Speed = 2, Damage = 2},
        new Character {Id = 29, Name = "Tainted Apollyon", Health = 2, Speed = 2, Damage = 1},
        new Character {Id = 30, Name = "Tainted The Forgotten", Health = -1, Speed = -1, Damage = 4},
        new Character {Id = 31, Name = "Tainted Bethany", Health = -1, Speed = 2, Damage = 2},
        new Character {Id = 32, Name = "Tainted Jacob", Health = 3, Speed = 2, Damage = 3}
    };
}