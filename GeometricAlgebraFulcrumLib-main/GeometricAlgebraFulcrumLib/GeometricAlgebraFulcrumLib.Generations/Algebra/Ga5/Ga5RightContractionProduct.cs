using System.Runtime.CompilerServices;

namespace GeometricAlgebraFulcrumLib.Generations.Algebra.Ga5;

public static class Ga5RightContractionProduct
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga5KVector0 Rcp(this Ga5KVector0 mv1, Ga5KVector0 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga5KVector0.Zero;
        
        return new Ga5KVector0
        {
            Scalar = mv1.Scalar * mv2.Scalar
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga5KVector0 Rcp(this Ga5KVector0 mv1, Ga5KVector1 mv2)
    {
        return Ga5KVector0.Zero;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga5KVector0 Rcp(this Ga5KVector0 mv1, Ga5KVector2 mv2)
    {
        return Ga5KVector0.Zero;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga5KVector0 Rcp(this Ga5KVector0 mv1, Ga5KVector3 mv2)
    {
        return Ga5KVector0.Zero;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga5KVector0 Rcp(this Ga5KVector0 mv1, Ga5KVector4 mv2)
    {
        return Ga5KVector0.Zero;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga5KVector0 Rcp(this Ga5KVector0 mv1, Ga5KVector5 mv2)
    {
        return Ga5KVector0.Zero;
    }
    
    public static Ga5KVector0 Rcp(this Ga5KVector0 mv1, Ga5Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga5KVector0.Zero;
        
        var tempScalar = 0d;
        
        if (!mv2.KVector0.IsZero())
        {
            tempScalar += mv1.Scalar * mv2.KVector0.Scalar;
        }
        
        return new Ga5KVector0
        {
            Scalar = tempScalar
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga5KVector1 Rcp(this Ga5KVector1 mv1, Ga5KVector0 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga5KVector1.Zero;
        
        return new Ga5KVector1
        {
            Scalar1 = mv1.Scalar1 * mv2.Scalar,
            Scalar2 = mv1.Scalar2 * mv2.Scalar,
            Scalar3 = mv1.Scalar3 * mv2.Scalar,
            Scalar4 = mv1.Scalar4 * mv2.Scalar,
            Scalar5 = mv1.Scalar5 * mv2.Scalar
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga5KVector0 Rcp(this Ga5KVector1 mv1, Ga5KVector1 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga5KVector0.Zero;
        
        return new Ga5KVector0
        {
            Scalar = mv1.Scalar1 * mv2.Scalar1 + mv1.Scalar2 * mv2.Scalar2 + mv1.Scalar3 * mv2.Scalar3 + mv1.Scalar4 * mv2.Scalar4 + mv1.Scalar5 * mv2.Scalar5
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga5KVector0 Rcp(this Ga5KVector1 mv1, Ga5KVector2 mv2)
    {
        return Ga5KVector0.Zero;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga5KVector0 Rcp(this Ga5KVector1 mv1, Ga5KVector3 mv2)
    {
        return Ga5KVector0.Zero;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga5KVector0 Rcp(this Ga5KVector1 mv1, Ga5KVector4 mv2)
    {
        return Ga5KVector0.Zero;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga5KVector0 Rcp(this Ga5KVector1 mv1, Ga5KVector5 mv2)
    {
        return Ga5KVector0.Zero;
    }
    
    public static Ga5Multivector Rcp(this Ga5KVector1 mv1, Ga5Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga5Multivector.Zero;
        
        var tempScalar = new double[32];
        
        if (!mv2.KVector0.IsZero())
        {
            tempScalar[1] += mv1.Scalar1 * mv2.KVector0.Scalar;
            tempScalar[2] += mv1.Scalar2 * mv2.KVector0.Scalar;
            tempScalar[4] += mv1.Scalar3 * mv2.KVector0.Scalar;
            tempScalar[8] += mv1.Scalar4 * mv2.KVector0.Scalar;
            tempScalar[16] += mv1.Scalar5 * mv2.KVector0.Scalar;
        }
        
        if (!mv2.KVector1.IsZero())
        {
            tempScalar[0] += mv1.Scalar1 * mv2.KVector1.Scalar1 + mv1.Scalar2 * mv2.KVector1.Scalar2 + mv1.Scalar3 * mv2.KVector1.Scalar3 + mv1.Scalar4 * mv2.KVector1.Scalar4 + mv1.Scalar5 * mv2.KVector1.Scalar5;
        }
        
        return Ga5Multivector.Create(tempScalar);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga5KVector2 Rcp(this Ga5KVector2 mv1, Ga5KVector0 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga5KVector2.Zero;
        
        return new Ga5KVector2
        {
            Scalar12 = mv1.Scalar12 * mv2.Scalar,
            Scalar13 = mv1.Scalar13 * mv2.Scalar,
            Scalar23 = mv1.Scalar23 * mv2.Scalar,
            Scalar14 = mv1.Scalar14 * mv2.Scalar,
            Scalar24 = mv1.Scalar24 * mv2.Scalar,
            Scalar34 = mv1.Scalar34 * mv2.Scalar,
            Scalar15 = mv1.Scalar15 * mv2.Scalar,
            Scalar25 = mv1.Scalar25 * mv2.Scalar,
            Scalar35 = mv1.Scalar35 * mv2.Scalar,
            Scalar45 = mv1.Scalar45 * mv2.Scalar
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga5KVector1 Rcp(this Ga5KVector2 mv1, Ga5KVector1 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga5KVector1.Zero;
        
        return new Ga5KVector1
        {
            Scalar1 = mv1.Scalar12 * mv2.Scalar2 + mv1.Scalar13 * mv2.Scalar3 + mv1.Scalar14 * mv2.Scalar4 + mv1.Scalar15 * mv2.Scalar5,
            Scalar2 = -mv1.Scalar12 * mv2.Scalar1 + mv1.Scalar23 * mv2.Scalar3 + mv1.Scalar24 * mv2.Scalar4 + mv1.Scalar25 * mv2.Scalar5,
            Scalar3 = -mv1.Scalar13 * mv2.Scalar1 - mv1.Scalar23 * mv2.Scalar2 + mv1.Scalar34 * mv2.Scalar4 + mv1.Scalar35 * mv2.Scalar5,
            Scalar4 = -mv1.Scalar14 * mv2.Scalar1 - mv1.Scalar24 * mv2.Scalar2 - mv1.Scalar34 * mv2.Scalar3 + mv1.Scalar45 * mv2.Scalar5,
            Scalar5 = -mv1.Scalar15 * mv2.Scalar1 - mv1.Scalar25 * mv2.Scalar2 - mv1.Scalar35 * mv2.Scalar3 - mv1.Scalar45 * mv2.Scalar4
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga5KVector0 Rcp(this Ga5KVector2 mv1, Ga5KVector2 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga5KVector0.Zero;
        
        return new Ga5KVector0
        {
            Scalar = -mv1.Scalar12 * mv2.Scalar12 - mv1.Scalar13 * mv2.Scalar13 - mv1.Scalar23 * mv2.Scalar23 - mv1.Scalar14 * mv2.Scalar14 - mv1.Scalar24 * mv2.Scalar24 - mv1.Scalar34 * mv2.Scalar34 - mv1.Scalar15 * mv2.Scalar15 - mv1.Scalar25 * mv2.Scalar25 - mv1.Scalar35 * mv2.Scalar35 - mv1.Scalar45 * mv2.Scalar45
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga5KVector0 Rcp(this Ga5KVector2 mv1, Ga5KVector3 mv2)
    {
        return Ga5KVector0.Zero;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga5KVector0 Rcp(this Ga5KVector2 mv1, Ga5KVector4 mv2)
    {
        return Ga5KVector0.Zero;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga5KVector0 Rcp(this Ga5KVector2 mv1, Ga5KVector5 mv2)
    {
        return Ga5KVector0.Zero;
    }
    
    public static Ga5Multivector Rcp(this Ga5KVector2 mv1, Ga5Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga5Multivector.Zero;
        
        var tempScalar = new double[32];
        
        if (!mv2.KVector0.IsZero())
        {
            tempScalar[3] += mv1.Scalar12 * mv2.KVector0.Scalar;
            tempScalar[5] += mv1.Scalar13 * mv2.KVector0.Scalar;
            tempScalar[6] += mv1.Scalar23 * mv2.KVector0.Scalar;
            tempScalar[9] += mv1.Scalar14 * mv2.KVector0.Scalar;
            tempScalar[10] += mv1.Scalar24 * mv2.KVector0.Scalar;
            tempScalar[12] += mv1.Scalar34 * mv2.KVector0.Scalar;
            tempScalar[17] += mv1.Scalar15 * mv2.KVector0.Scalar;
            tempScalar[18] += mv1.Scalar25 * mv2.KVector0.Scalar;
            tempScalar[20] += mv1.Scalar35 * mv2.KVector0.Scalar;
            tempScalar[24] += mv1.Scalar45 * mv2.KVector0.Scalar;
        }
        
        if (!mv2.KVector1.IsZero())
        {
            tempScalar[1] += mv1.Scalar12 * mv2.KVector1.Scalar2 + mv1.Scalar13 * mv2.KVector1.Scalar3 + mv1.Scalar14 * mv2.KVector1.Scalar4 + mv1.Scalar15 * mv2.KVector1.Scalar5;
            tempScalar[2] += -mv1.Scalar12 * mv2.KVector1.Scalar1 + mv1.Scalar23 * mv2.KVector1.Scalar3 + mv1.Scalar24 * mv2.KVector1.Scalar4 + mv1.Scalar25 * mv2.KVector1.Scalar5;
            tempScalar[4] += -mv1.Scalar13 * mv2.KVector1.Scalar1 - mv1.Scalar23 * mv2.KVector1.Scalar2 + mv1.Scalar34 * mv2.KVector1.Scalar4 + mv1.Scalar35 * mv2.KVector1.Scalar5;
            tempScalar[8] += -mv1.Scalar14 * mv2.KVector1.Scalar1 - mv1.Scalar24 * mv2.KVector1.Scalar2 - mv1.Scalar34 * mv2.KVector1.Scalar3 + mv1.Scalar45 * mv2.KVector1.Scalar5;
            tempScalar[16] += -mv1.Scalar15 * mv2.KVector1.Scalar1 - mv1.Scalar25 * mv2.KVector1.Scalar2 - mv1.Scalar35 * mv2.KVector1.Scalar3 - mv1.Scalar45 * mv2.KVector1.Scalar4;
        }
        
        if (!mv2.KVector2.IsZero())
        {
            tempScalar[0] += -mv1.Scalar12 * mv2.KVector2.Scalar12 - mv1.Scalar13 * mv2.KVector2.Scalar13 - mv1.Scalar23 * mv2.KVector2.Scalar23 - mv1.Scalar14 * mv2.KVector2.Scalar14 - mv1.Scalar24 * mv2.KVector2.Scalar24 - mv1.Scalar34 * mv2.KVector2.Scalar34 - mv1.Scalar15 * mv2.KVector2.Scalar15 - mv1.Scalar25 * mv2.KVector2.Scalar25 - mv1.Scalar35 * mv2.KVector2.Scalar35 - mv1.Scalar45 * mv2.KVector2.Scalar45;
        }
        
        return Ga5Multivector.Create(tempScalar);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga5KVector3 Rcp(this Ga5KVector3 mv1, Ga5KVector0 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga5KVector3.Zero;
        
        return new Ga5KVector3
        {
            Scalar123 = mv1.Scalar123 * mv2.Scalar,
            Scalar124 = mv1.Scalar124 * mv2.Scalar,
            Scalar134 = mv1.Scalar134 * mv2.Scalar,
            Scalar234 = mv1.Scalar234 * mv2.Scalar,
            Scalar125 = mv1.Scalar125 * mv2.Scalar,
            Scalar135 = mv1.Scalar135 * mv2.Scalar,
            Scalar235 = mv1.Scalar235 * mv2.Scalar,
            Scalar145 = mv1.Scalar145 * mv2.Scalar,
            Scalar245 = mv1.Scalar245 * mv2.Scalar,
            Scalar345 = mv1.Scalar345 * mv2.Scalar
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga5KVector2 Rcp(this Ga5KVector3 mv1, Ga5KVector1 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga5KVector2.Zero;
        
        return new Ga5KVector2
        {
            Scalar12 = mv1.Scalar123 * mv2.Scalar3 + mv1.Scalar124 * mv2.Scalar4 + mv1.Scalar125 * mv2.Scalar5,
            Scalar13 = -mv1.Scalar123 * mv2.Scalar2 + mv1.Scalar134 * mv2.Scalar4 + mv1.Scalar135 * mv2.Scalar5,
            Scalar23 = mv1.Scalar123 * mv2.Scalar1 + mv1.Scalar234 * mv2.Scalar4 + mv1.Scalar235 * mv2.Scalar5,
            Scalar14 = -mv1.Scalar124 * mv2.Scalar2 - mv1.Scalar134 * mv2.Scalar3 + mv1.Scalar145 * mv2.Scalar5,
            Scalar24 = mv1.Scalar124 * mv2.Scalar1 - mv1.Scalar234 * mv2.Scalar3 + mv1.Scalar245 * mv2.Scalar5,
            Scalar34 = mv1.Scalar134 * mv2.Scalar1 + mv1.Scalar234 * mv2.Scalar2 + mv1.Scalar345 * mv2.Scalar5,
            Scalar15 = -mv1.Scalar125 * mv2.Scalar2 - mv1.Scalar135 * mv2.Scalar3 - mv1.Scalar145 * mv2.Scalar4,
            Scalar25 = mv1.Scalar125 * mv2.Scalar1 - mv1.Scalar235 * mv2.Scalar3 - mv1.Scalar245 * mv2.Scalar4,
            Scalar35 = mv1.Scalar135 * mv2.Scalar1 + mv1.Scalar235 * mv2.Scalar2 - mv1.Scalar345 * mv2.Scalar4,
            Scalar45 = mv1.Scalar145 * mv2.Scalar1 + mv1.Scalar245 * mv2.Scalar2 + mv1.Scalar345 * mv2.Scalar3
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga5KVector1 Rcp(this Ga5KVector3 mv1, Ga5KVector2 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga5KVector1.Zero;
        
        return new Ga5KVector1
        {
            Scalar1 = -mv1.Scalar123 * mv2.Scalar23 - mv1.Scalar124 * mv2.Scalar24 - mv1.Scalar134 * mv2.Scalar34 - mv1.Scalar125 * mv2.Scalar25 - mv1.Scalar135 * mv2.Scalar35 - mv1.Scalar145 * mv2.Scalar45,
            Scalar2 = mv1.Scalar123 * mv2.Scalar13 + mv1.Scalar124 * mv2.Scalar14 - mv1.Scalar234 * mv2.Scalar34 + mv1.Scalar125 * mv2.Scalar15 - mv1.Scalar235 * mv2.Scalar35 - mv1.Scalar245 * mv2.Scalar45,
            Scalar3 = -mv1.Scalar123 * mv2.Scalar12 + mv1.Scalar134 * mv2.Scalar14 + mv1.Scalar234 * mv2.Scalar24 + mv1.Scalar135 * mv2.Scalar15 + mv1.Scalar235 * mv2.Scalar25 - mv1.Scalar345 * mv2.Scalar45,
            Scalar4 = -mv1.Scalar124 * mv2.Scalar12 - mv1.Scalar134 * mv2.Scalar13 - mv1.Scalar234 * mv2.Scalar23 + mv1.Scalar145 * mv2.Scalar15 + mv1.Scalar245 * mv2.Scalar25 + mv1.Scalar345 * mv2.Scalar35,
            Scalar5 = -mv1.Scalar125 * mv2.Scalar12 - mv1.Scalar135 * mv2.Scalar13 - mv1.Scalar235 * mv2.Scalar23 - mv1.Scalar145 * mv2.Scalar14 - mv1.Scalar245 * mv2.Scalar24 - mv1.Scalar345 * mv2.Scalar34
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga5KVector0 Rcp(this Ga5KVector3 mv1, Ga5KVector3 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga5KVector0.Zero;
        
        return new Ga5KVector0
        {
            Scalar = -mv1.Scalar123 * mv2.Scalar123 - mv1.Scalar124 * mv2.Scalar124 - mv1.Scalar134 * mv2.Scalar134 - mv1.Scalar234 * mv2.Scalar234 - mv1.Scalar125 * mv2.Scalar125 - mv1.Scalar135 * mv2.Scalar135 - mv1.Scalar235 * mv2.Scalar235 - mv1.Scalar145 * mv2.Scalar145 - mv1.Scalar245 * mv2.Scalar245 - mv1.Scalar345 * mv2.Scalar345
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga5KVector0 Rcp(this Ga5KVector3 mv1, Ga5KVector4 mv2)
    {
        return Ga5KVector0.Zero;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga5KVector0 Rcp(this Ga5KVector3 mv1, Ga5KVector5 mv2)
    {
        return Ga5KVector0.Zero;
    }
    
    public static Ga5Multivector Rcp(this Ga5KVector3 mv1, Ga5Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga5Multivector.Zero;
        
        var tempScalar = new double[32];
        
        if (!mv2.KVector0.IsZero())
        {
            tempScalar[7] += mv1.Scalar123 * mv2.KVector0.Scalar;
            tempScalar[11] += mv1.Scalar124 * mv2.KVector0.Scalar;
            tempScalar[13] += mv1.Scalar134 * mv2.KVector0.Scalar;
            tempScalar[14] += mv1.Scalar234 * mv2.KVector0.Scalar;
            tempScalar[19] += mv1.Scalar125 * mv2.KVector0.Scalar;
            tempScalar[21] += mv1.Scalar135 * mv2.KVector0.Scalar;
            tempScalar[22] += mv1.Scalar235 * mv2.KVector0.Scalar;
            tempScalar[25] += mv1.Scalar145 * mv2.KVector0.Scalar;
            tempScalar[26] += mv1.Scalar245 * mv2.KVector0.Scalar;
            tempScalar[28] += mv1.Scalar345 * mv2.KVector0.Scalar;
        }
        
        if (!mv2.KVector1.IsZero())
        {
            tempScalar[3] += mv1.Scalar123 * mv2.KVector1.Scalar3 + mv1.Scalar124 * mv2.KVector1.Scalar4 + mv1.Scalar125 * mv2.KVector1.Scalar5;
            tempScalar[5] += -mv1.Scalar123 * mv2.KVector1.Scalar2 + mv1.Scalar134 * mv2.KVector1.Scalar4 + mv1.Scalar135 * mv2.KVector1.Scalar5;
            tempScalar[6] += mv1.Scalar123 * mv2.KVector1.Scalar1 + mv1.Scalar234 * mv2.KVector1.Scalar4 + mv1.Scalar235 * mv2.KVector1.Scalar5;
            tempScalar[9] += -mv1.Scalar124 * mv2.KVector1.Scalar2 - mv1.Scalar134 * mv2.KVector1.Scalar3 + mv1.Scalar145 * mv2.KVector1.Scalar5;
            tempScalar[10] += mv1.Scalar124 * mv2.KVector1.Scalar1 - mv1.Scalar234 * mv2.KVector1.Scalar3 + mv1.Scalar245 * mv2.KVector1.Scalar5;
            tempScalar[12] += mv1.Scalar134 * mv2.KVector1.Scalar1 + mv1.Scalar234 * mv2.KVector1.Scalar2 + mv1.Scalar345 * mv2.KVector1.Scalar5;
            tempScalar[17] += -mv1.Scalar125 * mv2.KVector1.Scalar2 - mv1.Scalar135 * mv2.KVector1.Scalar3 - mv1.Scalar145 * mv2.KVector1.Scalar4;
            tempScalar[18] += mv1.Scalar125 * mv2.KVector1.Scalar1 - mv1.Scalar235 * mv2.KVector1.Scalar3 - mv1.Scalar245 * mv2.KVector1.Scalar4;
            tempScalar[20] += mv1.Scalar135 * mv2.KVector1.Scalar1 + mv1.Scalar235 * mv2.KVector1.Scalar2 - mv1.Scalar345 * mv2.KVector1.Scalar4;
            tempScalar[24] += mv1.Scalar145 * mv2.KVector1.Scalar1 + mv1.Scalar245 * mv2.KVector1.Scalar2 + mv1.Scalar345 * mv2.KVector1.Scalar3;
        }
        
        if (!mv2.KVector2.IsZero())
        {
            tempScalar[1] += -mv1.Scalar123 * mv2.KVector2.Scalar23 - mv1.Scalar124 * mv2.KVector2.Scalar24 - mv1.Scalar134 * mv2.KVector2.Scalar34 - mv1.Scalar125 * mv2.KVector2.Scalar25 - mv1.Scalar135 * mv2.KVector2.Scalar35 - mv1.Scalar145 * mv2.KVector2.Scalar45;
            tempScalar[2] += mv1.Scalar123 * mv2.KVector2.Scalar13 + mv1.Scalar124 * mv2.KVector2.Scalar14 - mv1.Scalar234 * mv2.KVector2.Scalar34 + mv1.Scalar125 * mv2.KVector2.Scalar15 - mv1.Scalar235 * mv2.KVector2.Scalar35 - mv1.Scalar245 * mv2.KVector2.Scalar45;
            tempScalar[4] += -mv1.Scalar123 * mv2.KVector2.Scalar12 + mv1.Scalar134 * mv2.KVector2.Scalar14 + mv1.Scalar234 * mv2.KVector2.Scalar24 + mv1.Scalar135 * mv2.KVector2.Scalar15 + mv1.Scalar235 * mv2.KVector2.Scalar25 - mv1.Scalar345 * mv2.KVector2.Scalar45;
            tempScalar[8] += -mv1.Scalar124 * mv2.KVector2.Scalar12 - mv1.Scalar134 * mv2.KVector2.Scalar13 - mv1.Scalar234 * mv2.KVector2.Scalar23 + mv1.Scalar145 * mv2.KVector2.Scalar15 + mv1.Scalar245 * mv2.KVector2.Scalar25 + mv1.Scalar345 * mv2.KVector2.Scalar35;
            tempScalar[16] += -mv1.Scalar125 * mv2.KVector2.Scalar12 - mv1.Scalar135 * mv2.KVector2.Scalar13 - mv1.Scalar235 * mv2.KVector2.Scalar23 - mv1.Scalar145 * mv2.KVector2.Scalar14 - mv1.Scalar245 * mv2.KVector2.Scalar24 - mv1.Scalar345 * mv2.KVector2.Scalar34;
        }
        
        if (!mv2.KVector3.IsZero())
        {
            tempScalar[0] += -mv1.Scalar123 * mv2.KVector3.Scalar123 - mv1.Scalar124 * mv2.KVector3.Scalar124 - mv1.Scalar134 * mv2.KVector3.Scalar134 - mv1.Scalar234 * mv2.KVector3.Scalar234 - mv1.Scalar125 * mv2.KVector3.Scalar125 - mv1.Scalar135 * mv2.KVector3.Scalar135 - mv1.Scalar235 * mv2.KVector3.Scalar235 - mv1.Scalar145 * mv2.KVector3.Scalar145 - mv1.Scalar245 * mv2.KVector3.Scalar245 - mv1.Scalar345 * mv2.KVector3.Scalar345;
        }
        
        return Ga5Multivector.Create(tempScalar);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga5KVector4 Rcp(this Ga5KVector4 mv1, Ga5KVector0 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga5KVector4.Zero;
        
        return new Ga5KVector4
        {
            Scalar1234 = mv1.Scalar1234 * mv2.Scalar,
            Scalar1235 = mv1.Scalar1235 * mv2.Scalar,
            Scalar1245 = mv1.Scalar1245 * mv2.Scalar,
            Scalar1345 = mv1.Scalar1345 * mv2.Scalar,
            Scalar2345 = mv1.Scalar2345 * mv2.Scalar
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga5KVector3 Rcp(this Ga5KVector4 mv1, Ga5KVector1 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga5KVector3.Zero;
        
        return new Ga5KVector3
        {
            Scalar123 = mv1.Scalar1234 * mv2.Scalar4 + mv1.Scalar1235 * mv2.Scalar5,
            Scalar124 = -mv1.Scalar1234 * mv2.Scalar3 + mv1.Scalar1245 * mv2.Scalar5,
            Scalar134 = mv1.Scalar1234 * mv2.Scalar2 + mv1.Scalar1345 * mv2.Scalar5,
            Scalar234 = -mv1.Scalar1234 * mv2.Scalar1 + mv1.Scalar2345 * mv2.Scalar5,
            Scalar125 = -mv1.Scalar1235 * mv2.Scalar3 - mv1.Scalar1245 * mv2.Scalar4,
            Scalar135 = mv1.Scalar1235 * mv2.Scalar2 - mv1.Scalar1345 * mv2.Scalar4,
            Scalar235 = -mv1.Scalar1235 * mv2.Scalar1 - mv1.Scalar2345 * mv2.Scalar4,
            Scalar145 = mv1.Scalar1245 * mv2.Scalar2 + mv1.Scalar1345 * mv2.Scalar3,
            Scalar245 = -mv1.Scalar1245 * mv2.Scalar1 + mv1.Scalar2345 * mv2.Scalar3,
            Scalar345 = -mv1.Scalar1345 * mv2.Scalar1 - mv1.Scalar2345 * mv2.Scalar2
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga5KVector2 Rcp(this Ga5KVector4 mv1, Ga5KVector2 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga5KVector2.Zero;
        
        return new Ga5KVector2
        {
            Scalar12 = -mv1.Scalar1234 * mv2.Scalar34 - mv1.Scalar1235 * mv2.Scalar35 - mv1.Scalar1245 * mv2.Scalar45,
            Scalar13 = mv1.Scalar1234 * mv2.Scalar24 + mv1.Scalar1235 * mv2.Scalar25 - mv1.Scalar1345 * mv2.Scalar45,
            Scalar23 = -mv1.Scalar1234 * mv2.Scalar14 - mv1.Scalar1235 * mv2.Scalar15 - mv1.Scalar2345 * mv2.Scalar45,
            Scalar14 = -mv1.Scalar1234 * mv2.Scalar23 + mv1.Scalar1245 * mv2.Scalar25 + mv1.Scalar1345 * mv2.Scalar35,
            Scalar24 = mv1.Scalar1234 * mv2.Scalar13 - mv1.Scalar1245 * mv2.Scalar15 + mv1.Scalar2345 * mv2.Scalar35,
            Scalar34 = -mv1.Scalar1234 * mv2.Scalar12 - mv1.Scalar1345 * mv2.Scalar15 - mv1.Scalar2345 * mv2.Scalar25,
            Scalar15 = -mv1.Scalar1235 * mv2.Scalar23 - mv1.Scalar1245 * mv2.Scalar24 - mv1.Scalar1345 * mv2.Scalar34,
            Scalar25 = mv1.Scalar1235 * mv2.Scalar13 + mv1.Scalar1245 * mv2.Scalar14 - mv1.Scalar2345 * mv2.Scalar34,
            Scalar35 = -mv1.Scalar1235 * mv2.Scalar12 + mv1.Scalar1345 * mv2.Scalar14 + mv1.Scalar2345 * mv2.Scalar24,
            Scalar45 = -mv1.Scalar1245 * mv2.Scalar12 - mv1.Scalar1345 * mv2.Scalar13 - mv1.Scalar2345 * mv2.Scalar23
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga5KVector1 Rcp(this Ga5KVector4 mv1, Ga5KVector3 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga5KVector1.Zero;
        
        return new Ga5KVector1
        {
            Scalar1 = -mv1.Scalar1234 * mv2.Scalar234 - mv1.Scalar1235 * mv2.Scalar235 - mv1.Scalar1245 * mv2.Scalar245 - mv1.Scalar1345 * mv2.Scalar345,
            Scalar2 = mv1.Scalar1234 * mv2.Scalar134 + mv1.Scalar1235 * mv2.Scalar135 + mv1.Scalar1245 * mv2.Scalar145 - mv1.Scalar2345 * mv2.Scalar345,
            Scalar3 = -mv1.Scalar1234 * mv2.Scalar124 - mv1.Scalar1235 * mv2.Scalar125 + mv1.Scalar1345 * mv2.Scalar145 + mv1.Scalar2345 * mv2.Scalar245,
            Scalar4 = mv1.Scalar1234 * mv2.Scalar123 - mv1.Scalar1245 * mv2.Scalar125 - mv1.Scalar1345 * mv2.Scalar135 - mv1.Scalar2345 * mv2.Scalar235,
            Scalar5 = mv1.Scalar1235 * mv2.Scalar123 + mv1.Scalar1245 * mv2.Scalar124 + mv1.Scalar1345 * mv2.Scalar134 + mv1.Scalar2345 * mv2.Scalar234
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga5KVector0 Rcp(this Ga5KVector4 mv1, Ga5KVector4 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga5KVector0.Zero;
        
        return new Ga5KVector0
        {
            Scalar = mv1.Scalar1234 * mv2.Scalar1234 + mv1.Scalar1235 * mv2.Scalar1235 + mv1.Scalar1245 * mv2.Scalar1245 + mv1.Scalar1345 * mv2.Scalar1345 + mv1.Scalar2345 * mv2.Scalar2345
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga5KVector0 Rcp(this Ga5KVector4 mv1, Ga5KVector5 mv2)
    {
        return Ga5KVector0.Zero;
    }
    
    public static Ga5Multivector Rcp(this Ga5KVector4 mv1, Ga5Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga5Multivector.Zero;
        
        var tempScalar = new double[32];
        
        if (!mv2.KVector0.IsZero())
        {
            tempScalar[15] += mv1.Scalar1234 * mv2.KVector0.Scalar;
            tempScalar[23] += mv1.Scalar1235 * mv2.KVector0.Scalar;
            tempScalar[27] += mv1.Scalar1245 * mv2.KVector0.Scalar;
            tempScalar[29] += mv1.Scalar1345 * mv2.KVector0.Scalar;
            tempScalar[30] += mv1.Scalar2345 * mv2.KVector0.Scalar;
        }
        
        if (!mv2.KVector1.IsZero())
        {
            tempScalar[7] += mv1.Scalar1234 * mv2.KVector1.Scalar4 + mv1.Scalar1235 * mv2.KVector1.Scalar5;
            tempScalar[11] += -mv1.Scalar1234 * mv2.KVector1.Scalar3 + mv1.Scalar1245 * mv2.KVector1.Scalar5;
            tempScalar[13] += mv1.Scalar1234 * mv2.KVector1.Scalar2 + mv1.Scalar1345 * mv2.KVector1.Scalar5;
            tempScalar[14] += -mv1.Scalar1234 * mv2.KVector1.Scalar1 + mv1.Scalar2345 * mv2.KVector1.Scalar5;
            tempScalar[19] += -mv1.Scalar1235 * mv2.KVector1.Scalar3 - mv1.Scalar1245 * mv2.KVector1.Scalar4;
            tempScalar[21] += mv1.Scalar1235 * mv2.KVector1.Scalar2 - mv1.Scalar1345 * mv2.KVector1.Scalar4;
            tempScalar[22] += -mv1.Scalar1235 * mv2.KVector1.Scalar1 - mv1.Scalar2345 * mv2.KVector1.Scalar4;
            tempScalar[25] += mv1.Scalar1245 * mv2.KVector1.Scalar2 + mv1.Scalar1345 * mv2.KVector1.Scalar3;
            tempScalar[26] += -mv1.Scalar1245 * mv2.KVector1.Scalar1 + mv1.Scalar2345 * mv2.KVector1.Scalar3;
            tempScalar[28] += -mv1.Scalar1345 * mv2.KVector1.Scalar1 - mv1.Scalar2345 * mv2.KVector1.Scalar2;
        }
        
        if (!mv2.KVector2.IsZero())
        {
            tempScalar[3] += -mv1.Scalar1234 * mv2.KVector2.Scalar34 - mv1.Scalar1235 * mv2.KVector2.Scalar35 - mv1.Scalar1245 * mv2.KVector2.Scalar45;
            tempScalar[5] += mv1.Scalar1234 * mv2.KVector2.Scalar24 + mv1.Scalar1235 * mv2.KVector2.Scalar25 - mv1.Scalar1345 * mv2.KVector2.Scalar45;
            tempScalar[6] += -mv1.Scalar1234 * mv2.KVector2.Scalar14 - mv1.Scalar1235 * mv2.KVector2.Scalar15 - mv1.Scalar2345 * mv2.KVector2.Scalar45;
            tempScalar[9] += -mv1.Scalar1234 * mv2.KVector2.Scalar23 + mv1.Scalar1245 * mv2.KVector2.Scalar25 + mv1.Scalar1345 * mv2.KVector2.Scalar35;
            tempScalar[10] += mv1.Scalar1234 * mv2.KVector2.Scalar13 - mv1.Scalar1245 * mv2.KVector2.Scalar15 + mv1.Scalar2345 * mv2.KVector2.Scalar35;
            tempScalar[12] += -mv1.Scalar1234 * mv2.KVector2.Scalar12 - mv1.Scalar1345 * mv2.KVector2.Scalar15 - mv1.Scalar2345 * mv2.KVector2.Scalar25;
            tempScalar[17] += -mv1.Scalar1235 * mv2.KVector2.Scalar23 - mv1.Scalar1245 * mv2.KVector2.Scalar24 - mv1.Scalar1345 * mv2.KVector2.Scalar34;
            tempScalar[18] += mv1.Scalar1235 * mv2.KVector2.Scalar13 + mv1.Scalar1245 * mv2.KVector2.Scalar14 - mv1.Scalar2345 * mv2.KVector2.Scalar34;
            tempScalar[20] += -mv1.Scalar1235 * mv2.KVector2.Scalar12 + mv1.Scalar1345 * mv2.KVector2.Scalar14 + mv1.Scalar2345 * mv2.KVector2.Scalar24;
            tempScalar[24] += -mv1.Scalar1245 * mv2.KVector2.Scalar12 - mv1.Scalar1345 * mv2.KVector2.Scalar13 - mv1.Scalar2345 * mv2.KVector2.Scalar23;
        }
        
        if (!mv2.KVector3.IsZero())
        {
            tempScalar[1] += -mv1.Scalar1234 * mv2.KVector3.Scalar234 - mv1.Scalar1235 * mv2.KVector3.Scalar235 - mv1.Scalar1245 * mv2.KVector3.Scalar245 - mv1.Scalar1345 * mv2.KVector3.Scalar345;
            tempScalar[2] += mv1.Scalar1234 * mv2.KVector3.Scalar134 + mv1.Scalar1235 * mv2.KVector3.Scalar135 + mv1.Scalar1245 * mv2.KVector3.Scalar145 - mv1.Scalar2345 * mv2.KVector3.Scalar345;
            tempScalar[4] += -mv1.Scalar1234 * mv2.KVector3.Scalar124 - mv1.Scalar1235 * mv2.KVector3.Scalar125 + mv1.Scalar1345 * mv2.KVector3.Scalar145 + mv1.Scalar2345 * mv2.KVector3.Scalar245;
            tempScalar[8] += mv1.Scalar1234 * mv2.KVector3.Scalar123 - mv1.Scalar1245 * mv2.KVector3.Scalar125 - mv1.Scalar1345 * mv2.KVector3.Scalar135 - mv1.Scalar2345 * mv2.KVector3.Scalar235;
            tempScalar[16] += mv1.Scalar1235 * mv2.KVector3.Scalar123 + mv1.Scalar1245 * mv2.KVector3.Scalar124 + mv1.Scalar1345 * mv2.KVector3.Scalar134 + mv1.Scalar2345 * mv2.KVector3.Scalar234;
        }
        
        if (!mv2.KVector4.IsZero())
        {
            tempScalar[0] += mv1.Scalar1234 * mv2.KVector4.Scalar1234 + mv1.Scalar1235 * mv2.KVector4.Scalar1235 + mv1.Scalar1245 * mv2.KVector4.Scalar1245 + mv1.Scalar1345 * mv2.KVector4.Scalar1345 + mv1.Scalar2345 * mv2.KVector4.Scalar2345;
        }
        
        return Ga5Multivector.Create(tempScalar);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga5KVector5 Rcp(this Ga5KVector5 mv1, Ga5KVector0 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga5KVector5.Zero;
        
        return new Ga5KVector5
        {
            Scalar12345 = mv1.Scalar12345 * mv2.Scalar
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga5KVector4 Rcp(this Ga5KVector5 mv1, Ga5KVector1 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga5KVector4.Zero;
        
        return new Ga5KVector4
        {
            Scalar1234 = mv1.Scalar12345 * mv2.Scalar5,
            Scalar1235 = -mv1.Scalar12345 * mv2.Scalar4,
            Scalar1245 = mv1.Scalar12345 * mv2.Scalar3,
            Scalar1345 = -mv1.Scalar12345 * mv2.Scalar2,
            Scalar2345 = mv1.Scalar12345 * mv2.Scalar1
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga5KVector3 Rcp(this Ga5KVector5 mv1, Ga5KVector2 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga5KVector3.Zero;
        
        return new Ga5KVector3
        {
            Scalar123 = -mv1.Scalar12345 * mv2.Scalar45,
            Scalar124 = mv1.Scalar12345 * mv2.Scalar35,
            Scalar134 = -mv1.Scalar12345 * mv2.Scalar25,
            Scalar234 = mv1.Scalar12345 * mv2.Scalar15,
            Scalar125 = -mv1.Scalar12345 * mv2.Scalar34,
            Scalar135 = mv1.Scalar12345 * mv2.Scalar24,
            Scalar235 = -mv1.Scalar12345 * mv2.Scalar14,
            Scalar145 = -mv1.Scalar12345 * mv2.Scalar23,
            Scalar245 = mv1.Scalar12345 * mv2.Scalar13,
            Scalar345 = -mv1.Scalar12345 * mv2.Scalar12
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga5KVector2 Rcp(this Ga5KVector5 mv1, Ga5KVector3 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga5KVector2.Zero;
        
        return new Ga5KVector2
        {
            Scalar12 = -mv1.Scalar12345 * mv2.Scalar345,
            Scalar13 = mv1.Scalar12345 * mv2.Scalar245,
            Scalar23 = -mv1.Scalar12345 * mv2.Scalar145,
            Scalar14 = -mv1.Scalar12345 * mv2.Scalar235,
            Scalar24 = mv1.Scalar12345 * mv2.Scalar135,
            Scalar34 = -mv1.Scalar12345 * mv2.Scalar125,
            Scalar15 = mv1.Scalar12345 * mv2.Scalar234,
            Scalar25 = -mv1.Scalar12345 * mv2.Scalar134,
            Scalar35 = mv1.Scalar12345 * mv2.Scalar124,
            Scalar45 = -mv1.Scalar12345 * mv2.Scalar123
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga5KVector1 Rcp(this Ga5KVector5 mv1, Ga5KVector4 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga5KVector1.Zero;
        
        return new Ga5KVector1
        {
            Scalar1 = mv1.Scalar12345 * mv2.Scalar2345,
            Scalar2 = -mv1.Scalar12345 * mv2.Scalar1345,
            Scalar3 = mv1.Scalar12345 * mv2.Scalar1245,
            Scalar4 = -mv1.Scalar12345 * mv2.Scalar1235,
            Scalar5 = mv1.Scalar12345 * mv2.Scalar1234
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga5KVector0 Rcp(this Ga5KVector5 mv1, Ga5KVector5 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga5KVector0.Zero;
        
        return new Ga5KVector0
        {
            Scalar = mv1.Scalar12345 * mv2.Scalar12345
        };
    }
    
    public static Ga5Multivector Rcp(this Ga5KVector5 mv1, Ga5Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga5Multivector.Zero;
        
        var tempScalar = new double[32];
        
        if (!mv2.KVector0.IsZero())
        {
            tempScalar[31] += mv1.Scalar12345 * mv2.KVector0.Scalar;
        }
        
        if (!mv2.KVector1.IsZero())
        {
            tempScalar[15] += mv1.Scalar12345 * mv2.KVector1.Scalar5;
            tempScalar[23] += -mv1.Scalar12345 * mv2.KVector1.Scalar4;
            tempScalar[27] += mv1.Scalar12345 * mv2.KVector1.Scalar3;
            tempScalar[29] += -mv1.Scalar12345 * mv2.KVector1.Scalar2;
            tempScalar[30] += mv1.Scalar12345 * mv2.KVector1.Scalar1;
        }
        
        if (!mv2.KVector2.IsZero())
        {
            tempScalar[7] += -mv1.Scalar12345 * mv2.KVector2.Scalar45;
            tempScalar[11] += mv1.Scalar12345 * mv2.KVector2.Scalar35;
            tempScalar[13] += -mv1.Scalar12345 * mv2.KVector2.Scalar25;
            tempScalar[14] += mv1.Scalar12345 * mv2.KVector2.Scalar15;
            tempScalar[19] += -mv1.Scalar12345 * mv2.KVector2.Scalar34;
            tempScalar[21] += mv1.Scalar12345 * mv2.KVector2.Scalar24;
            tempScalar[22] += -mv1.Scalar12345 * mv2.KVector2.Scalar14;
            tempScalar[25] += -mv1.Scalar12345 * mv2.KVector2.Scalar23;
            tempScalar[26] += mv1.Scalar12345 * mv2.KVector2.Scalar13;
            tempScalar[28] += -mv1.Scalar12345 * mv2.KVector2.Scalar12;
        }
        
        if (!mv2.KVector3.IsZero())
        {
            tempScalar[3] += -mv1.Scalar12345 * mv2.KVector3.Scalar345;
            tempScalar[5] += mv1.Scalar12345 * mv2.KVector3.Scalar245;
            tempScalar[6] += -mv1.Scalar12345 * mv2.KVector3.Scalar145;
            tempScalar[9] += -mv1.Scalar12345 * mv2.KVector3.Scalar235;
            tempScalar[10] += mv1.Scalar12345 * mv2.KVector3.Scalar135;
            tempScalar[12] += -mv1.Scalar12345 * mv2.KVector3.Scalar125;
            tempScalar[17] += mv1.Scalar12345 * mv2.KVector3.Scalar234;
            tempScalar[18] += -mv1.Scalar12345 * mv2.KVector3.Scalar134;
            tempScalar[20] += mv1.Scalar12345 * mv2.KVector3.Scalar124;
            tempScalar[24] += -mv1.Scalar12345 * mv2.KVector3.Scalar123;
        }
        
        if (!mv2.KVector4.IsZero())
        {
            tempScalar[1] += mv1.Scalar12345 * mv2.KVector4.Scalar2345;
            tempScalar[2] += -mv1.Scalar12345 * mv2.KVector4.Scalar1345;
            tempScalar[4] += mv1.Scalar12345 * mv2.KVector4.Scalar1245;
            tempScalar[8] += -mv1.Scalar12345 * mv2.KVector4.Scalar1235;
            tempScalar[16] += mv1.Scalar12345 * mv2.KVector4.Scalar1234;
        }
        
        if (!mv2.KVector5.IsZero())
        {
            tempScalar[0] += mv1.Scalar12345 * mv2.KVector5.Scalar12345;
        }
        
        return Ga5Multivector.Create(tempScalar);
    }
    
    public static Ga5Multivector Rcp(this Ga5Multivector mv1, Ga5KVector0 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga5Multivector.Zero;
        
        var tempScalar = new double[32];
        
        if (!mv1.KVector0.IsZero())
        {
            tempScalar[0] += mv1.KVector0.Scalar * mv2.Scalar;
        }
        
        if (!mv1.KVector1.IsZero())
        {
            tempScalar[1] += mv1.KVector1.Scalar1 * mv2.Scalar;
            tempScalar[2] += mv1.KVector1.Scalar2 * mv2.Scalar;
            tempScalar[4] += mv1.KVector1.Scalar3 * mv2.Scalar;
            tempScalar[8] += mv1.KVector1.Scalar4 * mv2.Scalar;
            tempScalar[16] += mv1.KVector1.Scalar5 * mv2.Scalar;
        }
        
        if (!mv1.KVector2.IsZero())
        {
            tempScalar[3] += mv1.KVector2.Scalar12 * mv2.Scalar;
            tempScalar[5] += mv1.KVector2.Scalar13 * mv2.Scalar;
            tempScalar[6] += mv1.KVector2.Scalar23 * mv2.Scalar;
            tempScalar[9] += mv1.KVector2.Scalar14 * mv2.Scalar;
            tempScalar[10] += mv1.KVector2.Scalar24 * mv2.Scalar;
            tempScalar[12] += mv1.KVector2.Scalar34 * mv2.Scalar;
            tempScalar[17] += mv1.KVector2.Scalar15 * mv2.Scalar;
            tempScalar[18] += mv1.KVector2.Scalar25 * mv2.Scalar;
            tempScalar[20] += mv1.KVector2.Scalar35 * mv2.Scalar;
            tempScalar[24] += mv1.KVector2.Scalar45 * mv2.Scalar;
        }
        
        if (!mv1.KVector3.IsZero())
        {
            tempScalar[7] += mv1.KVector3.Scalar123 * mv2.Scalar;
            tempScalar[11] += mv1.KVector3.Scalar124 * mv2.Scalar;
            tempScalar[13] += mv1.KVector3.Scalar134 * mv2.Scalar;
            tempScalar[14] += mv1.KVector3.Scalar234 * mv2.Scalar;
            tempScalar[19] += mv1.KVector3.Scalar125 * mv2.Scalar;
            tempScalar[21] += mv1.KVector3.Scalar135 * mv2.Scalar;
            tempScalar[22] += mv1.KVector3.Scalar235 * mv2.Scalar;
            tempScalar[25] += mv1.KVector3.Scalar145 * mv2.Scalar;
            tempScalar[26] += mv1.KVector3.Scalar245 * mv2.Scalar;
            tempScalar[28] += mv1.KVector3.Scalar345 * mv2.Scalar;
        }
        
        if (!mv1.KVector4.IsZero())
        {
            tempScalar[15] += mv1.KVector4.Scalar1234 * mv2.Scalar;
            tempScalar[23] += mv1.KVector4.Scalar1235 * mv2.Scalar;
            tempScalar[27] += mv1.KVector4.Scalar1245 * mv2.Scalar;
            tempScalar[29] += mv1.KVector4.Scalar1345 * mv2.Scalar;
            tempScalar[30] += mv1.KVector4.Scalar2345 * mv2.Scalar;
        }
        
        if (!mv1.KVector5.IsZero())
        {
            tempScalar[31] += mv1.KVector5.Scalar12345 * mv2.Scalar;
        }
        
        return Ga5Multivector.Create(tempScalar);
    }
    
    public static Ga5Multivector Rcp(this Ga5Multivector mv1, Ga5KVector1 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga5Multivector.Zero;
        
        var tempScalar = new double[32];
        
        if (!mv1.KVector1.IsZero())
        {
            tempScalar[0] += mv1.KVector1.Scalar1 * mv2.Scalar1 + mv1.KVector1.Scalar2 * mv2.Scalar2 + mv1.KVector1.Scalar3 * mv2.Scalar3 + mv1.KVector1.Scalar4 * mv2.Scalar4 + mv1.KVector1.Scalar5 * mv2.Scalar5;
        }
        
        if (!mv1.KVector2.IsZero())
        {
            tempScalar[1] += mv1.KVector2.Scalar12 * mv2.Scalar2 + mv1.KVector2.Scalar13 * mv2.Scalar3 + mv1.KVector2.Scalar14 * mv2.Scalar4 + mv1.KVector2.Scalar15 * mv2.Scalar5;
            tempScalar[2] += -mv1.KVector2.Scalar12 * mv2.Scalar1 + mv1.KVector2.Scalar23 * mv2.Scalar3 + mv1.KVector2.Scalar24 * mv2.Scalar4 + mv1.KVector2.Scalar25 * mv2.Scalar5;
            tempScalar[4] += -mv1.KVector2.Scalar13 * mv2.Scalar1 - mv1.KVector2.Scalar23 * mv2.Scalar2 + mv1.KVector2.Scalar34 * mv2.Scalar4 + mv1.KVector2.Scalar35 * mv2.Scalar5;
            tempScalar[8] += -mv1.KVector2.Scalar14 * mv2.Scalar1 - mv1.KVector2.Scalar24 * mv2.Scalar2 - mv1.KVector2.Scalar34 * mv2.Scalar3 + mv1.KVector2.Scalar45 * mv2.Scalar5;
            tempScalar[16] += -mv1.KVector2.Scalar15 * mv2.Scalar1 - mv1.KVector2.Scalar25 * mv2.Scalar2 - mv1.KVector2.Scalar35 * mv2.Scalar3 - mv1.KVector2.Scalar45 * mv2.Scalar4;
        }
        
        if (!mv1.KVector3.IsZero())
        {
            tempScalar[3] += mv1.KVector3.Scalar123 * mv2.Scalar3 + mv1.KVector3.Scalar124 * mv2.Scalar4 + mv1.KVector3.Scalar125 * mv2.Scalar5;
            tempScalar[5] += -mv1.KVector3.Scalar123 * mv2.Scalar2 + mv1.KVector3.Scalar134 * mv2.Scalar4 + mv1.KVector3.Scalar135 * mv2.Scalar5;
            tempScalar[6] += mv1.KVector3.Scalar123 * mv2.Scalar1 + mv1.KVector3.Scalar234 * mv2.Scalar4 + mv1.KVector3.Scalar235 * mv2.Scalar5;
            tempScalar[9] += -mv1.KVector3.Scalar124 * mv2.Scalar2 - mv1.KVector3.Scalar134 * mv2.Scalar3 + mv1.KVector3.Scalar145 * mv2.Scalar5;
            tempScalar[10] += mv1.KVector3.Scalar124 * mv2.Scalar1 - mv1.KVector3.Scalar234 * mv2.Scalar3 + mv1.KVector3.Scalar245 * mv2.Scalar5;
            tempScalar[12] += mv1.KVector3.Scalar134 * mv2.Scalar1 + mv1.KVector3.Scalar234 * mv2.Scalar2 + mv1.KVector3.Scalar345 * mv2.Scalar5;
            tempScalar[17] += -mv1.KVector3.Scalar125 * mv2.Scalar2 - mv1.KVector3.Scalar135 * mv2.Scalar3 - mv1.KVector3.Scalar145 * mv2.Scalar4;
            tempScalar[18] += mv1.KVector3.Scalar125 * mv2.Scalar1 - mv1.KVector3.Scalar235 * mv2.Scalar3 - mv1.KVector3.Scalar245 * mv2.Scalar4;
            tempScalar[20] += mv1.KVector3.Scalar135 * mv2.Scalar1 + mv1.KVector3.Scalar235 * mv2.Scalar2 - mv1.KVector3.Scalar345 * mv2.Scalar4;
            tempScalar[24] += mv1.KVector3.Scalar145 * mv2.Scalar1 + mv1.KVector3.Scalar245 * mv2.Scalar2 + mv1.KVector3.Scalar345 * mv2.Scalar3;
        }
        
        if (!mv1.KVector4.IsZero())
        {
            tempScalar[7] += mv1.KVector4.Scalar1234 * mv2.Scalar4 + mv1.KVector4.Scalar1235 * mv2.Scalar5;
            tempScalar[11] += -mv1.KVector4.Scalar1234 * mv2.Scalar3 + mv1.KVector4.Scalar1245 * mv2.Scalar5;
            tempScalar[13] += mv1.KVector4.Scalar1234 * mv2.Scalar2 + mv1.KVector4.Scalar1345 * mv2.Scalar5;
            tempScalar[14] += -mv1.KVector4.Scalar1234 * mv2.Scalar1 + mv1.KVector4.Scalar2345 * mv2.Scalar5;
            tempScalar[19] += -mv1.KVector4.Scalar1235 * mv2.Scalar3 - mv1.KVector4.Scalar1245 * mv2.Scalar4;
            tempScalar[21] += mv1.KVector4.Scalar1235 * mv2.Scalar2 - mv1.KVector4.Scalar1345 * mv2.Scalar4;
            tempScalar[22] += -mv1.KVector4.Scalar1235 * mv2.Scalar1 - mv1.KVector4.Scalar2345 * mv2.Scalar4;
            tempScalar[25] += mv1.KVector4.Scalar1245 * mv2.Scalar2 + mv1.KVector4.Scalar1345 * mv2.Scalar3;
            tempScalar[26] += -mv1.KVector4.Scalar1245 * mv2.Scalar1 + mv1.KVector4.Scalar2345 * mv2.Scalar3;
            tempScalar[28] += -mv1.KVector4.Scalar1345 * mv2.Scalar1 - mv1.KVector4.Scalar2345 * mv2.Scalar2;
        }
        
        if (!mv1.KVector5.IsZero())
        {
            tempScalar[15] += mv1.KVector5.Scalar12345 * mv2.Scalar5;
            tempScalar[23] += -mv1.KVector5.Scalar12345 * mv2.Scalar4;
            tempScalar[27] += mv1.KVector5.Scalar12345 * mv2.Scalar3;
            tempScalar[29] += -mv1.KVector5.Scalar12345 * mv2.Scalar2;
            tempScalar[30] += mv1.KVector5.Scalar12345 * mv2.Scalar1;
        }
        
        return Ga5Multivector.Create(tempScalar);
    }
    
    public static Ga5Multivector Rcp(this Ga5Multivector mv1, Ga5KVector2 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga5Multivector.Zero;
        
        var tempScalar = new double[32];
        
        if (!mv1.KVector2.IsZero())
        {
            tempScalar[0] += -mv1.KVector2.Scalar12 * mv2.Scalar12 - mv1.KVector2.Scalar13 * mv2.Scalar13 - mv1.KVector2.Scalar23 * mv2.Scalar23 - mv1.KVector2.Scalar14 * mv2.Scalar14 - mv1.KVector2.Scalar24 * mv2.Scalar24 - mv1.KVector2.Scalar34 * mv2.Scalar34 - mv1.KVector2.Scalar15 * mv2.Scalar15 - mv1.KVector2.Scalar25 * mv2.Scalar25 - mv1.KVector2.Scalar35 * mv2.Scalar35 - mv1.KVector2.Scalar45 * mv2.Scalar45;
        }
        
        if (!mv1.KVector3.IsZero())
        {
            tempScalar[1] += -mv1.KVector3.Scalar123 * mv2.Scalar23 - mv1.KVector3.Scalar124 * mv2.Scalar24 - mv1.KVector3.Scalar134 * mv2.Scalar34 - mv1.KVector3.Scalar125 * mv2.Scalar25 - mv1.KVector3.Scalar135 * mv2.Scalar35 - mv1.KVector3.Scalar145 * mv2.Scalar45;
            tempScalar[2] += mv1.KVector3.Scalar123 * mv2.Scalar13 + mv1.KVector3.Scalar124 * mv2.Scalar14 - mv1.KVector3.Scalar234 * mv2.Scalar34 + mv1.KVector3.Scalar125 * mv2.Scalar15 - mv1.KVector3.Scalar235 * mv2.Scalar35 - mv1.KVector3.Scalar245 * mv2.Scalar45;
            tempScalar[4] += -mv1.KVector3.Scalar123 * mv2.Scalar12 + mv1.KVector3.Scalar134 * mv2.Scalar14 + mv1.KVector3.Scalar234 * mv2.Scalar24 + mv1.KVector3.Scalar135 * mv2.Scalar15 + mv1.KVector3.Scalar235 * mv2.Scalar25 - mv1.KVector3.Scalar345 * mv2.Scalar45;
            tempScalar[8] += -mv1.KVector3.Scalar124 * mv2.Scalar12 - mv1.KVector3.Scalar134 * mv2.Scalar13 - mv1.KVector3.Scalar234 * mv2.Scalar23 + mv1.KVector3.Scalar145 * mv2.Scalar15 + mv1.KVector3.Scalar245 * mv2.Scalar25 + mv1.KVector3.Scalar345 * mv2.Scalar35;
            tempScalar[16] += -mv1.KVector3.Scalar125 * mv2.Scalar12 - mv1.KVector3.Scalar135 * mv2.Scalar13 - mv1.KVector3.Scalar235 * mv2.Scalar23 - mv1.KVector3.Scalar145 * mv2.Scalar14 - mv1.KVector3.Scalar245 * mv2.Scalar24 - mv1.KVector3.Scalar345 * mv2.Scalar34;
        }
        
        if (!mv1.KVector4.IsZero())
        {
            tempScalar[3] += -mv1.KVector4.Scalar1234 * mv2.Scalar34 - mv1.KVector4.Scalar1235 * mv2.Scalar35 - mv1.KVector4.Scalar1245 * mv2.Scalar45;
            tempScalar[5] += mv1.KVector4.Scalar1234 * mv2.Scalar24 + mv1.KVector4.Scalar1235 * mv2.Scalar25 - mv1.KVector4.Scalar1345 * mv2.Scalar45;
            tempScalar[6] += -mv1.KVector4.Scalar1234 * mv2.Scalar14 - mv1.KVector4.Scalar1235 * mv2.Scalar15 - mv1.KVector4.Scalar2345 * mv2.Scalar45;
            tempScalar[9] += -mv1.KVector4.Scalar1234 * mv2.Scalar23 + mv1.KVector4.Scalar1245 * mv2.Scalar25 + mv1.KVector4.Scalar1345 * mv2.Scalar35;
            tempScalar[10] += mv1.KVector4.Scalar1234 * mv2.Scalar13 - mv1.KVector4.Scalar1245 * mv2.Scalar15 + mv1.KVector4.Scalar2345 * mv2.Scalar35;
            tempScalar[12] += -mv1.KVector4.Scalar1234 * mv2.Scalar12 - mv1.KVector4.Scalar1345 * mv2.Scalar15 - mv1.KVector4.Scalar2345 * mv2.Scalar25;
            tempScalar[17] += -mv1.KVector4.Scalar1235 * mv2.Scalar23 - mv1.KVector4.Scalar1245 * mv2.Scalar24 - mv1.KVector4.Scalar1345 * mv2.Scalar34;
            tempScalar[18] += mv1.KVector4.Scalar1235 * mv2.Scalar13 + mv1.KVector4.Scalar1245 * mv2.Scalar14 - mv1.KVector4.Scalar2345 * mv2.Scalar34;
            tempScalar[20] += -mv1.KVector4.Scalar1235 * mv2.Scalar12 + mv1.KVector4.Scalar1345 * mv2.Scalar14 + mv1.KVector4.Scalar2345 * mv2.Scalar24;
            tempScalar[24] += -mv1.KVector4.Scalar1245 * mv2.Scalar12 - mv1.KVector4.Scalar1345 * mv2.Scalar13 - mv1.KVector4.Scalar2345 * mv2.Scalar23;
        }
        
        if (!mv1.KVector5.IsZero())
        {
            tempScalar[7] += -mv1.KVector5.Scalar12345 * mv2.Scalar45;
            tempScalar[11] += mv1.KVector5.Scalar12345 * mv2.Scalar35;
            tempScalar[13] += -mv1.KVector5.Scalar12345 * mv2.Scalar25;
            tempScalar[14] += mv1.KVector5.Scalar12345 * mv2.Scalar15;
            tempScalar[19] += -mv1.KVector5.Scalar12345 * mv2.Scalar34;
            tempScalar[21] += mv1.KVector5.Scalar12345 * mv2.Scalar24;
            tempScalar[22] += -mv1.KVector5.Scalar12345 * mv2.Scalar14;
            tempScalar[25] += -mv1.KVector5.Scalar12345 * mv2.Scalar23;
            tempScalar[26] += mv1.KVector5.Scalar12345 * mv2.Scalar13;
            tempScalar[28] += -mv1.KVector5.Scalar12345 * mv2.Scalar12;
        }
        
        return Ga5Multivector.Create(tempScalar);
    }
    
    public static Ga5Multivector Rcp(this Ga5Multivector mv1, Ga5KVector3 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga5Multivector.Zero;
        
        var tempScalar = new double[32];
        
        if (!mv1.KVector3.IsZero())
        {
            tempScalar[0] += -mv1.KVector3.Scalar123 * mv2.Scalar123 - mv1.KVector3.Scalar124 * mv2.Scalar124 - mv1.KVector3.Scalar134 * mv2.Scalar134 - mv1.KVector3.Scalar234 * mv2.Scalar234 - mv1.KVector3.Scalar125 * mv2.Scalar125 - mv1.KVector3.Scalar135 * mv2.Scalar135 - mv1.KVector3.Scalar235 * mv2.Scalar235 - mv1.KVector3.Scalar145 * mv2.Scalar145 - mv1.KVector3.Scalar245 * mv2.Scalar245 - mv1.KVector3.Scalar345 * mv2.Scalar345;
        }
        
        if (!mv1.KVector4.IsZero())
        {
            tempScalar[1] += -mv1.KVector4.Scalar1234 * mv2.Scalar234 - mv1.KVector4.Scalar1235 * mv2.Scalar235 - mv1.KVector4.Scalar1245 * mv2.Scalar245 - mv1.KVector4.Scalar1345 * mv2.Scalar345;
            tempScalar[2] += mv1.KVector4.Scalar1234 * mv2.Scalar134 + mv1.KVector4.Scalar1235 * mv2.Scalar135 + mv1.KVector4.Scalar1245 * mv2.Scalar145 - mv1.KVector4.Scalar2345 * mv2.Scalar345;
            tempScalar[4] += -mv1.KVector4.Scalar1234 * mv2.Scalar124 - mv1.KVector4.Scalar1235 * mv2.Scalar125 + mv1.KVector4.Scalar1345 * mv2.Scalar145 + mv1.KVector4.Scalar2345 * mv2.Scalar245;
            tempScalar[8] += mv1.KVector4.Scalar1234 * mv2.Scalar123 - mv1.KVector4.Scalar1245 * mv2.Scalar125 - mv1.KVector4.Scalar1345 * mv2.Scalar135 - mv1.KVector4.Scalar2345 * mv2.Scalar235;
            tempScalar[16] += mv1.KVector4.Scalar1235 * mv2.Scalar123 + mv1.KVector4.Scalar1245 * mv2.Scalar124 + mv1.KVector4.Scalar1345 * mv2.Scalar134 + mv1.KVector4.Scalar2345 * mv2.Scalar234;
        }
        
        if (!mv1.KVector5.IsZero())
        {
            tempScalar[3] += -mv1.KVector5.Scalar12345 * mv2.Scalar345;
            tempScalar[5] += mv1.KVector5.Scalar12345 * mv2.Scalar245;
            tempScalar[6] += -mv1.KVector5.Scalar12345 * mv2.Scalar145;
            tempScalar[9] += -mv1.KVector5.Scalar12345 * mv2.Scalar235;
            tempScalar[10] += mv1.KVector5.Scalar12345 * mv2.Scalar135;
            tempScalar[12] += -mv1.KVector5.Scalar12345 * mv2.Scalar125;
            tempScalar[17] += mv1.KVector5.Scalar12345 * mv2.Scalar234;
            tempScalar[18] += -mv1.KVector5.Scalar12345 * mv2.Scalar134;
            tempScalar[20] += mv1.KVector5.Scalar12345 * mv2.Scalar124;
            tempScalar[24] += -mv1.KVector5.Scalar12345 * mv2.Scalar123;
        }
        
        return Ga5Multivector.Create(tempScalar);
    }
    
    public static Ga5Multivector Rcp(this Ga5Multivector mv1, Ga5KVector4 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga5Multivector.Zero;
        
        var tempScalar = new double[32];
        
        if (!mv1.KVector4.IsZero())
        {
            tempScalar[0] += mv1.KVector4.Scalar1234 * mv2.Scalar1234 + mv1.KVector4.Scalar1235 * mv2.Scalar1235 + mv1.KVector4.Scalar1245 * mv2.Scalar1245 + mv1.KVector4.Scalar1345 * mv2.Scalar1345 + mv1.KVector4.Scalar2345 * mv2.Scalar2345;
        }
        
        if (!mv1.KVector5.IsZero())
        {
            tempScalar[1] += mv1.KVector5.Scalar12345 * mv2.Scalar2345;
            tempScalar[2] += -mv1.KVector5.Scalar12345 * mv2.Scalar1345;
            tempScalar[4] += mv1.KVector5.Scalar12345 * mv2.Scalar1245;
            tempScalar[8] += -mv1.KVector5.Scalar12345 * mv2.Scalar1235;
            tempScalar[16] += mv1.KVector5.Scalar12345 * mv2.Scalar1234;
        }
        
        return Ga5Multivector.Create(tempScalar);
    }
    
    public static Ga5KVector0 Rcp(this Ga5Multivector mv1, Ga5KVector5 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga5KVector0.Zero;
        
        var tempScalar = 0d;
        
        if (!mv1.KVector5.IsZero())
        {
            tempScalar += mv1.KVector5.Scalar12345 * mv2.Scalar12345;
        }
        
        return new Ga5KVector0
        {
            Scalar = tempScalar
        };
    }
    
    public static Ga5Multivector Rcp(this Ga5Multivector mv1, Ga5Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga5Multivector.Zero;
        
        var tempScalar = new double[32];
        
        if (!mv1.KVector0.IsZero())
        {
            if (!mv2.KVector0.IsZero())
            {
                tempScalar[0] += mv1.KVector0.Scalar * mv2.KVector0.Scalar;
            }
            
        }
        
        if (!mv1.KVector1.IsZero())
        {
            if (!mv2.KVector0.IsZero())
            {
                tempScalar[1] += mv1.KVector1.Scalar1 * mv2.KVector0.Scalar;
                tempScalar[2] += mv1.KVector1.Scalar2 * mv2.KVector0.Scalar;
                tempScalar[4] += mv1.KVector1.Scalar3 * mv2.KVector0.Scalar;
                tempScalar[8] += mv1.KVector1.Scalar4 * mv2.KVector0.Scalar;
                tempScalar[16] += mv1.KVector1.Scalar5 * mv2.KVector0.Scalar;
            }
            
            if (!mv2.KVector1.IsZero())
            {
                tempScalar[0] += mv1.KVector1.Scalar1 * mv2.KVector1.Scalar1 + mv1.KVector1.Scalar2 * mv2.KVector1.Scalar2 + mv1.KVector1.Scalar3 * mv2.KVector1.Scalar3 + mv1.KVector1.Scalar4 * mv2.KVector1.Scalar4 + mv1.KVector1.Scalar5 * mv2.KVector1.Scalar5;
            }
            
        }
        
        if (!mv1.KVector2.IsZero())
        {
            if (!mv2.KVector0.IsZero())
            {
                tempScalar[3] += mv1.KVector2.Scalar12 * mv2.KVector0.Scalar;
                tempScalar[5] += mv1.KVector2.Scalar13 * mv2.KVector0.Scalar;
                tempScalar[6] += mv1.KVector2.Scalar23 * mv2.KVector0.Scalar;
                tempScalar[9] += mv1.KVector2.Scalar14 * mv2.KVector0.Scalar;
                tempScalar[10] += mv1.KVector2.Scalar24 * mv2.KVector0.Scalar;
                tempScalar[12] += mv1.KVector2.Scalar34 * mv2.KVector0.Scalar;
                tempScalar[17] += mv1.KVector2.Scalar15 * mv2.KVector0.Scalar;
                tempScalar[18] += mv1.KVector2.Scalar25 * mv2.KVector0.Scalar;
                tempScalar[20] += mv1.KVector2.Scalar35 * mv2.KVector0.Scalar;
                tempScalar[24] += mv1.KVector2.Scalar45 * mv2.KVector0.Scalar;
            }
            
            if (!mv2.KVector1.IsZero())
            {
                tempScalar[1] += mv1.KVector2.Scalar12 * mv2.KVector1.Scalar2 + mv1.KVector2.Scalar13 * mv2.KVector1.Scalar3 + mv1.KVector2.Scalar14 * mv2.KVector1.Scalar4 + mv1.KVector2.Scalar15 * mv2.KVector1.Scalar5;
                tempScalar[2] += -mv1.KVector2.Scalar12 * mv2.KVector1.Scalar1 + mv1.KVector2.Scalar23 * mv2.KVector1.Scalar3 + mv1.KVector2.Scalar24 * mv2.KVector1.Scalar4 + mv1.KVector2.Scalar25 * mv2.KVector1.Scalar5;
                tempScalar[4] += -mv1.KVector2.Scalar13 * mv2.KVector1.Scalar1 - mv1.KVector2.Scalar23 * mv2.KVector1.Scalar2 + mv1.KVector2.Scalar34 * mv2.KVector1.Scalar4 + mv1.KVector2.Scalar35 * mv2.KVector1.Scalar5;
                tempScalar[8] += -mv1.KVector2.Scalar14 * mv2.KVector1.Scalar1 - mv1.KVector2.Scalar24 * mv2.KVector1.Scalar2 - mv1.KVector2.Scalar34 * mv2.KVector1.Scalar3 + mv1.KVector2.Scalar45 * mv2.KVector1.Scalar5;
                tempScalar[16] += -mv1.KVector2.Scalar15 * mv2.KVector1.Scalar1 - mv1.KVector2.Scalar25 * mv2.KVector1.Scalar2 - mv1.KVector2.Scalar35 * mv2.KVector1.Scalar3 - mv1.KVector2.Scalar45 * mv2.KVector1.Scalar4;
            }
            
            if (!mv2.KVector2.IsZero())
            {
                tempScalar[0] += -mv1.KVector2.Scalar12 * mv2.KVector2.Scalar12 - mv1.KVector2.Scalar13 * mv2.KVector2.Scalar13 - mv1.KVector2.Scalar23 * mv2.KVector2.Scalar23 - mv1.KVector2.Scalar14 * mv2.KVector2.Scalar14 - mv1.KVector2.Scalar24 * mv2.KVector2.Scalar24 - mv1.KVector2.Scalar34 * mv2.KVector2.Scalar34 - mv1.KVector2.Scalar15 * mv2.KVector2.Scalar15 - mv1.KVector2.Scalar25 * mv2.KVector2.Scalar25 - mv1.KVector2.Scalar35 * mv2.KVector2.Scalar35 - mv1.KVector2.Scalar45 * mv2.KVector2.Scalar45;
            }
            
        }
        
        if (!mv1.KVector3.IsZero())
        {
            if (!mv2.KVector0.IsZero())
            {
                tempScalar[7] += mv1.KVector3.Scalar123 * mv2.KVector0.Scalar;
                tempScalar[11] += mv1.KVector3.Scalar124 * mv2.KVector0.Scalar;
                tempScalar[13] += mv1.KVector3.Scalar134 * mv2.KVector0.Scalar;
                tempScalar[14] += mv1.KVector3.Scalar234 * mv2.KVector0.Scalar;
                tempScalar[19] += mv1.KVector3.Scalar125 * mv2.KVector0.Scalar;
                tempScalar[21] += mv1.KVector3.Scalar135 * mv2.KVector0.Scalar;
                tempScalar[22] += mv1.KVector3.Scalar235 * mv2.KVector0.Scalar;
                tempScalar[25] += mv1.KVector3.Scalar145 * mv2.KVector0.Scalar;
                tempScalar[26] += mv1.KVector3.Scalar245 * mv2.KVector0.Scalar;
                tempScalar[28] += mv1.KVector3.Scalar345 * mv2.KVector0.Scalar;
            }
            
            if (!mv2.KVector1.IsZero())
            {
                tempScalar[3] += mv1.KVector3.Scalar123 * mv2.KVector1.Scalar3 + mv1.KVector3.Scalar124 * mv2.KVector1.Scalar4 + mv1.KVector3.Scalar125 * mv2.KVector1.Scalar5;
                tempScalar[5] += -mv1.KVector3.Scalar123 * mv2.KVector1.Scalar2 + mv1.KVector3.Scalar134 * mv2.KVector1.Scalar4 + mv1.KVector3.Scalar135 * mv2.KVector1.Scalar5;
                tempScalar[6] += mv1.KVector3.Scalar123 * mv2.KVector1.Scalar1 + mv1.KVector3.Scalar234 * mv2.KVector1.Scalar4 + mv1.KVector3.Scalar235 * mv2.KVector1.Scalar5;
                tempScalar[9] += -mv1.KVector3.Scalar124 * mv2.KVector1.Scalar2 - mv1.KVector3.Scalar134 * mv2.KVector1.Scalar3 + mv1.KVector3.Scalar145 * mv2.KVector1.Scalar5;
                tempScalar[10] += mv1.KVector3.Scalar124 * mv2.KVector1.Scalar1 - mv1.KVector3.Scalar234 * mv2.KVector1.Scalar3 + mv1.KVector3.Scalar245 * mv2.KVector1.Scalar5;
                tempScalar[12] += mv1.KVector3.Scalar134 * mv2.KVector1.Scalar1 + mv1.KVector3.Scalar234 * mv2.KVector1.Scalar2 + mv1.KVector3.Scalar345 * mv2.KVector1.Scalar5;
                tempScalar[17] += -mv1.KVector3.Scalar125 * mv2.KVector1.Scalar2 - mv1.KVector3.Scalar135 * mv2.KVector1.Scalar3 - mv1.KVector3.Scalar145 * mv2.KVector1.Scalar4;
                tempScalar[18] += mv1.KVector3.Scalar125 * mv2.KVector1.Scalar1 - mv1.KVector3.Scalar235 * mv2.KVector1.Scalar3 - mv1.KVector3.Scalar245 * mv2.KVector1.Scalar4;
                tempScalar[20] += mv1.KVector3.Scalar135 * mv2.KVector1.Scalar1 + mv1.KVector3.Scalar235 * mv2.KVector1.Scalar2 - mv1.KVector3.Scalar345 * mv2.KVector1.Scalar4;
                tempScalar[24] += mv1.KVector3.Scalar145 * mv2.KVector1.Scalar1 + mv1.KVector3.Scalar245 * mv2.KVector1.Scalar2 + mv1.KVector3.Scalar345 * mv2.KVector1.Scalar3;
            }
            
            if (!mv2.KVector2.IsZero())
            {
                tempScalar[1] += -mv1.KVector3.Scalar123 * mv2.KVector2.Scalar23 - mv1.KVector3.Scalar124 * mv2.KVector2.Scalar24 - mv1.KVector3.Scalar134 * mv2.KVector2.Scalar34 - mv1.KVector3.Scalar125 * mv2.KVector2.Scalar25 - mv1.KVector3.Scalar135 * mv2.KVector2.Scalar35 - mv1.KVector3.Scalar145 * mv2.KVector2.Scalar45;
                tempScalar[2] += mv1.KVector3.Scalar123 * mv2.KVector2.Scalar13 + mv1.KVector3.Scalar124 * mv2.KVector2.Scalar14 - mv1.KVector3.Scalar234 * mv2.KVector2.Scalar34 + mv1.KVector3.Scalar125 * mv2.KVector2.Scalar15 - mv1.KVector3.Scalar235 * mv2.KVector2.Scalar35 - mv1.KVector3.Scalar245 * mv2.KVector2.Scalar45;
                tempScalar[4] += -mv1.KVector3.Scalar123 * mv2.KVector2.Scalar12 + mv1.KVector3.Scalar134 * mv2.KVector2.Scalar14 + mv1.KVector3.Scalar234 * mv2.KVector2.Scalar24 + mv1.KVector3.Scalar135 * mv2.KVector2.Scalar15 + mv1.KVector3.Scalar235 * mv2.KVector2.Scalar25 - mv1.KVector3.Scalar345 * mv2.KVector2.Scalar45;
                tempScalar[8] += -mv1.KVector3.Scalar124 * mv2.KVector2.Scalar12 - mv1.KVector3.Scalar134 * mv2.KVector2.Scalar13 - mv1.KVector3.Scalar234 * mv2.KVector2.Scalar23 + mv1.KVector3.Scalar145 * mv2.KVector2.Scalar15 + mv1.KVector3.Scalar245 * mv2.KVector2.Scalar25 + mv1.KVector3.Scalar345 * mv2.KVector2.Scalar35;
                tempScalar[16] += -mv1.KVector3.Scalar125 * mv2.KVector2.Scalar12 - mv1.KVector3.Scalar135 * mv2.KVector2.Scalar13 - mv1.KVector3.Scalar235 * mv2.KVector2.Scalar23 - mv1.KVector3.Scalar145 * mv2.KVector2.Scalar14 - mv1.KVector3.Scalar245 * mv2.KVector2.Scalar24 - mv1.KVector3.Scalar345 * mv2.KVector2.Scalar34;
            }
            
            if (!mv2.KVector3.IsZero())
            {
                tempScalar[0] += -mv1.KVector3.Scalar123 * mv2.KVector3.Scalar123 - mv1.KVector3.Scalar124 * mv2.KVector3.Scalar124 - mv1.KVector3.Scalar134 * mv2.KVector3.Scalar134 - mv1.KVector3.Scalar234 * mv2.KVector3.Scalar234 - mv1.KVector3.Scalar125 * mv2.KVector3.Scalar125 - mv1.KVector3.Scalar135 * mv2.KVector3.Scalar135 - mv1.KVector3.Scalar235 * mv2.KVector3.Scalar235 - mv1.KVector3.Scalar145 * mv2.KVector3.Scalar145 - mv1.KVector3.Scalar245 * mv2.KVector3.Scalar245 - mv1.KVector3.Scalar345 * mv2.KVector3.Scalar345;
            }
            
        }
        
        if (!mv1.KVector4.IsZero())
        {
            if (!mv2.KVector0.IsZero())
            {
                tempScalar[15] += mv1.KVector4.Scalar1234 * mv2.KVector0.Scalar;
                tempScalar[23] += mv1.KVector4.Scalar1235 * mv2.KVector0.Scalar;
                tempScalar[27] += mv1.KVector4.Scalar1245 * mv2.KVector0.Scalar;
                tempScalar[29] += mv1.KVector4.Scalar1345 * mv2.KVector0.Scalar;
                tempScalar[30] += mv1.KVector4.Scalar2345 * mv2.KVector0.Scalar;
            }
            
            if (!mv2.KVector1.IsZero())
            {
                tempScalar[7] += mv1.KVector4.Scalar1234 * mv2.KVector1.Scalar4 + mv1.KVector4.Scalar1235 * mv2.KVector1.Scalar5;
                tempScalar[11] += -mv1.KVector4.Scalar1234 * mv2.KVector1.Scalar3 + mv1.KVector4.Scalar1245 * mv2.KVector1.Scalar5;
                tempScalar[13] += mv1.KVector4.Scalar1234 * mv2.KVector1.Scalar2 + mv1.KVector4.Scalar1345 * mv2.KVector1.Scalar5;
                tempScalar[14] += -mv1.KVector4.Scalar1234 * mv2.KVector1.Scalar1 + mv1.KVector4.Scalar2345 * mv2.KVector1.Scalar5;
                tempScalar[19] += -mv1.KVector4.Scalar1235 * mv2.KVector1.Scalar3 - mv1.KVector4.Scalar1245 * mv2.KVector1.Scalar4;
                tempScalar[21] += mv1.KVector4.Scalar1235 * mv2.KVector1.Scalar2 - mv1.KVector4.Scalar1345 * mv2.KVector1.Scalar4;
                tempScalar[22] += -mv1.KVector4.Scalar1235 * mv2.KVector1.Scalar1 - mv1.KVector4.Scalar2345 * mv2.KVector1.Scalar4;
                tempScalar[25] += mv1.KVector4.Scalar1245 * mv2.KVector1.Scalar2 + mv1.KVector4.Scalar1345 * mv2.KVector1.Scalar3;
                tempScalar[26] += -mv1.KVector4.Scalar1245 * mv2.KVector1.Scalar1 + mv1.KVector4.Scalar2345 * mv2.KVector1.Scalar3;
                tempScalar[28] += -mv1.KVector4.Scalar1345 * mv2.KVector1.Scalar1 - mv1.KVector4.Scalar2345 * mv2.KVector1.Scalar2;
            }
            
            if (!mv2.KVector2.IsZero())
            {
                tempScalar[3] += -mv1.KVector4.Scalar1234 * mv2.KVector2.Scalar34 - mv1.KVector4.Scalar1235 * mv2.KVector2.Scalar35 - mv1.KVector4.Scalar1245 * mv2.KVector2.Scalar45;
                tempScalar[5] += mv1.KVector4.Scalar1234 * mv2.KVector2.Scalar24 + mv1.KVector4.Scalar1235 * mv2.KVector2.Scalar25 - mv1.KVector4.Scalar1345 * mv2.KVector2.Scalar45;
                tempScalar[6] += -mv1.KVector4.Scalar1234 * mv2.KVector2.Scalar14 - mv1.KVector4.Scalar1235 * mv2.KVector2.Scalar15 - mv1.KVector4.Scalar2345 * mv2.KVector2.Scalar45;
                tempScalar[9] += -mv1.KVector4.Scalar1234 * mv2.KVector2.Scalar23 + mv1.KVector4.Scalar1245 * mv2.KVector2.Scalar25 + mv1.KVector4.Scalar1345 * mv2.KVector2.Scalar35;
                tempScalar[10] += mv1.KVector4.Scalar1234 * mv2.KVector2.Scalar13 - mv1.KVector4.Scalar1245 * mv2.KVector2.Scalar15 + mv1.KVector4.Scalar2345 * mv2.KVector2.Scalar35;
                tempScalar[12] += -mv1.KVector4.Scalar1234 * mv2.KVector2.Scalar12 - mv1.KVector4.Scalar1345 * mv2.KVector2.Scalar15 - mv1.KVector4.Scalar2345 * mv2.KVector2.Scalar25;
                tempScalar[17] += -mv1.KVector4.Scalar1235 * mv2.KVector2.Scalar23 - mv1.KVector4.Scalar1245 * mv2.KVector2.Scalar24 - mv1.KVector4.Scalar1345 * mv2.KVector2.Scalar34;
                tempScalar[18] += mv1.KVector4.Scalar1235 * mv2.KVector2.Scalar13 + mv1.KVector4.Scalar1245 * mv2.KVector2.Scalar14 - mv1.KVector4.Scalar2345 * mv2.KVector2.Scalar34;
                tempScalar[20] += -mv1.KVector4.Scalar1235 * mv2.KVector2.Scalar12 + mv1.KVector4.Scalar1345 * mv2.KVector2.Scalar14 + mv1.KVector4.Scalar2345 * mv2.KVector2.Scalar24;
                tempScalar[24] += -mv1.KVector4.Scalar1245 * mv2.KVector2.Scalar12 - mv1.KVector4.Scalar1345 * mv2.KVector2.Scalar13 - mv1.KVector4.Scalar2345 * mv2.KVector2.Scalar23;
            }
            
            if (!mv2.KVector3.IsZero())
            {
                tempScalar[1] += -mv1.KVector4.Scalar1234 * mv2.KVector3.Scalar234 - mv1.KVector4.Scalar1235 * mv2.KVector3.Scalar235 - mv1.KVector4.Scalar1245 * mv2.KVector3.Scalar245 - mv1.KVector4.Scalar1345 * mv2.KVector3.Scalar345;
                tempScalar[2] += mv1.KVector4.Scalar1234 * mv2.KVector3.Scalar134 + mv1.KVector4.Scalar1235 * mv2.KVector3.Scalar135 + mv1.KVector4.Scalar1245 * mv2.KVector3.Scalar145 - mv1.KVector4.Scalar2345 * mv2.KVector3.Scalar345;
                tempScalar[4] += -mv1.KVector4.Scalar1234 * mv2.KVector3.Scalar124 - mv1.KVector4.Scalar1235 * mv2.KVector3.Scalar125 + mv1.KVector4.Scalar1345 * mv2.KVector3.Scalar145 + mv1.KVector4.Scalar2345 * mv2.KVector3.Scalar245;
                tempScalar[8] += mv1.KVector4.Scalar1234 * mv2.KVector3.Scalar123 - mv1.KVector4.Scalar1245 * mv2.KVector3.Scalar125 - mv1.KVector4.Scalar1345 * mv2.KVector3.Scalar135 - mv1.KVector4.Scalar2345 * mv2.KVector3.Scalar235;
                tempScalar[16] += mv1.KVector4.Scalar1235 * mv2.KVector3.Scalar123 + mv1.KVector4.Scalar1245 * mv2.KVector3.Scalar124 + mv1.KVector4.Scalar1345 * mv2.KVector3.Scalar134 + mv1.KVector4.Scalar2345 * mv2.KVector3.Scalar234;
            }
            
            if (!mv2.KVector4.IsZero())
            {
                tempScalar[0] += mv1.KVector4.Scalar1234 * mv2.KVector4.Scalar1234 + mv1.KVector4.Scalar1235 * mv2.KVector4.Scalar1235 + mv1.KVector4.Scalar1245 * mv2.KVector4.Scalar1245 + mv1.KVector4.Scalar1345 * mv2.KVector4.Scalar1345 + mv1.KVector4.Scalar2345 * mv2.KVector4.Scalar2345;
            }
            
        }
        
        if (!mv1.KVector5.IsZero())
        {
            if (!mv2.KVector0.IsZero())
            {
                tempScalar[31] += mv1.KVector5.Scalar12345 * mv2.KVector0.Scalar;
            }
            
            if (!mv2.KVector1.IsZero())
            {
                tempScalar[15] += mv1.KVector5.Scalar12345 * mv2.KVector1.Scalar5;
                tempScalar[23] += -mv1.KVector5.Scalar12345 * mv2.KVector1.Scalar4;
                tempScalar[27] += mv1.KVector5.Scalar12345 * mv2.KVector1.Scalar3;
                tempScalar[29] += -mv1.KVector5.Scalar12345 * mv2.KVector1.Scalar2;
                tempScalar[30] += mv1.KVector5.Scalar12345 * mv2.KVector1.Scalar1;
            }
            
            if (!mv2.KVector2.IsZero())
            {
                tempScalar[7] += -mv1.KVector5.Scalar12345 * mv2.KVector2.Scalar45;
                tempScalar[11] += mv1.KVector5.Scalar12345 * mv2.KVector2.Scalar35;
                tempScalar[13] += -mv1.KVector5.Scalar12345 * mv2.KVector2.Scalar25;
                tempScalar[14] += mv1.KVector5.Scalar12345 * mv2.KVector2.Scalar15;
                tempScalar[19] += -mv1.KVector5.Scalar12345 * mv2.KVector2.Scalar34;
                tempScalar[21] += mv1.KVector5.Scalar12345 * mv2.KVector2.Scalar24;
                tempScalar[22] += -mv1.KVector5.Scalar12345 * mv2.KVector2.Scalar14;
                tempScalar[25] += -mv1.KVector5.Scalar12345 * mv2.KVector2.Scalar23;
                tempScalar[26] += mv1.KVector5.Scalar12345 * mv2.KVector2.Scalar13;
                tempScalar[28] += -mv1.KVector5.Scalar12345 * mv2.KVector2.Scalar12;
            }
            
            if (!mv2.KVector3.IsZero())
            {
                tempScalar[3] += -mv1.KVector5.Scalar12345 * mv2.KVector3.Scalar345;
                tempScalar[5] += mv1.KVector5.Scalar12345 * mv2.KVector3.Scalar245;
                tempScalar[6] += -mv1.KVector5.Scalar12345 * mv2.KVector3.Scalar145;
                tempScalar[9] += -mv1.KVector5.Scalar12345 * mv2.KVector3.Scalar235;
                tempScalar[10] += mv1.KVector5.Scalar12345 * mv2.KVector3.Scalar135;
                tempScalar[12] += -mv1.KVector5.Scalar12345 * mv2.KVector3.Scalar125;
                tempScalar[17] += mv1.KVector5.Scalar12345 * mv2.KVector3.Scalar234;
                tempScalar[18] += -mv1.KVector5.Scalar12345 * mv2.KVector3.Scalar134;
                tempScalar[20] += mv1.KVector5.Scalar12345 * mv2.KVector3.Scalar124;
                tempScalar[24] += -mv1.KVector5.Scalar12345 * mv2.KVector3.Scalar123;
            }
            
            if (!mv2.KVector4.IsZero())
            {
                tempScalar[1] += mv1.KVector5.Scalar12345 * mv2.KVector4.Scalar2345;
                tempScalar[2] += -mv1.KVector5.Scalar12345 * mv2.KVector4.Scalar1345;
                tempScalar[4] += mv1.KVector5.Scalar12345 * mv2.KVector4.Scalar1245;
                tempScalar[8] += -mv1.KVector5.Scalar12345 * mv2.KVector4.Scalar1235;
                tempScalar[16] += mv1.KVector5.Scalar12345 * mv2.KVector4.Scalar1234;
            }
            
            if (!mv2.KVector5.IsZero())
            {
                tempScalar[0] += mv1.KVector5.Scalar12345 * mv2.KVector5.Scalar12345;
            }
            
        }
        
        return Ga5Multivector.Create(tempScalar);
    }
    
}
