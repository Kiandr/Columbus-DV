using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NND.CA.DV.Models;
using Sage.CA.SBS.ERP.Sage300.Common.Models.WebBaseModels;

namespace NND.CA.DV.Models.ScoreCard
{
    /// <summary>
    /// Score card DataModel
    /// </summary>
    class ScoreCardDv : ScoreCardBaseModel
    {
        public int Id { get; set; }
        public Locations Location{ get; set; }
        public ScoreCardElements ScoreCardElement { get; set; }
        public FiscalDate FiscalDate { get; set; }
    }
}
