# NullReferenceException in C#: Accessing Uninitialized Property

This example demonstrates a common error in C# that often leads to `NullReferenceException`s.  The issue arises from attempting to access a property of a class before it has been assigned a value.

**Problem:**
The `ExampleClass` has a property `MyProperty`. The `MyMethod` attempts to print the value of `MyProperty` without first assigning it a value. This results in a `NullReferenceException` because the property is `null`.

**Solution:**
The solution involves initializing the property either in the constructor or directly before accessing it.
