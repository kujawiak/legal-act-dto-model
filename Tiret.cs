using System;
using System.Collections.Generic;

#nullable enable

namespace ModelDto
{
    /// <summary>
    /// Model tiret - zawiera definicję struktury bez logiki parsowania.
    /// Tiret to wyliczeniowa jednostka w hierarchii.
    /// Części wspólne występują jako rodzeństwo tiretów na poziomie litery.
    /// </summary>
    public class Tiret : BaseEntity, IHasTextSegments
    {
        /// <summary>
        /// Segmenty tekstu (np. zdania) w obrębie tiretu.
        /// Umożliwiają kotwiczenie nowelizacji do konkretnego zdania.
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
