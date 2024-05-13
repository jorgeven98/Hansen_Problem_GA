using System.Runtime.CompilerServices;

namespace GeometricAlgebraFulcrumLib.Generations.Algebra.Ga31;

public static class Ga31Projection
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga31KVector0 ProjectOn(this Ga31KVector0 mv1, Ga31KVector1 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga31KVector0.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        return new Ga31KVector0
        {
            Scalar = (-mv1.Scalar * mv2.Scalar1 * mv2.Scalar1 + mv1.Scalar * mv2.Scalar2 * mv2.Scalar2 + mv1.Scalar * mv2.Scalar3 * mv2.Scalar3 + mv1.Scalar * mv2.Scalar4 * mv2.Scalar4) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga31KVector0 ProjectOn(this Ga31KVector0 mv1, Ga31KVector2 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga31KVector0.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        return new Ga31KVector0
        {
            Scalar = (-mv1.Scalar * mv2.Scalar12 * mv2.Scalar12 - mv1.Scalar * mv2.Scalar13 * mv2.Scalar13 + mv1.Scalar * mv2.Scalar23 * mv2.Scalar23 - mv1.Scalar * mv2.Scalar14 * mv2.Scalar14 + mv1.Scalar * mv2.Scalar24 * mv2.Scalar24 + mv1.Scalar * mv2.Scalar34 * mv2.Scalar34) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga31KVector0 ProjectOn(this Ga31KVector0 mv1, Ga31KVector3 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga31KVector0.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        return new Ga31KVector0
        {
            Scalar = (-mv1.Scalar * mv2.Scalar123 * mv2.Scalar123 - mv1.Scalar * mv2.Scalar124 * mv2.Scalar124 - mv1.Scalar * mv2.Scalar134 * mv2.Scalar134 + mv1.Scalar * mv2.Scalar234 * mv2.Scalar234) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga31KVector1 ProjectOn(this Ga31KVector1 mv1, Ga31KVector1 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga31KVector1.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        return new Ga31KVector1
        {
            Scalar1 = (-mv1.Scalar1 * mv2.Scalar1 * mv2.Scalar1 + mv1.Scalar2 * mv2.Scalar2 * mv2.Scalar1 + mv1.Scalar3 * mv2.Scalar3 * mv2.Scalar1 + mv1.Scalar4 * mv2.Scalar4 * mv2.Scalar1) * mv2NormSquaredInv,
            Scalar2 = (-mv1.Scalar1 * mv2.Scalar1 * mv2.Scalar2 + mv1.Scalar2 * mv2.Scalar2 * mv2.Scalar2 + mv1.Scalar3 * mv2.Scalar3 * mv2.Scalar2 + mv1.Scalar4 * mv2.Scalar4 * mv2.Scalar2) * mv2NormSquaredInv,
            Scalar3 = (-mv1.Scalar1 * mv2.Scalar1 * mv2.Scalar3 + mv1.Scalar2 * mv2.Scalar2 * mv2.Scalar3 + mv1.Scalar3 * mv2.Scalar3 * mv2.Scalar3 + mv1.Scalar4 * mv2.Scalar4 * mv2.Scalar3) * mv2NormSquaredInv,
            Scalar4 = (-mv1.Scalar1 * mv2.Scalar1 * mv2.Scalar4 + mv1.Scalar2 * mv2.Scalar2 * mv2.Scalar4 + mv1.Scalar3 * mv2.Scalar3 * mv2.Scalar4 + mv1.Scalar4 * mv2.Scalar4 * mv2.Scalar4) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga31KVector1 ProjectOn(this Ga31KVector1 mv1, Ga31KVector2 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga31KVector1.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        return new Ga31KVector1
        {
            Scalar1 = (-mv1.Scalar1 * mv2.Scalar12 * mv2.Scalar12 - mv1.Scalar1 * mv2.Scalar13 * mv2.Scalar13 - mv1.Scalar1 * mv2.Scalar14 * mv2.Scalar14 + mv1.Scalar2 * mv2.Scalar23 * mv2.Scalar13 + mv1.Scalar2 * mv2.Scalar24 * mv2.Scalar14 - mv1.Scalar3 * mv2.Scalar23 * mv2.Scalar12 + mv1.Scalar3 * mv2.Scalar34 * mv2.Scalar14 - mv1.Scalar4 * mv2.Scalar24 * mv2.Scalar12 - mv1.Scalar4 * mv2.Scalar34 * mv2.Scalar13) * mv2NormSquaredInv,
            Scalar2 = (-mv1.Scalar1 * mv2.Scalar13 * mv2.Scalar23 - mv1.Scalar1 * mv2.Scalar14 * mv2.Scalar24 - mv1.Scalar2 * mv2.Scalar12 * mv2.Scalar12 + mv1.Scalar2 * mv2.Scalar23 * mv2.Scalar23 + mv1.Scalar2 * mv2.Scalar24 * mv2.Scalar24 - mv1.Scalar3 * mv2.Scalar13 * mv2.Scalar12 + mv1.Scalar3 * mv2.Scalar34 * mv2.Scalar24 - mv1.Scalar4 * mv2.Scalar14 * mv2.Scalar12 - mv1.Scalar4 * mv2.Scalar34 * mv2.Scalar23) * mv2NormSquaredInv,
            Scalar3 = (mv1.Scalar1 * mv2.Scalar12 * mv2.Scalar23 - mv1.Scalar1 * mv2.Scalar14 * mv2.Scalar34 - mv1.Scalar2 * mv2.Scalar12 * mv2.Scalar13 + mv1.Scalar2 * mv2.Scalar24 * mv2.Scalar34 - mv1.Scalar3 * mv2.Scalar13 * mv2.Scalar13 + mv1.Scalar3 * mv2.Scalar23 * mv2.Scalar23 + mv1.Scalar3 * mv2.Scalar34 * mv2.Scalar34 - mv1.Scalar4 * mv2.Scalar14 * mv2.Scalar13 + mv1.Scalar4 * mv2.Scalar24 * mv2.Scalar23) * mv2NormSquaredInv,
            Scalar4 = (mv1.Scalar1 * mv2.Scalar12 * mv2.Scalar24 + mv1.Scalar1 * mv2.Scalar13 * mv2.Scalar34 - mv1.Scalar2 * mv2.Scalar12 * mv2.Scalar14 - mv1.Scalar2 * mv2.Scalar23 * mv2.Scalar34 - mv1.Scalar3 * mv2.Scalar13 * mv2.Scalar14 + mv1.Scalar3 * mv2.Scalar23 * mv2.Scalar24 - mv1.Scalar4 * mv2.Scalar14 * mv2.Scalar14 + mv1.Scalar4 * mv2.Scalar24 * mv2.Scalar24 + mv1.Scalar4 * mv2.Scalar34 * mv2.Scalar34) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga31KVector1 ProjectOn(this Ga31KVector1 mv1, Ga31KVector3 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga31KVector1.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        return new Ga31KVector1
        {
            Scalar1 = (-mv1.Scalar1 * mv2.Scalar123 * mv2.Scalar123 - mv1.Scalar1 * mv2.Scalar124 * mv2.Scalar124 - mv1.Scalar1 * mv2.Scalar134 * mv2.Scalar134 + mv1.Scalar2 * mv2.Scalar234 * mv2.Scalar134 - mv1.Scalar3 * mv2.Scalar234 * mv2.Scalar124 + mv1.Scalar4 * mv2.Scalar234 * mv2.Scalar123) * mv2NormSquaredInv,
            Scalar2 = (-mv1.Scalar1 * mv2.Scalar134 * mv2.Scalar234 - mv1.Scalar2 * mv2.Scalar123 * mv2.Scalar123 - mv1.Scalar2 * mv2.Scalar124 * mv2.Scalar124 + mv1.Scalar2 * mv2.Scalar234 * mv2.Scalar234 - mv1.Scalar3 * mv2.Scalar134 * mv2.Scalar124 + mv1.Scalar4 * mv2.Scalar134 * mv2.Scalar123) * mv2NormSquaredInv,
            Scalar3 = (mv1.Scalar1 * mv2.Scalar124 * mv2.Scalar234 - mv1.Scalar2 * mv2.Scalar124 * mv2.Scalar134 - mv1.Scalar3 * mv2.Scalar123 * mv2.Scalar123 - mv1.Scalar3 * mv2.Scalar134 * mv2.Scalar134 + mv1.Scalar3 * mv2.Scalar234 * mv2.Scalar234 - mv1.Scalar4 * mv2.Scalar124 * mv2.Scalar123) * mv2NormSquaredInv,
            Scalar4 = (-mv1.Scalar1 * mv2.Scalar123 * mv2.Scalar234 + mv1.Scalar2 * mv2.Scalar123 * mv2.Scalar134 - mv1.Scalar3 * mv2.Scalar123 * mv2.Scalar124 - mv1.Scalar4 * mv2.Scalar124 * mv2.Scalar124 - mv1.Scalar4 * mv2.Scalar134 * mv2.Scalar134 + mv1.Scalar4 * mv2.Scalar234 * mv2.Scalar234) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga31KVector2 ProjectOn(this Ga31KVector2 mv1, Ga31KVector2 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga31KVector2.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        return new Ga31KVector2
        {
            Scalar12 = (-mv1.Scalar12 * mv2.Scalar12 * mv2.Scalar12 - mv1.Scalar13 * mv2.Scalar13 * mv2.Scalar12 + mv1.Scalar23 * mv2.Scalar23 * mv2.Scalar12 - mv1.Scalar14 * mv2.Scalar14 * mv2.Scalar12 + mv1.Scalar24 * mv2.Scalar24 * mv2.Scalar12 + mv1.Scalar34 * mv2.Scalar34 * mv2.Scalar12) * mv2NormSquaredInv,
            Scalar13 = (-mv1.Scalar12 * mv2.Scalar12 * mv2.Scalar13 - mv1.Scalar13 * mv2.Scalar13 * mv2.Scalar13 + mv1.Scalar23 * mv2.Scalar23 * mv2.Scalar13 - mv1.Scalar14 * mv2.Scalar14 * mv2.Scalar13 + mv1.Scalar24 * mv2.Scalar24 * mv2.Scalar13 + mv1.Scalar34 * mv2.Scalar34 * mv2.Scalar13) * mv2NormSquaredInv,
            Scalar23 = (-mv1.Scalar12 * mv2.Scalar12 * mv2.Scalar23 - mv1.Scalar13 * mv2.Scalar13 * mv2.Scalar23 + mv1.Scalar23 * mv2.Scalar23 * mv2.Scalar23 - mv1.Scalar14 * mv2.Scalar14 * mv2.Scalar23 + mv1.Scalar24 * mv2.Scalar24 * mv2.Scalar23 + mv1.Scalar34 * mv2.Scalar34 * mv2.Scalar23) * mv2NormSquaredInv,
            Scalar14 = (-mv1.Scalar12 * mv2.Scalar12 * mv2.Scalar14 - mv1.Scalar13 * mv2.Scalar13 * mv2.Scalar14 + mv1.Scalar23 * mv2.Scalar23 * mv2.Scalar14 - mv1.Scalar14 * mv2.Scalar14 * mv2.Scalar14 + mv1.Scalar24 * mv2.Scalar24 * mv2.Scalar14 + mv1.Scalar34 * mv2.Scalar34 * mv2.Scalar14) * mv2NormSquaredInv,
            Scalar24 = (-mv1.Scalar12 * mv2.Scalar12 * mv2.Scalar24 - mv1.Scalar13 * mv2.Scalar13 * mv2.Scalar24 + mv1.Scalar23 * mv2.Scalar23 * mv2.Scalar24 - mv1.Scalar14 * mv2.Scalar14 * mv2.Scalar24 + mv1.Scalar24 * mv2.Scalar24 * mv2.Scalar24 + mv1.Scalar34 * mv2.Scalar34 * mv2.Scalar24) * mv2NormSquaredInv,
            Scalar34 = (-mv1.Scalar12 * mv2.Scalar12 * mv2.Scalar34 - mv1.Scalar13 * mv2.Scalar13 * mv2.Scalar34 + mv1.Scalar23 * mv2.Scalar23 * mv2.Scalar34 - mv1.Scalar14 * mv2.Scalar14 * mv2.Scalar34 + mv1.Scalar24 * mv2.Scalar24 * mv2.Scalar34 + mv1.Scalar34 * mv2.Scalar34 * mv2.Scalar34) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga31KVector2 ProjectOn(this Ga31KVector2 mv1, Ga31KVector3 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga31KVector2.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        return new Ga31KVector2
        {
            Scalar12 = (-mv1.Scalar12 * mv2.Scalar123 * mv2.Scalar123 - mv1.Scalar12 * mv2.Scalar124 * mv2.Scalar124 - mv1.Scalar13 * mv2.Scalar134 * mv2.Scalar124 + mv1.Scalar23 * mv2.Scalar234 * mv2.Scalar124 + mv1.Scalar14 * mv2.Scalar134 * mv2.Scalar123 - mv1.Scalar24 * mv2.Scalar234 * mv2.Scalar123) * mv2NormSquaredInv,
            Scalar13 = (-mv1.Scalar12 * mv2.Scalar124 * mv2.Scalar134 - mv1.Scalar13 * mv2.Scalar123 * mv2.Scalar123 - mv1.Scalar13 * mv2.Scalar134 * mv2.Scalar134 + mv1.Scalar23 * mv2.Scalar234 * mv2.Scalar134 - mv1.Scalar14 * mv2.Scalar124 * mv2.Scalar123 - mv1.Scalar34 * mv2.Scalar234 * mv2.Scalar123) * mv2NormSquaredInv,
            Scalar23 = (-mv1.Scalar12 * mv2.Scalar124 * mv2.Scalar234 - mv1.Scalar13 * mv2.Scalar134 * mv2.Scalar234 - mv1.Scalar23 * mv2.Scalar123 * mv2.Scalar123 + mv1.Scalar23 * mv2.Scalar234 * mv2.Scalar234 - mv1.Scalar24 * mv2.Scalar124 * mv2.Scalar123 - mv1.Scalar34 * mv2.Scalar134 * mv2.Scalar123) * mv2NormSquaredInv,
            Scalar14 = (mv1.Scalar12 * mv2.Scalar123 * mv2.Scalar134 - mv1.Scalar13 * mv2.Scalar123 * mv2.Scalar124 - mv1.Scalar14 * mv2.Scalar124 * mv2.Scalar124 - mv1.Scalar14 * mv2.Scalar134 * mv2.Scalar134 + mv1.Scalar24 * mv2.Scalar234 * mv2.Scalar134 - mv1.Scalar34 * mv2.Scalar234 * mv2.Scalar124) * mv2NormSquaredInv,
            Scalar24 = (mv1.Scalar12 * mv2.Scalar123 * mv2.Scalar234 - mv1.Scalar23 * mv2.Scalar123 * mv2.Scalar124 - mv1.Scalar14 * mv2.Scalar134 * mv2.Scalar234 - mv1.Scalar24 * mv2.Scalar124 * mv2.Scalar124 + mv1.Scalar24 * mv2.Scalar234 * mv2.Scalar234 - mv1.Scalar34 * mv2.Scalar134 * mv2.Scalar124) * mv2NormSquaredInv,
            Scalar34 = (mv1.Scalar13 * mv2.Scalar123 * mv2.Scalar234 - mv1.Scalar23 * mv2.Scalar123 * mv2.Scalar134 + mv1.Scalar14 * mv2.Scalar124 * mv2.Scalar234 - mv1.Scalar24 * mv2.Scalar124 * mv2.Scalar134 - mv1.Scalar34 * mv2.Scalar134 * mv2.Scalar134 + mv1.Scalar34 * mv2.Scalar234 * mv2.Scalar234) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga31KVector3 ProjectOn(this Ga31KVector3 mv1, Ga31KVector3 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga31KVector3.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        return new Ga31KVector3
        {
            Scalar123 = (-mv1.Scalar123 * mv2.Scalar123 * mv2.Scalar123 - mv1.Scalar124 * mv2.Scalar124 * mv2.Scalar123 - mv1.Scalar134 * mv2.Scalar134 * mv2.Scalar123 + mv1.Scalar234 * mv2.Scalar234 * mv2.Scalar123) * mv2NormSquaredInv,
            Scalar124 = (-mv1.Scalar123 * mv2.Scalar123 * mv2.Scalar124 - mv1.Scalar124 * mv2.Scalar124 * mv2.Scalar124 - mv1.Scalar134 * mv2.Scalar134 * mv2.Scalar124 + mv1.Scalar234 * mv2.Scalar234 * mv2.Scalar124) * mv2NormSquaredInv,
            Scalar134 = (-mv1.Scalar123 * mv2.Scalar123 * mv2.Scalar134 - mv1.Scalar124 * mv2.Scalar124 * mv2.Scalar134 - mv1.Scalar134 * mv2.Scalar134 * mv2.Scalar134 + mv1.Scalar234 * mv2.Scalar234 * mv2.Scalar134) * mv2NormSquaredInv,
            Scalar234 = (-mv1.Scalar123 * mv2.Scalar123 * mv2.Scalar234 - mv1.Scalar124 * mv2.Scalar124 * mv2.Scalar234 - mv1.Scalar134 * mv2.Scalar134 * mv2.Scalar234 + mv1.Scalar234 * mv2.Scalar234 * mv2.Scalar234) * mv2NormSquaredInv
        };
    }
    
    public static Ga31Multivector ProjectOn(this Ga31Multivector mv1, Ga31KVector1 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga31Multivector.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        var tempScalar = new double[16];
        
        if (!mv1.KVector0.IsZero())
        {
            tempScalar[0] += (-mv1.KVector0.Scalar * mv2.Scalar1 * mv2.Scalar1 + mv1.KVector0.Scalar * mv2.Scalar2 * mv2.Scalar2 + mv1.KVector0.Scalar * mv2.Scalar3 * mv2.Scalar3 + mv1.KVector0.Scalar * mv2.Scalar4 * mv2.Scalar4) * mv2NormSquaredInv;
        }
        
        if (!mv1.KVector1.IsZero())
        {
            tempScalar[1] += (-mv1.KVector1.Scalar1 * mv2.Scalar1 * mv2.Scalar1 + mv1.KVector1.Scalar2 * mv2.Scalar2 * mv2.Scalar1 + mv1.KVector1.Scalar3 * mv2.Scalar3 * mv2.Scalar1 + mv1.KVector1.Scalar4 * mv2.Scalar4 * mv2.Scalar1) * mv2NormSquaredInv;
            tempScalar[2] += (-mv1.KVector1.Scalar1 * mv2.Scalar1 * mv2.Scalar2 + mv1.KVector1.Scalar2 * mv2.Scalar2 * mv2.Scalar2 + mv1.KVector1.Scalar3 * mv2.Scalar3 * mv2.Scalar2 + mv1.KVector1.Scalar4 * mv2.Scalar4 * mv2.Scalar2) * mv2NormSquaredInv;
            tempScalar[4] += (-mv1.KVector1.Scalar1 * mv2.Scalar1 * mv2.Scalar3 + mv1.KVector1.Scalar2 * mv2.Scalar2 * mv2.Scalar3 + mv1.KVector1.Scalar3 * mv2.Scalar3 * mv2.Scalar3 + mv1.KVector1.Scalar4 * mv2.Scalar4 * mv2.Scalar3) * mv2NormSquaredInv;
            tempScalar[8] += (-mv1.KVector1.Scalar1 * mv2.Scalar1 * mv2.Scalar4 + mv1.KVector1.Scalar2 * mv2.Scalar2 * mv2.Scalar4 + mv1.KVector1.Scalar3 * mv2.Scalar3 * mv2.Scalar4 + mv1.KVector1.Scalar4 * mv2.Scalar4 * mv2.Scalar4) * mv2NormSquaredInv;
        }
        
        return Ga31Multivector.Create(tempScalar);
    }
    
    public static Ga31Multivector ProjectOn(this Ga31Multivector mv1, Ga31KVector2 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga31Multivector.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        var tempScalar = new double[16];
        
        if (!mv1.KVector0.IsZero())
        {
            tempScalar[0] += (-mv1.KVector0.Scalar * mv2.Scalar12 * mv2.Scalar12 - mv1.KVector0.Scalar * mv2.Scalar13 * mv2.Scalar13 + mv1.KVector0.Scalar * mv2.Scalar23 * mv2.Scalar23 - mv1.KVector0.Scalar * mv2.Scalar14 * mv2.Scalar14 + mv1.KVector0.Scalar * mv2.Scalar24 * mv2.Scalar24 + mv1.KVector0.Scalar * mv2.Scalar34 * mv2.Scalar34) * mv2NormSquaredInv;
        }
        
        if (!mv1.KVector1.IsZero())
        {
            tempScalar[1] += (-mv1.KVector1.Scalar1 * mv2.Scalar12 * mv2.Scalar12 - mv1.KVector1.Scalar1 * mv2.Scalar13 * mv2.Scalar13 - mv1.KVector1.Scalar1 * mv2.Scalar14 * mv2.Scalar14 + mv1.KVector1.Scalar2 * mv2.Scalar23 * mv2.Scalar13 + mv1.KVector1.Scalar2 * mv2.Scalar24 * mv2.Scalar14 - mv1.KVector1.Scalar3 * mv2.Scalar23 * mv2.Scalar12 + mv1.KVector1.Scalar3 * mv2.Scalar34 * mv2.Scalar14 - mv1.KVector1.Scalar4 * mv2.Scalar24 * mv2.Scalar12 - mv1.KVector1.Scalar4 * mv2.Scalar34 * mv2.Scalar13) * mv2NormSquaredInv;
            tempScalar[2] += (-mv1.KVector1.Scalar1 * mv2.Scalar13 * mv2.Scalar23 - mv1.KVector1.Scalar1 * mv2.Scalar14 * mv2.Scalar24 - mv1.KVector1.Scalar2 * mv2.Scalar12 * mv2.Scalar12 + mv1.KVector1.Scalar2 * mv2.Scalar23 * mv2.Scalar23 + mv1.KVector1.Scalar2 * mv2.Scalar24 * mv2.Scalar24 - mv1.KVector1.Scalar3 * mv2.Scalar13 * mv2.Scalar12 + mv1.KVector1.Scalar3 * mv2.Scalar34 * mv2.Scalar24 - mv1.KVector1.Scalar4 * mv2.Scalar14 * mv2.Scalar12 - mv1.KVector1.Scalar4 * mv2.Scalar34 * mv2.Scalar23) * mv2NormSquaredInv;
            tempScalar[4] += (mv1.KVector1.Scalar1 * mv2.Scalar12 * mv2.Scalar23 - mv1.KVector1.Scalar1 * mv2.Scalar14 * mv2.Scalar34 - mv1.KVector1.Scalar2 * mv2.Scalar12 * mv2.Scalar13 + mv1.KVector1.Scalar2 * mv2.Scalar24 * mv2.Scalar34 - mv1.KVector1.Scalar3 * mv2.Scalar13 * mv2.Scalar13 + mv1.KVector1.Scalar3 * mv2.Scalar23 * mv2.Scalar23 + mv1.KVector1.Scalar3 * mv2.Scalar34 * mv2.Scalar34 - mv1.KVector1.Scalar4 * mv2.Scalar14 * mv2.Scalar13 + mv1.KVector1.Scalar4 * mv2.Scalar24 * mv2.Scalar23) * mv2NormSquaredInv;
            tempScalar[8] += (mv1.KVector1.Scalar1 * mv2.Scalar12 * mv2.Scalar24 + mv1.KVector1.Scalar1 * mv2.Scalar13 * mv2.Scalar34 - mv1.KVector1.Scalar2 * mv2.Scalar12 * mv2.Scalar14 - mv1.KVector1.Scalar2 * mv2.Scalar23 * mv2.Scalar34 - mv1.KVector1.Scalar3 * mv2.Scalar13 * mv2.Scalar14 + mv1.KVector1.Scalar3 * mv2.Scalar23 * mv2.Scalar24 - mv1.KVector1.Scalar4 * mv2.Scalar14 * mv2.Scalar14 + mv1.KVector1.Scalar4 * mv2.Scalar24 * mv2.Scalar24 + mv1.KVector1.Scalar4 * mv2.Scalar34 * mv2.Scalar34) * mv2NormSquaredInv;
        }
        
        if (!mv1.KVector2.IsZero())
        {
            tempScalar[3] += (-mv1.KVector2.Scalar12 * mv2.Scalar12 * mv2.Scalar12 - mv1.KVector2.Scalar13 * mv2.Scalar13 * mv2.Scalar12 + mv1.KVector2.Scalar23 * mv2.Scalar23 * mv2.Scalar12 - mv1.KVector2.Scalar14 * mv2.Scalar14 * mv2.Scalar12 + mv1.KVector2.Scalar24 * mv2.Scalar24 * mv2.Scalar12 + mv1.KVector2.Scalar34 * mv2.Scalar34 * mv2.Scalar12) * mv2NormSquaredInv;
            tempScalar[5] += (-mv1.KVector2.Scalar12 * mv2.Scalar12 * mv2.Scalar13 - mv1.KVector2.Scalar13 * mv2.Scalar13 * mv2.Scalar13 + mv1.KVector2.Scalar23 * mv2.Scalar23 * mv2.Scalar13 - mv1.KVector2.Scalar14 * mv2.Scalar14 * mv2.Scalar13 + mv1.KVector2.Scalar24 * mv2.Scalar24 * mv2.Scalar13 + mv1.KVector2.Scalar34 * mv2.Scalar34 * mv2.Scalar13) * mv2NormSquaredInv;
            tempScalar[6] += (-mv1.KVector2.Scalar12 * mv2.Scalar12 * mv2.Scalar23 - mv1.KVector2.Scalar13 * mv2.Scalar13 * mv2.Scalar23 + mv1.KVector2.Scalar23 * mv2.Scalar23 * mv2.Scalar23 - mv1.KVector2.Scalar14 * mv2.Scalar14 * mv2.Scalar23 + mv1.KVector2.Scalar24 * mv2.Scalar24 * mv2.Scalar23 + mv1.KVector2.Scalar34 * mv2.Scalar34 * mv2.Scalar23) * mv2NormSquaredInv;
            tempScalar[9] += (-mv1.KVector2.Scalar12 * mv2.Scalar12 * mv2.Scalar14 - mv1.KVector2.Scalar13 * mv2.Scalar13 * mv2.Scalar14 + mv1.KVector2.Scalar23 * mv2.Scalar23 * mv2.Scalar14 - mv1.KVector2.Scalar14 * mv2.Scalar14 * mv2.Scalar14 + mv1.KVector2.Scalar24 * mv2.Scalar24 * mv2.Scalar14 + mv1.KVector2.Scalar34 * mv2.Scalar34 * mv2.Scalar14) * mv2NormSquaredInv;
            tempScalar[10] += (-mv1.KVector2.Scalar12 * mv2.Scalar12 * mv2.Scalar24 - mv1.KVector2.Scalar13 * mv2.Scalar13 * mv2.Scalar24 + mv1.KVector2.Scalar23 * mv2.Scalar23 * mv2.Scalar24 - mv1.KVector2.Scalar14 * mv2.Scalar14 * mv2.Scalar24 + mv1.KVector2.Scalar24 * mv2.Scalar24 * mv2.Scalar24 + mv1.KVector2.Scalar34 * mv2.Scalar34 * mv2.Scalar24) * mv2NormSquaredInv;
            tempScalar[12] += (-mv1.KVector2.Scalar12 * mv2.Scalar12 * mv2.Scalar34 - mv1.KVector2.Scalar13 * mv2.Scalar13 * mv2.Scalar34 + mv1.KVector2.Scalar23 * mv2.Scalar23 * mv2.Scalar34 - mv1.KVector2.Scalar14 * mv2.Scalar14 * mv2.Scalar34 + mv1.KVector2.Scalar24 * mv2.Scalar24 * mv2.Scalar34 + mv1.KVector2.Scalar34 * mv2.Scalar34 * mv2.Scalar34) * mv2NormSquaredInv;
        }
        
        return Ga31Multivector.Create(tempScalar);
    }
    
    public static Ga31Multivector ProjectOn(this Ga31Multivector mv1, Ga31KVector3 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga31Multivector.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        var tempScalar = new double[16];
        
        if (!mv1.KVector0.IsZero())
        {
            tempScalar[0] += (-mv1.KVector0.Scalar * mv2.Scalar123 * mv2.Scalar123 - mv1.KVector0.Scalar * mv2.Scalar124 * mv2.Scalar124 - mv1.KVector0.Scalar * mv2.Scalar134 * mv2.Scalar134 + mv1.KVector0.Scalar * mv2.Scalar234 * mv2.Scalar234) * mv2NormSquaredInv;
        }
        
        if (!mv1.KVector1.IsZero())
        {
            tempScalar[1] += (-mv1.KVector1.Scalar1 * mv2.Scalar123 * mv2.Scalar123 - mv1.KVector1.Scalar1 * mv2.Scalar124 * mv2.Scalar124 - mv1.KVector1.Scalar1 * mv2.Scalar134 * mv2.Scalar134 + mv1.KVector1.Scalar2 * mv2.Scalar234 * mv2.Scalar134 - mv1.KVector1.Scalar3 * mv2.Scalar234 * mv2.Scalar124 + mv1.KVector1.Scalar4 * mv2.Scalar234 * mv2.Scalar123) * mv2NormSquaredInv;
            tempScalar[2] += (-mv1.KVector1.Scalar1 * mv2.Scalar134 * mv2.Scalar234 - mv1.KVector1.Scalar2 * mv2.Scalar123 * mv2.Scalar123 - mv1.KVector1.Scalar2 * mv2.Scalar124 * mv2.Scalar124 + mv1.KVector1.Scalar2 * mv2.Scalar234 * mv2.Scalar234 - mv1.KVector1.Scalar3 * mv2.Scalar134 * mv2.Scalar124 + mv1.KVector1.Scalar4 * mv2.Scalar134 * mv2.Scalar123) * mv2NormSquaredInv;
            tempScalar[4] += (mv1.KVector1.Scalar1 * mv2.Scalar124 * mv2.Scalar234 - mv1.KVector1.Scalar2 * mv2.Scalar124 * mv2.Scalar134 - mv1.KVector1.Scalar3 * mv2.Scalar123 * mv2.Scalar123 - mv1.KVector1.Scalar3 * mv2.Scalar134 * mv2.Scalar134 + mv1.KVector1.Scalar3 * mv2.Scalar234 * mv2.Scalar234 - mv1.KVector1.Scalar4 * mv2.Scalar124 * mv2.Scalar123) * mv2NormSquaredInv;
            tempScalar[8] += (-mv1.KVector1.Scalar1 * mv2.Scalar123 * mv2.Scalar234 + mv1.KVector1.Scalar2 * mv2.Scalar123 * mv2.Scalar134 - mv1.KVector1.Scalar3 * mv2.Scalar123 * mv2.Scalar124 - mv1.KVector1.Scalar4 * mv2.Scalar124 * mv2.Scalar124 - mv1.KVector1.Scalar4 * mv2.Scalar134 * mv2.Scalar134 + mv1.KVector1.Scalar4 * mv2.Scalar234 * mv2.Scalar234) * mv2NormSquaredInv;
        }
        
        if (!mv1.KVector2.IsZero())
        {
            tempScalar[3] += (-mv1.KVector2.Scalar12 * mv2.Scalar123 * mv2.Scalar123 - mv1.KVector2.Scalar12 * mv2.Scalar124 * mv2.Scalar124 - mv1.KVector2.Scalar13 * mv2.Scalar134 * mv2.Scalar124 + mv1.KVector2.Scalar23 * mv2.Scalar234 * mv2.Scalar124 + mv1.KVector2.Scalar14 * mv2.Scalar134 * mv2.Scalar123 - mv1.KVector2.Scalar24 * mv2.Scalar234 * mv2.Scalar123) * mv2NormSquaredInv;
            tempScalar[5] += (-mv1.KVector2.Scalar12 * mv2.Scalar124 * mv2.Scalar134 - mv1.KVector2.Scalar13 * mv2.Scalar123 * mv2.Scalar123 - mv1.KVector2.Scalar13 * mv2.Scalar134 * mv2.Scalar134 + mv1.KVector2.Scalar23 * mv2.Scalar234 * mv2.Scalar134 - mv1.KVector2.Scalar14 * mv2.Scalar124 * mv2.Scalar123 - mv1.KVector2.Scalar34 * mv2.Scalar234 * mv2.Scalar123) * mv2NormSquaredInv;
            tempScalar[6] += (-mv1.KVector2.Scalar12 * mv2.Scalar124 * mv2.Scalar234 - mv1.KVector2.Scalar13 * mv2.Scalar134 * mv2.Scalar234 - mv1.KVector2.Scalar23 * mv2.Scalar123 * mv2.Scalar123 + mv1.KVector2.Scalar23 * mv2.Scalar234 * mv2.Scalar234 - mv1.KVector2.Scalar24 * mv2.Scalar124 * mv2.Scalar123 - mv1.KVector2.Scalar34 * mv2.Scalar134 * mv2.Scalar123) * mv2NormSquaredInv;
            tempScalar[9] += (mv1.KVector2.Scalar12 * mv2.Scalar123 * mv2.Scalar134 - mv1.KVector2.Scalar13 * mv2.Scalar123 * mv2.Scalar124 - mv1.KVector2.Scalar14 * mv2.Scalar124 * mv2.Scalar124 - mv1.KVector2.Scalar14 * mv2.Scalar134 * mv2.Scalar134 + mv1.KVector2.Scalar24 * mv2.Scalar234 * mv2.Scalar134 - mv1.KVector2.Scalar34 * mv2.Scalar234 * mv2.Scalar124) * mv2NormSquaredInv;
            tempScalar[10] += (mv1.KVector2.Scalar12 * mv2.Scalar123 * mv2.Scalar234 - mv1.KVector2.Scalar23 * mv2.Scalar123 * mv2.Scalar124 - mv1.KVector2.Scalar14 * mv2.Scalar134 * mv2.Scalar234 - mv1.KVector2.Scalar24 * mv2.Scalar124 * mv2.Scalar124 + mv1.KVector2.Scalar24 * mv2.Scalar234 * mv2.Scalar234 - mv1.KVector2.Scalar34 * mv2.Scalar134 * mv2.Scalar124) * mv2NormSquaredInv;
            tempScalar[12] += (mv1.KVector2.Scalar13 * mv2.Scalar123 * mv2.Scalar234 - mv1.KVector2.Scalar23 * mv2.Scalar123 * mv2.Scalar134 + mv1.KVector2.Scalar14 * mv2.Scalar124 * mv2.Scalar234 - mv1.KVector2.Scalar24 * mv2.Scalar124 * mv2.Scalar134 - mv1.KVector2.Scalar34 * mv2.Scalar134 * mv2.Scalar134 + mv1.KVector2.Scalar34 * mv2.Scalar234 * mv2.Scalar234) * mv2NormSquaredInv;
        }
        
        if (!mv1.KVector3.IsZero())
        {
            tempScalar[7] += (-mv1.KVector3.Scalar123 * mv2.Scalar123 * mv2.Scalar123 - mv1.KVector3.Scalar124 * mv2.Scalar124 * mv2.Scalar123 - mv1.KVector3.Scalar134 * mv2.Scalar134 * mv2.Scalar123 + mv1.KVector3.Scalar234 * mv2.Scalar234 * mv2.Scalar123) * mv2NormSquaredInv;
            tempScalar[11] += (-mv1.KVector3.Scalar123 * mv2.Scalar123 * mv2.Scalar124 - mv1.KVector3.Scalar124 * mv2.Scalar124 * mv2.Scalar124 - mv1.KVector3.Scalar134 * mv2.Scalar134 * mv2.Scalar124 + mv1.KVector3.Scalar234 * mv2.Scalar234 * mv2.Scalar124) * mv2NormSquaredInv;
            tempScalar[13] += (-mv1.KVector3.Scalar123 * mv2.Scalar123 * mv2.Scalar134 - mv1.KVector3.Scalar124 * mv2.Scalar124 * mv2.Scalar134 - mv1.KVector3.Scalar134 * mv2.Scalar134 * mv2.Scalar134 + mv1.KVector3.Scalar234 * mv2.Scalar234 * mv2.Scalar134) * mv2NormSquaredInv;
            tempScalar[14] += (-mv1.KVector3.Scalar123 * mv2.Scalar123 * mv2.Scalar234 - mv1.KVector3.Scalar124 * mv2.Scalar124 * mv2.Scalar234 - mv1.KVector3.Scalar134 * mv2.Scalar134 * mv2.Scalar234 + mv1.KVector3.Scalar234 * mv2.Scalar234 * mv2.Scalar234) * mv2NormSquaredInv;
        }
        
        return Ga31Multivector.Create(tempScalar);
    }
    
}
