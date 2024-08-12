// See https://aka.ms/new-console-template for more information

// SYNTAX (DERLEME) ERRORS
// Console.WriteLine("Hi") // ; koymalısın
// string value = 15; // data type ve value uyumsuzluğu

// RUNTIME (ÇALIŞMA ZAMANI) ERRORS
// Kullanıcıdan alınan telefon numarasının doğru formatta olup olmaması:
// Doğru format: 10 digit, without 0 at the beginning (1112223344)

//EnterPhone:
//Console.Write("Enter your phone number (10 digits, without 0): ");
//string phone = Console.ReadLine();

//if(phone.Length == 10)
//{
//    //Console.WriteLine("Correct phone format");
//    //int phoneInt = int.Parse(phone);
//    //Console.WriteLine($"Entered phone: {phoneInt}");

//    int phoneInt;
//    bool isCorrect = int.TryParse(phone, out phoneInt);
//    if(isCorrect )
//    {
//        Console.WriteLine("Correct phone format");
//        Console.WriteLine($"Entered phone: {phoneInt}");
//    }
//    else
//    {
//        Console.WriteLine("Wrong format! Please enter again...");
//        goto EnterPhone;
//    }
//}

#region TRY CATCH 
//try
//{
//    Console.Write("Enter your phone number (10 digits, without 0): ");
//    string phone = Console.ReadLine();
//    int phoneInt = int.Parse(phone);
//    Console.WriteLine("Correct phone format");
//    Console.WriteLine($"Entered phone: {phoneInt}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Wrong format! {ex.Message}");
//}
//finally
//{
//    Console.WriteLine("This line will always be displayed");
//}
#endregion

#region Exception Class Overview
try
{
	Console.WriteLine("Enter 1. number");
	int num1 = int.Parse(Console.ReadLine());
	Console.WriteLine("Enter 2. number");
    int num2 = int.Parse(Console.ReadLine());
	double result = num1 / num2;

    Console.WriteLine("Result: " + result);
}
catch (DivideByZeroException divideZeroEx)
{
    Console.WriteLine(divideZeroEx.Message);
    Console.WriteLine(divideZeroEx.Source);
    Console.WriteLine(divideZeroEx.HelpLink);
    Console.WriteLine(divideZeroEx.InnerException);
    Console.WriteLine(divideZeroEx.StackTrace);
    Console.WriteLine("You cannot divide a number by 0");
}
catch (OverflowException overFlowEx)
{
    Console.WriteLine(overFlowEx.Message);
    Console.WriteLine(overFlowEx.Source);
    Console.WriteLine(overFlowEx.HelpLink);
    Console.WriteLine(overFlowEx.InnerException);
    Console.WriteLine(overFlowEx.StackTrace);
    Console.WriteLine("Integer cannot store one of the entered numbers. It is too big!");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
#endregion