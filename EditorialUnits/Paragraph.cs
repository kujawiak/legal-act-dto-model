using System;
using System.Collections.Generic;
using ModelDto;

#nullable enable

namespace ModelDto.EditorialUnits
{
    /// <summary>
    /// Model ustepu artykulu (Paragraph) - definicja struktury bez logiki parsowania.
    /// Paragraph zawiera co najmniej jeden punkt lub tekst bezposrednio.
    /// Czesci wspolne dla listy punktow wystepuja na tym samym poziomie co punkty.
    /// </summary>
    public class Paragraph : BaseEntity, IHasCommonParts, IHasTextSegments
    {
        /// <summary>
        /// Czesci wspolne na poziomie ustepu (np. intro/wrapUp wobec listy punktow).
        /// Wystepuja jako rodzenstwo punktow.
        /// </summary>
        public List<CommonPart> CommonParts { get; set; } = new();

        /// <summary>
        /// Segmenty tekstu (np. zdania) w obrebie ustepu.
        /// Umozliwiaja kotwiczenie nowelizacji do konkretnego zdania.
        /// </summary>
        public List<TextSegment> TextSegments { get; set; } = new();

        public List<Point> Points { get; set; } = new();
        public List<Amendment> Amendments { get; set; } = new();

        /// <summary>
        /// Role moze okreslac specjalne mapowania/nazewnictwo (np. "prg" dla paragrafu w kodeksie).
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
