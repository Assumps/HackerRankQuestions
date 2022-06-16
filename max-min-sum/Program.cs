static void miniMaxSum()
    {
        List<int> numbers = new List<int>{7, 69, 2, 221, 8974};
        List<int> sum = new List<int>();



        for(int i = 0; i <= numbers.Count(); i++)
        {
              var sumNumber = numbers.AsQueryable().Sum();
              var listNumber = sumNumber - numbers[i];

              sum.Add(listNumber);  
        }
        
        foreach(var item in sum){
            System.Console.WriteLine(item);
        }
        
        sum.Sort();

        var first = sum[0];
        var last = sum[sum.Count() - 1];
        System.Console.WriteLine(first);
        System.Console.WriteLine(last);
        
    }

    miniMaxSum();