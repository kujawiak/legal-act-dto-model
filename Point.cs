using System;
using System.Collections.Generic;

#nullable enable

namespace ModelDto
{
    /// <summary>
    /// Model punktu ustępu - zawiera definicję struktury bez logiki parsowania.
    /// Punkt zawiera litery lub tekst bezpośrednio.
    /// </summary>
    public class Point : BaseEntity
    {
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
