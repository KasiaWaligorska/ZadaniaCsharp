namespace a_zadania.d_Konstruktor;

public class Calculator
{
    public String[] operationHistory;

    public Calculator()
    {
        operationHistory = new String[0];
    }

    public double Add(int num1, int num2)
    {
        double result = num1 + num2;
        String operation = "Added " + num1 + " to " + num2 + " got " + result + ".";
        AddToOperationList(operation);
        return result;
    }

    public double Multiply(int num1, int num2)
    {
        double result = num1 * num2;
        String operation = "Multiplied " + num1 + " with " + num2 + " got " + result + ".";
        AddToOperationList(operation);
        return result;
    }

    public double Subtract(int num1, int num2)
    {
        double result = num1 - num2;
        String operation = "Subtracted " + num2 + " from " + num1 + " got " + result + ".";
        AddToOperationList(operation);
        return result;
    }

    public double Divide(int num1, int num2)
    {
        if (num2 > 0)
        {
            double result = num1 / num2;
            String operation = "Divided " + num1 + " by " + num2 + " got " + result + ".";
            AddToOperationList(operation);
            return result;
        }
        else
        {
            Console.WriteLine("Can't divide by 0!");
            String operation = "Error - dividing by zero";
            AddToOperationList(operation);
            double result = 0;
            return result;
        }
    }

    public void AddToOperationList(String operation)
    {
        int length = this.operationHistory.Length + 1;
        String[] temporaryArray = new String[length];
        for (int i = 0; i < this.operationHistory.Length; i++)
        {
            temporaryArray[i] = this.operationHistory[i];
        }

        temporaryArray[length - 1] = operation;
        this.operationHistory = temporaryArray;
    }

    public string[] PrintOperations()
    {
        Console.WriteLine("Oto lista operacji:");
        for (int i = 0; i < this.operationHistory.Length; i++)
        {
            Console.WriteLine(this.operationHistory[i]);
        }
        return this.operationHistory;
    }

    public void ClearOperations()
    {
        this.operationHistory = new String[0];
        Console.WriteLine("Wyczyszczono listę operacji");
    }
}