using Chain;
using System;
using System.Collections.Generic;

namespace MinerSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            #region BlockTest

            //firstBlock
            BlockChain blockChain = new BlockChain(new Blocks()
            {
                Data = new System.Collections.Generic.List<Transaction>(),
                Hash = "00000000000000000000000000000000",
                Nonce = 1,
                PreviousHah = "0000000000000000000000000000000000",
                TimeStap = DateTime.UtcNow
            }) ;

            for (int i = 0; i < 5; i++)
            {
                List<Transaction> lst = new List<Transaction>();
                lst.Add(new Transaction()
                {

                    Receiver = "234kjh34kjh43k4j",
                    Sender ="234234n234kl34l",
                    Values= i+5

                });

                Blocks block = new Blocks()
                {
                    Data = lst,
                    TimeStap = DateTime.UtcNow

                };
                blockChain.Mine(block);
                
            }


            
            #endregion
        }
    }
}
