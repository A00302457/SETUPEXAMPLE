Console.WriteLine("Please give a calculation:");
string? cmd = Console.ReadLine();
string[] arr = cmd?.Split(" ");
Command operation = new Command();
if (arr[0] == "+")
{
    operation = new Add();
}
if (arr[0] == "%")
{
    operation = new Modulo();
}
if (arr[0] == "*")
{
    operation = new Multiply();
}
if (arr[0] == "/")
{
    operation = new Divide();
}
if (arr[0] == "-")
{
    operation = new Subtract();
}
if (operation is not null)
    Console.WriteLine($"Hello Reader:\n{operation?.Execute(decimal.Parse(arr[1]), decimal.Parse(arr[2]))}");


public class Command
{
    public virtual string Execute(decimal left, decimal right)
    {
        return " ";
    }
}
public class Add : Command
{
    public override string Execute(decimal left, decimal right)
    {
        return $"The Addition of {left} and {right} is = {left + right}";
    }
}
public class Divide : Command
{
    public override string Execute(decimal left, decimal right)
    {
        return $"The Division of {left} and {right} is = {left / right}";
    }
}
public class Multiply : Command
{
    public override string Execute(decimal left, decimal right)
    {
        return $"The Muliplication of {left} and {right} is = {left * right}";
    }
}
public class Modulo : Command
{
    public override string Execute(decimal left, decimal right)
    {
        return $"The reminder of {left} and {right} is = {left % right}";
    }
}
public class Subtract : Command
{
    public override string Execute(Decimal left, Decimal right)
    {
        return $"The Substraction of {left} and {right} is = {left - right}";
    }
}