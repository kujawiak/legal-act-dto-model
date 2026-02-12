using System;
using System.Collections.Generic;

#nullable enable

namespace ModelDto
{
    /// <summary>
    /// Reprezentuje pojedynczy cel nowelizacji.
    /// Bez żadnych powiązań z XML/ELI.
    /// </summary>
    public class StructuralAmendmentReference
    {   
        /// <summary>
        /// Strukturalna ścieżka jednostki redakcyjnej będącej celem zmiany:
        /// art. → ust. → pkt → lit. → tiret
        /// </summary>
        public StructuralReference Structure { get; set; } = new();

        /// <summary>
        /// Surowy tekst źródłowy powołania, przydatny dla walidacji
        /// lub celów diagnostycznych parsera.
        /// </summary>
        public string? RawText { get; set; }

        public override string ToString()
        {
            var parts = new List<string>();

            // Dz.U.
            //parts.Add($"Dz.U. {Journal.Year}, poz. {string.Join(",", Journal.Positions)}");

            // Jednostka redakcyjna
            var s = Structure;
            if (s.Article   != null) parts.Add($"art_{s.Article}");
            if (s.Paragraph != null) parts.Add($"ust_{s.Paragraph}");
            if (s.Point     != null) parts.Add($"pkt_{s.Point}");
            if (s.Letter    != null) parts.Add($"lit_{s.Letter}");
            if (s.Tiret     != null) parts.Add($"tiret_{s.Tiret}");

            return string.Join("__", parts);
        }
    }

    public class StructuralReference
    {
        public string? Article { get; set; }
        public string? Paragraph { get; set; }
        public string? Point { get; set; }
        public string? Letter { get; set; }
        public string? Tiret { get; set; }

        public void SetArticle(string value)
        {
            Article = value;
            Paragraph = Point = Letter = Tiret = null;
        }

        public void SetParagraph(string value)
        {
            Paragraph = value;
            Point = Letter = Tiret = null;
        }

        public void SetPoint(string value)
        {
            Point = value;
            Letter = Tiret = null;
        }

        public void SetLetter(string value)
        {
            Letter = value;
            Tiret = null;
        }

        public void SetTiret(string value)
        {
            Tiret = value;
        }

        public StructuralReference Clone()
        {
            return new StructuralReference
            {
                Article = this.Article,
                Paragraph = this.Paragraph,
                Point = this.Point,
                Letter = this.Letter,
                Tiret = this.Tiret
            };
        }
    }
}
