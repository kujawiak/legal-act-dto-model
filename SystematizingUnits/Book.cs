using System.Collections.Generic;

namespace ModelDto.SystematizingUnits
{
    /// <summary>
    /// Jednostka systematyzująca: księga
    /// </summary>
    public class Book : BaseEntity
    {
        public Book()
        {
            UnitType = UnitType.Book;
            EIdPrefix = "ks";
            DisplayLabel = "ks.";
        }

        public List<Title> Titles { get; set; } = new();
    }
}