namespace GeometricAlgebraFulcrumLib.Applications.PowerSystems.ClarkeMap;

public static partial class ClarkeMapUtils
{
    public static double[] ClarkeRotate15D(this double[] uVector)
    {
        const int n = 15;

        var vVector = new double[n];

        //Begin GA-FuL MetaContext Code Generation, 2022-11-01T17:20:49.5518562+02:00
        //MetaContext: Clarke Transformation
        var temp0 = Math.Sqrt(0.13333333333333333);
        var temp1 = temp0 * uVector[0];
        var temp2 = 2 * Math.PI;
        temp2 = 0.06666666666666667 * temp2;
        var temp3 = Math.Cos(temp2);
        temp3 = temp0 * temp3;
        temp3 *= uVector[1];
        temp3 = temp1 + temp3;
        var temp4 = 4 * Math.PI;
        temp4 = 0.06666666666666667 * temp4;
        var temp5 = Math.Cos(temp4);
        temp5 = temp0 * temp5;
        var temp6 = temp5 * uVector[2];
        temp3 += temp6;
        temp6 = 6 * Math.PI;
        temp6 = 0.06666666666666667 * temp6;
        var temp7 = Math.Cos(temp6);
        temp7 = temp0 * temp7;
        var temp8 = temp7 * uVector[3];
        temp3 += temp8;
        temp8 = 8 * Math.PI;
        temp8 = 0.06666666666666667 * temp8;
        var temp9 = Math.Cos(temp8);
        temp9 = temp0 * temp9;
        var temp10 = temp9 * uVector[4];
        temp3 += temp10;
        temp10 = 10 * Math.PI;
        temp10 = 0.06666666666666667 * temp10;
        var temp11 = Math.Cos(temp10);
        temp11 = temp0 * temp11;
        var temp12 = temp11 * uVector[5];
        temp3 += temp12;
        temp12 = 12 * Math.PI;
        temp12 = 0.06666666666666667 * temp12;
        var temp13 = Math.Cos(temp12);
        temp13 = temp0 * temp13;
        var temp14 = temp13 * uVector[6];
        temp3 += temp14;
        temp14 = 14 * Math.PI;
        temp14 = 0.06666666666666667 * temp14;
        var temp15 = Math.Cos(temp14);
        temp15 = temp0 * temp15;
        var temp16 = temp15 * uVector[7];
        temp3 += temp16;
        temp16 = 16 * Math.PI;
        temp16 = 0.06666666666666667 * temp16;
        var temp17 = Math.Cos(temp16);
        temp17 = temp0 * temp17;
        var temp18 = temp17 * uVector[8];
        temp3 += temp18;
        temp18 = 18 * Math.PI;
        temp18 = 0.06666666666666667 * temp18;
        var temp19 = Math.Cos(temp18);
        temp19 = temp0 * temp19;
        var temp20 = temp19 * uVector[9];
        temp3 += temp20;
        temp20 = 20 * Math.PI;
        temp20 = 0.06666666666666667 * temp20;
        var temp21 = Math.Cos(temp20);
        temp21 = temp0 * temp21;
        var temp22 = temp21 * uVector[10];
        temp3 += temp22;
        temp22 = 22 * Math.PI;
        temp22 = 0.06666666666666667 * temp22;
        var temp23 = Math.Cos(temp22);
        temp23 = temp0 * temp23;
        temp23 *= uVector[11];
        temp3 += temp23;
        temp23 = 24 * Math.PI;
        temp23 = 0.06666666666666667 * temp23;
        var temp24 = Math.Cos(temp23);
        temp24 = temp0 * temp24;
        var temp25 = temp24 * uVector[12];
        temp3 += temp25;
        temp25 = 26 * Math.PI;
        temp25 = 0.06666666666666667 * temp25;
        var temp26 = Math.Cos(temp25);
        temp26 = temp0 * temp26;
        temp26 *= uVector[13];
        temp3 += temp26;
        temp26 = 28 * Math.PI;
        temp26 = 0.06666666666666667 * temp26;
        var temp27 = Math.Cos(temp26);
        temp27 = temp0 * temp27;
        var temp28 = temp27 * uVector[14];
        vVector[0] = temp3 + temp28;
            
        temp2 = Math.Sin(temp2);
        temp2 = temp0 * temp2;
        temp2 *= uVector[1];
        temp3 = Math.Sin(temp4);
        temp3 = temp0 * temp3;
        temp4 = temp3 * uVector[2];
        temp2 += temp4;
        temp4 = Math.Sin(temp6);
        temp4 = temp0 * temp4;
        temp6 = temp4 * uVector[3];
        temp2 += temp6;
        temp6 = Math.Sin(temp8);
        temp6 = temp0 * temp6;
        temp8 = temp6 * uVector[4];
        temp2 += temp8;
        temp8 = Math.Sin(temp10);
        temp8 = temp0 * temp8;
        temp10 = temp8 * uVector[5];
        temp2 += temp10;
        temp10 = Math.Sin(temp12);
        temp10 = temp0 * temp10;
        temp12 = temp10 * uVector[6];
        temp2 += temp12;
        temp12 = Math.Sin(temp14);
        temp12 = temp0 * temp12;
        temp14 = temp12 * uVector[7];
        temp2 += temp14;
        temp14 = Math.Sin(temp16);
        temp14 = temp0 * temp14;
        temp16 = temp14 * uVector[8];
        temp2 += temp16;
        temp16 = Math.Sin(temp18);
        temp16 = temp0 * temp16;
        temp18 = temp16 * uVector[9];
        temp2 += temp18;
        temp18 = Math.Sin(temp20);
        temp18 = temp0 * temp18;
        temp20 = temp18 * uVector[10];
        temp2 += temp20;
        temp20 = Math.Sin(temp22);
        temp20 = temp0 * temp20;
        temp20 *= uVector[11];
        temp2 += temp20;
        temp20 = Math.Sin(temp23);
        temp20 = temp0 * temp20;
        temp22 = temp20 * uVector[12];
        temp2 += temp22;
        temp22 = Math.Sin(temp25);
        temp22 = temp0 * temp22;
        temp22 *= uVector[13];
        temp2 += temp22;
        temp22 = Math.Sin(temp26);
        temp22 = temp0 * temp22;
        temp23 = temp22 * uVector[14];
        vVector[1] = temp2 + temp23;
            
        temp2 = temp5 * uVector[1];
        temp2 = temp1 + temp2;
        temp5 = temp9 * uVector[2];
        temp2 += temp5;
        temp5 = temp13 * uVector[3];
        temp2 += temp5;
        temp5 = temp17 * uVector[4];
        temp2 += temp5;
        temp5 = temp21 * uVector[5];
        temp2 += temp5;
        temp5 = temp24 * uVector[6];
        temp2 += temp5;
        temp5 = temp27 * uVector[7];
        temp2 += temp5;
        temp5 = 32 * Math.PI;
        temp5 = 0.06666666666666667 * temp5;
        temp23 = Math.Cos(temp5);
        temp23 = temp0 * temp23;
        temp25 = temp23 * uVector[8];
        temp2 += temp25;
        temp25 = 36 * Math.PI;
        temp25 = 0.06666666666666667 * temp25;
        temp26 = Math.Cos(temp25);
        temp26 = temp0 * temp26;
        temp28 = temp26 * uVector[9];
        temp2 += temp28;
        temp28 = 40 * Math.PI;
        temp28 = 0.06666666666666667 * temp28;
        var temp29 = Math.Cos(temp28);
        temp29 = temp0 * temp29;
        var temp30 = temp29 * uVector[10];
        temp2 += temp30;
        temp30 = 44 * Math.PI;
        temp30 = 0.06666666666666667 * temp30;
        var temp31 = Math.Cos(temp30);
        temp31 = temp0 * temp31;
        temp31 *= uVector[11];
        temp2 += temp31;
        temp31 = 48 * Math.PI;
        temp31 = 0.06666666666666667 * temp31;
        var temp32 = Math.Cos(temp31);
        temp32 = temp0 * temp32;
        var temp33 = temp32 * uVector[12];
        temp2 += temp33;
        temp33 = 52 * Math.PI;
        temp33 = 0.06666666666666667 * temp33;
        var temp34 = Math.Cos(temp33);
        temp34 = temp0 * temp34;
        temp34 *= uVector[13];
        temp2 += temp34;
        temp34 = 56 * Math.PI;
        temp34 = 0.06666666666666667 * temp34;
        var temp35 = Math.Cos(temp34);
        temp35 = temp0 * temp35;
        var temp36 = temp35 * uVector[14];
        vVector[2] = temp2 + temp36;
            
        temp2 = temp3 * uVector[1];
        temp3 = temp6 * uVector[2];
        temp2 += temp3;
        temp3 = temp10 * uVector[3];
        temp2 += temp3;
        temp3 = temp14 * uVector[4];
        temp2 += temp3;
        temp3 = temp18 * uVector[5];
        temp2 += temp3;
        temp3 = temp20 * uVector[6];
        temp2 += temp3;
        temp3 = temp22 * uVector[7];
        temp2 += temp3;
        temp3 = Math.Sin(temp5);
        temp3 = temp0 * temp3;
        temp5 = temp3 * uVector[8];
        temp2 += temp5;
        temp5 = Math.Sin(temp25);
        temp5 = temp0 * temp5;
        temp25 = temp5 * uVector[9];
        temp2 += temp25;
        temp25 = Math.Sin(temp28);
        temp25 = temp0 * temp25;
        temp28 = temp25 * uVector[10];
        temp2 += temp28;
        temp28 = Math.Sin(temp30);
        temp28 = temp0 * temp28;
        temp28 *= uVector[11];
        temp2 += temp28;
        temp28 = Math.Sin(temp31);
        temp28 = temp0 * temp28;
        temp30 = temp28 * uVector[12];
        temp2 += temp30;
        temp30 = Math.Sin(temp33);
        temp30 = temp0 * temp30;
        temp30 *= uVector[13];
        temp2 += temp30;
        temp30 = Math.Sin(temp34);
        temp30 = temp0 * temp30;
        temp31 = temp30 * uVector[14];
        vVector[3] = temp2 + temp31;
            
        temp2 = temp7 * uVector[1];
        temp2 = temp1 + temp2;
        temp7 = temp13 * uVector[2];
        temp2 += temp7;
        temp7 = temp19 * uVector[3];
        temp2 += temp7;
        temp7 = temp24 * uVector[4];
        temp2 += temp7;
        temp7 = 30 * Math.PI;
        temp7 = 0.06666666666666667 * temp7;
        temp19 = Math.Cos(temp7);
        temp19 = temp0 * temp19;
        temp31 = temp19 * uVector[5];
        temp2 += temp31;
        temp31 = temp26 * uVector[6];
        temp2 += temp31;
        temp31 = 42 * Math.PI;
        temp31 = 0.06666666666666667 * temp31;
        temp33 = Math.Cos(temp31);
        temp33 *= temp0;
        temp34 = temp33 * uVector[7];
        temp2 = temp34 + temp2;
        temp34 = temp32 * uVector[8];
        temp2 += temp34;
        temp34 = 54 * Math.PI;
        temp34 = 0.06666666666666667 * temp34;
        temp36 = Math.Cos(temp34);
        temp36 *= temp0;
        temp36 *= uVector[9];
        temp2 += temp36;
        temp36 = 60 * Math.PI;
        temp36 = 0.06666666666666667 * temp36;
        var temp37 = Math.Cos(temp36);
        temp37 *= temp0;
        var temp38 = temp37 * uVector[10];
        temp2 += temp38;
        temp38 = 66 * Math.PI;
        temp38 = 0.06666666666666667 * temp38;
        var temp39 = Math.Cos(temp38);
        temp39 *= temp0;
        temp39 *= uVector[11];
        temp2 += temp39;
        temp39 = 72 * Math.PI;
        temp39 = 0.06666666666666667 * temp39;
        var temp40 = Math.Cos(temp39);
        temp40 *= temp0;
        var temp41 = temp40 * uVector[12];
        temp2 += temp41;
        temp41 = 78 * Math.PI;
        temp41 = 0.06666666666666667 * temp41;
        var temp42 = Math.Cos(temp41);
        temp42 *= temp0;
        temp42 *= uVector[13];
        temp2 += temp42;
        temp42 = 84 * Math.PI;
        temp42 = 0.06666666666666667 * temp42;
        var temp43 = Math.Cos(temp42);
        temp43 *= temp0;
        var temp44 = temp43 * uVector[14];
        vVector[4] = temp2 + temp44;
            
        temp2 = temp4 * uVector[1];
        temp4 = temp10 * uVector[2];
        temp2 += temp4;
        temp4 = temp16 * uVector[3];
        temp2 += temp4;
        temp4 = temp20 * uVector[4];
        temp2 += temp4;
        temp4 = Math.Sin(temp7);
        temp4 *= temp0;
        temp7 = temp4 * uVector[5];
        temp2 += temp7;
        temp7 = temp5 * uVector[6];
        temp2 += temp7;
        temp7 = Math.Sin(temp31);
        temp7 *= temp0;
        temp16 = temp7 * uVector[7];
        temp2 += temp16;
        temp16 = temp28 * uVector[8];
        temp2 += temp16;
        temp16 = Math.Sin(temp34);
        temp16 *= temp0;
        temp16 *= uVector[9];
        temp2 += temp16;
        temp16 = Math.Sin(temp36);
        temp16 *= temp0;
        temp31 = temp16 * uVector[10];
        temp2 += temp31;
        temp31 = Math.Sin(temp38);
        temp31 *= temp0;
        temp31 *= uVector[11];
        temp2 += temp31;
        temp31 = Math.Sin(temp39);
        temp31 *= temp0;
        temp34 = temp31 * uVector[12];
        temp2 += temp34;
        temp34 = Math.Sin(temp41);
        temp34 *= temp0;
        temp34 *= uVector[13];
        temp2 += temp34;
        temp34 = Math.Sin(temp42);
        temp34 *= temp0;
        temp36 = temp34 * uVector[14];
        vVector[5] = temp2 + temp36;
            
        temp2 = temp9 * uVector[1];
        temp2 += temp1;
        temp9 = temp17 * uVector[2];
        temp2 += temp9;
        temp9 = temp24 * uVector[3];
        temp2 += temp9;
        temp9 = temp23 * uVector[4];
        temp2 += temp9;
        temp9 = temp29 * uVector[5];
        temp2 += temp9;
        temp9 = temp32 * uVector[6];
        temp2 += temp9;
        temp9 = temp35 * uVector[7];
        temp2 += temp9;
        temp9 = 64 * Math.PI;
        temp9 = 0.06666666666666667 * temp9;
        temp17 = Math.Cos(temp9);
        temp17 *= temp0;
        temp17 *= uVector[8];
        temp2 += temp17;
        temp17 = temp40 * uVector[9];
        temp2 += temp17;
        temp17 = 80 * Math.PI;
        temp17 = 0.06666666666666667 * temp17;
        temp23 = Math.Cos(temp17);
        temp23 *= temp0;
        temp36 = temp23 * uVector[10];
        temp2 += temp36;
        temp36 = 88 * Math.PI;
        temp36 = 0.06666666666666667 * temp36;
        temp38 = Math.Cos(temp36);
        temp38 *= temp0;
        temp38 *= uVector[11];
        temp2 += temp38;
        temp38 = 96 * Math.PI;
        temp38 = 0.06666666666666667 * temp38;
        temp39 = Math.Cos(temp38);
        temp39 *= temp0;
        temp41 = temp39 * uVector[12];
        temp2 += temp41;
        temp41 = 104 * Math.PI;
        temp41 = 0.06666666666666667 * temp41;
        temp42 = Math.Cos(temp41);
        temp42 *= temp0;
        temp42 *= uVector[13];
        temp2 += temp42;
        temp42 = 112 * Math.PI;
        temp42 = 0.06666666666666667 * temp42;
        temp44 = Math.Cos(temp42);
        temp44 *= temp0;
        var temp45 = temp44 * uVector[14];
        vVector[6] = temp2 + temp45;
            
        temp2 = temp6 * uVector[1];
        temp6 = temp14 * uVector[2];
        temp2 += temp6;
        temp6 = temp20 * uVector[3];
        temp2 += temp6;
        temp3 *= uVector[4];
        temp2 += temp3;
        temp3 = temp25 * uVector[5];
        temp2 += temp3;
        temp3 = temp28 * uVector[6];
        temp2 += temp3;
        temp3 = temp30 * uVector[7];
        temp2 += temp3;
        temp3 = Math.Sin(temp9);
        temp3 *= temp0;
        temp3 *= uVector[8];
        temp2 += temp3;
        temp3 = temp31 * uVector[9];
        temp2 += temp3;
        temp3 = Math.Sin(temp17);
        temp3 *= temp0;
        temp6 = temp3 * uVector[10];
        temp2 += temp6;
        temp6 = Math.Sin(temp36);
        temp6 *= temp0;
        temp6 *= uVector[11];
        temp2 += temp6;
        temp6 = Math.Sin(temp38);
        temp6 *= temp0;
        temp9 = temp6 * uVector[12];
        temp2 += temp9;
        temp9 = Math.Sin(temp41);
        temp9 *= temp0;
        temp9 *= uVector[13];
        temp2 += temp9;
        temp9 = Math.Sin(temp42);
        temp9 *= temp0;
        temp14 = temp9 * uVector[14];
        vVector[7] = temp2 + temp14;
            
        temp2 = temp11 * uVector[1];
        temp2 += temp1;
        temp11 = temp21 * uVector[2];
        temp2 += temp11;
        temp11 = temp19 * uVector[3];
        temp2 += temp11;
        temp11 = temp29 * uVector[4];
        temp2 += temp11;
        temp11 = 50 * Math.PI;
        temp11 = 0.06666666666666667 * temp11;
        temp14 = Math.Cos(temp11);
        temp14 *= temp0;
        temp14 *= uVector[5];
        temp2 += temp14;
        temp14 = temp37 * uVector[6];
        temp2 += temp14;
        temp14 = 70 * Math.PI;
        temp14 = 0.06666666666666667 * temp14;
        temp17 = Math.Cos(temp14);
        temp17 *= temp0;
        temp19 = temp17 * uVector[7];
        temp2 += temp19;
        temp19 = temp23 * uVector[8];
        temp2 += temp19;
        temp19 = 90 * Math.PI;
        temp19 = 0.06666666666666667 * temp19;
        temp21 = Math.Cos(temp19);
        temp21 *= temp0;
        temp21 *= uVector[9];
        temp2 += temp21;
        temp21 = 100 * Math.PI;
        temp21 = 0.06666666666666667 * temp21;
        temp23 = Math.Cos(temp21);
        temp23 *= temp0;
        temp23 *= uVector[10];
        temp2 += temp23;
        temp23 = 110 * Math.PI;
        temp23 = 0.06666666666666667 * temp23;
        temp29 = Math.Cos(temp23);
        temp29 *= temp0;
        temp29 *= uVector[11];
        temp2 += temp29;
        temp29 = 120 * Math.PI;
        temp29 = 0.06666666666666667 * temp29;
        temp36 = Math.Cos(temp29);
        temp36 *= temp0;
        temp38 = temp36 * uVector[12];
        temp2 += temp38;
        temp38 = 130 * Math.PI;
        temp38 = 0.06666666666666667 * temp38;
        temp41 = Math.Cos(temp38);
        temp41 *= temp0;
        temp41 *= uVector[13];
        temp2 += temp41;
        temp41 = 140 * Math.PI;
        temp41 = 0.06666666666666667 * temp41;
        temp42 = Math.Cos(temp41);
        temp42 *= temp0;
        temp45 = temp42 * uVector[14];
        vVector[8] = temp2 + temp45;
            
        temp2 = temp8 * uVector[1];
        temp8 = temp18 * uVector[2];
        temp2 += temp8;
        temp4 *= uVector[3];
        temp2 += temp4;
        temp4 = temp25 * uVector[4];
        temp2 += temp4;
        temp4 = Math.Sin(temp11);
        temp4 *= temp0;
        temp4 *= uVector[5];
        temp2 += temp4;
        temp4 = temp16 * uVector[6];
        temp2 += temp4;
        temp4 = Math.Sin(temp14);
        temp4 *= temp0;
        temp8 = temp4 * uVector[7];
        temp2 += temp8;
        temp3 *= uVector[8];
        temp2 += temp3;
        temp3 = Math.Sin(temp19);
        temp3 *= temp0;
        temp3 *= uVector[9];
        temp2 += temp3;
        temp3 = Math.Sin(temp21);
        temp3 *= temp0;
        temp3 *= uVector[10];
        temp2 += temp3;
        temp3 = Math.Sin(temp23);
        temp3 *= temp0;
        temp3 *= uVector[11];
        temp2 += temp3;
        temp3 = Math.Sin(temp29);
        temp3 *= temp0;
        temp8 = temp3 * uVector[12];
        temp2 += temp8;
        temp8 = Math.Sin(temp38);
        temp8 *= temp0;
        temp8 *= uVector[13];
        temp2 += temp8;
        temp8 = Math.Sin(temp41);
        temp8 *= temp0;
        temp11 = temp8 * uVector[14];
        vVector[9] = temp2 + temp11;
            
        temp2 = temp13 * uVector[1];
        temp2 += temp1;
        temp11 = temp24 * uVector[2];
        temp2 += temp11;
        temp11 = temp26 * uVector[3];
        temp2 += temp11;
        temp11 = temp32 * uVector[4];
        temp2 += temp11;
        temp11 = temp37 * uVector[5];
        temp2 += temp11;
        temp11 = temp40 * uVector[6];
        temp2 += temp11;
        temp11 = temp43 * uVector[7];
        temp2 += temp11;
        temp11 = temp39 * uVector[8];
        temp2 += temp11;
        temp11 = 108 * Math.PI;
        temp11 = 0.06666666666666667 * temp11;
        temp13 = Math.Cos(temp11);
        temp13 *= temp0;
        temp13 *= uVector[9];
        temp2 += temp13;
        temp13 = temp36 * uVector[10];
        temp2 += temp13;
        temp13 = 132 * Math.PI;
        temp13 = 0.06666666666666667 * temp13;
        temp14 = Math.Cos(temp13);
        temp14 *= temp0;
        temp14 *= uVector[11];
        temp2 += temp14;
        temp14 = 144 * Math.PI;
        temp14 = 0.06666666666666667 * temp14;
        temp18 = Math.Cos(temp14);
        temp18 *= temp0;
        temp18 *= uVector[12];
        temp2 += temp18;
        temp18 = 156 * Math.PI;
        temp18 = 0.06666666666666667 * temp18;
        temp19 = Math.Cos(temp18);
        temp19 *= temp0;
        temp19 *= uVector[13];
        temp2 += temp19;
        temp19 = 168 * Math.PI;
        temp19 = 0.06666666666666667 * temp19;
        temp21 = Math.Cos(temp19);
        temp21 *= temp0;
        temp23 = temp21 * uVector[14];
        vVector[10] = temp2 + temp23;
            
        temp2 = temp10 * uVector[1];
        temp10 = temp20 * uVector[2];
        temp2 += temp10;
        temp5 *= uVector[3];
        temp2 += temp5;
        temp5 = temp28 * uVector[4];
        temp2 += temp5;
        temp5 = temp16 * uVector[5];
        temp2 += temp5;
        temp5 = temp31 * uVector[6];
        temp2 += temp5;
        temp5 = temp34 * uVector[7];
        temp2 += temp5;
        temp5 = temp6 * uVector[8];
        temp2 += temp5;
        temp5 = Math.Sin(temp11);
        temp5 *= temp0;
        temp5 *= uVector[9];
        temp2 += temp5;
        temp3 *= uVector[10];
        temp2 += temp3;
        temp3 = Math.Sin(temp13);
        temp3 *= temp0;
        temp3 *= uVector[11];
        temp2 += temp3;
        temp3 = Math.Sin(temp14);
        temp3 *= temp0;
        temp3 *= uVector[12];
        temp2 += temp3;
        temp3 = Math.Sin(temp18);
        temp3 *= temp0;
        temp3 *= uVector[13];
        temp2 += temp3;
        temp3 = Math.Sin(temp19);
        temp3 *= temp0;
        temp5 = temp3 * uVector[14];
        vVector[11] = temp2 + temp5;
            
        temp2 = temp15 * uVector[1];
        temp1 = temp2 + temp1;
        temp2 = temp27 * uVector[2];
        temp1 += temp2;
        temp2 = temp33 * uVector[3];
        temp1 += temp2;
        temp2 = temp35 * uVector[4];
        temp1 += temp2;
        temp2 = temp17 * uVector[5];
        temp1 += temp2;
        temp2 = temp43 * uVector[6];
        temp1 += temp2;
        temp2 = 98 * Math.PI;
        temp2 = 0.06666666666666667 * temp2;
        temp5 = Math.Cos(temp2);
        temp5 *= temp0;
        temp5 *= uVector[7];
        temp1 += temp5;
        temp5 = temp44 * uVector[8];
        temp1 += temp5;
        temp5 = 126 * Math.PI;
        temp5 = 0.06666666666666667 * temp5;
        temp6 = Math.Cos(temp5);
        temp6 *= temp0;
        temp6 *= uVector[9];
        temp1 += temp6;
        temp6 = temp42 * uVector[10];
        temp1 += temp6;
        temp6 = 154 * Math.PI;
        temp6 = 0.06666666666666667 * temp6;
        temp10 = Math.Cos(temp6);
        temp10 *= temp0;
        temp10 *= uVector[11];
        temp1 += temp10;
        temp10 = temp21 * uVector[12];
        temp1 += temp10;
        temp10 = 182 * Math.PI;
        temp10 = 0.06666666666666667 * temp10;
        temp11 = Math.Cos(temp10);
        temp11 *= temp0;
        temp11 *= uVector[13];
        temp1 += temp11;
        temp11 = 196 * Math.PI;
        temp11 = 0.06666666666666667 * temp11;
        temp13 = Math.Cos(temp11);
        temp13 *= temp0;
        temp13 *= uVector[14];
        vVector[12] = temp1 + temp13;
            
        temp1 = temp12 * uVector[1];
        temp12 = temp22 * uVector[2];
        temp1 += temp12;
        temp7 *= uVector[3];
        temp1 += temp7;
        temp7 = temp30 * uVector[4];
        temp1 += temp7;
        temp4 *= uVector[5];
        temp1 += temp4;
        temp4 = temp34 * uVector[6];
        temp1 += temp4;
        temp2 = Math.Sin(temp2);
        temp2 *= temp0;
        temp2 *= uVector[7];
        temp1 += temp2;
        temp2 = temp9 * uVector[8];
        temp1 += temp2;
        temp2 = Math.Sin(temp5);
        temp2 *= temp0;
        temp2 *= uVector[9];
        temp1 += temp2;
        temp2 = temp8 * uVector[10];
        temp1 += temp2;
        temp2 = Math.Sin(temp6);
        temp2 *= temp0;
        temp2 *= uVector[11];
        temp1 += temp2;
        temp2 = temp3 * uVector[12];
        temp1 += temp2;
        temp2 = Math.Sin(temp10);
        temp2 *= temp0;
        temp2 *= uVector[13];
        temp1 += temp2;
        temp2 = Math.Sin(temp11);
        temp0 = temp2 * temp0;
        temp0 *= uVector[14];
        vVector[13] = temp1 + temp0;
            
        temp0 = Math.Sqrt(15);
        temp0 = 1 / temp0;
        temp1 = temp0 * uVector[0];
        temp2 = temp0 * uVector[1];
        temp1 += temp2;
        temp2 = temp0 * uVector[2];
        temp1 += temp2;
        temp2 = temp0 * uVector[3];
        temp1 += temp2;
        temp2 = temp0 * uVector[4];
        temp1 += temp2;
        temp2 = temp0 * uVector[5];
        temp1 += temp2;
        temp2 = temp0 * uVector[6];
        temp1 += temp2;
        temp2 = temp0 * uVector[7];
        temp1 += temp2;
        temp2 = temp0 * uVector[8];
        temp1 += temp2;
        temp2 = temp0 * uVector[9];
        temp1 += temp2;
        temp2 = temp0 * uVector[10];
        temp1 += temp2;
        temp2 = temp0 * uVector[11];
        temp1 += temp2;
        temp2 = temp0 * uVector[12];
        temp1 += temp2;
        temp2 = temp0 * uVector[13];
        temp1 += temp2;
        temp0 *= uVector[14];
        vVector[14] = temp1 + temp0;
            
        //Finish GA-FuL MetaContext Code Generation, 2022-11-01T17:20:49.5525622+02:00
            

        return vVector;
    }
}