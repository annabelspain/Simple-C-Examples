

public class Calculator
{
    private float answer;

    public float GetAnswer()
    {
        return answer;
    }

    public void Calculation(double firstNumber, double secondNumber, string operator1, float answer)
    {
        float answer; 

        switch (operator1)
        {
            case "+":
                answer = (float)(firstNumber + secondNumber);
                break;
            case "-":
                answer = (float)(firstNumber - secondNumber);
                break;
            case "*":
                answer = (float)(firstNumber * secondNumber);
                break;
            case "/":
                answer = (float)(firstNumber / secondNumber);
                break;
        }
        Console.WriteLine($"Result is {answer}");
    }
}

//internal void Calculation(double firstNumber, double secondNumber, string operator1)
//{
//    Calculation(firstNumber, secondNumber, operator1, answer);
//}

//public void Calculation(double num1, double num2, string operator1, double answer)
//{
//    switch (operator1)
//    {
//        case "+":
//            answer = num1 + num2;
//            break;
//        case "-":
//            answer = num1 - num2;
//            break;
//        case "*":
//            answer = num1 * num2;
//            break;
//        case "/":
//            answer = num1 / num2;
//            break;
//    }
//    Console.WriteLine($"Result is {answer}");
//}