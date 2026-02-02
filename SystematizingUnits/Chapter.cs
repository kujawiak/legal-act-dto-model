using System.Collections.Generic;

namespace ModelDto.SystematizingUnits
{
    /// <summary>
    /// Jednostka systematyzująca: rozdział
    /// </summary>
    public class Chapter : BaseEntity
    {
        public Chapter()
        {
            UnitType = UnitType.Chapter;
            EIdPrefix = "roz";
            DisplayLabel = "roz.";
        }

        public List<Subchapter> Sections { get; set; } = new();
    }
}