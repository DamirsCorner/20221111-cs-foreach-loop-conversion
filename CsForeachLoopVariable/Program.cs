var attributes = typeof(MyClass).GetCustomAttributes(typeof(FirstAttribute), false);

foreach (SecondAttribute attribute in attributes)
{
    //...
}

[AttributeUsage(AttributeTargets.Class)]
public class FirstAttribute : Attribute
{
}

[AttributeUsage(AttributeTargets.Class)]
public class SecondAttribute : Attribute
{
}

[First]
[Second]
public class MyClass
{
}