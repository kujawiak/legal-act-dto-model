namespace ModelDto
{
    /// <summary>
    /// Typ części wspólnej (wirtualnego bytu reprezentującego intro lub wrapUp jednostki nadrzędnej).
    /// Służy do adresowania fragmentów tekstu przed i po liście w modelu redakcyjnym.
    /// </summary>
    public enum CommonPartType
    {
        /// <summary>
        /// Część wspólna przed listą (np. "Poniższe przepisy uchyla się:")
        /// </summary>
        Intro,

        /// <summary>
        /// Część wspólna po liście (np. "Szczegółowe warunki zawarte w rozporządzeniu")
        /// </summary>
        WrapUp
    }

    public static class CommonPartTypeExtensions
    {
        public static string ToFriendlyString(this CommonPartType type)
        {
            return type switch
            {
                CommonPartType.Intro => "intro",
                CommonPartType.WrapUp => "wrapUp",
                _ => "unknown"
            };
        }

        public static string ToEIdSegment(this CommonPartType type)
        {
            return type switch
            {
                CommonPartType.Intro => "intro",
                CommonPartType.WrapUp => "wrapUp",
                _ => ""
            };
        }
    }
}
