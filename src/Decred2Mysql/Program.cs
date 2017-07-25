using System;
using System.Runtime.InteropServices.ComTypes;

namespace Decred2Mysql
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting block query...");

            var blockchainClient = new BlockchainClient(new Uri("https://mainnet.decred.org/"));
            var currentBlock = blockchainClient.GetBlock(100000);

            while (currentBlock?.nextblockhash != null)
            {
                Console.WriteLine($"Block #{currentBlock.height} - Hash: {currentBlock.hash} - Tx Count: {currentBlock.tx.Count}");

                // write data to sql here!

                Console.Write("  Getting block transactions...");
                var blockTransactions = blockchainClient.GetBlockTransactions(currentBlock.hash, 0);
                Console.WriteLine($"pulling {blockTransactions.pagesTotal} pages.");
                if (blockTransactions.pagesTotal > 1)
                {
                    for (int p = 1; p < blockTransactions.pagesTotal; p++)
                    {
                        var nextBlockTransactions = blockchainClient.GetBlockTransactions(currentBlock.hash, p);
                    }
                }

                currentBlock = blockchainClient.GetBlock(currentBlock.nextblockhash);
            }

            #if DEBUG
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            #endif
        }

        
    }
}