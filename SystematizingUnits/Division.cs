using System.Collections.Generic;

namespace ModelDto.SystematizingUnits
{
    /// <summary>
    /// Jednostka systematyzująca: oddział
    /// </summary>
    public class Division : BaseEntity, ISystematizingUnit
    {
        /// <summary>
        /// Tytuł oddziału (np. "Ochrona środowiska", "Bezpieczeństwo i higiena pracy")
        /// </summary>
        public string Heading { get; set; } = string.Empty;

        public Division()
        {
            UnitType = UnitType.Division;
            EIdPrefix = "oddz";
            DisplayLabel = "oddz.";
        }

        public List<Chapter> Chapters { get; set; } = new();
    }
}