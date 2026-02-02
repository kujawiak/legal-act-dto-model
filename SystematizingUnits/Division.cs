using System.Collections.Generic;

namespace ModelDto.SystematizingUnits
{
    /// <summary>
    /// Jednostka systematyzująca: oddział
    /// </summary>
    public class Division : BaseEntity
    {
        public Division()
        {
            UnitType = UnitType.Division;
            EIdPrefix = "oddz";
            DisplayLabel = "oddz.";
        }

        public List<Chapter> Chapters { get; set; } = new();
    }
}