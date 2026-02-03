#nullable enable

namespace ModelDto.SystematizingUnits
{
    /// <summary>
    /// Kontrakt dla jednostek systematyzujących (organizacyjnych) aktu prawnego.
    /// 
    /// Jednostki systematyzujące służą do strukturyzacji aktu prawnego w bloki tematyczne,
    /// ale same nie zawierają treści prawnej (w przeciwieństwie do jednostek redakcyjnych).
    /// 
    /// Przykłady: Część, Księga, Tytuł, Dział, Rozdział, Podrozdział.
    /// 
    /// Każda jednostka systematyzująca ma:
    /// - Heading: krótki tytuł opisujący zakres tematyczny (np. "Przepisy ogólne", "Odpowiedzialność karna")
    /// - Number: numer jednostki (np. "I", "II", "1", "2")
    /// - Hierarchię: może zawierać inne jednostki systematyzujące lub jednostki redakcyjne
    /// </summary>
    public interface ISystematizingUnit
    {
        /// <summary>
        /// Krótki tytuł/nagłówek jednostki systematyzującej.
        /// Przykłady: "Przepisy ogólne", "Odpowiedzialność karna", "Postępowanie administracyjne".
        /// </summary>
        string Heading { get; set; }
    }
}
