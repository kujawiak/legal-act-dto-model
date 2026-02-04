using System;
using System.Collections.Generic;
using ModelDto.SystematizingUnits;

#nullable enable

namespace ModelDto
{
    /// <summary>
    /// Model aktu prawnego - wrapper całej struktury dokumentu legislacyjnego.
    /// 
    /// Zawiera metadane dotyczące całego aktu oraz hierarchię jego struktury.
    /// Każdy akt zawiera co najmniej jeden rozdział (Chapter) gdzieś w drzewie,
    /// ale może się pojawić na różnych poziomach zależnie od struktury.
    /// 
    /// Przykładowa pełna hierarchia (różne akty mogą mieć części tej hierarchii):
    /// Część (Part) → Księga (Book) → Tytuł (Title) → Dział (Division) → 
    /// Rozdział (Chapter) → Oddział (Subchapter) → Artykuł (Article)
    /// 
    /// Struktura w LegalDocument:
    /// LegalDocument
    ///   ├─ Type: Statute/Regulation/Code (determinuje nazewnictwo jednostek)
    ///   ├─ Title: "Ustawa o ochronie pracy"
    ///   ├─ SourceJournal: DzU 2024, poz. 123
    ///   └─ RootSystematizingUnits[]: pierwsze jednostki systematyzujące (mogą być Part, Book, Title, Division, itd.)
    ///       └─ ... (kolejne poziomy Part/Book/Title/Division)
    ///           └─ Chapter (obowiązkowa co najmniej raz w drzewie, zwykle ostatnia systematyzująca)
    ///               ├─ Subchapters (Oddziały): jeśli istnieją
    ///               │   └─ Articles[]: artykuły w oddziale
    ///               │       └─ Subsections: ustępy
    ///               └─ Articles[]: artykuły bezpośrednio w rozdziale (gdy brak Oddziałów)
    ///                   └─ Subsections: ustępy
    /// </summary>
    public class LegalDocument
    {
        /// <summary>
        /// Unikalny identyfikator dokumentu.
        /// </summary>
        public Guid Guid { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Typ aktu prawnego (ustawa, rozporządzenie, kodeks).
        /// Określa konwencje nazewnictwa i struktury jednostek redakcyjnych.
        /// </summary>
        public LegalActType Type { get; set; } = LegalActType.Statute;

        /// <summary>
        /// Pełny tytuł aktu prawnego.
        /// Przykłady: "Kodeks cywilny", "Ustawa z dnia 1 marca 2024 r. o ochronie konkurencji"
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Informacja o źródle publikacji (Dziennik Ustaw, rok, numer pozycji).
        /// Zawiera metadane potrzebne do odwołań w systemie prawnym.
        /// </summary>
        public JournalInfo SourceJournal { get; set; } = new();

        /// <summary>
        /// Pierwsze (najwyższe) jednostki systematyzujące w akcie.
        /// Przykłady:
        /// - Kodeks: Księga → Tytuł → Oddział → Rozdział → Artykuły
        /// - Ustawa: Rozdział → Artykuły (lub Rozdział domyślny, gdy brak jawnych rozdziałów)
        /// - Rozporządzenie: Rozdział → Artykuły (§)
        /// 
        /// W całym drzewie jednostek MUSI wystąpić co najmniej jeden rozdział.
        /// Jeśli dokument nie zawiera jawnych rozdziałów, należy dodać domyślny
        /// Chapter z IsImplicit = true i umieścić w nim wszystkie artykuły.
        /// </summary>
        public List<ISystematizingUnit> RootSystematizingUnits { get; set; } = new();

        /// <summary>
        /// Data utworzenia dokumentu w systemie.
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        /// <summary>
        /// Data ostatniej modyfikacji dokumentu.
        /// </summary>
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        /// <summary>
        /// Zwraca etykietę wyświetlającą dla głównej jednostki redakcyjnej (artykułu).
        /// Zależy od typu aktu.
        /// </summary>
        public string GetMainUnitLabel() => Type.GetMainUnitLabel();

        /// <summary>
        /// Zwraca etykietę wyświetlającą dla podjednostki (ustępu/paragrafu).
        /// Zależy od typu aktu.
        /// </summary>
        public string GetSubUnitLabel() => Type.GetSubUnitLabel();

        public override string ToString()
        {
            return $"{Type.ToFriendlyString().ToUpper()}: {Title} ({SourceJournal})";
        }
    }
}
