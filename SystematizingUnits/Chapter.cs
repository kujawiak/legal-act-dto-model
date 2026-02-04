using System.Collections.Generic;
using ModelDto;

namespace ModelDto.SystematizingUnits
{
    /// <summary>
    /// Jednostka systematyzująca: rozdział (obowiązkowa w każdym akcie prawnym)
    /// 
    /// Rozdział jest szczególną jednostką systematyzującą - ZAWSZE musi występować w akcie prawnym.
    /// Nawet jeśli dokument nie zawiera jawnych rozdziałów, wszystkie artykuły są przypisane
    /// do domyślnego "rozdziału pierwszego" (rozdział z IsImplicit = true).
    /// 
    /// W przeciwieństwie do innych jednostek systematyzujących (Część, Księga, Tytuł, Dział, Podrozdział),
    /// które są opcjonalne, rozdział jest obligatoryjny dla struktury aktu prawnego.
    /// </summary>
    public class Chapter : BaseEntity, ISystematizingUnit
    {
        /// <summary>
        /// Tytuł rozdziału (np. "Warunki przyjęcia", "Odpowiedzialność przewoźnika")
        /// Dla rozdziału domyślnego (IsImplicit = true) może być pusty.
        /// </summary>
        public string Heading { get; set; } = string.Empty;

        /// <summary>
        /// Czy rozdział jest domyślny/ukryty (niejawny w dokumencie).
        /// 
        /// true: Rozdział nie występuje jawnie w tekście ustawy, ale wszystkie artykuły
        ///       są formalnie przypisane do domyślnego "rozdziału pierwszego".
        ///       
        /// false: Rozdział występuje jawnie w dokumencie z numerem i tytułem.
        /// 
        /// Przykład: Jeśli ustawa nie ma rozdziałów, tworzy się domyślny Chapter z IsImplicit = true.
        /// </summary>
        public bool IsImplicit { get; set; } = false;

        public Chapter()
        {
            UnitType = UnitType.Chapter;
            EIdPrefix = "rozd";
            DisplayLabel = "rozd.";
        }

        /// <summary>
        /// Oddział (Subchapter) — opcjonalny poziom organizacji poniżej Rozdziału.
        /// Jeśli Oddział nie istnieje, artykuły idą bezpośrednio do właściwości Articles.
        /// </summary>
        public List<Subchapter> Subchapters { get; set; } = new();

        /// <summary>
        /// Artykuły zawarte bezpośrednio w tym Rozdziale (gdy brak Oddziałów).
        /// W modelu hierarchicznym: jeśli Sections nie jest puste, artykuły są tam;
        /// jeśli Sections jest puste, artykuły są tutaj.
        /// </summary>
        public List<Article> Articles { get; set; } = new();
    }
}