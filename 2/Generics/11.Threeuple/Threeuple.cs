public class Threeuple<O1, O2, O3>
{
    private object ob1;
    private object ob2;
    private object ob3;

    public Threeuple(object ob1, object ob2, object ob3)
    {
        this.Ob1 = ob1;
        this.Ob2 = ob2;
        this.Ob3 = ob3;
    }

    public object Ob1
    {
        get
        {
            return ob1;
        }

        set
        {
            ob1 = value;
        }
    }

    public object Ob2
    {
        get
        {
            return ob2;
        }

        set
        {
            ob2 = value;
        }
    }

    public object Ob3
    {
        get
        {
            return ob3;
        }

        set
        {
            ob3 = value;
        }
    }

    public override string ToString()
    {
        return $"{this.Ob1} -> {this.Ob2} -> {this.Ob3}";
    }
}
