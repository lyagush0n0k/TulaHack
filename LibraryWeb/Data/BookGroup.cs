using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWeb.Models
{
    public enum BookGroup
    {
        [Display(Name = "Акустика")]
        Acoustics,
        [Display(Name = "Физика")]
        Physics,
        [Display(Name = "Математика")]
        Mathematics,
        [Display(Name = "Астрономия")]
        Astronomy,
        [Display(Name = "Биология")]
        Biology,
        [Display(Name = "Информатика")]
        Informatics,
        [Display(Name = "Инжинерия")]
        Engineering,
        [Display(Name = "Строительная инжинерия")]
        BuildingEngineering,
        [Display(Name = "История")]
        History,
        NonFiction,
        [Display(Name = "Архитектура")]
        Architecture,
        [Display(Name = "Дизайн")]
        Design,
        [Display(Name = "Графический дизайн")]
        GraphicDesign,
        [Display(Name = "Индустриальный дизайн")]
        IndustrialDesign,
        [Display(Name = "Искусство")]
        Art,
        [Display(Name = "Нет")]
        None
    }
}
