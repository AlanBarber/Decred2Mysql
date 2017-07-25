using System.Collections.Generic;

namespace Decred2Mysql
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

    public class BlockIndex
    {
        public string blockHash { get; set; }
    }

    public class ScriptSig
    {
        public string asm { get; set; }
        public string hex { get; set; }
    }

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

    public class ScriptPubKey
    {
        public string asm { get; set; }
        public string hex { get; set; }
        public int reqSigs { get; set; }
        public string type { get; set; }
        public List<string> addresses { get; set; }
        public double? commitamt { get; set; }
    }

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

    public class Tx
    {
        public string txid { get; set; }
        public int version { get; set; }
        public int locktime { get; set; }
        public int expiry { get; set; }
        public List<Vin> vin { get; set; }
        public List<Vout> vout { get; set; }
        public string blockhash { get; set; }
        public int blockheight { get; set; }
        public int confirmations { get; set; }
        public int time { get; set; }
        public int blocktime { get; set; }
        public double valueOut { get; set; }
        public int size { get; set; }
        public double? valueIn { get; set; }
        public double? fees { get; set; }
        public string ticketid { get; set; }
        public bool? isStakeGen { get; set; }
        public int? voterVersion { get; set; }
        public List<string> agendas { get; set; }
        public bool? isStakeTx { get; set; }
    }

    public class BlockTransactions
    {
        public int pagesTotal { get; set; }
        public List<Tx> txs { get; set; }
    }
}