namespace G_NET_12_LINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q01
            /*
            var result1 = products.OrderByDescending(p => p.UnitPrice).Take(3);
            */
            #endregion

            #region Q02
            /*
            var result2 = products.Skip(5).Take(5);

            */
            #endregion

            #region Q03
            /*
            var result3 = products.TakeWhile(p => p.UnitPrice < 25);
            */
            #endregion



        }
    }
}
