using System.Collections.Generic;

namespace Decred2Mysql.Models
{
    public class BlockTransactions
    {
        public int pagesTotal { get; set; }
        public List<Tx> txs { get; set; }
    }
}