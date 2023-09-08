abstract class Masofa
{
     public abstract double Roo(double[] point1, double[] point2);
}

class Evklid : Masofa
{
     public override double Roo(double[] point1, double[] point2)
     {
          double sum = 0;
          for (int i = 0; i < point1.Length; i++)
          {
               double diff = point1[i] - point2[i];
               sum += diff * diff;
          }
          return Math.Sqrt(sum);
     }
}

class Chebishev : Masofa
{
     public override double Roo(double[] point1, double[] point2)
     {
          double maxDiff = 0;
          for (int i = 0; i < point1.Length; i++)
          {
               double diff = Math.Abs(point1[i] - point2[i]);
               if (diff > maxDiff)
               {
                    maxDiff = diff;
               }
          }
          return maxDiff;
     }
}

class Hemming : Masofa
{
     public override double Roo(double[] point1, double[] point2)
     {
          double numDiff = 0;
          for (int i = 0; i < point1.Length; i++)
          {
               if (point1[i] != point2[i])
               {
                    numDiff += Math.Abs(point1[i] - point2[i]);
               }
          }
          return numDiff;
     }
}