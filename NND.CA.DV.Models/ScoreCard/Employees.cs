namespace NND.CA.DV.Models.ScoreCard
{
    public class Employees
    {
        public string NumberOfOfficeEmployees { get; set; }
        public string ActiveCareGivers { get; set; }
        public string InActiveCareGivers { get; set; }
        public string NewHires { get; set; }
        public string Terminations { get; set; }
        public string NetIncrease { get; set; }
        public string TotalNumberOfEmployees { get; set; }
        /// <summary>
        /// Excluding facility staffing
        /// </summary>
        public string EeHours { get; set; }
        public string AverageHoursPerCareGiver { get; set; }
        public Recruiting Recruting { get; set; }
        public Marketing Marketing { get; set; }









    }
}