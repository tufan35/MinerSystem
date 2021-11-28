using System;
using System.Collections.Generic;
using System.Text;

namespace Chain
{
    public class Blocks
    {
        public int Nonce { get; set; }
        public List<Transaction> Data { get; set; }
        public string PreviousHah { get; set; }
        public string Hash { get; set; }
        public DateTime TimeStap { get; set; }

        public override string ToString()
        {
            return Nonce + ":" + PreviousHah + ":" + TimeStap.ToString() + GetTrans() ;
        }



        public string GetTrans() {

            string rez = "";
            foreach (var data in Data)
            {
                rez += data.ToString() + ":";
            }

            return "";
        }
        
    }
}
