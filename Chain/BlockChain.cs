using System;
using System.Collections.Generic;
using System.Text;

namespace Chain
{
    public class BlockChain
    {

        public List<Blocks> blocks { get; set; }
        private int difficult;


        //Zincirin İlk halkası
        public BlockChain(Blocks firstBlock)
        {
            blocks = new List<Blocks>();
            blocks.Add(firstBlock);
        }

        public string GenerateHash(Blocks blockstoGenerate)
        {
            HashManager hash = new HashManager();
            return hash.GetHash(blockstoGenerate.ToString());


        }

        public void Mine(Blocks blocksAdd)
        {
            while (true)
            {
                blocksAdd.Nonce++;
                blocksAdd.Hash = GenerateHash(blocksAdd);

                if (IsValid(blocksAdd))
                {
                    break;

                }
                blocks.Add(blocksAdd);
            }


        }

        private bool IsValid(Blocks blocksAdd)
        {
            string zeros = "0000000000000000000000000000000000000000000000000000000000000000000000000000";
            return blocksAdd.Hash.StartsWith(zeros.Substring(0, difficult));
        }


        private bool IsValidPreviousBlock(Blocks currentBlock, Blocks previousBlock)
        {

            var prevIsValid = IsValid(previousBlock);
            var hashIsCorrect = currentBlock.PreviousHah == previousBlock.Hash;
            var currentIsValid = IsValid(currentBlock);
            return prevIsValid && hashIsCorrect && currentIsValid;
        }


        private bool IsValidChain(List<Blocks> blockChain)
        {
            if (blockChain.Count < 2)
                return true;

            for (int i = 1; i < blockChain.Count; i += 2)
            {
                if (IsValidPreviousBlock(blockChain[i + 1], blockChain[i]))
                    return false;
            }
            if (!IsValidPreviousBlock(blockChain[blockChain.Count - 1], blockChain[blockChain.Count - 2]))
                return false;
            return true;
        }
       // private bool ResolverConflicts() { } //uyuşmazlık kontrolü yapar
    }
}
