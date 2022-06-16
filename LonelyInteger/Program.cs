static int lonelyinteger(List<int> a)
    {
        HashSet<int> set = new HashSet<int>();
        foreach (int item in a){
            if (!set.Contains(item)){            
                set.Add(item);
            }else{           
                set.Remove(item);
            }
        }
        return set.ToList()[0];
         
    }
    int numberList;
    List<int> number = new List<int>{1, 2, 3, 4, 3, 2, 1};
    numberList = lonelyinteger(number);
    Console.WriteLine(numberList);