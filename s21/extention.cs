public static class EXT{
    public static IEnumerable<T> MyTake<T>(this IEnumerable<T> lines , int n){
        List<T> list = new List<T>();
        foreach (var item in lines){
            if(list.Count()< n)
                list.Add(item);
            else break;
        }
        // for (int i = 0; i < n; i++)
        // {
        //     list.Add(lines[i]);
        // }
        //IEnumerable can only see the next or the back so we cannot use index!
        return list;
    }

    public static IEnumerable<T> MyTake2<T>(this IEnumerable<T> lines , int n){
        foreach (var item in lines){
            if(n-- > 0){
                yield return item;
                //yeild will get the pointer to the current position of IEnumerable
            }
        }
    }    
}