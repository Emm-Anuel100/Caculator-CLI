using System;

   class program
   {
      static void Main(string[] args){   // main method 

       Calculate();

       Console.ReadKey(); //wait before closing the program
      }
    

    static void Calculate(){ // method for performing all calculations  

      Console.WriteLine("C# simple Calculator, what would you like to do? \a\n ");

      begin_calculation:
      Console.WriteLine("Strike 'A' for addition 'S' for subtraction 'D' for division 'M' for multiplication.");
      string choose = Console.ReadLine();


      if (choose == "A" || choose ==  "a")
      {
        Console.WriteLine("Enter first number: \t\t ");
        float first_numb = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number: \t\t");
        float second_numb = float.Parse(Console.ReadLine());

      Console.WriteLine("the sum of " + (first_numb) + " and " +  (second_numb) + " is " + (first_numb + second_numb) + "\n\n");
      
      Console.WriteLine("want to do any other calculation? (Y/N)");
      string other_calcu = Console.ReadLine();

      if (other_calcu == "Y" || other_calcu == "y")
      {
         goto begin_calculation;

      }else{
         Console.WriteLine("Thank you! \n");
      }
      }

      else if(choose == "S" || choose == "s")
      {
         Console.WriteLine("Enter first number: \t\t ");
        float first_numb = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number: \t\t");
        float second_numb = float.Parse(Console.ReadLine());

      Console.WriteLine("the difference of " + (first_numb) + " and " +  (second_numb) + " is " + (first_numb - second_numb) + "\n\n");
      
      Console.WriteLine("want to do any other calculation? (Y/N)");
      string other_calcu = Console.ReadLine();

      if (other_calcu == "Y" || other_calcu == "y")
      {
         goto begin_calculation;

      }else{
         Console.WriteLine(" Thank you! \n");
      }
      }


        else if(choose == "D" || choose == "d")
      {
         Console.WriteLine("Enter first number: \t\t ");
        float first_numb = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number: \t\t");
        float second_numb = float.Parse(Console.ReadLine());

      Console.WriteLine("the devidend of " + (first_numb) + " and " +  (second_numb) + " is " + (first_numb / second_numb) + "\n\n");
      
      Console.WriteLine("want to do any other calculation? (Y/N)");
      string other_calcu = Console.ReadLine();

      if (other_calcu == "Y" || other_calcu == "y")
      {
         goto begin_calculation;

      }else{
         Console.WriteLine(" Thank you! \n");
      }
      }

        else if(choose == "M" || choose == "m")
      {
         Console.WriteLine("Enter first number: \t\t ");
        float first_numb = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number: \t\t");
        float second_numb = float.Parse(Console.ReadLine());

      Console.WriteLine("the product of " + (first_numb) + " and " +  (second_numb) + " is " + (first_numb * second_numb) + "\n\n");
      
      Console.WriteLine("want to do any other calculation? (Y/N)");
      string other_calcu = Console.ReadLine();

      if (other_calcu == "Y" || other_calcu == "y")
      {
         goto begin_calculation;

      }else{
         Console.WriteLine(" Thank you! \n");
      }
      }
      else 
      {
       Console.WriteLine("input unknown ! \a ");
       goto begin_calculation;
      }
      
      // Console.Writeline("This is all !");
    }
   }