using System;

namespace LOG_IN_PASSWORD___USER_NAME
{
    class Program
    {
        static void Main(string[] args)
        {
            string username,user_name,Password,pass_word,Square,Rectangle,Circle,Sphere,Shape,Area,Perimeter,AREA_OR_PERIMETER;
            double square,rectangle,circle,sphere,length,width,radius,SQUARE,RECTANGLE,CIRCLE;
            const double pie=3.142;
            Console.WriteLine("Please Enter User Name(3 Trials Remaining)");
            username=Console.ReadLine();
            user_name="ericndegwa";
            if(username==user_name||username!=user_name)
            {
                Console.WriteLine("Please Enter Password");
                Password=Console.ReadLine();
                pass_word="microsoft";
                if(Password==pass_word&&username==user_name)
                {
                    Console.WriteLine("AREA & PERIMETER OF SHAPES");
                    console.WriteLine("Please Enter Area or Perimeter(Use Lower Case)")
                    AREA_OR_PERIMETER=Console.ReadLine();
                    Area="area";
                    Perimeter="perimeter";
                    if(AREA_OR_PERIMETER==Area)
                    {
                        Console.WriteLine("Enter Any of The Following Shapes...")
                        Console.WriteLine(">square")
                        Console.WriteLine(">rectangle")
                        Console.WriteLine(">circle")
                        Console.WriteLine(">sphere")
                    }
                    
                }
                else
                {
                    Console.WriteLine("Wrong User Name or Password !");
                    Console.WriteLine("Please Enter User Name Again(2 Trials Remaining)");
                    username=Console.ReadLine();
                    user_name="ericndegwa";
                    if(username==user_name||username!=user_name)
                 {
                    Console.WriteLine("Please Enter Password");
                    Password=Console.ReadLine();
                    pass_word="microsoft";
                    if(Password==pass_word&&username==user_name)
                  {
                    Console.WriteLine("Succeeded");
                  }
                  else
                {
                    Console.WriteLine("Wrong User Name or Password !");
                    Console.WriteLine("Please Enter User Name Again(1 Trial Remaining)");
                    username=Console.ReadLine();
                    user_name="ericndegwa";
                    if(username==user_name||username!=user_name)
                {
                    Console.WriteLine("Please Enter Password");
                    Password=Console.ReadLine();
                    pass_word="microsoft";
                    if(Password==pass_word&&username==user_name)
                {
                    Console.WriteLine("Succeeded");
                }
                else
                {
                    Console.WriteLine("Three Times Exceeded !");
                }
                }
                }
                
                
                }
                }
                
            }  


        }
    }
}
