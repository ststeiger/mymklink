
using System;
using System.Collections.Generic;
using System.Text;


namespace MbUnit.FrameworkReplacement 
{


    internal class Assert
    {

        public static void IsTrue(bool b)
        { }

        public static void IsTrue(bool b, string Message)
        { }

        public static void IsFalse(bool b)
        { }

        public static void IsFalse(bool b, string Message)
        { }

        public static void AreEqual(object obj1, object obj2)
        { }

    }


    [AttributeUsage(AttributeTargets.All)]
    public class TestAttribute : System.Attribute
    { }

    [AttributeUsage(AttributeTargets.All)]
    public class TestFixtureAttribute : System.Attribute
    { }

    [AttributeUsage(AttributeTargets.All)]
    public class SetUpAttribute : System.Attribute
    { }

    [AttributeUsage(AttributeTargets.All)]
    public class TearDownAttribute : System.Attribute
    { }



    [AttributeUsage(AttributeTargets.All)]
    public class TestsOnAttribute : System.Attribute
    {
        public TestsOnAttribute() { }
        public TestsOnAttribute(Type t) { }
    }

    [AttributeUsage(AttributeTargets.All)]
    public class AuthorAttribute : System.Attribute
    {
        public AuthorAttribute() { }
        public AuthorAttribute(string name, string email) { }
    }


    [AttributeUsage(AttributeTargets.All)]
    public class ExpectedExceptionAttribute : System.Attribute
    {
        public ExpectedExceptionAttribute() { }
        public ExpectedExceptionAttribute(Type tException, string Message) { }
    }


}
