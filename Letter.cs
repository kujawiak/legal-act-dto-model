using System;
using System.Collections.Generic;

#nullable enable

namespace ModelDto
{
    /// <summary>
    /// Model litery punktu - zawiera definicję struktury bez logiki parsowania.
    /// Litera może zawierać:
    /// - CommonParts (intro/wrapUp) na tym samym poziomie co tirety
    /// - Tirety lub tekst bezpośrednio
    /// Numer litery przechowywany jest w EntityNumber (dziedziczony z BaseEntity),
    /// gdzie część liczbowa jest pusta, a wartość zawiera symbol litery (np. "a", "b", "aa" itp.).
    /// </summary>
    public class Letter : BaseEntity, IHasCommonParts, IHasTextSegments
    {
        /// <summary>
        /// Części wspólne na poziomie litery (np. intro/wrapUp wobec listy tiretów).
        /// Występują jako rodzeństwo tiretów, nie jako ich element.
        /// </summary>
        public List<CommonPart> CommonParts { get; set; } = new();

        /// <summary>
        /// Segmenty tekstu (np. zdania) w obrębie litery.
        /// Umożliwiają kotwiczenie nowelizacji do konkretnego zdania.
        /// </summary>
        public List<TextSegment> TextSegments { get; set; } = new();

        /// <summary>
        /// Tirety wchodzące w skład litery.
        /// </summary>
        public List<Tiret> Tirets { get; set; } = new();

        public List<Amendment> Amendments { get; set; } = new();

        public Letter()
        {
            UnitType = UnitType.Letter;
            EIdPrefix = "lit";
            DisplayLabel = "lit";
        }
    }
}
