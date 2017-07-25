namespace Decred2Mysql.Models
{
    public class Vin
    {
        public string txid { get; set; }
        public object vout { get; set; }
        public int tree { get; set; }
        public object sequence { get; set; }
        public double amountin { get; set; }
        public int blockheight { get; set; }
        public object blockindex { get; set; }
        public ScriptSig scriptSig { get; set; }
        public int n { get; set; }
        public string addr { get; set; }
        public object valueSat { get; set; }
        public double? value { get; set; }
        public object doubleSpentTxID { get; set; }
        public bool? isStakeBase { get; set; }
        public string dbError { get; set; }
    }
}