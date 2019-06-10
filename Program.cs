using System;

namespace OnlineGroceryStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
			int Val1;
            int Val2;
            int Val3;
            int p = 0;
            int f = 0;
            int g = 0;
			Console.Write("Enter the number of sliced ham or SH3 needed  ");
			userInput = Console.ReadLine();
			Val1 = Convert.ToInt32(userInput);
            Console.Write("Enter the number of Yoghurt or YT2 needed  ");
			userInput = Console.ReadLine();
			Val2 = Convert.ToInt32(userInput);
            Console.Write("Enter the number of Toilet Roll or TR needed  ");
			userInput = Console.ReadLine();
			Val3 = Convert.ToInt32(userInput);
            Program t = new Program();
			t.slicedham(Val1, p, f);
            t.yoghurt(Val2,g,f,p);
            t.ToiletRoll(Val3,g,f,p);
            
        }
     public void slicedham(int n, int p, int f){
    int i=n;
    double sum;
        while(i>0)
        {
             if(i%5==0){
                i=i-5;
                f++;
                
            }
            else if(i%3==0){
                i=i-3;
                p++;
                
            }
            if(i%3!=0 && i%5!=0)
            {
            if(i>=3 && i<5){
                i=i-3;
                p++;
                
            }
            else if(i>=5){
                i=i-5;
                f++;
                
            }
            else if(i>0 && i<3)/* The lowest pair of pre-packed sliced ham is given to the customer since assumption taken that packs are not sold individually*/ 
            {
                 
                 p++;
                i=0;
            }
        }
        }
        sum = (f*4.49)+(p*2.99);
          Console.WriteLine(n + "  SH3  " + sum);
        if(p!=0){
      Console.WriteLine("SH3  " + p + "* 3 $2.99");}
      if(f!=0){
        Console.WriteLine("SH3  " + f + "* 5 $4.49");}
        p=0;
        f=0;
    }
         public void yoghurt(int n, int g, int f, int p){
    int i=n;
    double sum;
        while(i>0)
        {
             if(i%15==0){
                i=i-15;
                f++;
            }
            else if(i%10==0){
                i=i-10;
                p++;
            }
             else if(i%4==0){
                i=i-4;
                g++;
            }
            if(i%15!=0 && i%10!=0 && i%4!=0)
            {
            if(i>=4 && i<10){
                i=i-4;
                g++;
            }
            else if(i>=10 && i<15){
                i=i-10;
                p++;
            }
            else if(i>=15){
                i=i-15;
                f++;
            }
            else if(i>0 && i<4)/* The lowest pair of pre-packed Yoghurt is given to the customer since assumption taken that packes are no sold individually*/
            {
                 
                 g++;
                i=0;
            }
        }
        }
        sum = (f*13.95)+(p*9.95)+(g*4.95);
          Console.WriteLine(n + "  YT2  " + sum);
        if(f!=0){
      Console.WriteLine("YT2  " + f + "* 15 $13.95");}
      if(p!=0){
        Console.WriteLine("YT2  " + p + "* 10 $9.95");}
        if(g!=0){
        Console.WriteLine("YT2  " + g + "* 4 $4.95");}
      p=f=g=0; 
    }
             public void ToiletRoll(int n, int g, int f, int p){
    int i=n;
    double sum;
        while(i>0)
        {
             if(i%9==0){
                i=i-9;
                f++;
            }
            else if(i%5==0){
                i=i-5;
                p++;
            }
             else if(i%3==0){
                i=i-3;
                g++;
            }
            if(i%9!=0 && i%5!=0 && i%3!=0)
            {
            if(i>=3 && i<5){
                i=i-3;
                g++;
            }
            else if(i>=5 && i<9){
                i=i-5;
                p++;
            }
            else if(i>=9){
                i=i-9;
                f++;
            }
            else if(i>0 && i<3)/* The lowest pair of pre-packed Toilet Rolls is given to the customer since assumption taken that packs are not sold individually.*/
            {
                 
                 g++;
                i=0;
            }
        }
        }
        sum = (f*7.99)+(p*4.45)+(g*2.95);
        Console.WriteLine(n + "  TR  " + sum);
        if(f!=0){
      Console.WriteLine("TR  " + f + "* 9 $7.99");}
      if(p!=0){
        Console.WriteLine("TR  " + p + "* 5 $4.45");}
        if(g!=0){
        Console.WriteLine("TR  " + g + "* 3 $2.95");}
      p=f=g=0; 
    }

    }

    }

