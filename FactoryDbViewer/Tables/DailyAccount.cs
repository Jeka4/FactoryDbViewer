namespace FactoryDbViewer.Tables
{
    public class DailyAccount
    {
        public int WorkerId { get; set; }
        public int DetailId { get; set; }
        public System.DateTime Date { get; set; }
        public int MadeCount { get; set; }
        public int Norm { get; set; }
        public int DefectCount { get; set; }
    }
}
