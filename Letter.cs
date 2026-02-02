using System;
using System.Collections.Generic;

#nullable enable

namespace ModelDto
{
    /// <summary>
    /// Model litery punktu - zawiera definicję struktury bez logiki parsowania.
    /// Litera zawiera tirets lub tekst bezpośrednio.
    /// Numer litery przechowywany jest w EntityNumber (dziedziczony z BaseEntity),
    /// gdzie część liczbowa jest pusta, a wartość zawiera symbol litery (np. "a", "b", "aa" itp.).
    /// </summary>
    public class Letter : BaseEntity
    {
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
