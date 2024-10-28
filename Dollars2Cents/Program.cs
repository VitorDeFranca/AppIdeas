int quartersAmount = 0, dimesAmount = 0, nickelsAmount = 0, penniesAmount = 0;
bool control = true;

while (control)
{
    Console.WriteLine("Enter a dollar value (empty to exit): ");
    string? input = Console.ReadLine();
    bool success = decimal.TryParse(input, out var dollarValue);
    if (success)
    {
        int centsValue = (int)(Math.Round(dollarValue, 2) * 100);
        Console.WriteLine($"Cents value: {centsValue}");
        while (centsValue > 0)
        {
            if (centsValue % 25 == 0)
            {
                quartersAmount++;
                centsValue -= 25;
            }
            else if (centsValue % 10 == 0)
            {
                dimesAmount++;
                centsValue -= 10;
            }
            else if (centsValue % 5 == 0)
            {
                nickelsAmount++;
                centsValue -= 5;
            }
            else
            {
                penniesAmount++;
                centsValue -= 1;
            }
        }
        Console.WriteLine($"Amount of coins\nQuarters:{quartersAmount}\nDimes:{dimesAmount}\nNickels:{nickelsAmount}\nPennies:{penniesAmount}\n");

    }
    else
    {
        if (string.IsNullOrEmpty(input)) control = false;
        else Console.WriteLine("Invald dollar value!");
    }
}

