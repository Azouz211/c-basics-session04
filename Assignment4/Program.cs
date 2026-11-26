namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1

            //double[] Prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(Prices[1]);

            #endregion

            #region Question 2

            //int[,] ShelfCopies = new int[2, 2]             {
            //    { 3, 5 },
            //    { 1, 4 }
            //};

            //Console.WriteLine(ShelfCopies[1, 0]);

            #endregion

            #region Question 3

            //PrintWelcomeMessage();

            #endregion

            #region Question 4
            //string title = "Clean Code";
            //PrintBookTitle(title);

            #endregion

            #region Question 5
            //int pages = 400;
            //AddBonusPages(ref pages);   // add bonus pages to the original pages (ref)
            //Console.WriteLine( pages);


            #endregion

            #region Question 6 

            double[] prices = { 25.5, 40.0 };
            //ApplyDiscount(ref prices); // apply discount to first price (25.5)
            //Console.WriteLine(prices[0]);

            #endregion

            #region Question 7
            //int pages = 400;
            //AddBonusPages(pages);   // Did not use ref keyword, so the original pages variable is not modified
            //Console.WriteLine(pages);


            #endregion

            #region Question 8 

            

            ReplaceArray(ref prices);

            Console.WriteLine(prices.Length);


            #endregion
        }




        #region User Defined Func

        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }       


        public static void PrintBookTitle(string title)
        {
            Console.WriteLine($"Book Title: {title}");
        }


        public static int AddBonusPages( int pages)
        { 
            return pages += 50;
        }

        public static double ApplyDiscount(ref double[] prices)
        {
           return prices[0] -= 5.0; 
        }

        public static double ReplaceArray(ref double[] prices) 
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
            return prices[0];
        }


        #endregion
    }
}
