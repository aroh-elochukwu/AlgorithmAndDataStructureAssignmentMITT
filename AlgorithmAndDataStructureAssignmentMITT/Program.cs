using System.Text;

// “RTFFFFYYUPPPEEEUU”

//accepts a string and compares its characters with a for loop to meet questions conditions
// with the use of a stringbuilder
//incomplete code/logic at least according to return string

string stringReducer(string caseString)
{
    string stringToReduce = String.Format("{0}{1}{2}", caseString,"1","2");

    StringBuilder returnString = new StringBuilder();

    Console.WriteLine(stringToReduce);
    
    int presentCharCount = 1;

    for (int index = 0; index < stringToReduce.Length - 2; index++)
    {          
        if (stringToReduce[index] == stringToReduce[index + 1] && stringToReduce[index + 1] == stringToReduce[index + 2])
        {            
           if (stringToReduce[index] == stringToReduce[index + 1])
            {
                presentCharCount++;
                index++;

                if (stringToReduce[index + 1]  != stringToReduce[index + 2])
                {
                    presentCharCount++;
                    index++;
                    returnString.Append(stringToReduce[index ]);
                    returnString.Append(presentCharCount);
                    presentCharCount = 1;
                }
                // goes on break with hopes of coming back with an idea on how to fix bug 
            }     

        }
        else if ( stringToReduce[index] == stringToReduce[index + 1]  && stringToReduce[index + 1] != stringToReduce[index + 2])
        {
            returnString.Append(stringToReduce[index]);
            returnString.Append(stringToReduce[index + 1]);
            index = index + 1;
        } 
        else  if (stringToReduce[index] != stringToReduce[index + 1])
        {
            returnString.Append(stringToReduce[index]);
        }
        
    }


    return returnString.ToString();
}

Console.WriteLine(stringReducer("RTFFFFYYUPPPEEEUU"));