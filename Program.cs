// See https://aka.ms/new-console-template for more information


public class Program{
    public static void Main(string[]args){

        IPay launch=new PaymentLaunch(250,1000);
        Console.WriteLine(launch.Pay());

        IPay dinner=new PaymentDinner(300,1000);
        Console.WriteLine(dinner.Pay());

        IPay amount=new PaymentAmount(100,1000);
        Console.WriteLine(amount.Pay());

        ITransfer transfer=new PaymentTransfer();
       Console.WriteLine("You transfer: "+transfer.Transfer(1000));
    }
}

 public  interface IPay{
    public double Pay();
}

public interface ITransfer
{
    public double Transfer();
    double Transfer(double money);
}


public class Payment{

    public double Balance{get;set;}

    public Payment(double balance){
    Balance=balance;

  } 

}

public class PaymentLaunch:Payment,IPay
{
    public double PayLaunch{get;set;}

    public PaymentLaunch(double payLaunch,double balance):base(balance)
    {

        PayLaunch=payLaunch;

    }
   
    public double Pay()
    {
        double goOut =Balance-PayLaunch;
        Console.WriteLine("Restaurant Star: "+PayLaunch);

       return goOut;

    }

}

public class PaymentDinner:Payment,IPay{

    public double PayDinner{get;set;}

    public PaymentDinner(double payDinner,double balance):base(balance)
    {
        PayDinner=payDinner;
    }


    public double Pay(){
        double goOut=Balance -PayDinner;
         Console.WriteLine("Restaurant Sushiko: "+PayDinner);

        return goOut;
    }
}


public class PaymentAmount:Payment,IPay{
    public double Amount{get;set;}

    public PaymentAmount(double amount,double balance):base(balance){

        Amount=amount;

    }

    public double Pay()
    {

        double goin=Balance+Amount;
        Console.WriteLine("Deposit: "+Amount +" N26 Bank");
        return goin;
        
    }


}


public class PaymentTransfer : ITransfer
{
    public string Bank{get;set;}

    public double Money{get;set;}

   

   public  double Transfer(double  money)
    {
        Money=money;

        return   Money;
    }

    public double Transfer()
    {
        throw new NotImplementedException();
    }
}