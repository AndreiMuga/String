using System.Diagnostics;
using System.Text;

public static class Program
{
    public static void Main()
    {
        //Declare strings
        string myFirstString = "Hello world again!!! ";
        Console.WriteLine("Hello again");
        Console.WriteLine(myFirstString);

        int myNumber = 42;
        Console.WriteLine(myNumber);

        string myNumberAsString = myNumber.ToString();


        //Manipulating strings
        //Concatenation
        string firstName = "Ionel ";
        string lastName = "Popescu";
        string fullName = firstName + lastName;
        string fullNameWithConcat = String.Concat(firstName, " ", lastName);
        Console.WriteLine(fullNameWithConcat);
        Console.WriteLine(fullName);
        Console.WriteLine(fullNameWithConcat);
        Console.WriteLine($"{firstName} {lastName}");

        //Searching in strings
        int index = fullName.IndexOf("Io"); //0
        Console.WriteLine(index);
        index = fullName.IndexOf("Popescu");

        Console.WriteLine(index);
        index = fullName.IndexOf("POPESCU"); // 6
        index = fullName.IndexOf("o", 1); //1
        index = fullName.IndexOf("o", 3); // 7
        Console.WriteLine(index);


        //Extract substring
        //C:/Holiday/2025/1/nice_pic.png

        string path = "C:/Holiday/2025/1/nice_pic.png";

        //searcg tge dit ub strubg
        int indexOfDot = path.IndexOf(".");
        int indexOfLastDot = path.LastIndexOf(".");
        //take the file extension
        string extention = path.Substring(indexOfLastDot + 1);

        //extract the file name
        int lastIndexOfSlash = path.LastIndexOf("/");
        int substringLength = indexOfDot - lastIndexOfSlash - 1;

        string fileName = path.Substring(lastIndexOfSlash + 1, substringLength);
        Console.WriteLine($"{fileName}.{extention}");


        //Extract substring
        #region Comparing strings
        string str1 = "oradea";
        string str2 = "Oradea";

        int result = string.Compare(str1, str2, true);//casing matters
        if (result == 0)
        {
            Console.WriteLine("str1 equals str 2");

        }
        if (str1 == str2)
        {
            //
        }
        if (str1.Equals(str2))
        {

        }
        #endregion

        #region Splitting
        string listOfCities = "Londra, Paris, Iasi, Cluj, Bucuresti";
        string[] cities = listOfCities.Split(',', ' ', '.');

        foreach (string city in cities)
        {
            if (!string.IsNullOrEmpty(city))
            {
                Console.WriteLine(city.ToUpper());
                //Console.WriteLine(city.ToLower());
            }
        }

        #endregion

        //Trim

        string mySpacedString = "               this is a string     ";
        Console.WriteLine(mySpacedString.TrimStart());
        Console.WriteLine(mySpacedString.TrimEnd());
        mySpacedString.Trim();

        string myFunnyString = "---+++++--++this is a string ++++++++++-----";
        Console.WriteLine(myFunnyString.Trim('+', '-'));
        Console.WriteLine(myFunnyString.Replace("+", ""));

        StringBuilder stringBuilder = new StringBuilder(); //dureaza mult mai putin
        var stopWatch = new Stopwatch();
        string myCoolString = "Counting bottle: ";

        stopWatch.Start();

        stringBuilder.Append(myCoolString);
        for (int i = 0; i < 10000; i++)
        {
            stringBuilder.Append(i.ToString());//dureaza mult mai putin

            //myCoolString += i.ToString();
            //Console.WriteLine(myCoolString);//dureaza mult sa scrie la consola
        }
        Console.WriteLine(stringBuilder.ToString());
        stopWatch.Stop();
        Console.WriteLine(stopWatch.Elapsed.TotalSeconds.ToString());
    }

}
