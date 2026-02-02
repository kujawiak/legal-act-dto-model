using System;
using System.Collections.Generic;

#nullable enable

namespace ModelDto
{
    /// <summary>
    /// Model punktu ustępu - zawiera definicję struktury bez logiki parsowania.
    /// Punkt może zawierać:
    /// - CommonPart intro (wprowadzenie do wyliczenia liter)
    /// - Litery lub tekst bezpośrednio
    /// - CommonPart wrapUp (część wspólna po liście)
    /// </summary>
    public class Point : BaseEntity
    {
        /// <summary>
        /// Część wspólna (wprowadzenie) przed listą liter.
        /// Zazwyczaj zawiera tekst typu "gdzie:" lub "mianowicie:".
        /// </summary>
        public CommonPart? CommonPartIntro { get; set; }

        /// <summary>
        /// Litery wchodzące w skład punktu.
        /// </summary>
        public List<Letter> Letters { get; set; } = new();

        /// <summary>
        /// Część wspólna (końcowa) po liście liter.
        /// Zawiera tekst wspólny dla wszystkich wariantów.
        /// </summary>
        public CommonPart? CommonPartWrapUp { get; set; }

        public List<Amendment> Amendments { get; set; } = new();

        public Point()
        {
            UnitType = UnitType.Point;
            EIdPrefix = "pkt";
            DisplayLabel = "pkt";
        }
    }
}
