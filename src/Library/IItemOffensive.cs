using System.Dynamic;
using System.Runtime.CompilerServices;

public interface IItemOffensive : IItem
{
    int AttackValue
    {
        get; set;
    }
}