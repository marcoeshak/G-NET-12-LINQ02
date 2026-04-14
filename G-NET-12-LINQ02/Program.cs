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

            #region Q04
            /*
            var result4 = products.Where(p => p.Category == "Seafood").All(p => p.UnitsInStock > 0);
            */
            #endregion

            #region Q05
            /*
            int[] ids = { 3, 9, 13, 18 };
            var result5 = ids.Contains(9);
            */
            #endregion

            #region Q06
            /*
            var result6 = products.GroupBy(p => p.Category)
                      .Select(g => new { Category = g.Key, Count = g.Count() });
            */
            #endregion

            #region Q07
            /*
            var result7 = products.GroupBy(p => p.Category)
                      .Select(g => new { Category = g.Key, Names = g.Select(p => p.ProductName) });

            */
            #endregion

            #region Q08
            /*
            var result8 = products.GroupBy(p => p.Category)
                      .Where(g => g.Count() > 3)
                      .Select(g => g.Key);

            */
            #endregion

            #region Q09
            /*
            var result9 = from c in customers
                          group c by c.Country into g
                          select new
                          {
                              Country = g.Key,
                              Count = g.Count(),
                              TotalOrderValue = g.SelectMany(c => c.Orders).Sum(o => o.Total)
                          };

            */
            #endregion

            #region Q10
            /*
            var result10 = products.Sum(p => p.UnitsInStock);
            */
            #endregion

            #region Q11
            /*
            var cheapest = products.Min(p => p.UnitPrice);
            var mostExpensive = products.Max(p => p.UnitPrice);
            */
            #endregion

            #region Q12
            /*
            var result12 = products.Select(p => p.Category).Distinct();
            */
            #endregion

            #region Q13
            /*
            int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            int[] setB = { 3, 6, 9, 12, 15, 13 };
            var result13 = setA.Except(setB);

            */
            #endregion

            #region Q14
            /*
            string[] list1 = { "Germany", "France", "UK", "Spain" };
            string[] list2 = { "france", "SPAIN", "Italy" };
            var result14 = list1.Except(list2, StringComparer.OrdinalIgnoreCase);
            */
            #endregion

            #region Q15
            /*
            var dict = products.ToDictionary(p => p.ProductID);
            var product18 = dict[18];
            */
            #endregion

            #region Q16
            /*
            var result16 = products.First(p => p.UnitPrice > 50);
            */
            #endregion

            #region Q17
            /*
            var result17 = products.FirstOrDefault(p => p.UnitPrice > 500);
            */
            #endregion

        }
    }
}
