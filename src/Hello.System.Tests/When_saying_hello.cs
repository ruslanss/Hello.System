using NUnit.Framework;

namespace Hello.System.Tests
{
    public class When_saying_hello
    {
        [Test]
        public void Should_Greet_The_User()
        {
            Assert.That(Greeter.hello, Is.EqualTo("hi"));
        }
    }
}
