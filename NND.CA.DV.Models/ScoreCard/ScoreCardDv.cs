namespace NND.CA.DV.Models.ScoreCard
{
    /// <summary>
    /// Score card DataModel
    /// </summary>
    class ScoreCardDv 
    {
        public int Id { get; set; }
        public Locations Location{ get; set; }
        public ScoreCardElements ScoreCardElement { get; set; }
        public FiscalDate FiscalDate { get; set; }
    }
}
