namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Trainer system
    /// </summary>
    public partial class TrainerGreeting
    {
        /// <summary>
        /// Entry of Trainer
        /// </summary>
        public uint Entry { get; set; }
        /// <summary>
        /// Text of the greeting
        /// </summary>
        public string? Text { get; set; }
    }
}
