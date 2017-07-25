namespace Decred2Mysql.Models
{
    public class Vout
    {
        public string value { get; set; }
        public int n { get; set; }
        public int version { get; set; }
        public ScriptPubKey scriptPubKey { get; set; }
        public string spentTxId { get; set; }
        public int spentIndex { get; set; }
        public int spentTs { get; set; }
    }
}