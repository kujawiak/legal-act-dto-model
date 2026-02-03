using System.Collections.Generic;

namespace ModelDto.SystematizingUnits
{
    /// <summary>
    /// Jednostka systematyzująca: księga
    /// </summary>
    public class Book : BaseEntity, ISystematizingUnit
    {
        /// <summary>
        /// Tytuł księgi (np. "Własność", "Zobowiązania")
        /// </summary>
        public string Heading { get; set; } = string.Empty;

        public Book()
        {
            UnitType = UnitType.Book;
            EIdPrefix = "ks";
            DisplayLabel = "ks.";
        }

        public List<Title> Titles { get; set; } = new();
    }
}