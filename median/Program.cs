static void median()
    {
        List<int> OrderNumber = new List<int>{0,1,2,4,6,5,3};
        OrderNumber.Sort();
        var position = OrderNumber.Count();
        var divisor = position / 2;
        System.Console.WriteLine(OrderNumber[divisor]);
          
        //Console.Write((arr.Sum()-arr.Max()) + " " + (arr.Sum()-arr.Min()));
    }
median();
