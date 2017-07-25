using System;
using System.Net.Http;
using Decred2Mysql.Models;
using Newtonsoft.Json;

namespace Decred2Mysql
{
    public class BlockchainClient
    {
        public Uri ApiUri { get; set; }

        public BlockchainClient(Uri apiUri)
        {
            ApiUri = apiUri ?? throw new ArgumentNullException(nameof(apiUri));
        }

        public Block GetBlock(string blockHash)
        {
            var query = new Uri(ApiUri, $"/api/block/{blockHash}");
            var results = QueryApi(query);
            return JsonConvert.DeserializeObject<Block>(results);
        }

        public Block GetBlock(int blockNum)
        {
            // Get hash for blockNum
            var query = new Uri(ApiUri, $"/api/block-index/{blockNum}");
            var results = QueryApi(query);
            var hash = JsonConvert.DeserializeObject<BlockIndex>(results);
            // Get block of hash
            return GetBlock(hash.blockHash);
        }

        public BlockTransactions GetBlockTransactions(string blockHash, int pageNum)
        {
            var query = new Uri(ApiUri, $"/api/txs?block={blockHash}&pageNum={pageNum}");
            var results = QueryApi(query);
            return JsonConvert.DeserializeObject<BlockTransactions>(results);
        }

        private string QueryApi(Uri query)
        {
            var httpClient = new HttpClient();
            var result = httpClient.GetStringAsync(query).Result;

            return result;
        }
    }
}
