using System.Runtime.CompilerServices;

namespace GeometricAlgebraFulcrumLib.Generations.Algebra.Ga22;

public static class Ga22LeftContractionProduct
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga22KVector0 Lcp(this Ga22KVector0 mv1, Ga22KVector0 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga22KVector0.Zero;
        
        return new Ga22KVector0
        {
            Scalar = mv1.Scalar * mv2.Scalar
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga22KVector1 Lcp(this Ga22KVector0 mv1, Ga22KVector1 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga22KVector1.Zero;
        
        return new Ga22KVector1
        {
            Scalar1 = mv1.Scalar * mv2.Scalar1,
            Scalar2 = mv1.Scalar * mv2.Scalar2,
            Scalar3 = mv1.Scalar * mv2.Scalar3,
            Scalar4 = mv1.Scalar * mv2.Scalar4
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga22KVector2 Lcp(this Ga22KVector0 mv1, Ga22KVector2 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga22KVector2.Zero;
        
        return new Ga22KVector2
        {
            Scalar12 = mv1.Scalar * mv2.Scalar12,
            Scalar13 = mv1.Scalar * mv2.Scalar13,
            Scalar23 = mv1.Scalar * mv2.Scalar23,
            Scalar14 = mv1.Scalar * mv2.Scalar14,
            Scalar24 = mv1.Scalar * mv2.Scalar24,
            Scalar34 = mv1.Scalar * mv2.Scalar34
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga22KVector3 Lcp(this Ga22KVector0 mv1, Ga22KVector3 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga22KVector3.Zero;
        
        return new Ga22KVector3
        {
            Scalar123 = mv1.Scalar * mv2.Scalar123,
            Scalar124 = mv1.Scalar * mv2.Scalar124,
            Scalar134 = mv1.Scalar * mv2.Scalar134,
            Scalar234 = mv1.Scalar * mv2.Scalar234
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga22KVector4 Lcp(this Ga22KVector0 mv1, Ga22KVector4 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga22KVector4.Zero;
        
        return new Ga22KVector4
        {
            Scalar1234 = mv1.Scalar * mv2.Scalar1234
        };
    }
    
    public static Ga22Multivector Lcp(this Ga22KVector0 mv1, Ga22Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga22Multivector.Zero;
        
        var tempScalar = new double[16];
        
        if (!mv2.KVector0.IsZero())
        {
            tempScalar[0] += mv1.Scalar * mv2.KVector0.Scalar;
        }
        
        if (!mv2.KVector1.IsZero())
        {
            tempScalar[1] += mv1.Scalar * mv2.KVector1.Scalar1;
            tempScalar[2] += mv1.Scalar * mv2.KVector1.Scalar2;
            tempScalar[4] += mv1.Scalar * mv2.KVector1.Scalar3;
            tempScalar[8] += mv1.Scalar * mv2.KVector1.Scalar4;
        }
        
        if (!mv2.KVector2.IsZero())
        {
            tempScalar[3] += mv1.Scalar * mv2.KVector2.Scalar12;
            tempScalar[5] += mv1.Scalar * mv2.KVector2.Scalar13;
            tempScalar[6] += mv1.Scalar * mv2.KVector2.Scalar23;
            tempScalar[9] += mv1.Scalar * mv2.KVector2.Scalar14;
            tempScalar[10] += mv1.Scalar * mv2.KVector2.Scalar24;
            tempScalar[12] += mv1.Scalar * mv2.KVector2.Scalar34;
        }
        
        if (!mv2.KVector3.IsZero())
        {
            tempScalar[7] += mv1.Scalar * mv2.KVector3.Scalar123;
            tempScalar[11] += mv1.Scalar * mv2.KVector3.Scalar124;
            tempScalar[13] += mv1.Scalar * mv2.KVector3.Scalar134;
            tempScalar[14] += mv1.Scalar * mv2.KVector3.Scalar234;
        }
        
        if (!mv2.KVector4.IsZero())
        {
            tempScalar[15] += mv1.Scalar * mv2.KVector4.Scalar1234;
        }
        
        return Ga22Multivector.Create(tempScalar);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga22KVector0 Lcp(this Ga22KVector1 mv1, Ga22KVector0 mv2)
    {
        return Ga22KVector0.Zero;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga22KVector0 Lcp(this Ga22KVector1 mv1, Ga22KVector1 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga22KVector0.Zero;
        
        return new Ga22KVector0
        {
            Scalar = -mv1.Scalar1 * mv2.Scalar1 - mv1.Scalar2 * mv2.Scalar2 + mv1.Scalar3 * mv2.Scalar3 + mv1.Scalar4 * mv2.Scalar4
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga22KVector1 Lcp(this Ga22KVector1 mv1, Ga22KVector2 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga22KVector1.Zero;
        
        return new Ga22KVector1
        {
            Scalar1 = mv1.Scalar2 * mv2.Scalar12 - mv1.Scalar3 * mv2.Scalar13 - mv1.Scalar4 * mv2.Scalar14,
            Scalar2 = -mv1.Scalar1 * mv2.Scalar12 - mv1.Scalar3 * mv2.Scalar23 - mv1.Scalar4 * mv2.Scalar24,
            Scalar3 = -mv1.Scalar1 * mv2.Scalar13 - mv1.Scalar2 * mv2.Scalar23 - mv1.Scalar4 * mv2.Scalar34,
            Scalar4 = -mv1.Scalar1 * mv2.Scalar14 - mv1.Scalar2 * mv2.Scalar24 + mv1.Scalar3 * mv2.Scalar34
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga22KVector2 Lcp(this Ga22KVector1 mv1, Ga22KVector3 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga22KVector2.Zero;
        
        return new Ga22KVector2
        {
            Scalar12 = mv1.Scalar3 * mv2.Scalar123 + mv1.Scalar4 * mv2.Scalar124,
            Scalar13 = mv1.Scalar2 * mv2.Scalar123 + mv1.Scalar4 * mv2.Scalar134,
            Scalar23 = -mv1.Scalar1 * mv2.Scalar123 + mv1.Scalar4 * mv2.Scalar234,
            Scalar14 = mv1.Scalar2 * mv2.Scalar124 - mv1.Scalar3 * mv2.Scalar134,
            Scalar24 = -mv1.Scalar1 * mv2.Scalar124 - mv1.Scalar3 * mv2.Scalar234,
            Scalar34 = -mv1.Scalar1 * mv2.Scalar134 - mv1.Scalar2 * mv2.Scalar234
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga22KVector3 Lcp(this Ga22KVector1 mv1, Ga22KVector4 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga22KVector3.Zero;
        
        return new Ga22KVector3
        {
            Scalar123 = -mv1.Scalar4 * mv2.Scalar1234,
            Scalar124 = mv1.Scalar3 * mv2.Scalar1234,
            Scalar134 = mv1.Scalar2 * mv2.Scalar1234,
            Scalar234 = -mv1.Scalar1 * mv2.Scalar1234
        };
    }
    
    public static Ga22Multivector Lcp(this Ga22KVector1 mv1, Ga22Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga22Multivector.Zero;
        
        var tempScalar = new double[16];
        
        if (!mv2.KVector1.IsZero())
        {
            tempScalar[0] += -mv1.Scalar1 * mv2.KVector1.Scalar1 - mv1.Scalar2 * mv2.KVector1.Scalar2 + mv1.Scalar3 * mv2.KVector1.Scalar3 + mv1.Scalar4 * mv2.KVector1.Scalar4;
        }
        
        if (!mv2.KVector2.IsZero())
        {
            tempScalar[1] += mv1.Scalar2 * mv2.KVector2.Scalar12 - mv1.Scalar3 * mv2.KVector2.Scalar13 - mv1.Scalar4 * mv2.KVector2.Scalar14;
            tempScalar[2] += -mv1.Scalar1 * mv2.KVector2.Scalar12 - mv1.Scalar3 * mv2.KVector2.Scalar23 - mv1.Scalar4 * mv2.KVector2.Scalar24;
            tempScalar[4] += -mv1.Scalar1 * mv2.KVector2.Scalar13 - mv1.Scalar2 * mv2.KVector2.Scalar23 - mv1.Scalar4 * mv2.KVector2.Scalar34;
            tempScalar[8] += -mv1.Scalar1 * mv2.KVector2.Scalar14 - mv1.Scalar2 * mv2.KVector2.Scalar24 + mv1.Scalar3 * mv2.KVector2.Scalar34;
        }
        
        if (!mv2.KVector3.IsZero())
        {
            tempScalar[3] += mv1.Scalar3 * mv2.KVector3.Scalar123 + mv1.Scalar4 * mv2.KVector3.Scalar124;
            tempScalar[5] += mv1.Scalar2 * mv2.KVector3.Scalar123 + mv1.Scalar4 * mv2.KVector3.Scalar134;
            tempScalar[6] += -mv1.Scalar1 * mv2.KVector3.Scalar123 + mv1.Scalar4 * mv2.KVector3.Scalar234;
            tempScalar[9] += mv1.Scalar2 * mv2.KVector3.Scalar124 - mv1.Scalar3 * mv2.KVector3.Scalar134;
            tempScalar[10] += -mv1.Scalar1 * mv2.KVector3.Scalar124 - mv1.Scalar3 * mv2.KVector3.Scalar234;
            tempScalar[12] += -mv1.Scalar1 * mv2.KVector3.Scalar134 - mv1.Scalar2 * mv2.KVector3.Scalar234;
        }
        
        if (!mv2.KVector4.IsZero())
        {
            tempScalar[7] += -mv1.Scalar4 * mv2.KVector4.Scalar1234;
            tempScalar[11] += mv1.Scalar3 * mv2.KVector4.Scalar1234;
            tempScalar[13] += mv1.Scalar2 * mv2.KVector4.Scalar1234;
            tempScalar[14] += -mv1.Scalar1 * mv2.KVector4.Scalar1234;
        }
        
        return Ga22Multivector.Create(tempScalar);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga22KVector0 Lcp(this Ga22KVector2 mv1, Ga22KVector0 mv2)
    {
        return Ga22KVector0.Zero;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga22KVector0 Lcp(this Ga22KVector2 mv1, Ga22KVector1 mv2)
    {
        return Ga22KVector0.Zero;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga22KVector0 Lcp(this Ga22KVector2 mv1, Ga22KVector2 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga22KVector0.Zero;
        
        return new Ga22KVector0
        {
            Scalar = -mv1.Scalar12 * mv2.Scalar12 + mv1.Scalar13 * mv2.Scalar13 + mv1.Scalar23 * mv2.Scalar23 + mv1.Scalar14 * mv2.Scalar14 + mv1.Scalar24 * mv2.Scalar24 - mv1.Scalar34 * mv2.Scalar34
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga22KVector1 Lcp(this Ga22KVector2 mv1, Ga22KVector3 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga22KVector1.Zero;
        
        return new Ga22KVector1
        {
            Scalar1 = mv1.Scalar23 * mv2.Scalar123 + mv1.Scalar24 * mv2.Scalar124 - mv1.Scalar34 * mv2.Scalar134,
            Scalar2 = -mv1.Scalar13 * mv2.Scalar123 - mv1.Scalar14 * mv2.Scalar124 - mv1.Scalar34 * mv2.Scalar234,
            Scalar3 = -mv1.Scalar12 * mv2.Scalar123 - mv1.Scalar14 * mv2.Scalar134 - mv1.Scalar24 * mv2.Scalar234,
            Scalar4 = -mv1.Scalar12 * mv2.Scalar124 + mv1.Scalar13 * mv2.Scalar134 + mv1.Scalar23 * mv2.Scalar234
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga22KVector2 Lcp(this Ga22KVector2 mv1, Ga22KVector4 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga22KVector2.Zero;
        
        return new Ga22KVector2
        {
            Scalar12 = -mv1.Scalar34 * mv2.Scalar1234,
            Scalar13 = -mv1.Scalar24 * mv2.Scalar1234,
            Scalar23 = mv1.Scalar14 * mv2.Scalar1234,
            Scalar14 = mv1.Scalar23 * mv2.Scalar1234,
            Scalar24 = -mv1.Scalar13 * mv2.Scalar1234,
            Scalar34 = -mv1.Scalar12 * mv2.Scalar1234
        };
    }
    
    public static Ga22Multivector Lcp(this Ga22KVector2 mv1, Ga22Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga22Multivector.Zero;
        
        var tempScalar = new double[16];
        
        if (!mv2.KVector2.IsZero())
        {
            tempScalar[0] += -mv1.Scalar12 * mv2.KVector2.Scalar12 + mv1.Scalar13 * mv2.KVector2.Scalar13 + mv1.Scalar23 * mv2.KVector2.Scalar23 + mv1.Scalar14 * mv2.KVector2.Scalar14 + mv1.Scalar24 * mv2.KVector2.Scalar24 - mv1.Scalar34 * mv2.KVector2.Scalar34;
        }
        
        if (!mv2.KVector3.IsZero())
        {
            tempScalar[1] += mv1.Scalar23 * mv2.KVector3.Scalar123 + mv1.Scalar24 * mv2.KVector3.Scalar124 - mv1.Scalar34 * mv2.KVector3.Scalar134;
            tempScalar[2] += -mv1.Scalar13 * mv2.KVector3.Scalar123 - mv1.Scalar14 * mv2.KVector3.Scalar124 - mv1.Scalar34 * mv2.KVector3.Scalar234;
            tempScalar[4] += -mv1.Scalar12 * mv2.KVector3.Scalar123 - mv1.Scalar14 * mv2.KVector3.Scalar134 - mv1.Scalar24 * mv2.KVector3.Scalar234;
            tempScalar[8] += -mv1.Scalar12 * mv2.KVector3.Scalar124 + mv1.Scalar13 * mv2.KVector3.Scalar134 + mv1.Scalar23 * mv2.KVector3.Scalar234;
        }
        
        if (!mv2.KVector4.IsZero())
        {
            tempScalar[3] += -mv1.Scalar34 * mv2.KVector4.Scalar1234;
            tempScalar[5] += -mv1.Scalar24 * mv2.KVector4.Scalar1234;
            tempScalar[6] += mv1.Scalar14 * mv2.KVector4.Scalar1234;
            tempScalar[9] += mv1.Scalar23 * mv2.KVector4.Scalar1234;
            tempScalar[10] += -mv1.Scalar13 * mv2.KVector4.Scalar1234;
            tempScalar[12] += -mv1.Scalar12 * mv2.KVector4.Scalar1234;
        }
        
        return Ga22Multivector.Create(tempScalar);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga22KVector0 Lcp(this Ga22KVector3 mv1, Ga22KVector0 mv2)
    {
        return Ga22KVector0.Zero;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga22KVector0 Lcp(this Ga22KVector3 mv1, Ga22KVector1 mv2)
    {
        return Ga22KVector0.Zero;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga22KVector0 Lcp(this Ga22KVector3 mv1, Ga22KVector2 mv2)
    {
        return Ga22KVector0.Zero;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga22KVector0 Lcp(this Ga22KVector3 mv1, Ga22KVector3 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga22KVector0.Zero;
        
        return new Ga22KVector0
        {
            Scalar = -mv1.Scalar123 * mv2.Scalar123 - mv1.Scalar124 * mv2.Scalar124 + mv1.Scalar134 * mv2.Scalar134 + mv1.Scalar234 * mv2.Scalar234
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga22KVector1 Lcp(this Ga22KVector3 mv1, Ga22KVector4 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga22KVector1.Zero;
        
        return new Ga22KVector1
        {
            Scalar1 = -mv1.Scalar234 * mv2.Scalar1234,
            Scalar2 = mv1.Scalar134 * mv2.Scalar1234,
            Scalar3 = mv1.Scalar124 * mv2.Scalar1234,
            Scalar4 = -mv1.Scalar123 * mv2.Scalar1234
        };
    }
    
    public static Ga22Multivector Lcp(this Ga22KVector3 mv1, Ga22Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga22Multivector.Zero;
        
        var tempScalar = new double[16];
        
        if (!mv2.KVector3.IsZero())
        {
            tempScalar[0] += -mv1.Scalar123 * mv2.KVector3.Scalar123 - mv1.Scalar124 * mv2.KVector3.Scalar124 + mv1.Scalar134 * mv2.KVector3.Scalar134 + mv1.Scalar234 * mv2.KVector3.Scalar234;
        }
        
        if (!mv2.KVector4.IsZero())
        {
            tempScalar[1] += -mv1.Scalar234 * mv2.KVector4.Scalar1234;
            tempScalar[2] += mv1.Scalar134 * mv2.KVector4.Scalar1234;
            tempScalar[4] += mv1.Scalar124 * mv2.KVector4.Scalar1234;
            tempScalar[8] += -mv1.Scalar123 * mv2.KVector4.Scalar1234;
        }
        
        return Ga22Multivector.Create(tempScalar);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga22KVector0 Lcp(this Ga22KVector4 mv1, Ga22KVector0 mv2)
    {
        return Ga22KVector0.Zero;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga22KVector0 Lcp(this Ga22KVector4 mv1, Ga22KVector1 mv2)
    {
        return Ga22KVector0.Zero;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga22KVector0 Lcp(this Ga22KVector4 mv1, Ga22KVector2 mv2)
    {
        return Ga22KVector0.Zero;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga22KVector0 Lcp(this Ga22KVector4 mv1, Ga22KVector3 mv2)
    {
        return Ga22KVector0.Zero;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga22KVector0 Lcp(this Ga22KVector4 mv1, Ga22KVector4 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga22KVector0.Zero;
        
        return new Ga22KVector0
        {
            Scalar = mv1.Scalar1234 * mv2.Scalar1234
        };
    }
    
    public static Ga22KVector0 Lcp(this Ga22KVector4 mv1, Ga22Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga22KVector0.Zero;
        
        var tempScalar = 0d;
        
        if (!mv2.KVector4.IsZero())
        {
            tempScalar += mv1.Scalar1234 * mv2.KVector4.Scalar1234;
        }
        
        return new Ga22KVector0
        {
            Scalar = tempScalar
        };
    }
    
    public static Ga22KVector0 Lcp(this Ga22Multivector mv1, Ga22KVector0 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga22KVector0.Zero;
        
        var tempScalar = 0d;
        
        if (!mv1.KVector0.IsZero())
        {
            tempScalar += mv1.KVector0.Scalar * mv2.Scalar;
        }
        
        return new Ga22KVector0
        {
            Scalar = tempScalar
        };
    }
    
    public static Ga22Multivector Lcp(this Ga22Multivector mv1, Ga22KVector1 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga22Multivector.Zero;
        
        var tempScalar = new double[16];
        
        if (!mv1.KVector0.IsZero())
        {
            tempScalar[1] += mv1.KVector0.Scalar * mv2.Scalar1;
            tempScalar[2] += mv1.KVector0.Scalar * mv2.Scalar2;
            tempScalar[4] += mv1.KVector0.Scalar * mv2.Scalar3;
            tempScalar[8] += mv1.KVector0.Scalar * mv2.Scalar4;
        }
        
        if (!mv1.KVector1.IsZero())
        {
            tempScalar[0] += -mv1.KVector1.Scalar1 * mv2.Scalar1 - mv1.KVector1.Scalar2 * mv2.Scalar2 + mv1.KVector1.Scalar3 * mv2.Scalar3 + mv1.KVector1.Scalar4 * mv2.Scalar4;
        }
        
        return Ga22Multivector.Create(tempScalar);
    }
    
    public static Ga22Multivector Lcp(this Ga22Multivector mv1, Ga22KVector2 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga22Multivector.Zero;
        
        var tempScalar = new double[16];
        
        if (!mv1.KVector0.IsZero())
        {
            tempScalar[3] += mv1.KVector0.Scalar * mv2.Scalar12;
            tempScalar[5] += mv1.KVector0.Scalar * mv2.Scalar13;
            tempScalar[6] += mv1.KVector0.Scalar * mv2.Scalar23;
            tempScalar[9] += mv1.KVector0.Scalar * mv2.Scalar14;
            tempScalar[10] += mv1.KVector0.Scalar * mv2.Scalar24;
            tempScalar[12] += mv1.KVector0.Scalar * mv2.Scalar34;
        }
        
        if (!mv1.KVector1.IsZero())
        {
            tempScalar[1] += mv1.KVector1.Scalar2 * mv2.Scalar12 - mv1.KVector1.Scalar3 * mv2.Scalar13 - mv1.KVector1.Scalar4 * mv2.Scalar14;
            tempScalar[2] += -mv1.KVector1.Scalar1 * mv2.Scalar12 - mv1.KVector1.Scalar3 * mv2.Scalar23 - mv1.KVector1.Scalar4 * mv2.Scalar24;
            tempScalar[4] += -mv1.KVector1.Scalar1 * mv2.Scalar13 - mv1.KVector1.Scalar2 * mv2.Scalar23 - mv1.KVector1.Scalar4 * mv2.Scalar34;
            tempScalar[8] += -mv1.KVector1.Scalar1 * mv2.Scalar14 - mv1.KVector1.Scalar2 * mv2.Scalar24 + mv1.KVector1.Scalar3 * mv2.Scalar34;
        }
        
        if (!mv1.KVector2.IsZero())
        {
            tempScalar[0] += -mv1.KVector2.Scalar12 * mv2.Scalar12 + mv1.KVector2.Scalar13 * mv2.Scalar13 + mv1.KVector2.Scalar23 * mv2.Scalar23 + mv1.KVector2.Scalar14 * mv2.Scalar14 + mv1.KVector2.Scalar24 * mv2.Scalar24 - mv1.KVector2.Scalar34 * mv2.Scalar34;
        }
        
        return Ga22Multivector.Create(tempScalar);
    }
    
    public static Ga22Multivector Lcp(this Ga22Multivector mv1, Ga22KVector3 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga22Multivector.Zero;
        
        var tempScalar = new double[16];
        
        if (!mv1.KVector0.IsZero())
        {
            tempScalar[7] += mv1.KVector0.Scalar * mv2.Scalar123;
            tempScalar[11] += mv1.KVector0.Scalar * mv2.Scalar124;
            tempScalar[13] += mv1.KVector0.Scalar * mv2.Scalar134;
            tempScalar[14] += mv1.KVector0.Scalar * mv2.Scalar234;
        }
        
        if (!mv1.KVector1.IsZero())
        {
            tempScalar[3] += mv1.KVector1.Scalar3 * mv2.Scalar123 + mv1.KVector1.Scalar4 * mv2.Scalar124;
            tempScalar[5] += mv1.KVector1.Scalar2 * mv2.Scalar123 + mv1.KVector1.Scalar4 * mv2.Scalar134;
            tempScalar[6] += -mv1.KVector1.Scalar1 * mv2.Scalar123 + mv1.KVector1.Scalar4 * mv2.Scalar234;
            tempScalar[9] += mv1.KVector1.Scalar2 * mv2.Scalar124 - mv1.KVector1.Scalar3 * mv2.Scalar134;
            tempScalar[10] += -mv1.KVector1.Scalar1 * mv2.Scalar124 - mv1.KVector1.Scalar3 * mv2.Scalar234;
            tempScalar[12] += -mv1.KVector1.Scalar1 * mv2.Scalar134 - mv1.KVector1.Scalar2 * mv2.Scalar234;
        }
        
        if (!mv1.KVector2.IsZero())
        {
            tempScalar[1] += mv1.KVector2.Scalar23 * mv2.Scalar123 + mv1.KVector2.Scalar24 * mv2.Scalar124 - mv1.KVector2.Scalar34 * mv2.Scalar134;
            tempScalar[2] += -mv1.KVector2.Scalar13 * mv2.Scalar123 - mv1.KVector2.Scalar14 * mv2.Scalar124 - mv1.KVector2.Scalar34 * mv2.Scalar234;
            tempScalar[4] += -mv1.KVector2.Scalar12 * mv2.Scalar123 - mv1.KVector2.Scalar14 * mv2.Scalar134 - mv1.KVector2.Scalar24 * mv2.Scalar234;
            tempScalar[8] += -mv1.KVector2.Scalar12 * mv2.Scalar124 + mv1.KVector2.Scalar13 * mv2.Scalar134 + mv1.KVector2.Scalar23 * mv2.Scalar234;
        }
        
        if (!mv1.KVector3.IsZero())
        {
            tempScalar[0] += -mv1.KVector3.Scalar123 * mv2.Scalar123 - mv1.KVector3.Scalar124 * mv2.Scalar124 + mv1.KVector3.Scalar134 * mv2.Scalar134 + mv1.KVector3.Scalar234 * mv2.Scalar234;
        }
        
        return Ga22Multivector.Create(tempScalar);
    }
    
    public static Ga22Multivector Lcp(this Ga22Multivector mv1, Ga22KVector4 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga22Multivector.Zero;
        
        var tempScalar = new double[16];
        
        if (!mv1.KVector0.IsZero())
        {
            tempScalar[15] += mv1.KVector0.Scalar * mv2.Scalar1234;
        }
        
        if (!mv1.KVector1.IsZero())
        {
            tempScalar[7] += -mv1.KVector1.Scalar4 * mv2.Scalar1234;
            tempScalar[11] += mv1.KVector1.Scalar3 * mv2.Scalar1234;
            tempScalar[13] += mv1.KVector1.Scalar2 * mv2.Scalar1234;
            tempScalar[14] += -mv1.KVector1.Scalar1 * mv2.Scalar1234;
        }
        
        if (!mv1.KVector2.IsZero())
        {
            tempScalar[3] += -mv1.KVector2.Scalar34 * mv2.Scalar1234;
            tempScalar[5] += -mv1.KVector2.Scalar24 * mv2.Scalar1234;
            tempScalar[6] += mv1.KVector2.Scalar14 * mv2.Scalar1234;
            tempScalar[9] += mv1.KVector2.Scalar23 * mv2.Scalar1234;
            tempScalar[10] += -mv1.KVector2.Scalar13 * mv2.Scalar1234;
            tempScalar[12] += -mv1.KVector2.Scalar12 * mv2.Scalar1234;
        }
        
        if (!mv1.KVector3.IsZero())
        {
            tempScalar[1] += -mv1.KVector3.Scalar234 * mv2.Scalar1234;
            tempScalar[2] += mv1.KVector3.Scalar134 * mv2.Scalar1234;
            tempScalar[4] += mv1.KVector3.Scalar124 * mv2.Scalar1234;
            tempScalar[8] += -mv1.KVector3.Scalar123 * mv2.Scalar1234;
        }
        
        if (!mv1.KVector4.IsZero())
        {
            tempScalar[0] += mv1.KVector4.Scalar1234 * mv2.Scalar1234;
        }
        
        return Ga22Multivector.Create(tempScalar);
    }
    
    public static Ga22Multivector Lcp(this Ga22Multivector mv1, Ga22Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga22Multivector.Zero;
        
        var tempScalar = new double[16];
        
        if (!mv1.KVector0.IsZero())
        {
            if (!mv2.KVector0.IsZero())
            {
                tempScalar[0] += mv1.KVector0.Scalar * mv2.KVector0.Scalar;
            }
            
            if (!mv2.KVector1.IsZero())
            {
                tempScalar[1] += mv1.KVector0.Scalar * mv2.KVector1.Scalar1;
                tempScalar[2] += mv1.KVector0.Scalar * mv2.KVector1.Scalar2;
                tempScalar[4] += mv1.KVector0.Scalar * mv2.KVector1.Scalar3;
                tempScalar[8] += mv1.KVector0.Scalar * mv2.KVector1.Scalar4;
            }
            
            if (!mv2.KVector2.IsZero())
            {
                tempScalar[3] += mv1.KVector0.Scalar * mv2.KVector2.Scalar12;
                tempScalar[5] += mv1.KVector0.Scalar * mv2.KVector2.Scalar13;
                tempScalar[6] += mv1.KVector0.Scalar * mv2.KVector2.Scalar23;
                tempScalar[9] += mv1.KVector0.Scalar * mv2.KVector2.Scalar14;
                tempScalar[10] += mv1.KVector0.Scalar * mv2.KVector2.Scalar24;
                tempScalar[12] += mv1.KVector0.Scalar * mv2.KVector2.Scalar34;
            }
            
            if (!mv2.KVector3.IsZero())
            {
                tempScalar[7] += mv1.KVector0.Scalar * mv2.KVector3.Scalar123;
                tempScalar[11] += mv1.KVector0.Scalar * mv2.KVector3.Scalar124;
                tempScalar[13] += mv1.KVector0.Scalar * mv2.KVector3.Scalar134;
                tempScalar[14] += mv1.KVector0.Scalar * mv2.KVector3.Scalar234;
            }
            
            if (!mv2.KVector4.IsZero())
            {
                tempScalar[15] += mv1.KVector0.Scalar * mv2.KVector4.Scalar1234;
            }
            
        }
        
        if (!mv1.KVector1.IsZero())
        {
            if (!mv2.KVector1.IsZero())
            {
                tempScalar[0] += -mv1.KVector1.Scalar1 * mv2.KVector1.Scalar1 - mv1.KVector1.Scalar2 * mv2.KVector1.Scalar2 + mv1.KVector1.Scalar3 * mv2.KVector1.Scalar3 + mv1.KVector1.Scalar4 * mv2.KVector1.Scalar4;
            }
            
            if (!mv2.KVector2.IsZero())
            {
                tempScalar[1] += mv1.KVector1.Scalar2 * mv2.KVector2.Scalar12 - mv1.KVector1.Scalar3 * mv2.KVector2.Scalar13 - mv1.KVector1.Scalar4 * mv2.KVector2.Scalar14;
                tempScalar[2] += -mv1.KVector1.Scalar1 * mv2.KVector2.Scalar12 - mv1.KVector1.Scalar3 * mv2.KVector2.Scalar23 - mv1.KVector1.Scalar4 * mv2.KVector2.Scalar24;
                tempScalar[4] += -mv1.KVector1.Scalar1 * mv2.KVector2.Scalar13 - mv1.KVector1.Scalar2 * mv2.KVector2.Scalar23 - mv1.KVector1.Scalar4 * mv2.KVector2.Scalar34;
                tempScalar[8] += -mv1.KVector1.Scalar1 * mv2.KVector2.Scalar14 - mv1.KVector1.Scalar2 * mv2.KVector2.Scalar24 + mv1.KVector1.Scalar3 * mv2.KVector2.Scalar34;
            }
            
            if (!mv2.KVector3.IsZero())
            {
                tempScalar[3] += mv1.KVector1.Scalar3 * mv2.KVector3.Scalar123 + mv1.KVector1.Scalar4 * mv2.KVector3.Scalar124;
                tempScalar[5] += mv1.KVector1.Scalar2 * mv2.KVector3.Scalar123 + mv1.KVector1.Scalar4 * mv2.KVector3.Scalar134;
                tempScalar[6] += -mv1.KVector1.Scalar1 * mv2.KVector3.Scalar123 + mv1.KVector1.Scalar4 * mv2.KVector3.Scalar234;
                tempScalar[9] += mv1.KVector1.Scalar2 * mv2.KVector3.Scalar124 - mv1.KVector1.Scalar3 * mv2.KVector3.Scalar134;
                tempScalar[10] += -mv1.KVector1.Scalar1 * mv2.KVector3.Scalar124 - mv1.KVector1.Scalar3 * mv2.KVector3.Scalar234;
                tempScalar[12] += -mv1.KVector1.Scalar1 * mv2.KVector3.Scalar134 - mv1.KVector1.Scalar2 * mv2.KVector3.Scalar234;
            }
            
            if (!mv2.KVector4.IsZero())
            {
                tempScalar[7] += -mv1.KVector1.Scalar4 * mv2.KVector4.Scalar1234;
                tempScalar[11] += mv1.KVector1.Scalar3 * mv2.KVector4.Scalar1234;
                tempScalar[13] += mv1.KVector1.Scalar2 * mv2.KVector4.Scalar1234;
                tempScalar[14] += -mv1.KVector1.Scalar1 * mv2.KVector4.Scalar1234;
            }
            
        }
        
        if (!mv1.KVector2.IsZero())
        {
            if (!mv2.KVector2.IsZero())
            {
                tempScalar[0] += -mv1.KVector2.Scalar12 * mv2.KVector2.Scalar12 + mv1.KVector2.Scalar13 * mv2.KVector2.Scalar13 + mv1.KVector2.Scalar23 * mv2.KVector2.Scalar23 + mv1.KVector2.Scalar14 * mv2.KVector2.Scalar14 + mv1.KVector2.Scalar24 * mv2.KVector2.Scalar24 - mv1.KVector2.Scalar34 * mv2.KVector2.Scalar34;
            }
            
            if (!mv2.KVector3.IsZero())
            {
                tempScalar[1] += mv1.KVector2.Scalar23 * mv2.KVector3.Scalar123 + mv1.KVector2.Scalar24 * mv2.KVector3.Scalar124 - mv1.KVector2.Scalar34 * mv2.KVector3.Scalar134;
                tempScalar[2] += -mv1.KVector2.Scalar13 * mv2.KVector3.Scalar123 - mv1.KVector2.Scalar14 * mv2.KVector3.Scalar124 - mv1.KVector2.Scalar34 * mv2.KVector3.Scalar234;
                tempScalar[4] += -mv1.KVector2.Scalar12 * mv2.KVector3.Scalar123 - mv1.KVector2.Scalar14 * mv2.KVector3.Scalar134 - mv1.KVector2.Scalar24 * mv2.KVector3.Scalar234;
                tempScalar[8] += -mv1.KVector2.Scalar12 * mv2.KVector3.Scalar124 + mv1.KVector2.Scalar13 * mv2.KVector3.Scalar134 + mv1.KVector2.Scalar23 * mv2.KVector3.Scalar234;
            }
            
            if (!mv2.KVector4.IsZero())
            {
                tempScalar[3] += -mv1.KVector2.Scalar34 * mv2.KVector4.Scalar1234;
                tempScalar[5] += -mv1.KVector2.Scalar24 * mv2.KVector4.Scalar1234;
                tempScalar[6] += mv1.KVector2.Scalar14 * mv2.KVector4.Scalar1234;
                tempScalar[9] += mv1.KVector2.Scalar23 * mv2.KVector4.Scalar1234;
                tempScalar[10] += -mv1.KVector2.Scalar13 * mv2.KVector4.Scalar1234;
                tempScalar[12] += -mv1.KVector2.Scalar12 * mv2.KVector4.Scalar1234;
            }
            
        }
        
        if (!mv1.KVector3.IsZero())
        {
            if (!mv2.KVector3.IsZero())
            {
                tempScalar[0] += -mv1.KVector3.Scalar123 * mv2.KVector3.Scalar123 - mv1.KVector3.Scalar124 * mv2.KVector3.Scalar124 + mv1.KVector3.Scalar134 * mv2.KVector3.Scalar134 + mv1.KVector3.Scalar234 * mv2.KVector3.Scalar234;
            }
            
            if (!mv2.KVector4.IsZero())
            {
                tempScalar[1] += -mv1.KVector3.Scalar234 * mv2.KVector4.Scalar1234;
                tempScalar[2] += mv1.KVector3.Scalar134 * mv2.KVector4.Scalar1234;
                tempScalar[4] += mv1.KVector3.Scalar124 * mv2.KVector4.Scalar1234;
                tempScalar[8] += -mv1.KVector3.Scalar123 * mv2.KVector4.Scalar1234;
            }
            
        }
        
        if (!mv1.KVector4.IsZero())
        {
            if (!mv2.KVector4.IsZero())
            {
                tempScalar[0] += mv1.KVector4.Scalar1234 * mv2.KVector4.Scalar1234;
            }
            
        }
        
        return Ga22Multivector.Create(tempScalar);
    }
    
}
