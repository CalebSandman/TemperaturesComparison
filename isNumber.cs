class IsInputNumber{
    public static int? GetInt(string input)
    {
        if (int.TryParse(input, out int number))
            return number;
        return null;
    }

    public static double? GetDouble(string input)
    {
        if(double.TryParse(input, out double number))
            return number;
        return null;
    }
}