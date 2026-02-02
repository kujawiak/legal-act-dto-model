using System;
using System.Collections.Generic;

#nullable enable

namespace ModelDto
{
    /// <summary>
    /// Model ustępu artykułu (Paragraph) - definicja struktury bez logiki parsowania.
    /// Paragraph zawiera co najmniej jeden punkt lub tekst bezpośrednio.
    /// </summary>
    public class Paragraph : BaseEntity
    {
        public List<Point> Points { get; set; } = new();
        public List<Amendment> Amendments { get; set; } = new();

        /// <summary>
        /// Role może określać specjalne mapowania/nazewnictwo (np. "prg" dla paragrafu w kodeksie).
        /// </summary>
        public string? Role { get; set; }

        public Paragraph()
        {
            UnitType = UnitType.Paragraph;
            EIdPrefix = "ust";
            DisplayLabel = "ust.";
        }
    }
}