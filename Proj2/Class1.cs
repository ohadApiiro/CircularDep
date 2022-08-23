using CircularDep;

namespace Proj2;

public class Class1
{
    public void Proj2Func()
    {
        var bar = new Bar();
        bar.BarFunc();
    }
}