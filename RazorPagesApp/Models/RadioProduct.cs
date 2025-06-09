using RazorPagesApp.Models;
using System.ComponentModel.DataAnnotations;

public class RadioProduct : Product
{
    [Display(Name = "Назначение")]
    public string Purpose { get; set; } = string.Empty;
}

// Models/DairyProduct.cs - молочные продукты
public class DairyProduct : Product
{
    [Display(Name = "Разновидность")]
    public string Variety { get; set; } = string.Empty;

    [Display(Name = "Дата изготовления")]
    [DataType(DataType.Date)]
    public DateTime ProductionDate { get; set; }
}