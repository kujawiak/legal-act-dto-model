using System;

#nullable enable

namespace ModelDto
{
    /// <summary>
    /// Część wspólna (intro/wrapUp) - wirtualna jednostka redakcyjna reprezentująca
    /// tekst przed listą (intro) lub po liście (wrapUp) jednostki nadrzędnej.
    /// 
    /// Nie jest jednostką prawa w tradycyjnym sensie, lecz adresowalnym fragmentem
    /// w systemie redakcyjnym i w modelu zmian legislacyjnych.
    /// 
    /// W publikacyjnym XML (AKN/ELI) CommonPart nie pojawia się jawnie - jego zawartość
    /// trafia bezpośrednio do elementów &lt;intro&gt; lub &lt;wrapUp&gt;.
    /// 
    /// Przykład hierarchii:
    ///   Article (art_5)
    ///     └─ Paragraph (art_5__ust_1)
    ///         ├─ CommonPart Intro (art_5__ust_1__intro)
    ///         ├─ Point (art_5__ust_1__pkt_1)
    ///         ├─ Point (art_5__ust_1__pkt_2)
    ///         └─ CommonPart WrapUp (art_5__ust_1__wrapUp)
    /// </summary>
    public class CommonPart : BaseEntity
    {
        /// <summary>
        /// Typ części wspólnej: Intro (przed listą) lub WrapUp (po liście).
        /// </summary>
        public CommonPartType Type { get; set; } = CommonPartType.Intro;

        /// <summary>
        /// Hierarchiczny identyfikator jednostki nadrzędnej (np. "art_5__ust_1").
        /// Służy do precyzyjnego odwołania w systemie zmian legislacyjnych.
        /// </summary>
        public string ParentEId { get; set; } = string.Empty;

        public CommonPart()
        {
            UnitType = UnitType.CommonPart;
            EIdPrefix = Type.ToEIdSegment();
        }

        /// <summary>
        /// Konstruktor z parametrami.
        /// </summary>
        public CommonPart(CommonPartType type, string parentEId, string contentText) : this()
        {
            Type = type;
            ParentEId = parentEId;
            ContentText = contentText;
            EIdPrefix = type.ToEIdSegment();
        }

        /// <summary>
        /// Zwraca segment ID dla części wspólnej (np. "intro" lub "wrapUp").
        /// Nie dodaje przedrostka numerycznego - CommonPart nie ma numeru.
        /// </summary>
        protected override string GetLocalIdSegment()
        {
            return Type.ToEIdSegment();
        }

        /// <summary>
        /// Właściwość wyświetlająca typ części wspólnej do celów UI.
        /// </summary>
        public string TypeDisplayLabel => Type.ToFriendlyString();

        public override string ToString()
        {
            return $"CommonPart [{Type}] w {ParentEId}: {ContentText}";
        }
    }
}
