using System.Runtime.CompilerServices;

namespace GeometricAlgebraFulcrumLib.Generations.Algebra.Ga301;

public sealed partial class Ga301KVector2
{
    public static Ga301KVector2 Zero { get; } = new Ga301KVector2();
    
    public static Ga301KVector2 E12 { get; } = new Ga301KVector2() { Scalar12 = 1d };
    
    public static Ga301KVector2 E13 { get; } = new Ga301KVector2() { Scalar13 = 1d };
    
    public static Ga301KVector2 E23 { get; } = new Ga301KVector2() { Scalar23 = 1d };
    
    public static Ga301KVector2 E14 { get; } = new Ga301KVector2() { Scalar14 = 1d };
    
    public static Ga301KVector2 E24 { get; } = new Ga301KVector2() { Scalar24 = 1d };
    
    public static Ga301KVector2 E34 { get; } = new Ga301KVector2() { Scalar34 = 1d };
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga301KVector2 Create(params double[] scalarArray)
    {
        return new Ga301KVector2
        {
            Scalar12 = scalarArray[0],
            Scalar13 = scalarArray[1],
            Scalar23 = scalarArray[2],
            Scalar14 = scalarArray[3],
            Scalar24 = scalarArray[4],
            Scalar34 = scalarArray[5]
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga301KVector2 operator +(Ga301KVector2 mv)
    {
        return mv;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga301KVector2 operator -(Ga301KVector2 mv)
    {
        return mv.Negative();
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga301KVector2 operator *(Ga301KVector2 mv1, double mv2)
    {
        return mv1.Times(mv2);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga301KVector2 operator *(double mv1, Ga301KVector2 mv2)
    {
        return mv2.Times(mv1);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga301KVector2 operator /(Ga301KVector2 mv1, double mv2)
    {
        return mv1.Times(1d / mv2);
    }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga301Multivector operator +(Ga301KVector2 mv1, Ga301KVector0 mv2)
    {
        return mv1.Add(mv2);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga301Multivector operator -(Ga301KVector2 mv1, Ga301KVector0 mv2)
    {
        return mv1.Subtract(mv2);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga301Multivector operator +(Ga301KVector2 mv1, Ga301KVector1 mv2)
    {
        return mv1.Add(mv2);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga301Multivector operator -(Ga301KVector2 mv1, Ga301KVector1 mv2)
    {
        return mv1.Subtract(mv2);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga301KVector2 operator +(Ga301KVector2 mv1, Ga301KVector2 mv2)
    {
        return mv1.Add(mv2);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga301KVector2 operator -(Ga301KVector2 mv1, Ga301KVector2 mv2)
    {
        return mv1.Subtract(mv2);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga301Multivector operator +(Ga301KVector2 mv1, Ga301KVector3 mv2)
    {
        return mv1.Add(mv2);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga301Multivector operator -(Ga301KVector2 mv1, Ga301KVector3 mv2)
    {
        return mv1.Subtract(mv2);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga301Multivector operator +(Ga301KVector2 mv1, Ga301Multivector mv2)
    {
        return mv1.Add(mv2);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga301Multivector operator -(Ga301KVector2 mv1, Ga301Multivector mv2)
    {
        return mv1.Subtract(mv2);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga301Multivector operator +(Ga301KVector2 mv1, double mv2)
    {
        return Ga301Multivector.Create(mv1, mv2);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga301Multivector operator +(double mv1, Ga301KVector2 mv2)
    {
        return Ga301Multivector.Create(mv2, mv1);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga301Multivector operator -(Ga301KVector2 mv1, double mv2)
    {
        return Ga301Multivector.Create(mv1, -mv2);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga301Multivector operator -(double mv1, Ga301KVector2 mv2)
    {
        return Ga301Multivector.Create(mv2.Negative(), mv1);
    }
    
    public double Scalar12 { get; init; }
    
    public double Scalar13 { get; init; }
    
    public double Scalar23 { get; init; }
    
    public double Scalar14 { get; init; }
    
    public double Scalar24 { get; init; }
    
    public double Scalar34 { get; init; }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga301KVector2()
    {
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsValid()
    {
        return
            !double.IsNaN(Scalar12) &&
            !double.IsNaN(Scalar13) &&
            !double.IsNaN(Scalar23) &&
            !double.IsNaN(Scalar14) &&
            !double.IsNaN(Scalar24) &&
            !double.IsNaN(Scalar34);
    }
    
    private bool? _isZero;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsZero()
    {
        _isZero ??= 
            Scalar12 == 0d &&
            Scalar13 == 0d &&
            Scalar23 == 0d &&
            Scalar14 == 0d &&
            Scalar24 == 0d &&
            Scalar34 == 0d;
    
        return _isZero.Value;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsNearZero(double epsilon = 1e-12d)
    {
        var norm = this.Norm();
    
        return norm > -epsilon && norm < epsilon;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public double[] GetMultivectorArray()
    {
        var scalarArray = new double[16];
        
        scalarArray[3] = Scalar12;
        scalarArray[5] = Scalar13;
        scalarArray[6] = Scalar23;
        scalarArray[9] = Scalar14;
        scalarArray[10] = Scalar24;
        scalarArray[12] = Scalar34;
        
        return scalarArray;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public double[] GetKVectorArray()
    {
        return new double[]
        {
            Scalar12,
            Scalar13,
            Scalar23,
            Scalar14,
            Scalar24,
            Scalar34
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga301KVector2 Times(double mv2)
    {
        return new Ga301KVector2()
        {
            Scalar12 = Scalar12 * mv2,
            Scalar13 = Scalar13 * mv2,
            Scalar23 = Scalar23 * mv2,
            Scalar14 = Scalar14 * mv2,
            Scalar24 = Scalar24 * mv2,
            Scalar34 = Scalar34 * mv2
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga301KVector2 Divide(double mv2)
    {
        return Times(1d / mv2);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga301KVector2 DivideByNorm()
    {
        return Times(1d / this.Norm());
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga301KVector2 DivideByNormSquared()
    {
        return Times(1d / this.NormSquared());
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga301KVector2 DivideBySpSquared()
    {
        return Times(1d / this.SpSquared());
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga301KVector2 Negative()
    {
        return new Ga301KVector2()
        {
            Scalar12 = -Scalar12,
            Scalar13 = -Scalar13,
            Scalar23 = -Scalar23,
            Scalar14 = -Scalar14,
            Scalar24 = -Scalar24,
            Scalar34 = -Scalar34
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga301KVector2 Reverse()
    {
        return Negative();
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga301KVector2 GradeInvolution()
    {
        return this;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga301KVector2 CliffordConjugate()
    {
        return Negative();
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga301KVector2 Inverse()
    {
        return Times(-1d / this.NormSquared());
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga301KVector2 InverseTimes(double mv2)
    {
        return Times(-mv2 / this.NormSquared());
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga301KVector2 PseudoInverse()
    {
        var conjugate = Conjugate();
    
        return conjugate.Times(
            1d / conjugate.Sp(this).Scalar
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga301KVector2 PseudoInverseTimes(double mv2)
    {
        var conjugate = Conjugate();
    
        return conjugate.Times(
            mv2 / conjugate.Sp(this).Scalar
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga301KVector2 Conjugate()
    {
        return new Ga301KVector2()
               {
                   Scalar23 = -Scalar23,
                   Scalar24 = -Scalar24,
                   Scalar34 = -Scalar34
               };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga301KVector2 UnDual()
    {
        return new Ga301KVector2()
               {
                   Scalar12 = -Scalar34,
                   Scalar13 = Scalar24,
                   Scalar14 = -Scalar23
               };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga301KVector0 Dual(Ga301KVector2 kv2)
    {
        return this.Lcp(kv2.Inverse());
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga301KVector0 UnDual(Ga301KVector2 kv2)
    {
        return this.Lcp(kv2);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga301KVector1 Dual(Ga301KVector3 kv2)
    {
        return this.Lcp(kv2.Inverse());
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga301KVector1 UnDual(Ga301KVector3 kv2)
    {
        return this.Lcp(kv2);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga301KVector2 Dual(Ga301KVector4 kv2)
    {
        return this.Lcp(kv2.Inverse());
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga301KVector2 UnDual(Ga301KVector4 kv2)
    {
        return this.Lcp(kv2);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga301Multivector Add(Ga301KVector0 mv2)
    {
        if (mv2.IsZero()) return Ga301Multivector.Create(this);
        if (IsZero()) return Ga301Multivector.Create(mv2);
        
        return Ga301Multivector.Create(
            mv2,
            Ga301KVector1.Zero,
            this,
            Ga301KVector3.Zero,
            Ga301KVector4.Zero
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga301Multivector Add(Ga301KVector1 mv2)
    {
        if (mv2.IsZero()) return Ga301Multivector.Create(this);
        if (IsZero()) return Ga301Multivector.Create(mv2);
        
        return Ga301Multivector.Create(
            Ga301KVector0.Zero,
            mv2,
            this,
            Ga301KVector3.Zero,
            Ga301KVector4.Zero
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga301KVector2 Add(Ga301KVector2 mv2)
    {
        if (mv2.IsZero()) return this;
        if (IsZero()) return mv2;
        
        return new Ga301KVector2()
        {
            Scalar12 = Scalar12 + mv2.Scalar12,
            Scalar13 = Scalar13 + mv2.Scalar13,
            Scalar23 = Scalar23 + mv2.Scalar23,
            Scalar14 = Scalar14 + mv2.Scalar14,
            Scalar24 = Scalar24 + mv2.Scalar24,
            Scalar34 = Scalar34 + mv2.Scalar34
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga301Multivector Add(Ga301KVector3 mv2)
    {
        if (mv2.IsZero()) return Ga301Multivector.Create(this);
        if (IsZero()) return Ga301Multivector.Create(mv2);
        
        return Ga301Multivector.Create(
            Ga301KVector0.Zero,
            Ga301KVector1.Zero,
            this,
            mv2,
            Ga301KVector4.Zero
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga301Multivector Add(Ga301KVector4 mv2)
    {
        if (mv2.IsZero()) return Ga301Multivector.Create(this);
        if (IsZero()) return Ga301Multivector.Create(mv2);
        
        return Ga301Multivector.Create(
            Ga301KVector0.Zero,
            Ga301KVector1.Zero,
            this,
            Ga301KVector3.Zero,
            mv2
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga301Multivector Add(Ga301Multivector mv2)
    {
        if (mv2.IsZero()) return Ga301Multivector.Create(this);
        if (IsZero()) return mv2;
        
        return Ga301Multivector.Create(
            mv2.KVector0,
            mv2.KVector1,
            Add(mv2.KVector2),
            mv2.KVector3,
            mv2.KVector4
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga301Multivector Subtract(Ga301KVector0 mv2)
    {
        if (mv2.IsZero()) return Ga301Multivector.Create(this);
        if (IsZero()) return Ga301Multivector.Create(mv2.Negative());
        
        return Ga301Multivector.Create(
            mv2.Negative(),
            Ga301KVector1.Zero,
            this,
            Ga301KVector3.Zero,
            Ga301KVector4.Zero
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga301Multivector Subtract(Ga301KVector1 mv2)
    {
        if (mv2.IsZero()) return Ga301Multivector.Create(this);
        if (IsZero()) return Ga301Multivector.Create(mv2.Negative());
        
        return Ga301Multivector.Create(
            Ga301KVector0.Zero,
            mv2.Negative(),
            this,
            Ga301KVector3.Zero,
            Ga301KVector4.Zero
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga301KVector2 Subtract(Ga301KVector2 mv2)
    {
        if (mv2.IsZero()) return this;
        if (IsZero()) return mv2.Negative();
        
        return new Ga301KVector2()
        {
            Scalar12 = Scalar12 - mv2.Scalar12,
            Scalar13 = Scalar13 - mv2.Scalar13,
            Scalar23 = Scalar23 - mv2.Scalar23,
            Scalar14 = Scalar14 - mv2.Scalar14,
            Scalar24 = Scalar24 - mv2.Scalar24,
            Scalar34 = Scalar34 - mv2.Scalar34
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga301Multivector Subtract(Ga301KVector3 mv2)
    {
        if (mv2.IsZero()) return Ga301Multivector.Create(this);
        if (IsZero()) return Ga301Multivector.Create(mv2.Negative());
        
        return Ga301Multivector.Create(
            Ga301KVector0.Zero,
            Ga301KVector1.Zero,
            this,
            mv2.Negative(),
            Ga301KVector4.Zero
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga301Multivector Subtract(Ga301KVector4 mv2)
    {
        if (mv2.IsZero()) return Ga301Multivector.Create(this);
        if (IsZero()) return Ga301Multivector.Create(mv2.Negative());
        
        return Ga301Multivector.Create(
            Ga301KVector0.Zero,
            Ga301KVector1.Zero,
            this,
            Ga301KVector3.Zero,
            mv2.Negative()
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga301Multivector Subtract(Ga301Multivector mv2)
    {
        if (mv2.IsZero()) return Ga301Multivector.Create(this);
        if (IsZero()) return mv2.Negative();
        
        return Ga301Multivector.Create(
            mv2.KVector0.Negative(),
            mv2.KVector1.Negative(),
            Subtract(mv2.KVector2),
            mv2.KVector3.Negative(),
            mv2.KVector4.Negative()
        );
    }
    
}
