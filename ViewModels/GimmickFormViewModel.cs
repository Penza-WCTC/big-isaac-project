using Microsoft.AspNetCore.Mvc.Rendering;
using big_isaac_project.Models;

namespace big_isaac_project.ViewModels;

public class GimmickFormViewModel
{
    public Gimmicks Gimmick { get; set; } = new();

    public SelectList? Characters { get; set; }
}