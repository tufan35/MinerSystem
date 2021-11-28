namespace Chain
{
    public class Transaction
    {
        #region CoinProp

        //amount of coins sent
        public string Sender { get; set; }

        //amount of coins received
        public string Receiver { get; set; }
        //amount of coin
        public float Values { get; set; }

        #endregion

        public override string ToString()
        {
            return Sender + ":" + Receiver + ":" + Values;

        }

    }
}