using System;
using System.Collections.Generic;
using ModelDto;

#nullable enable

namespace ModelDto.EditorialUnits
{
    /// <summary>
    /// Model tiret - zawiera definicje struktury bez logiki parsowania.
    /// Tiret to wyliczeniowa jednostka w hierarchii.
    /// Czesci wspolne wystepuja jako rodzenstwo tiretow na poziomie litery.
    /// </summary>
    public class Tiret : BaseEntity, IHasTextSegments
    {
        /// <summary>
        /// Segmenty tekstu (np. zdania) w obrebie tiretu.
        /// Umozliwiaja kotwiczenie nowelizacji do konkretnego zdania.
        /// </summary>
        public List<TextSegment> TextSegments { get; set; } = new();

        public List<Amendment> Amendments { get; set; } = new();

        public Tiret()
        {
            UnitType = UnitType.Tiret;
            EIdPrefix = "tir";
            DisplayLabel = "tiret";
        }
    }
}
