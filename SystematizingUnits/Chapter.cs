using System.Collections.Generic;

namespace ModelDto.SystematizingUnits
{
    /// <summary>
    /// Jednostka systematyzująca: rozdział
    /// </summary>
    public class Chapter : BaseEntity, ISystematizingUnit
    {
        /// <summary>
        /// Tytuł rozdziału (np. "Warunki przyjęcia", "Odpowiedzialność przewoźnika")
        /// </summary>
        public string Heading { get; set; } = string.Empty;

        public Chapter()
        {
            UnitType = UnitType.Chapter;
            EIdPrefix = "roz";
            DisplayLabel = "roz.";
        }

        public List<Subchapter> Sections { get; set; } = new();
    }
}