namespace azuremyst.models.characters
{
    /// <summary>
    /// Debug System
    /// </summary>
    public partial class Bugreport
    {
        /// <summary>
        /// Identifier
        /// </summary>
        public int Id { get; set; }
        public string Type { get; set; } = null!;
        public string Content { get; set; } = null!;
    }
}
