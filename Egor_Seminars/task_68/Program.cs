// 68.Показать натуральные числа от M до N, N и M заданы

string GetSequens(int start, int end)
{
    if (start < end)
    {
        if (start == end) return " " + start;
        return start + " " + GetSequens(start + 1, end);
    }
    else if (start > end)
    {
        if (start == end) return " " + start;
        return GetSequens(start + 1, end) + " " + start;
    }
}

Console.WriteLine("последовательность: " + GetSequens(15, 10));