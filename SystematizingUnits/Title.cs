using System.Collections.Generic;

namespace ModelDto.SystematizingUnits
{
    /// <summary>
    /// Jednostka systematyzująca: tytuł
    /// </summary>
    public class Title : BaseEntity, ISystematizingUnit
    {
        /// <summary>
        /// Tytuł sekcji (np. "Podmioty prawa cywilnego", "Spadki")
        /// </summary>
        public string Heading { get; set; } = string.Empty;

        public Title()
        {
            UnitType = UnitType.Title;
            EIdPrefix = "tyt";
            DisplayLabel = "tyt.";
        }

        public List<Division> Divisions { get; set; } = new();
    }
}