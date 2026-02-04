using System;

#nullable enable

namespace ModelDto
{
    /// <summary>
    /// Część wspólna (intro/wrapUp) - wirtualna jednostka redakcyjna reprezentująca
    /// tekst występujący przed listą elementów wyliczeniowych lub po niej.
    /// 
    /// CommonPart jest na tym samym poziomie hierarchii co elementy wyliczeniowe,
    /// których dotyczy (np. rodzeństwo punktów, liter, tiretów).
    /// 
    /// Typowe poziomy występowania:
    /// - Paragraph: CommonParts (wobec listy punktów)
    /// - Point: CommonParts (wobec listy liter)
    /// - Letter: CommonParts (wobec listy tiretów)
    /// 
    /// CommonPart NIE występuje w Article jako bezpośrednie dziecko.
    /// 
    /// Nie jest jednostką prawa w tradycyjnym sensie, lecz adresowalnym fragmentem
    /// w systemie redakcyjnym i w modelu zmian legislacyjnych.
    /// 
    /// W publikacyjnym XML (AKN/ELI) CommonPart nie pojawia się jawnie - jego zawartość
    /// trafia bezpośrednio do elementów intro lub wrapUp.
    /// 
    /// Przykład hierarchii:
    ///   Article (art_5)
    ///     └─ Paragraph (art_5__ust_1)
    ///         ├─ CommonPart Intro (art_5__ust_1__intro)
    ///         ├─ Point (art_5__ust_1__pkt_1)
    ///         │   ├─ CommonPart Intro (art_5__ust_1__pkt_1__intro)
    ///         │   ├─ Letter (art_5__ust_1__pkt_1__lit_a)
    ///         │   │   ├─ CommonPart Intro (art_5__ust_1__pkt_1__lit_a__intro)
    ///         │   │   ├─ Tiret (art_5__ust_1__pkt_1__lit_a__tir_1)
    ///         │   │   └─ CommonPart WrapUp (art_5__ust_1__pkt_1__lit_a__wrapUp)
    ///         │   └─ CommonPart WrapUp (art_5__ust_1__pkt_1__wrapUp)
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

        /// <summary>
        /// Opcjonalne powiązanie z segmentem tekstu (np. zdaniem) w jednostce nadrzędnej.
        /// Pozwala wskazać, które zdanie pełni rolę intro/wrapUp.
        /// </summary>
        public int? SourceSegmentOrder { get; set; }

        public CommonPart()
        {
            UnitType = UnitType.CommonPart;
            EIdPrefix = Type.ToEIdSegment();
        }

        /// <summary>
        /// Konstruktor z parametrami.
        /// </summary>
        public CommonPart(CommonPartType type, string parentEId, string contentText, int? sourceSegmentOrder = null) : this()
        {
            Type = type;
            ParentEId = parentEId;
            ContentText = contentText;
            SourceSegmentOrder = sourceSegmentOrder;
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
