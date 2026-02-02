using System.Collections.Generic;

namespace ModelDto.SystematizingUnits
{
    /// <summary>
    /// Jednostka systematyzująca: część
    /// </summary>
    public class Part : BaseEntity
    {
        public Part()
        {
            UnitType = UnitType.Part;
            EIdPrefix = "cz";
            DisplayLabel = "cz.";
        }

        public List<Book> Books { get; set; } = new();
    }
}