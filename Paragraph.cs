using System;
using System.Collections.Generic;

#nullable enable

namespace ModelDto
{
    /// <summary>
    /// Model ustępu artykułu (Paragraph) - definicja struktury bez logiki parsowania.
    /// Paragraph zawiera co najmniej jeden punkt lub tekst bezpośrednio.
    /// Części wspólne dla listy punktów występują na tym samym poziomie co punkty.
    /// </summary>
    public class Paragraph : BaseEntity, IHasCommonParts
    {
        /// <summary>
        /// Części wspólne na poziomie ustępu (np. intro/wrapUp wobec listy punktów).
        /// Występują jako rodzeństwo punktów.
        /// </summary>
        public List<CommonPart> CommonParts { get; set; } = new();

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