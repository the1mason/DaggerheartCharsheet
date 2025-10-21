using RhoMicro.CodeAnalysis;

namespace DaggerheartCharsheet.Core.Models;

public readonly partial struct Either<[UnionType(Alias = "Left")] TLeft, [UnionType(Alias = "Right")] TRight>
    where TLeft : notnull where TRight : notnull
{
    /*public static implicit operator Either<TLeft, TRight>(TLeft one) => new(one);
    public static implicit operator Either<TLeft, TRight>(TRight two) => new(two);*/
}