using Proj1;

namespace CircularDep;

public class Bar
{
    public void BarFunc()
    {
        var foo = new Foo();
    }
}