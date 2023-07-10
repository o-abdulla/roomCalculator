//room calculator

//prompt user to enter values of classroom (length and width)

Console.WriteLine("Enter length of classroom");
double length = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the width of classroom");
double width = double.Parse(Console.ReadLine());
double perimeter = 2 * length + width;
Console.WriteLine("The perimeter of the classroom is " + perimeter);
double area = length * width;
Console.WriteLine("The area of classroom is " + area);

// Extra credit coming up with volume and surface area of classroom

Console.WriteLine("Enter the height of the room");
double height = double.Parse(Console.ReadLine());
double volume = height * width * length;
Console.WriteLine("The volume of the room is " + volume);
double sarea = 2 * (length * width) + (width * height) + (length * height);
Console.WriteLine("The surface area of the room is " + sarea);

// make an if statement to determine room classification sizes

if (area <= 250)
{
    Console.WriteLine("Room is small");
}
else if (area >= 251 && area < 650)
{
    Console.WriteLine("Room is medium");
}
else if (area >= 650)
{
    Console.WriteLine("Room is large");
}

