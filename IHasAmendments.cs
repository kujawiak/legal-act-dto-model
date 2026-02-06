#nullable enable

using System.Collections.Generic;

namespace ModelDto
{
    /// <summary>
    /// Kontrakt dla jednostek, ktore zawieraja nowelizacje.
    /// </summary>
    public interface IHasAmendments
    {
        /// <summary>
        /// Lista nowelizacji przypisanych do jednostki.
        /// </summary>
        List<Amendment> Amendments { get; set; }
    }
}