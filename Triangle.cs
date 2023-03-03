using System;

public static class Triangle
{
    public static bool IsTriangleValid(double side1, double side2, double side3){
        double[] values = new double[3];
        values[0] = side1;
        values[1] = side2;
        values[2] = side3;
        Array.Sort(values);
        return values[0] + values[1] > values[2];
    }
    public static bool IsScalene(double side1, double side2, double side3)
    {
        IsTriangleValid(side1, side2, side3);
        double epsilon = 0.00000001;
        return IsTriangleValid(side1, side2, side3)
            && (Math.Abs(side1 - side2) > epsilon 
            && Math.Abs(side2 - side3) > epsilon 
            && Math.Abs(side3 - side1) > epsilon);
    }

    public static bool IsIsosceles(double side1, double side2, double side3) 
    {
        double epsilon = 0.00000001;
        return (Math.Abs(side1 - side2) < epsilon 
            || Math.Abs(side2 - side3) < epsilon 
            || Math.Abs(side3 - side1) < epsilon)
            && IsTriangleValid(side1, side2, side3);
    }

    public static bool IsEquilateral(double side1, double side2, double side3) 
    {
        double epsilon = 0.00000001;
        return IsTriangleValid(side1, side2, side3)
        &&(Math.Abs(side1 - side2) < epsilon 
        && Math.Abs(side2 - side3) < epsilon 
        && Math.Abs(side3 - side1) < epsilon);

        
    }
}
