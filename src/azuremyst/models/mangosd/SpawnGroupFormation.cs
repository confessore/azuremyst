namespace azuremyst.models.mangosd
{
    public partial class SpawnGroupFormation
    {
        /// <summary>
        /// Spawn group id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Formation shape 0..6
        /// </summary>
        public sbyte FormationType { get; set; }
        /// <summary>
        /// Distance between formation members
        /// </summary>
        public float FormationSpread { get; set; }
        /// <summary>
        /// Keep formation compact (bit 1)
        /// </summary>
        public int FormationOptions { get; set; }
        /// <summary>
        /// PathId from waypoint_path path
        /// </summary>
        public int PathId { get; set; }
        /// <summary>
        /// Same as creature table
        /// </summary>
        public sbyte MovementType { get; set; }
        public string? Comment { get; set; }
    }
}
