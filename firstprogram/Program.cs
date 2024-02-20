class Program{

    static int add(){
        int a,b;
        Console.WriteLine("Enter The A Value");
        a=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter The B Value");
        b=Convert.ToInt32(Console.ReadLine());
        return a+b;
    }
    
    
    static void Main (string[] args){
        Console.WriteLine("Enter The Value");
        string[] d=Console.ReadLine().Split();
        int p=int.Parse(d[0]);
        int q=int.Parse(d[1]);
        Console.WriteLine(p);
        Console.WriteLine(q);
        
        Console.WriteLine(add());
        }
}
        // Console.WriteLine("Enter The Value");
        //  int a=Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine(a);
        /*  Console.WriteLine("Enter The Size Of Array"); 
        int a=Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[a];//Declaration and Initialization of array  
   
        //traversing array  
       Console.WriteLine("Enter The Value Of Array"); 
        for (int i = 0; i < a; i++)  
        {  
           arr[i]=Convert.ToInt32(Console.ReadLine());
        }  

         Console.WriteLine("The Value Of Array"); 
         int min, max;
         min=arr[0];
         max=arr[0];
      
        for (int i = 0; i <a; i++)  
        {  
            if(arr[i]<min)
            {
               min=arr[i];
              
            }
        }  

       for (int i = 0; i <a; i++)  
        {  
            if(arr[i]>max)
            {
                max=arr[i];
                continue;
            }
        } 
        Console.WriteLine(max);
        Console.WriteLine(min);
         


    } */
