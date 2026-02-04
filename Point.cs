using System;
using System.Collections.Generic;

#nullable enable

namespace ModelDto
{
    /// <summary>
    /// Model punktu ustępu - zawiera definicję struktury bez logiki parsowania.
    /// Punkt może zawierać:
    /// - CommonParts (intro/wrapUp) na tym samym poziomie co litery
    /// - Litery lub tekst bezpośrednio
    /// </summary>
    public class Point : BaseEntity, IHasCommonParts, IHasTextSegments
    {
        /// <summary>
        /// Części wspólne na poziomie punktu (np. intro/wrapUp wobec listy liter).
        /// Występują jako rodzeństwo liter, nie jako ich element.
        /// </summary>
        public List<CommonPart> CommonParts { get; set; } = new();

        /// <summary>
        /// Segmenty tekstu (np. zdania) w obrębie punktu.
        /// Umożliwiają kotwiczenie nowelizacji do konkretnego zdania.
        /// </summary>
        public List<TextSegment> TextSegments { get; set; } = new();

        /// <summary>
        /// Litery wchodzące w skład punktu.
        /// </summary>
        public List<Letter> Letters { get; set; } = new();

        public List<Amendment> Amendments { get; set; } = new();

        public Point()
        {
            UnitType = UnitType.Point;
            EIdPrefix = "pkt";
            DisplayLabel = "pkt";
        }
    }
}
