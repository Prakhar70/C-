using System;
class parse
{
    public static void Main()
    {
        string strName="998q7";
        int Result=0;
        bool isConvertedSuccessful=int.TryParse(strName,out Result);
        if(isConvertedSuccessful){
            Console.WriteLine(Result);
        }
        else{
            Console.WriteLine("Please enter a valid number");
        }
    }
}