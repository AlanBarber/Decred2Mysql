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
            var currentBlock = blockchainClient.GetBlock(0);

            while (currentBlock?.nextblockhash != null)
            {
                var blockTransactions = blockchainClient.GetBlockTransactions(currentBlock.hash, 0);
                Console.WriteLine($"Block #{currentBlock.height} - Hash: {currentBlock.hash} - Tx Count: {currentBlock.tx.Count} - API Pages: {blockTransactions.pagesTotal}");

                // write data to sql here!

                currentBlock = blockchainClient.GetBlock(currentBlock.nextblockhash);
            }

            #if DEBUG
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            #endif
        }

        
    }
}