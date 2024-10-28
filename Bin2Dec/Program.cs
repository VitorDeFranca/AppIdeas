bool control = true;
while (control) {
    Console.WriteLine("Enter an up to 8-digit binary number (empty to exit): ");
    string? binaryNum = Console.ReadLine();
    if (string.IsNullOrEmpty(binaryNum)) control = false;
    if (binaryNum.Length > 8) Console.WriteLine($"Numbers longer than 8 digits are not valid!");
    if (!binaryNum.All(c => c == '0' || c == '1')) 
        Console.WriteLine("Invalid binary number! Only '0' and '1' are allowed.");
    else
    {
        int decNum = 0;
        int originalLength = binaryNum.Length;
        for (int i = 0; i < originalLength; i++)
        {
            char lastDigit = binaryNum.Last();
            if (lastDigit == '0') binaryNum = binaryNum.Remove(binaryNum.Length - 1);
            else if (lastDigit == '1')
            {
                double numToBeAdded = Math.Pow(2, i);
                decNum += (int)numToBeAdded;
                binaryNum = binaryNum.Remove(binaryNum.Length - 1);
            }
        }
        Console.WriteLine($"Decimal number: {decNum}");
    }
}
