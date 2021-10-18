// See https://aka.ms/new-console-template for more information


#region Q1

//Func<int, int, int, int> func1 = (x, y, z) =>
//       {
//           int min;
//           if (x < y)
//           {
//               min = x;
//           }
//           else min = y;
//           if (min < z)
//           {
//               return min;
//           }
//           else return z;
//       };
//Console.WriteLine(func1(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));

#endregion

#region Q2

//Action<int, int, int> action1 = (x, y, z) =>
//{
//    Console.WriteLine((x + y + z) / 3);
//};
//action1(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

#endregion

#region Q3

//Func<string, string> func3 = str =>
// {
//     string newStr;
//     if (str.Length % 2 == 1)
//     {
//         newStr = (str[str.Length / 2]).ToString();
//     }
//     else
//     {
//         newStr = (str[(str.Length / 2) - 1]).ToString() + (str[str.Length / 2]).ToString();
//     }
//     return newStr;
// };
//string s = func3(Console.ReadLine());
//Console.WriteLine(s);

#endregion

#region Q4

//Func<string, int> func4 = (str) =>
//{
//    int count = 0;
//    str = str.ToLower();
//    foreach (char item in str)
//    {
//        switch (item)
//        {
//            case 'a':
//                count++;
//                break;

//            case 'e':
//                count++;
//                break;

//            case 'i':
//                count++;
//                break;

//            case 'o':
//                count++;
//                break;

//            case 'u':
//                count++;
//                break;
//        }
//    }
//    return count;
//};
//int count2 = func4(Console.ReadLine());
//Console.WriteLine(count2);

#endregion

#region Q5

//Func<string, int> func4 = (str) =>
//{
//    int count = 1;
//    foreach (char item in str)
//    {
//        switch (item)
//        {
//            case ' ':
//                count++;
//                break;
//        }
//    }
//    return count;
//};
//int count2 = func4(Console.ReadLine());
//Console.WriteLine(count2);

#endregion

#region Q6

//Func<int, int> func6 = x =>
//{
//    int sum = 0;
//    int digit;
//    while (x > 0)
//    {
//        digit = x % 10;
//        sum += digit;
//        x /= 10;
//    }
//    return sum;
//};
//int x = func6(int.Parse(Console.ReadLine()));
//Console.WriteLine(x);

#endregion

#region Predicate Exercise

//Predicate<int> predicate = x =>
//{
//    if (x>10)
//    {
//        return true;
//    }
//    else return false;
//};

//Console.WriteLine(predicate(5));
//Console.WriteLine(predicate(51));
//Console.WriteLine(predicate(7));
//Console.WriteLine(predicate(75));

#endregion