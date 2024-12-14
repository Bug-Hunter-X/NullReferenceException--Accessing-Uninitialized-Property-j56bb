public class ExampleClass
{
    public int MyProperty { get; set; }

    // Constructor to initialize the property
    public ExampleClass()
    {
        MyProperty = 0; // Or another default value
    }

    public void MyMethod()
    {
        Console.WriteLine(MyProperty.ToString()); 
    }
}