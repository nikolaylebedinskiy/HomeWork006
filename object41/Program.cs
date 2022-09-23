int[] GetArray(int length) {
    System.Console.WriteLine($"\nВведите {length} чисел:\n");
    var array = new int[length];
    for (var i = 0; i < array.Length; i++) {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] n) {
    System.Console.WriteLine("\nВведены числа: \n");
    for (int i = 0; i < n.Length - 1; i++) {
        System.Console.Write($"{n[i]}, ");
    }
    System.Console.Write($"{n[n.Length - 1]}");
}

int PositiveNumbers(int[] numbers) {
    int x = 0;
    for (int i = 0; i < numbers.Length; i++){
        if (numbers[i] > 0) {
            x++;
        }
    }
    return x;
}
int[] n = GetArray(10);
PrintArray(n);
System.Console.WriteLine($"\n\nВведено{PositiveNumbers(n)} положительных чисел.");

