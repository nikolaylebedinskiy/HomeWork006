void LineIntersection (int k1, int b1, int k2, int b2){
    int x = (b1 -b2) / (k2 -k1);
    int y = (k2 * b1 - k1 * b2) / (k2 - k1);
    if (k1 == k2)
        System.Console.WriteLine("Прямые не пересекаются"); 
    else
    System.Console.WriteLine($"Точка пересечения прямых ({x}; {y})");
}

System.Console.WriteLine("Введите b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
LineIntersection(k1, b1, k2, b2);
