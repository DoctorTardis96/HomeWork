//Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 3D пространстве.

double GetValue(String text)
{
    Console.Write(text + ": ");
    double value = Convert.ToDouble(Console.ReadLine());
    return value;
}

void Print(double ax, double ay, double bx, double by, double bz, double az, double res)
{
    string output = $"|A({ax}, {ay}); B({bx}, {by}); Z({az}, {bz})| = {res}";
    Console.WriteLine(output);
}

double GetDistance3D(double ax, double ay, double bx, double by, double az, double bz)
{
double x = (ax - bx) * (ax - bx);
double y = (ay - by) * (ay - by);
double z = (az - bz) * (az - bz);
double result = Math.Sqrt(y + x + z);
return result;
}

double ax = GetValue("ax");
double ay = GetValue("ay");
double bx = GetValue("bx");
double by = GetValue("by");
double az = GetValue("az");
double bz = GetValue("bz");

double dis = GetDistance3D(ax, ay, bx, by, az, bz);
Print(ax, ay, bx, by, az, bz, dis);