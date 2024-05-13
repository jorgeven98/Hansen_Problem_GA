using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra;
using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra.Vectors.Space2D;
using System.Text;
using System;

namespace GeometricAlgebraFulcrumLib.Lite.Samples.Geometry;

public sealed record HansenData2D
{
    public static HansenData2D Create(Float64Vector2D pointA, Float64Vector2D pointB, Float64Vector2D pointP1, Float64Vector2D pointP2)
    {
        var alpha1 = pointP2.GetDirectedAngle(pointP1, pointB);
        var beta1 = pointP2.GetDirectedAngle(pointP1, pointA);

        var alpha2 = pointA.GetDirectedAngle(pointP2, pointP1);
        var beta2 = pointB.GetDirectedAngle(pointP2, pointP1);


        return new HansenData2D(
            pointA,
            pointB,
            alpha1,
            alpha2,
            beta1,
            beta2
        );
    }

    public HansenData2D AddGNoise(double stdDev)
    {
        Random rand = new Random();
        Float64PlanarAngle[] angles = {Alpha1, Alpha2, Beta1, Beta2};
        Float64PlanarAngle[] noisy_angles = new Float64PlanarAngle[4];

        for (int i = 0; i < 4; i++)
        {
            double u1 = 1.0 - rand.NextDouble();
            double u2 = 1.0 - rand.NextDouble();
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2);
            noisy_angles[i] = angles[i].Radians.Value + stdDev * randStdNormal;
        }

        return new HansenData2D(
            A,
            B,
            noisy_angles[0],
            noisy_angles[1],
            noisy_angles[2],
            noisy_angles[3]
        );
    }

    public Float64Vector2D A { get; }

    public Float64Vector2D B { get; }

    public Float64PlanarAngle Alpha1 { get; }

    public Float64PlanarAngle Alpha2 { get; }

    public Float64PlanarAngle Beta1 { get; }

    public Float64PlanarAngle Beta2 { get; }


    private HansenData2D(Float64Vector2D pointA, Float64Vector2D pointB, Float64PlanarAngle alpha1, Float64PlanarAngle alpha2, Float64PlanarAngle beta1, Float64PlanarAngle beta2)
    {
        A = pointA;
        B = pointB;
        Alpha1 = alpha1;
        Alpha2 = alpha2;
        Beta1 = beta1;
        Beta2 = beta2;
    }

    
    public void SolveUsingTrig(out double p1X, out double p1Y, out double p2X, out double p2Y)
    {
        //Begin GA-FuL MetaContext Code Generation, 2024-03-14T20:32:50.0564743+02:00
        //MetaContext: Trig
        //Input Variables: 8 used, 0 not used, 8 total.
        //Temp Variables: 84 sub-expressions, 0 generated temps, 84 total.
        //Target Temp Variables: 17 total.
        //Output Variables: 4 total.
        //Computations: 1.6136363636363635 average, 142 total.
        //Memory Reads: 2.3068181818181817 average, 203 total.
        //Memory Writes: 88 total.
        //
        //MetaContext Binding Data:
        //   1 = constant: '1'
        //   -1 = constant: '-1'
        //   2 = constant: '2'
        //   Rational[1, 2] = constant: 'Rational[1, 2]'
        //   Rational[-1, 2] = constant: 'Rational[-1, 2]'
        //   Ax = parameter: A.X.Value
        //   Ay = parameter: A.Y.Value
        //   Bx = parameter: B.X.Value
        //   By = parameter: B.Y.Value
        //   alpha1 = parameter: Alpha1.Radians.Value
        //   alpha2 = parameter: Alpha2.Radians.Value
        //   beta1 = parameter: Beta1.Radians.Value
        //   beta2 = parameter: Beta2.Radians.Value

        var temp0 = Math.Sin(Alpha2.Radians.Value);
        var temp1 = Math.Cos(Alpha2.Radians.Value);
        var temp2 = Math.Cos(Beta2.Radians.Value);
        var temp3 = Math.Sin(Beta2.Radians.Value);
        var temp4 = temp1 * temp2 + temp0 * temp3;
        temp2 = temp0 * temp2;
        temp2 = temp1 * temp3 - temp2;
        temp3 = temp0 * temp4 + temp1 * temp2;
        var temp5 = Math.Cos(Alpha1.Radians.Value);
        var temp6 = Math.Sin(Beta1.Radians.Value);
        var temp7 = Math.Sin(Alpha1.Radians.Value);
        var temp8 = Math.Cos(Beta1.Radians.Value);
        var temp9 = temp7 * temp8;
        temp9 = temp5 * temp6 - temp9;
        temp8 = temp5 * temp8;
        temp6 *= temp7;
        var temp10 = temp8 + temp6;
        var temp11 = temp5 * temp9 + temp7 * temp10;
        var temp12 = temp7 * temp9;
        temp12 = temp5 * temp10 - temp12;
        temp11 = temp1 * temp11 + temp0 * temp12;
        temp11 = temp3 * temp11;
        temp12 = temp0 * temp2;
        temp12 = temp1 * temp4 - temp12;
        temp3 = temp3 * temp5 + temp7 * temp12;
        temp3 = temp0 * temp3;
        temp3 = temp11 * 1 / temp3;
        temp11 = 1 + temp8 + temp6;
        temp11 = 1 / Math.Sqrt(2) * Math.Sqrt(temp11) * Math.Sign(temp10);
        temp6 = -(temp8 + temp6);
        temp8 = 1 / Math.Sqrt(2) * Math.Sqrt(1 + temp6) * Math.Sign(temp9);
        temp8 = 1 / temp11 * temp8;
        temp3 = 1 / (temp8 + temp3 * temp8) + -temp3 * 1 / (temp8 + temp3 * temp8);
        temp3 = 2 * Math.Atan(temp3);
        temp8 = Math.Cos(temp3);
        temp11 = temp9 * temp8;
        temp3 = Math.Sin(temp3);
        temp12 = temp6 * temp3;
        var temp13 = temp11 - temp12;
        temp6 *= temp8;
        temp8 = -temp6;
        temp3 = temp9 * temp3;
        var temp14 = -temp3;
        var temp15 = temp8 + temp14;
        temp13 = 1 / Math.Sqrt(2) * Math.Sqrt(1 + temp15) * Math.Sign(temp13);
        temp13 = 1 / temp9 * temp13;
        temp15 = B.X.Value - A.X.Value;
        var temp16 = temp6 + temp14;
        temp6 = 1 + temp6 + temp14;
        temp6 = 1 / Math.Sqrt(2) * Math.Sqrt(temp6) * Math.Sign(temp16);
        temp14 = B.Y.Value - A.Y.Value;
        temp11 += temp12;
        temp3 = 1 + temp8 + temp3;
        temp3 = 1 / Math.Sqrt(2) * Math.Sqrt(temp3) * Math.Sign(temp11);
        temp8 = temp15 * temp6 + temp14 * temp3;
        p1X = A.X.Value + temp13 * temp8;

        temp8 = temp15 * temp3;
        temp8 = temp6 * temp14 - temp8;
        p1Y = A.Y.Value + temp13 * temp8;

        temp8 = temp9 * temp6 + temp10 * temp3;
        temp11 = temp9 * temp3;
        temp11 = temp10 * temp6 - temp11;
        temp12 = temp5 * temp8 + temp7 * temp11;
        temp8 = temp7 * temp8;
        temp8 = temp5 * temp11 - temp8;
        temp11 = temp1 * temp12 + temp0 * temp8;
        temp4 *= temp11;
        temp11 = temp0 * temp12;
        temp8 = temp1 * temp8 - temp11;
        temp8 = temp2 * temp8;
        temp4 = -(temp4 + temp8);
        temp2 = 1 / temp2 * temp4;
        temp4 = -temp6;
        temp3 = -temp3;
        temp6 = temp9 * temp3;
        temp6 = temp10 * temp4 - temp6;
        temp3 = temp9 * temp4 + temp10 * temp3;
        temp4 = temp7 * temp3;
        temp4 = temp5 * temp6 - temp4;
        temp3 = temp7 * temp6 + temp5 * temp3;
        temp5 = temp0 * temp3;
        temp5 = temp1 * temp4 - temp5;
        temp0 = temp0 * temp4 + temp1 * temp3;
        temp1 = temp15 * temp5 + temp14 * temp0;
        p2X = A.X.Value + temp2 * temp1;

        temp0 = temp15 * temp0;
        temp0 = temp14 * temp5 - temp0;
        p2Y = A.Y.Value + temp2 * temp0;

        //Finish GA-FuL MetaContext Code Generation, 2024-03-14T20:32:50.1526077+02:00
    }

    public void SolveUsingComplex(out double p1X, out double p1Y, out double p2X, out double p2Y)
    {
        //Begin GA-FuL MetaContext Code Generation, 2024-03-14T20:19:16.3148035+02:00
        //MetaContext: Complex
        //Input Variables: 8 used, 0 not used, 8 total.
        //Temp Variables: 72 sub-expressions, 0 generated temps, 72 total.
        //Target Temp Variables: 14 total.
        //Output Variables: 4 total.
        //Computations: 1.4210526315789473 average, 108 total.
        //Memory Reads: 2.1184210526315788 average, 161 total.
        //Memory Writes: 76 total.
        //
        //MetaContext Binding Data:
        //   1 = constant: '1'
        //   -1 = constant: '-1'
        //   2 = constant: '2'
        //   -2 = constant: '-2'
        //   Ax = parameter: A.X.Value
        //   Ay = parameter: A.Y.Value
        //   Bx = parameter: B.X.Value
        //   By = parameter: B.Y.Value
        //   alpha1 = parameter: Alpha1.Radians.Value
        //   alpha2 = parameter: Alpha2.Radians.Value
        //   beta1 = parameter: Beta1.Radians.Value
        //   beta2 = parameter: Beta2.Radians.Value

        var temp0 = Math.Sin(Beta1.Radians.Value);
        var temp1 = -Math.Sin(Alpha2.Radians.Value);
        var temp2 = 2 * temp1 * temp1;
        var temp3 = -2 * temp0 * temp0 + temp2;
        temp0 *= Math.Cos(Beta1.Radians.Value);
        temp1 *= Math.Cos(Alpha2.Radians.Value);
        temp1 = 2 * temp1;
        temp0 = -2 * temp0 + temp1;
        var temp4 = temp3 * temp3 + temp0 * temp0;
        temp4 = 1 / temp4;
        var temp5 = temp2 * temp3 + temp1 * temp0;
        temp5 = temp4 * temp5;
        var temp6 = Math.Sin(Alpha1.Radians.Value);
        var temp7 = -Math.Sin(Beta2.Radians.Value);
        var temp8 = 2 * temp7 * temp7;
        var temp9 = -2 * temp6 * temp6 + temp8;
        temp6 *= Math.Cos(Alpha1.Radians.Value);
        temp7 *= Math.Cos(Beta2.Radians.Value);
        temp7 = 2 * temp7;
        temp6 = -2 * temp6 + temp7;
        var temp10 = temp9 * temp9 + temp6 * temp6;
        temp10 = 1 / temp10;
        var temp11 = temp8 * temp9 + temp7 * temp6;
        temp11 = temp10 * temp11;
        var temp12 = 1 - temp11;
        var temp13 = temp5 * temp12;
        temp0 = temp2 * temp0;
        temp0 = temp3 * temp1 - temp0;
        temp0 = temp4 * temp0;
        temp1 = temp8 * temp6;
        temp1 = temp9 * temp7 - temp1;
        temp1 = temp10 * temp1;
        temp2 = -temp1;
        temp3 = temp0 * temp2 - temp13;
        temp4 = 1 - temp5;
        temp3 += temp11 * temp4;
        temp6 = -temp0;
        temp7 = temp1 * temp6;
        temp3 -= temp7;
        temp7 = temp1 * temp4 + temp11 * temp6;
        temp8 = temp5 * temp2;
        temp9 = temp12 * temp0;
        temp8 = -(temp8 + temp9);
        temp7 += temp8;
        temp8 = temp3 * temp3 + temp7 * temp7;
        temp8 = 1 / temp8;
        temp9 = A.Y.Value * temp1;
        temp9 = A.X.Value * temp11 - temp9;
        temp10 = B.X.Value * temp5;
        temp9 -= temp10;
        temp9 = B.Y.Value * temp0 + temp9;
        temp1 = A.Y.Value * temp11 + A.X.Value * temp1;
        temp5 = B.Y.Value * temp5;
        temp0 = B.X.Value * temp0;
        temp0 = -(temp5 + temp0);
        temp0 = temp1 + temp0;
        temp1 = temp3 * temp9 + temp7 * temp0;
        p1X = temp8 * temp1;

        temp1 = temp7 * temp9;
        temp0 = temp3 * temp0 - temp1;
        p1Y = temp8 * temp0;

        temp0 = B.Y.Value * temp6;
        temp0 = B.X.Value * temp4 - temp0;
        temp1 = A.X.Value * temp12;
        temp0 -= temp1;
        temp0 = A.Y.Value * temp2 + temp0;
        temp1 = B.Y.Value * temp4 + B.X.Value * temp6;
        temp2 = A.X.Value * temp2;
        temp4 = A.Y.Value * temp12;
        temp2 = -(temp2 + temp4);
        temp1 += temp2;
        temp2 = temp3 * temp0 + temp7 * temp1;
        p2X = temp8 * temp2;

        temp0 = temp7 * temp0;
        temp0 = temp3 * temp1 - temp0;
        p2Y = temp8 * temp0;

        //Finish GA-FuL MetaContext Code Generation, 2024-03-14T20:19:16.4242018+02:00
    }

    public void SolveUsingVGa(out double p1X, out double p1Y, out double p2X, out double p2Y)
    {
        //Begin GA-FuL MetaContext Code Generation, 2024-03-14T17:42:52.2553612+02:00
        //MetaContext: VGA
        //Input Variables: 8 used, 0 not used, 8 total.
        //Temp Variables: 44 sub-expressions, 0 generated temps, 44 total.
        //Target Temp Variables: 14 total.
        //Output Variables: 4 total.
        //Computations: 1.3541666666666667 average, 65 total.
        //Memory Reads: 2.2291666666666665 average, 107 total.
        //Memory Writes: 48 total.
        //
        //MetaContext Binding Data:
        //   -1 = constant: '-1'
        //   2 = constant: '2'
        //   Rational[-1, 2] = constant: 'Rational[-1, 2]'
        //   1 = constant: '1'
        //   Ax = parameter: A.X.Value
        //   Ay = parameter: A.Y.Value
        //   Bx = parameter: B.X.Value
        //   By = parameter: B.Y.Value
        //   alpha1 = parameter: Alpha1.Radians.Value
        //   alpha2 = parameter: Alpha2.Radians.Value
        //   beta1 = parameter: Beta1.Radians.Value
        //   beta2 = parameter: Beta2.Radians.Value

        var temp0 = Math.Sin(Alpha2.Radians.Value);
        var temp1 = Math.Cos(Beta1.Radians.Value);
        var temp2 = temp0 * temp1;
        var temp3 = Math.Cos(Alpha2.Radians.Value);
        var temp4 = Math.Sin(Beta1.Radians.Value);
        var temp5 = temp3 * temp4;
        var temp6 = temp2 + temp5;
        temp6 = 1 / temp6;
        var temp7 = temp0 * temp6;
        temp6 = temp4 * temp6;
        var temp8 = Math.Sin(Alpha1.Radians.Value);
        var temp9 = Math.Cos(Beta2.Radians.Value);
        var temp10 = Math.Sin(Beta2.Radians.Value);
        var temp11 = temp10 * Math.Cos(Alpha1.Radians.Value);
        temp11 = temp8 * temp9 + temp11;
        temp8 = temp8 * 1 / temp11;
        temp11 = temp6 * temp6 + temp8 * temp8;
        var temp12 = 2 * temp6 * temp8;
        var temp13 = temp3 * temp9 + temp0 * temp10;
        temp12 *= temp13;
        temp11 -= temp12;
        temp11 = 1 / Math.Sqrt(temp11);
        temp7 *= temp11;
        temp12 = B.X.Value - A.X.Value;
        temp10 = temp3 * temp10;
        temp9 = temp0 * temp9 - temp10;
        temp10 = temp8 * temp11;
        temp9 *= temp10;
        temp1 *= temp3;
        temp0 = temp0 * temp4 - temp1;
        temp1 = temp8 * temp13;
        temp1 = temp6 - temp1;
        temp1 = temp11 * temp1;
        temp2 = -(temp2 + temp5);
        temp3 = temp9 * temp0 + temp1 * temp2;
        temp2 = temp9 * temp2;
        temp0 = temp0 * temp1 - temp2;
        temp2 = B.Y.Value - A.Y.Value;
        temp4 = temp12 * temp3 + temp0 * temp2;
        p1Y = A.Y.Value + temp7 * temp4;

        temp4 = A.Y.Value - B.Y.Value;
        temp0 = temp12 * temp0 + temp3 * temp4;
        p1X = A.X.Value + temp7 * temp0;

        temp0 = temp6 * temp11;
        temp2 = temp12 * temp9 + temp1 * temp2;
        p2Y = A.Y.Value + temp0 * temp2;

        temp1 = temp12 * temp1 + temp9 * temp4;
        p2X = A.X.Value + temp0 * temp1;

        //Finish GA-FuL MetaContext Code Generation, 2024-03-14T17:42:52.3555208+02:00
    }

    public void SolveUsingCGa(out double p1X, out double p1Y, out double p2X, out double p2Y)
    {
        var alpha1Sin = Math.Sin(Alpha1.Radians.Value);
        var alpha2Sin = Math.Sin(Alpha2.Radians.Value);
        var beta1Sin = Math.Sin(Beta1.Radians.Value);
        var beta2Sin = Math.Sin(Beta2.Radians.Value);

        var alpha1Cos = Math.Sqrt(1 - alpha1Sin * alpha1Sin);
        var alpha2Cos = Math.Sqrt(1 - alpha2Sin * alpha2Sin);
        var beta1Cos = Math.Sqrt(1 - beta1Sin * beta1Sin);
        var beta2Cos = Math.Sqrt(1 - beta2Sin * beta2Sin);

        if (((int)Math.Floor(2 * Alpha1.Radians.Value / Math.PI) % 4 + 4) % 4 is 1 or 2) alpha1Cos = -alpha1Cos;
        if (((int)Math.Floor(2 * Alpha2.Radians.Value / Math.PI) % 4 + 4) % 4 is 1 or 2) alpha2Cos = -alpha2Cos;
        if (((int)Math.Floor(2 * Beta1.Radians.Value / Math.PI) % 4 + 4) % 4 is 1 or 2) beta1Cos = -beta1Cos;
        if (((int)Math.Floor(2 * Beta2.Radians.Value / Math.PI) % 4 + 4) % 4 is 1 or 2) beta2Cos = -beta2Cos;
        
        var halfAlpha1Cos = 1 / Math.Sqrt(2) * Math.Sqrt(1 + alpha1Cos);
        var halfAlpha1Sin = 1 / Math.Sqrt(2) * Math.Sqrt(1 - alpha1Cos);
        if (alpha1Sin > 0) halfAlpha1Cos = -halfAlpha1Cos;

        var halfBeta1Cos = 1 / Math.Sqrt(2) * Math.Sqrt(1 + beta1Cos);
        var halfBeta1Sin = 1 / Math.Sqrt(2) * Math.Sqrt(1 - beta1Cos);
        if (beta1Sin > 0) halfBeta1Cos = -halfBeta1Cos;

        var halfAlpha2Cos = 1 / Math.Sqrt(2) * Math.Sqrt(1 + alpha2Cos);
        var halfAlpha2Sin = 1 / Math.Sqrt(2) * Math.Sqrt(1 - alpha2Cos);
        if (alpha2Sin < 0) halfAlpha2Cos = -halfAlpha2Cos;

        var halfBeta2Cos = 1 / Math.Sqrt(2) * Math.Sqrt(1 + beta2Cos);
        var halfBeta2Sin = 1 / Math.Sqrt(2) * Math.Sqrt(1 - beta2Cos);
        if (beta2Sin < 0) halfBeta2Cos = -halfBeta2Cos;

        //Begin GA-FuL MetaContext Code Generation, 2024-04-19T01:05:17.3369930+02:00
        //MetaContext: CGA
        //Input Variables: 8 used, 4 not used, 12 total.
        //Temp Variables: 703 sub-expressions, 0 generated temps, 703 total.
        //Target Temp Variables: 61 total.
        //Output Variables: 12 total.
        //Computations: 1.393006993006993 average, 996 total.
        //Memory Reads: 2.2097902097902096 average, 1580 total.
        //Memory Writes: 715 total.
        //
        //MetaContext Binding Data:
        //   1 = constant: '1'
        //   -1 = constant: '-1'
        //   2 = constant: '2'
        //   0.5 = constant: '0.5'
        //   Rational[1, 2] = constant: 'Rational[1, 2]'
        //   -0.5 = constant: '-0.5'
        //   Rational[-1, 2] = constant: 'Rational[-1, 2]'
        //   Ax = parameter: data.Ax
        //   Ay = parameter: data.Ay
        //   Bx = parameter: data.Bx
        //   By = parameter: data.By
        //   alpha1Cos = parameter: alpha1Cos
        //   alpha2Cos = parameter: alpha2Cos
        //   beta1Cos = parameter: beta1Cos
        //   beta2Cos = parameter: beta2Cos
        //   alpha1Sin = parameter: alpha1Sin
        //   alpha2Sin = parameter: alpha2Sin
        //   beta1Sin = parameter: beta1Sin
        //   beta2Sin = parameter: beta2Sin

        var temp0 = -A.X.Value;
        var temp1 = -0.5 * A.X.Value;
        var temp2 = -0.5 * A.Y.Value;
        var temp3 = 0.5 * A.Y.Value;
        var temp4 = -1 + -(temp1 * temp1) + temp2 * temp3;
        var temp5 = 0.5 * A.X.Value;
        temp4 += temp5 * temp5;
        var temp6 = temp2 * temp3;
        temp4 -= temp6;
        temp6 = A.X.Value * temp0 + temp4 * temp4;
        var temp7 = temp1 * temp3;
        var temp8 = temp3 * temp5;
        temp7 = -(temp7 + temp8);
        temp8 = temp2 * temp5;
        var temp9 = temp7 + temp8;
        var temp10 = temp1 * temp2;
        temp9 += temp10;
        temp7 = -(temp7 + temp8);
        temp7 -= temp10;
        temp6 += temp9 * temp7;
        temp7 = -A.Y.Value;
        temp6 += A.Y.Value * temp7;
        temp8 = A.X.Value * A.X.Value;
        temp6 += temp8;
        temp6 = temp7 * temp7 + temp6;
        temp6 = 1 / Math.Sqrt(Math.Abs(temp6));
        temp10 = halfAlpha1Sin * temp6;
        var temp11 = A.Y.Value * temp10;
        var temp12 = -temp11;
        var temp13 = temp0 * temp10;
        var temp14 = -temp13;
        var temp15 = temp4 * temp10;
        var temp16 = temp13 * temp14 + temp15 * temp15;
        var temp17 = temp9 * temp10;
        var temp18 = -temp17;
        temp16 += temp17 * temp18;
        temp16 = temp11 * temp12 + temp16;
        var temp19 = A.X.Value * temp10;
        temp16 += temp19 * temp19;
        temp10 = temp7 * temp10;
        temp16 += temp10 * temp10;
        temp16 = halfAlpha1Cos * halfAlpha1Cos + temp16;
        temp16 = 1 / temp16;
        temp12 *= temp16;
        var temp20 = B.X.Value + temp0;
        var temp21 = B.Y.Value + temp7;
        var temp22 = temp20 * temp20 + temp21 * temp21;
        temp22 = 1 / Math.Sqrt(Math.Abs(temp22));
        temp20 *= temp22;
        temp21 *= temp22;
        temp21 = -temp21;
        temp22 = temp3 * temp21;
        temp22 = temp5 * temp20 - temp22;
        var temp23 = temp20 + temp1 * temp22;
        var temp24 = temp2 * temp21;
        temp24 = temp1 * temp20 - temp24;
        var temp25 = temp5 * temp24;
        temp23 -= temp25;
        temp25 = temp5 * temp21;
        var temp26 = temp3 * temp20;
        var temp27 = temp25 + temp26;
        var temp28 = temp2 * temp27;
        temp23 -= temp28;
        temp28 = temp1 * temp21;
        temp20 = temp2 * temp20;
        var temp29 = temp28 + temp20;
        temp23 += temp3 * temp29;
        temp26 = temp29 - temp26;
        temp25 = temp26 - temp25;
        temp26 = temp13 * temp23 + temp17 * temp25;
        temp5 = temp21 + temp5 * temp29;
        temp2 *= temp22;
        temp2 = temp5 - temp2;
        temp2 = temp3 * temp24 + temp2;
        temp1 *= temp27;
        temp1 = temp2 - temp1;
        temp2 = temp26 + temp11 * temp1;
        temp3 = temp27 - temp20;
        temp3 -= temp28;
        temp2 += halfAlpha1Cos * temp3;
        temp5 = temp12 * temp2;
        temp20 = -temp15 * temp16;
        temp21 = temp15 * temp1;
        temp21 = temp13 * temp3 - temp21;
        temp22 = temp19 * temp25;
        temp21 -= temp22;
        temp21 = halfAlpha1Cos * temp23 + temp21;
        temp22 = temp20 * temp21;
        temp5 = -(temp5 + temp22);
        temp22 = halfAlpha1Cos * temp16;
        temp24 = temp15 * temp23 + temp11 * temp3;
        temp26 = temp10 * temp25;
        temp24 -= temp26;
        temp24 = halfAlpha1Cos * temp1 + temp24;
        temp5 += temp22 * temp24;
        temp26 = -temp10 * temp16;
        temp27 = temp19 * temp23 + temp17 * temp3;
        temp27 = temp10 * temp1 + temp27;
        temp27 = halfAlpha1Cos * temp25 + temp27;
        temp5 += temp26 * temp27;
        temp14 *= temp16;
        temp28 = temp13 * temp1;
        temp28 = temp15 * temp3 - temp28;
        temp28 = temp11 * temp23 + temp28;
        temp29 = temp14 * temp28;
        temp5 -= temp29;
        temp29 = -temp19 * temp16;
        var temp30 = temp19 * temp1;
        temp15 = temp15 * temp25 - temp30;
        temp15 = temp10 * temp23 + temp15;
        temp5 += temp29 * temp15;
        temp16 = temp18 * temp16;
        temp11 *= temp25;
        temp11 = temp17 * temp1 - temp11;
        temp10 = temp10 * temp3 + temp11;
        temp5 += temp16 * temp10;
        temp11 = -B.X.Value;
        temp18 = -0.5 * B.X.Value;
        temp30 = -0.5 * B.Y.Value;
        var temp31 = 0.5 * B.Y.Value;
        var temp32 = -1 + -(temp18 * temp18) + temp30 * temp31;
        var temp33 = 0.5 * B.X.Value;
        temp32 += temp33 * temp33;
        var temp34 = temp30 * temp31;
        temp32 -= temp34;
        temp34 = B.X.Value * temp11 + temp32 * temp32;
        var temp35 = temp18 * temp31;
        temp31 *= temp33;
        temp31 = -(temp35 + temp31);
        temp33 = temp30 * temp33;
        temp35 = temp31 + temp33;
        temp18 *= temp30;
        temp30 = temp35 + temp18;
        temp31 = -(temp31 + temp33);
        temp18 = temp31 - temp18;
        temp18 = temp34 + temp30 * temp18;
        temp31 = -B.Y.Value;
        temp18 += B.Y.Value * temp31;
        temp33 = B.X.Value * B.X.Value;
        temp18 += temp33;
        temp18 = temp31 * temp31 + temp18;
        temp18 = 1 / Math.Sqrt(Math.Abs(temp18));
        temp34 = temp18 * halfBeta1Sin;
        temp35 = temp11 * temp34;
        var temp36 = -temp35;
        var temp37 = temp32 * temp34;
        var temp38 = temp35 * temp36 + temp37 * temp37;
        var temp39 = temp30 * temp34;
        var temp40 = -temp39;
        temp38 += temp39 * temp40;
        var temp41 = B.Y.Value * temp34;
        var temp42 = -temp41;
        temp38 += temp41 * temp42;
        var temp43 = B.X.Value * temp34;
        temp38 += temp43 * temp43;
        temp34 = temp31 * temp34;
        temp38 += temp34 * temp34;
        temp38 += halfBeta1Cos * halfBeta1Cos;
        temp38 = 1 / temp38;
        temp36 *= temp38;
        var temp44 = temp23 * temp35 + temp25 * temp39;
        temp44 = temp1 * temp41 + temp44;
        temp44 += temp3 * halfBeta1Cos;
        var temp45 = temp36 * temp44;
        var temp46 = temp38 * halfBeta1Cos;
        var temp47 = temp1 * temp37;
        temp47 = temp3 * temp35 - temp47;
        var temp48 = temp25 * temp43;
        temp47 -= temp48;
        temp47 += temp23 * halfBeta1Cos;
        temp45 = temp46 * temp47 - temp45;
        temp48 = -temp37 * temp38;
        var temp49 = temp23 * temp37 + temp3 * temp41;
        var temp50 = temp25 * temp34;
        temp49 -= temp50;
        temp49 += temp1 * halfBeta1Cos;
        temp45 += temp48 * temp49;
        temp50 = -temp43 * temp38;
        var temp51 = temp3 * temp39 + temp23 * temp43;
        temp51 = temp1 * temp34 + temp51;
        temp51 += temp25 * halfBeta1Cos;
        temp45 += temp50 * temp51;
        temp42 *= temp38;
        var temp52 = temp1 * temp35;
        temp52 = temp3 * temp37 - temp52;
        temp52 = temp23 * temp41 + temp52;
        temp45 += temp42 * temp52;
        temp40 *= temp38;
        temp35 = temp25 * temp35;
        temp35 = temp23 * temp39 - temp35;
        temp35 = temp3 * temp43 + temp35;
        temp45 += temp40 * temp35;
        temp38 = -temp34 * temp38;
        temp43 = temp1 * temp43;
        temp37 = temp25 * temp37 - temp43;
        temp37 = temp23 * temp34 + temp37;
        temp43 = temp38 * temp37;
        temp43 = temp45 - temp43;
        temp45 = temp5 * temp43;
        var temp53 = temp2 * temp14;
        temp53 = temp21 * temp22 - temp53;
        temp53 = temp20 * temp24 + temp53;
        temp53 = temp27 * temp29 + temp53;
        temp53 = temp12 * temp28 + temp53;
        temp13 *= temp25;
        temp13 = temp17 * temp23 - temp13;
        temp13 = temp19 * temp3 + temp13;
        temp17 = temp53 + temp16 * temp13;
        temp19 = temp26 * temp15;
        temp17 -= temp19;
        temp19 = temp44 * temp42;
        temp53 = temp47 * temp48;
        temp19 = -(temp19 + temp53);
        temp19 = temp46 * temp49 + temp19;
        temp19 = temp51 * temp38 + temp19;
        temp53 = temp36 * temp52;
        temp19 -= temp53;
        temp19 = temp50 * temp37 + temp19;
        temp41 = temp25 * temp41;
        temp39 = temp1 * temp39 - temp41;
        temp34 = temp3 * temp34 + temp39;
        temp19 += temp40 * temp34;
        temp39 = temp17 * temp19;
        temp41 = temp39 - temp45;
        temp53 = 0.5 * temp41;
        var temp54 = temp44 * temp40;
        var temp55 = temp47 * temp50;
        temp54 = -(temp54 + temp55);
        temp55 = temp49 * temp38;
        temp54 -= temp55;
        temp54 = temp46 * temp51 + temp54;
        temp55 = temp36 * temp35;
        temp54 -= temp55;
        temp37 = temp48 * temp37;
        temp37 = temp54 - temp37;
        temp54 = temp42 * temp34;
        temp37 -= temp54;
        temp54 = temp5 * temp37;
        temp55 = temp2 * temp16;
        var temp56 = temp21 * temp29;
        temp55 = -(temp55 + temp56);
        temp56 = temp24 * temp26;
        temp55 -= temp56;
        temp55 = temp22 * temp27 + temp55;
        temp56 = temp14 * temp13;
        temp55 -= temp56;
        temp15 = temp20 * temp15;
        temp15 = temp55 - temp15;
        temp55 = temp12 * temp10;
        temp15 -= temp55;
        temp55 = temp19 * temp15;
        temp56 = temp54 - temp55;
        var temp57 = temp43 * temp15;
        var temp58 = temp17 * temp37;
        var temp59 = temp58 - temp57;
        var temp60 = temp57 - temp58;
        temp39 = temp45 - temp39;
        temp39 = temp59 * temp60 + temp41 * temp39;
        temp14 = temp21 * temp14;
        temp2 = temp2 * temp22 - temp14;
        temp12 *= temp24;
        temp2 -= temp12;
        temp12 = temp27 * temp16;
        temp2 -= temp12;
        temp12 = temp20 * temp28;
        temp2 -= temp12;
        temp12 = temp29 * temp13;
        temp2 -= temp12;
        temp10 = temp26 * temp10;
        temp2 -= temp10;
        temp10 = temp43 * temp2;
        temp12 = temp36 * temp47;
        temp12 = temp44 * temp46 - temp12;
        temp13 = temp49 * temp42;
        temp12 -= temp13;
        temp13 = temp51 * temp40;
        temp12 -= temp13;
        temp13 = temp48 * temp52;
        temp12 -= temp13;
        temp13 = temp50 * temp35;
        temp12 -= temp13;
        temp13 = temp38 * temp34;
        temp12 -= temp13;
        temp13 = temp17 * temp12;
        temp14 = temp13 - temp10;
        temp16 = temp39 + temp14 * temp14;
        temp17 = temp55 - temp54;
        temp16 += temp56 * temp17;
        temp17 = temp37 * temp2;
        temp15 = temp15 * temp12 - temp17;
        temp16 += temp15 * temp15;
        temp2 = temp19 * temp2;
        temp5 *= temp12;
        temp12 = temp5 - temp2;
        temp16 += temp12 * temp12;
        temp16 = 1 / temp16;
        temp17 = temp56 * temp16;
        temp17 = temp53 * temp17;
        temp19 = -0.5 * temp57 + 0.5 * temp58;
        temp10 = 0.5 * temp10 + temp19;
        temp10 = -0.5 * temp13 + temp10;
        temp13 = temp15 * temp16;
        temp10 = temp10 * temp13 - temp17;
        temp12 *= temp16;
        temp10 += temp53 * temp12;
        temp8 = A.Y.Value * A.Y.Value + temp8;
        temp12 = 0.5 + 0.5 * temp8;
        temp15 = B.Y.Value * B.Y.Value + temp33;
        temp17 = 0.5 + 0.5 * temp15;
        temp19 = A.X.Value * temp17;
        temp19 = B.X.Value * temp12 - temp19;
        temp20 = temp59 * temp16;
        temp14 *= temp16;
        temp14 = temp53 * temp14;
        temp14 = temp53 * temp20 - temp14;
        temp16 = 0.5 * temp54 + -0.5 * temp55;
        temp2 = 0.5 * temp2 + temp16;
        temp2 = -0.5 * temp5 + temp2;
        temp2 = temp14 + temp13 * temp2;
        temp5 = A.Y.Value * temp17;
        temp5 = B.Y.Value * temp12 - temp5;
        temp13 = temp2 * temp5;
        temp13 = temp10 * temp19 - temp13;
        temp14 = temp10 * temp10 + temp2 * temp2;
        temp16 = 0.5 + 0.5 * temp14;
        temp20 = A.Y.Value * B.X.Value;
        temp20 = A.X.Value * B.Y.Value - temp20;
        temp13 += temp16 * temp20;
        temp6 *= halfBeta2Sin;
        temp7 *= temp6;
        temp0 *= temp6;
        temp21 = -temp0;
        temp4 *= temp6;
        temp22 = temp0 * temp21 + temp4 * temp4;
        temp9 *= temp6;
        temp24 = -temp9;
        temp22 += temp9 * temp24;
        temp26 = A.Y.Value * temp6;
        temp27 = -temp26;
        temp22 += temp26 * temp27;
        temp6 = A.X.Value * temp6;
        temp22 += temp6 * temp6;
        temp22 = temp7 * temp7 + temp22;
        temp22 += halfBeta2Cos * halfBeta2Cos;
        temp22 = 1 / temp22;
        temp28 = -temp7 * temp22;
        temp29 = temp3 * temp9 + temp23 * temp6;
        temp29 = temp1 * temp7 + temp29;
        temp29 += temp25 * halfBeta2Cos;
        temp27 *= temp22;
        temp33 = temp23 * temp0 + temp25 * temp9;
        temp33 = temp1 * temp26 + temp33;
        temp33 += temp3 * halfBeta2Cos;
        temp34 = temp27 * temp33;
        temp35 = -temp4 * temp22;
        temp36 = temp1 * temp4;
        temp36 = temp3 * temp0 - temp36;
        temp37 = temp25 * temp6;
        temp36 -= temp37;
        temp36 += temp23 * halfBeta2Cos;
        temp37 = temp35 * temp36;
        temp34 = -(temp34 + temp37);
        temp34 = temp28 * temp29 + temp34;
        temp37 = temp22 * halfBeta2Cos;
        temp38 = temp23 * temp4 + temp3 * temp26;
        temp39 = temp25 * temp7;
        temp38 -= temp39;
        temp38 += temp1 * halfBeta2Cos;
        temp34 += temp37 * temp38;
        temp21 *= temp22;
        temp39 = temp1 * temp0;
        temp39 = temp3 * temp4 - temp39;
        temp39 = temp23 * temp26 + temp39;
        temp40 = temp21 * temp39;
        temp34 -= temp40;
        temp40 = -temp6 * temp22;
        temp41 = temp1 * temp6;
        temp4 = temp25 * temp4 - temp41;
        temp4 = temp23 * temp7 + temp4;
        temp34 += temp40 * temp4;
        temp22 = temp24 * temp22;
        temp24 = temp25 * temp26;
        temp24 = temp1 * temp9 - temp24;
        temp7 = temp3 * temp7 + temp24;
        temp24 = temp34 + temp22 * temp7;
        temp18 *= halfAlpha2Sin;
        temp11 *= temp18;
        temp26 = temp30 * temp18;
        temp30 = temp23 * temp11 + temp25 * temp26;
        temp34 = B.Y.Value * temp18;
        temp30 += temp1 * temp34;
        temp30 += temp3 * halfAlpha2Cos;
        temp41 = -temp11;
        temp32 *= temp18;
        temp42 = temp11 * temp41 + temp32 * temp32;
        temp43 = -temp26;
        temp42 += temp26 * temp43;
        temp44 = -temp34;
        temp42 += temp34 * temp44;
        temp45 = B.X.Value * temp18;
        temp42 += temp45 * temp45;
        temp18 = temp31 * temp18;
        temp31 = temp42 + temp18 * temp18;
        temp31 += halfAlpha2Cos * halfAlpha2Cos;
        temp31 = 1 / temp31;
        temp41 *= temp31;
        temp42 = temp30 * temp41;
        temp46 = temp1 * temp32;
        temp46 = temp3 * temp11 - temp46;
        temp47 = temp25 * temp45;
        temp46 -= temp47;
        temp46 += temp23 * halfAlpha2Cos;
        temp47 = temp31 * halfAlpha2Cos;
        temp42 = temp46 * temp47 - temp42;
        temp48 = temp3 * temp34 + temp23 * temp32;
        temp49 = temp25 * temp18;
        temp48 -= temp49;
        temp48 += temp1 * halfAlpha2Cos;
        temp49 = -temp32 * temp31;
        temp42 += temp48 * temp49;
        temp50 = temp3 * temp26 + temp23 * temp45;
        temp50 = temp1 * temp18 + temp50;
        temp50 += temp25 * halfAlpha2Cos;
        temp51 = -temp45 * temp31;
        temp42 += temp50 * temp51;
        temp52 = temp1 * temp11;
        temp52 = temp3 * temp32 - temp52;
        temp52 = temp23 * temp34 + temp52;
        temp44 *= temp31;
        temp42 += temp52 * temp44;
        temp11 = temp25 * temp11;
        temp11 = temp23 * temp26 - temp11;
        temp11 = temp3 * temp45 + temp11;
        temp43 *= temp31;
        temp42 += temp11 * temp43;
        temp45 = temp1 * temp45;
        temp32 = temp25 * temp32 - temp45;
        temp32 = temp23 * temp18 + temp32;
        temp31 = -temp18 * temp31;
        temp45 = temp32 * temp31;
        temp42 -= temp45;
        temp45 = temp24 * temp42;
        temp53 = temp33 * temp21;
        temp53 = temp29 * temp40 - temp53;
        temp53 = temp36 * temp37 + temp53;
        temp53 = temp35 * temp38 + temp53;
        temp53 = temp27 * temp39 + temp53;
        temp0 = temp25 * temp0;
        temp0 = temp23 * temp9 - temp0;
        temp0 = temp3 * temp6 + temp0;
        temp6 = temp53 + temp22 * temp0;
        temp9 = temp28 * temp4;
        temp6 -= temp9;
        temp9 = temp30 * temp44;
        temp23 = temp46 * temp49;
        temp9 = -(temp9 + temp23);
        temp9 = temp47 * temp48 + temp9;
        temp9 = temp50 * temp31 + temp9;
        temp23 = temp41 * temp52;
        temp9 -= temp23;
        temp9 = temp51 * temp32 + temp9;
        temp23 = temp25 * temp34;
        temp1 = temp1 * temp26 - temp23;
        temp1 = temp3 * temp18 + temp1;
        temp3 = temp9 + temp43 * temp1;
        temp9 = temp6 * temp3;
        temp18 = temp9 - temp45;
        temp23 = 0.5 * temp18;
        temp25 = temp33 * temp22;
        temp26 = temp36 * temp40;
        temp25 = -(temp25 + temp26);
        temp25 = temp29 * temp37 + temp25;
        temp26 = temp28 * temp38;
        temp25 -= temp26;
        temp26 = temp21 * temp0;
        temp25 -= temp26;
        temp4 = temp35 * temp4;
        temp4 = temp25 - temp4;
        temp25 = temp27 * temp7;
        temp4 -= temp25;
        temp25 = temp42 * temp4;
        temp26 = temp30 * temp43;
        temp34 = temp46 * temp51;
        temp26 = -(temp26 + temp34);
        temp34 = temp48 * temp31;
        temp26 -= temp34;
        temp26 = temp47 * temp50 + temp26;
        temp34 = temp41 * temp11;
        temp26 -= temp34;
        temp32 = temp49 * temp32;
        temp26 -= temp32;
        temp32 = temp44 * temp1;
        temp26 -= temp32;
        temp32 = temp6 * temp26;
        temp34 = temp32 - temp25;
        temp53 = temp25 - temp32;
        temp9 = temp45 - temp9;
        temp9 = temp34 * temp53 + temp18 * temp9;
        temp18 = temp36 * temp21;
        temp18 = temp33 * temp37 - temp18;
        temp21 = temp27 * temp38;
        temp18 -= temp21;
        temp21 = temp29 * temp22;
        temp18 -= temp21;
        temp21 = temp35 * temp39;
        temp18 -= temp21;
        temp0 = temp40 * temp0;
        temp0 = temp18 - temp0;
        temp7 = temp28 * temp7;
        temp0 -= temp7;
        temp7 = temp42 * temp0;
        temp18 = temp41 * temp46;
        temp18 = temp30 * temp47 - temp18;
        temp21 = temp48 * temp44;
        temp18 -= temp21;
        temp21 = temp50 * temp43;
        temp18 -= temp21;
        temp21 = temp49 * temp52;
        temp18 -= temp21;
        temp11 = temp51 * temp11;
        temp11 = temp18 - temp11;
        temp1 = temp31 * temp1;
        temp1 = temp11 - temp1;
        temp6 *= temp1;
        temp11 = temp6 - temp7;
        temp9 += temp11 * temp11;
        temp18 = temp24 * temp26;
        temp21 = temp3 * temp4;
        temp22 = temp18 - temp21;
        temp27 = temp21 - temp18;
        temp9 += temp22 * temp27;
        temp26 *= temp0;
        temp4 = temp4 * temp1 - temp26;
        temp9 += temp4 * temp4;
        temp0 = temp3 * temp0;
        temp1 = temp24 * temp1;
        temp3 = temp1 - temp0;
        temp9 += temp3 * temp3;
        temp9 = 1 / temp9;
        temp24 = temp34 * temp9;
        temp11 *= temp9;
        temp11 = temp23 * temp11;
        temp11 = temp23 * temp24 - temp11;
        temp18 = 0.5 * temp18 + -0.5 * temp21;
        temp0 = 0.5 * temp0 + temp18;
        temp0 = -0.5 * temp1 + temp0;
        temp1 = temp4 * temp9;
        temp0 = temp11 + temp0 * temp1;
        temp4 = temp16 * temp0;
        temp11 = temp22 * temp9;
        temp11 = temp23 * temp11;
        temp18 = -0.5 * temp25 + 0.5 * temp32;
        temp7 = 0.5 * temp7 + temp18;
        temp6 = -0.5 * temp6 + temp7;
        temp1 = temp1 * temp6 - temp11;
        temp3 *= temp9;
        temp1 += temp23 * temp3;
        temp3 = temp0 * temp0 + temp1 * temp1;
        temp6 = 0.5 + 0.5 * temp3;
        temp4 = temp2 * temp6 - temp4;
        temp7 = 0.5 + -0.5 * temp14;
        temp9 = temp0 * temp7;
        temp4 -= temp9;
        temp3 = 0.5 + -0.5 * temp3;
        temp4 += temp2 * temp3;
        temp9 = temp13 * temp4;
        temp11 = 0.5 + -0.5 * temp15;
        temp8 = 0.5 + -0.5 * temp8;
        temp14 = temp17 * temp8;
        temp12 = temp12 * temp11 - temp14;
        temp14 = temp19 * temp7;
        temp14 = temp2 * temp12 - temp14;
        temp15 = A.X.Value * temp11;
        temp15 = B.X.Value * temp8 - temp15;
        temp14 += temp16 * temp15;
        temp17 = temp2 * temp1;
        temp18 = temp10 * temp0;
        temp21 = temp18 - temp17;
        temp22 = temp14 * temp21;
        temp23 = temp9 - temp22;
        temp24 = temp5 * temp7;
        temp24 = temp10 * temp12 - temp24;
        temp11 = A.Y.Value * temp11;
        temp8 = B.Y.Value * temp8 - temp11;
        temp11 = temp24 + temp16 * temp8;
        temp24 = temp4 * temp11;
        temp25 = temp10 * temp6;
        temp16 = temp16 * temp1 - temp25;
        temp16 = temp1 * temp7 + temp16;
        temp25 = temp10 * temp3;
        temp16 -= temp25;
        temp25 = temp14 * temp16;
        temp26 = -(temp24 + temp25);
        temp27 = -temp26;
        temp9 = temp22 - temp9;
        temp22 = temp2 * temp8;
        temp22 = temp10 * temp15 - temp22;
        temp7 = temp20 * temp7 + temp22;
        temp22 = temp4 * temp7;
        temp9 -= temp22;
        temp17 -= temp18;
        temp14 *= temp17;
        temp9 += temp14;
        temp18 = temp26 * temp26 + temp9 * temp9;
        temp28 = temp13 * temp16;
        temp29 = temp21 * temp11;
        temp28 = -(temp28 + temp29);
        temp29 = temp16 * temp7;
        temp11 *= temp17;
        temp11 = -(temp29 + temp11);
        temp29 = -(temp28 + temp11);
        temp18 += temp29 * temp29;
        temp18 = temp26 * temp27 + temp18;
        temp18 = 1 / temp18;
        temp27 *= temp18;
        temp27 = -temp27;
        temp14 = temp22 - temp14;
        temp22 = temp26 * temp18;
        temp22 = -temp22;
        temp26 = temp14 * temp22;
        temp26 = temp23 * temp27 - temp26;
        temp13 *= temp17;
        temp7 = temp21 * temp7 - temp13;
        temp13 = temp29 * temp18;
        temp13 = -temp13;
        temp26 += temp7 * temp13;
        temp24 += temp25;
        temp9 *= temp18;
        temp9 = -temp9;
        temp18 = temp22 * temp24 + temp23 * temp9;
        temp18 = temp28 * temp13 + temp18;
        temp18 = temp27 * temp24 + temp18;
        temp14 = temp14 * temp9 + temp18;
        temp13 = temp11 * temp13 + temp14;
        temp13 = 1 / temp13;
        temp14 = temp26 * temp13;
        p1X = 2 * temp14 - temp2;

        temp2 = temp11 * temp22;
        temp2 = temp28 * temp27 - temp2;
        temp7 *= temp9;
        temp2 -= temp7;
        temp2 = temp13 * temp2;
        p1Y = 2 * temp2 - temp10;

        temp2 = temp5 * temp0;
        temp2 = temp19 * temp1 - temp2;
        temp2 = temp20 * temp6 + temp2;
        temp7 = temp4 * temp2;
        temp9 = temp19 * temp3;
        temp9 = temp0 * temp12 - temp9;
        temp9 = temp6 * temp15 + temp9;
        temp10 = temp21 * temp9;
        temp11 = temp7 - temp10;
        temp5 *= temp3;
        temp5 = temp1 * temp12 - temp5;
        temp5 = temp6 * temp8 + temp5;
        temp6 = temp4 * temp5;
        temp12 = temp16 * temp9;
        temp13 = -(temp6 + temp12);
        temp14 = -temp13;
        temp7 = temp10 - temp7;
        temp8 = temp0 * temp8;
        temp8 = temp1 * temp15 - temp8;
        temp3 = temp20 * temp3 + temp8;
        temp4 *= temp3;
        temp7 -= temp4;
        temp8 = temp17 * temp9;
        temp7 += temp8;
        temp9 = temp13 * temp13 + temp7 * temp7;
        temp10 = temp16 * temp2;
        temp15 = temp21 * temp5;
        temp10 = -(temp10 + temp15);
        temp15 = temp16 * temp3;
        temp5 = temp17 * temp5;
        temp5 = -(temp15 + temp5);
        temp15 = -(temp10 + temp5);
        temp9 += temp15 * temp15;
        temp9 = temp13 * temp14 + temp9;
        temp9 = 1 / temp9;
        temp14 *= temp9;
        temp14 = -temp14;
        temp4 -= temp8;
        temp8 = temp13 * temp9;
        temp8 = -temp8;
        temp13 = temp4 * temp8;
        temp13 = temp11 * temp14 - temp13;
        temp2 = temp17 * temp2;
        temp2 = temp21 * temp3 - temp2;
        temp3 = temp15 * temp9;
        temp3 = -temp3;
        temp13 += temp2 * temp3;
        temp6 += temp12;
        temp7 *= temp9;
        temp7 = -temp7;
        temp9 = temp8 * temp6 + temp11 * temp7;
        temp9 = temp10 * temp3 + temp9;
        temp6 = temp14 * temp6 + temp9;
        temp4 = temp4 * temp7 + temp6;
        temp3 = temp5 * temp3 + temp4;
        temp3 = 1 / temp3;
        temp4 = temp13 * temp3;
        p2X = 2 * temp4 - temp0;

        temp0 = temp5 * temp8;
        temp0 = temp10 * temp14 - temp0;
        temp2 *= temp7;
        temp0 -= temp2;
        temp0 = temp3 * temp0;
        p2Y = 2 * temp0 - temp1;

        //Finish GA-FuL MetaContext Code Generation, 2024-04-19T01:05:17.4209873+02:00
    }

    public override string ToString()
    {
        return new StringBuilder()
            .AppendLine("2D Hansen Problem Data")
            .AppendLine($"   A     : {A.ToTupleString()}")
            .AppendLine($"   B     : {B.ToTupleString()}")
            .AppendLine($"   alpha1: {Alpha1}")
            .AppendLine($"   beta1 : {Beta1}")
            .AppendLine($"   alpha2: {Alpha2}")
            .AppendLine($"   beta2 : {Beta2}")
            .ToString();
    }
}