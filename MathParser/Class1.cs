namespace MathParser;

public class MyMathParser
{
    private string _userInput;
    
    public MyMathParser(string userInput)
    {
        _userInput = userInput;
    }

    public static char[] OpArray = new char[] { '+', '-', '*' };

    /*public int Parse()
    {
        char op='+';
        int index; 
        for (int i=0; i<_userInput.Length; i++)
        {
            char c = _userInput[i];
            if (Char.IsDigit(c) == false)
            {
                op = c;
                index = i; 
                break;
            }
        }

        string[] splitString = _userInput.Split(op);
        int[] myArr = new int[splitString.Length]; 
        for (int i = 0; i < splitString.Length; i++)
        {
            myArr[i] = int.Parse(splitString[i]);
        }

        if (op == '+')
        {
            int result = 0;
            for (int i = 0; i < myArr.Length; i++)
            {
                result += myArr[i];
            }

            return result; 
        }
        
        if (op == '-')
        {
            int result = 0;
            for (int i = 0; i < myArr.Length; i++)
            {
                result -= myArr[i];
            }

            return result; 
        }*/


}
