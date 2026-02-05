using System;
using System.Collections.Generic;
using ModelDto;

#nullable enable

namespace ModelDto.EditorialUnits
{
    /// <summary>
    /// Model litery punktu - zawiera definicje struktury bez logiki parsowania.
    /// Litera moze zawierac:
    /// - CommonParts (intro/wrapUp) na tym samym poziomie co tirety
    /// - Tirety lub tekst bezposrednio
    /// Numer litery przechowywany jest w EntityNumber (dziedziczony z BaseEntity),
    /// gdzie czesc liczbowa jest pusta, a wartosc zawiera symbol litery (np. "a", "b", "aa" itp.).
    /// </summary>
    public class Letter : BaseEntity, IHasCommonParts, IHasTextSegments
    {
        /// <summary>
        /// Czesci wspolne na poziomie litery (np. intro/wrapUp wobec listy tiretow).
        /// Wystepuja jako rodzenstwo tiretow, nie jako ich element.
        /// </summary>
        public List<CommonPart> CommonParts { get; set; } = new();

        /// <summary>
        /// Segmenty tekstu (np. zdania) w obrebie litery.
        /// Umozliwiaja kotwiczenie nowelizacji do konkretnego zdania.
        /// </summary>
        public List<TextSegment> TextSegments { get; set; } = new();

        /// <summary>
        /// Tirety wchodzace w sklad litery.
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
