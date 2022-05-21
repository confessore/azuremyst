namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Condition System
    /// </summary>
    public partial class Condition
    {
        /// <summary>
        /// Identifier
        /// </summary>
        public uint ConditionEntry { get; set; }
        /// <summary>
        /// Type of the condition
        /// </summary>
        public sbyte Type { get; set; }
        /// <summary>
        /// data field one for the condition
        /// </summary>
        public uint Value1 { get; set; }
        /// <summary>
        /// data field two for the condition
        /// </summary>
        public uint Value2 { get; set; }
        /// <summary>
        /// data field three for the condition
        /// </summary>
        public uint Value3 { get; set; }
        /// <summary>
        /// data field four for the condition
        /// </summary>
        public uint Value4 { get; set; }
        public byte Flags { get; set; }
        public string? Comments { get; set; }
    }
}
