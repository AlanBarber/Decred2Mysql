using System.Collections.Generic;

namespace Decred2Mysql.Models
{
    public class Block
    {
        public string hash { get; set; }
        public long confirmations { get; set; }
        public long size { get; set; }
        public long height { get; set; }
        public long version { get; set; }
        public string merkleroot { get; set; }
        public string stakeroot { get; set; }
        public List<string> tx { get; set; }
        public List<string> stx { get; set; }
        public long time { get; set; }
        public long nonce { get; set; }
        public long votebits { get; set; }
        public string finalstate { get; set; }
        public long voters { get; set; }
        public long freshstake { get; set; }
        public long revocations { get; set; }
        public long poolsize { get; set; }
        public string bits { get; set; }
        public double sbits { get; set; }
        public double difficulty { get; set; }
        public string extradata { get; set; }
        public long stakeversion { get; set; }
        public string previousblockhash { get; set; }
        public string nextblockhash { get; set; }
        public double reward { get; set; }
        public bool isMainChain { get; set; }
        public string unixtime { get; set; }
    }
}