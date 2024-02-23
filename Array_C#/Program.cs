class Anand{
   public  string name="Anand";
    public void tekessenceSoftwareSolution(string name){
        Console.WriteLine(name +" is an AR Caller");
    }
}
class Sanjay:Anand{
    
   
    
}
class Program{
    public static void Main(string[] args){
        Sanjay obj=new Sanjay();
        string b=obj.name;
        obj.tekessenceSoftwareSolution(b);
    }

}

    
   /*  public static void Main(string[] args)
    {
        int[] arr={1,2,3,4,5};
        int a=arr.Length;
        Console.WriteLine(a);
        foreach(int b in arr)
        {
            Console.WriteLine(b);
        }
        for(int i=a-1;i>=0;i--)
        {
            Console.WriteLine(arr[i]);
        }
        
    } */

