using System;
using System.Collections.Generic;

#nullable enable

namespace ModelDto
{
    /// <summary>
    /// Model litery punktu - zawiera definicję struktury bez logiki parsowania.
    /// Litera może zawierać:
    /// - CommonPart intro (wprowadzenie do wyliczenia tiretów)
    /// - Tirety lub tekst bezpośrednio
    /// - CommonPart wrapUp (część wspólna po liście tiretów)
    /// Numer litery przechowywany jest w EntityNumber (dziedziczony z BaseEntity),
    /// gdzie część liczbowa jest pusta, a wartość zawiera symbol litery (np. "a", "b", "aa" itp.).
    /// </summary>
    public class Letter : BaseEntity
    {
        /// <summary>
        /// Część wspólna (wprowadzenie) przed listą tiretów.
        /// Zazwyczaj zawiera tekst typu "gdzie:" lub "mianowicie:".
        /// </summary>
        public CommonPart? CommonPartIntro { get; set; }

        /// <summary>
        /// Tirety wchodzące w skład litery.
        /// </summary>
        public List<Tiret> Tirets { get; set; } = new();

        /// <summary>
        /// Część wspólna (końcowa) po liście tiretów.
        /// Zawiera tekst wspólny dla wszystkich wariantów.
        /// </summary>
        public CommonPart? CommonPartWrapUp { get; set; }

        public List<Amendment> Amendments { get; set; } = new();

        public Letter()
        {
            UnitType = UnitType.Letter;
            EIdPrefix = "lit";
            DisplayLabel = "lit";
        }
    }
}
