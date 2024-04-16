using System.Diagnostics;
using System.Globalization;
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

        //String Formatting
        double d = 0.375;
        string infoToDisplay = d.ToString("P2");
        Console.WriteLine(infoToDisplay);

        string myFormatterdString = String.Format("{0:F5}", d);
        Console.WriteLine(myFormatterdString);

        //Datetime

        DateTime myDate = DateTime.Now;
        Console.WriteLine(myDate);

        var myFormattedDate = string.Format("{0:d.MM.yyyy HH:mm}", myDate);
        Console.WriteLine(myFormattedDate);

        CultureInfo culture = new CultureInfo("ro-Ro");
        Console.WriteLine(myDate.ToString("d", culture));

        string myDate2 = "01.05.2024";
        
        var tommorow =myDate.AddDays(1);
        //var yesterday = myDate2.Add(-1); //this isn`t possible.
        DateTime futureDate = DateTime.ParseExact(myDate2, "dd.MM.yyyy", CultureInfo.InvariantCulture);
        var yesterday = futureDate.AddDays(-1);


        //String interpolation
        string student = "John";
        string age = "25";
        string str = $"Studentu {student} is {age} old.";

        string myStudent = "John is \"the best \".";//escaping character
        string myStudent2 = "John is 'the best'."; //using single quote
        string verbatimStudent = @"john is ""the best""";

        string spacedString = "this is my syoer " + "long string ";
        string verbatimString = @"this
is
my syoer
long 
string";
        Console.WriteLine("Enter your text using quotes:");
        string quote = Console.ReadLine();
        //Console.WriteLine(quote);


        //3 things to remember
        //are immutable
        //have a reference type
       



    }

}
