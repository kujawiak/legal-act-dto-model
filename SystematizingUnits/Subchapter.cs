using System.Collections.Generic;

namespace ModelDto.SystematizingUnits
{
    /// <summary>
    /// Jednostka systematyzująca: podrozdział
    /// </summary>
    public class Subchapter : BaseEntity, ISystematizingUnit
    {
        /// <summary>
        /// Tytuł podrodzdziału (np. "Zakres stosowania", "Definicje")
        /// </summary>
        public string Heading { get; set; } = string.Empty;

        public Subchapter()
        {
            UnitType = UnitType.Subchapter;
            EIdPrefix = "podroz";
            DisplayLabel = "podroz.";
        }

        // podrozdziały zazwyczaj zawierają artykuły
        public List<Article> Articles { get; set; } = new();
    }
}