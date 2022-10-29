var attributes = typeof(MyClass).GetCustomAttributes(typeof(FirstAttribute), false);

foreach (var attribute in attributes)
{
    SecondAttribute secondAttribute = (SecondAttribute)attribute;
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