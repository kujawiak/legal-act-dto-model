using System;
using System.Collections.Generic;
using ModelDto;

namespace ModelDto.EditorialUnits
{
    /// <summary>
    /// Model artykulu ustawy - zawiera definicje struktury bez logiki.
    /// Artykul zawiera co najmniej jeden ustep.
    /// </summary>
    public class Article : BaseEntity
    {
        public List<Paragraph> Paragraphs { get; set; } = new();
        public List<JournalInfo> Journals { get; set; } = new();

        public bool IsAmending => Journals.Count > 0;

        public Article()
        {
            UnitType = UnitType.Article;
            EIdPrefix = "art";
            DisplayLabel = "art.";
        }
    }
}
