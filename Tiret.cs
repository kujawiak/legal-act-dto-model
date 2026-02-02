using System;
using System.Collections.Generic;

#nullable enable

namespace ModelDto
{
    /// <summary>
    /// Model tiret litery - zawiera definicję struktury bez logiki parsowania.
    /// Tiret to najmniejsza jednostka struktury aktu prawnego.
    /// </summary>
    public class Tiret : BaseEntity
    {
        public List<Amendment> Amendments { get; set; } = new();

        public Tiret()
        {
            UnitType = UnitType.Tiret;
            EIdPrefix = "tir";
            DisplayLabel = "tiret";
        }
    }
}
