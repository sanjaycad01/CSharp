public class Rb{
      public string name="Sanjay";
      public string bike="Apache";
       public void display_rb(){
        Console.WriteLine(name+"Have A "+bike+"Bike");
      
     }

}

public class Rk{
    public string name="Ramki";
    public string bike="XL";
    public void display_rk(){
           Console.WriteLine(name+"Have A "+bike+"Bike");
      
    }
}
public class Rs :Rk,Rb{
    public void display_sh(){
        Console.WriteLine("Have A Bike");

    }
}

 class Main{
     public static void Main(string[] args)
    {
       Rs obj=new Rs();
       obj.display_rb();
    }

}
   



