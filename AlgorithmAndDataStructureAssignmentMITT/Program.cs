using System.Text;

// “RTFFFFYYUPPPEEEUU”

string stringReducer(string caseString)
{
    string stringToReduce = caseString;

    StringBuilder returnString = new StringBuilder();
    
    int presentCharCount = 0;

    for (int index = 0; index < stringToReduce.Length; index++)
    {          
        if ( stringToReduce[index] != stringToReduce[index + 1])
        {
            returnString.Append(stringToReduce[index]);
        }
        else if ( stringToReduce[index] == stringToReduce[index + 1])
        {
            presentCharCount++;
        }
    }


    return "infisenfknefkosw";
}

stringReducer("RTFFFFYYUPPPEEEUU");