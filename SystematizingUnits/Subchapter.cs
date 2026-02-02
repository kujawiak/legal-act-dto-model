using System.Collections.Generic;

namespace ModelDto.SystematizingUnits
{
    /// <summary>
    /// Jednostka systematyzująca: oddział
    /// </summary>
    public class Subchapter : BaseEntity
    {
        public Subchapter()
        {
            UnitType = UnitType.Subchapter;
            EIdPrefix = "oddz";
            DisplayLabel = "oddz.";
        }

        // oddziały zazwyczaj zawierają artykuły
        public List<Article> Articles { get; set; } = new();
    }
}