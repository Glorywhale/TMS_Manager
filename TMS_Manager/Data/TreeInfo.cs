using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMS_Manager
{
    public class TreeInfo
    {
        public int LineNo { get; set; }
        public int SectionNo { get; set; }
        public int TreeNo { get; set; }
        public string TreeType {get; set; }
        public DateTime ST_floreDate { get; set; }
        public DateTime ED_floreDate { get; set; }
        public DateTime FruitDate { get; set; }
        public string CountDeg { get; set; }
        public string CountLevel { get; set; }
        public string EarlyAmount { get; set; }
        public DateTime ColorDate { get; set; }
        public string ColorLevel { get; set; }
        public DateTime HarvestDate { get; set; }
        public string PostAmount { get; set; }
        public int TP_A { get; set; }
        public int TP_B { get; set; }
        public int TP_C { get; set; }
        public int TP_D { get; set; }
        public DateTime DiseaseDate { get; set; }
        public string DiseaseName { get; set; }
        public DateTime BugDate { get; set; }
        public string BugName { get; set; }
        public DateTime PeriodDate { get; set; }
        public string PeriodName { get; set; }        
    }
}
