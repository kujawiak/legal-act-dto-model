using System;
using System.Collections.Generic;

#nullable enable

namespace ModelDto
{
    /// <summary>
    /// Model tiret - zawiera definicję struktury bez logiki parsowania.
    /// Tiret to wyliczeniowa jednostka w hierarchii (może zawierać CommonParts).
    /// Tiret może zawierać:
    /// - CommonPart intro (wprowadzenie, zwykle rzadkie)
    /// - Tekst bezpośrednio
    /// - CommonPart wrapUp (część wspólna po tekście)
    /// </summary>
    public class Tiret : BaseEntity
    {
        /// <summary>
        /// Część wspólna (wprowadzenie) przed tekstem tiret.
        /// Zazwyczaj pusta, ale możliwe dla złożonych struktur.
        /// </summary>
        public CommonPart? CommonPartIntro { get; set; }

        /// <summary>
        /// Część wspólna (końcowa) po tekście tiret.
        /// Zawiera tekst wspólny dla wariantów lub dopiski.
        /// </summary>
        public CommonPart? CommonPartWrapUp { get; set; }

        public List<Amendment> Amendments { get; set; } = new();

        public Tiret()
        {
            UnitType = UnitType.Tiret;
            EIdPrefix = "tir";
            DisplayLabel = "tiret";
        }
    }
}
