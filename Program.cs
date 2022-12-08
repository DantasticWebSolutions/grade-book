// // Adding 2 numbers 
// double x = 34.7;
// double y = 32.7;
// double result = x + y;
// Console.WriteLine(result);

// Initialising an array
var numbers = new double[3];
numbers[0] = 12.7;
numbers[1] = 14.1;
numbers[2] = 15.4;
var result = numbers[0];
result = result + numbers[1];
result = result + numbers[2];
Console.WriteLine(result);

// Initialising an array without specifing the lenght of the array
var numbers2 = new[] {12.7, 14.1, 15.4, 4.1};

var result2 = numbers2[0];
result2 += numbers2[1];
result2 += numbers2[2];
result2 += numbers2[3];
Console.WriteLine(result2);

// Adding values using FOR EACH
var numbers3 = new[] {12.7, 14.1, 15.4, 4.1};

var result3 = 0.0;
foreach(double number in numbers3){
    result3 += number;
}
Console.WriteLine(result3);

// Lists
var grades = new List<double>()  {12.7, 14.1, 15.4, 4.1};
grades.Add(10.1);
var average=0.0;
foreach(var grade in grades){
    average += grade;
} 
    average /= grades.Count;
Console.WriteLine($"The average is: {average} and the count of grades is: {grades.Count}");


if(args.Length > 0){
    Console.WriteLine($"Hello, {args[0]}!");
} else {
    Console.WriteLine("Hello World!");
}
