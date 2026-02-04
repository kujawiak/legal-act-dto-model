using System;
using System.Collections.Generic;

namespace ModelDto
{
    /// <summary>
    /// Model artykułu ustawy - zawiera definicję struktury bez logiki.
    /// Artykuł zawiera co najmniej jeden ustęp.
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
