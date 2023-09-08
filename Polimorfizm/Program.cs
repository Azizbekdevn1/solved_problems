// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");





//Sinfdagi funksiyalarni chaqirib ishlatib koramiz 

double[] point1 = new double[] { 1, 2, 6 };
double[] point2 = new double[] { 3, 4, -12 };

Masofa distance = new Evklid();
double dist = distance.Roo(point1, point2);//  Evklid fazosidagi masofa
Console.WriteLine(dist);

distance = new Chebishev();
dist = distance.Roo(point1, point2);//  Chebyshev fazosidagi masofa
Console.WriteLine(dist);

distance = new Hemming();
dist = distance.Roo(point1, point2);//  Hemming fazosidagi masofa
Console.WriteLine(dist);