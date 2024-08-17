Console.WriteLine("Enter the String ");
string input = Console.ReadLine();
if(!string.IsNullOrEmpty(input))
{
    string[] strArray = input.Split(' ');
    if(strArray.Length > 0)
    {
        for(int counter= strArray.Length-1; counter>=0; counter--)
        {
            Console.WriteLine(strArray[counter]);
        }
    }
}