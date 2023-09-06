using NUnit.Framework;
using TestDateFormat;

namespace Library.Tests;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void DataFormatterTests()
    {
        string testDate2 = "10/11/1997";
        string nuevafecha= DateFormatter.ChangeFormat(testDate2);
        Assert.AreEqual("1997/11/10", nuevafecha);
    }
    [Test]
    public void FechaEnOtroFormato()
    {
        string testDate2= "10-11-1997";
        string nuevafecha= DateFormatter.ChangeFormat(testDate2);
        Assert.AreEqual(testDate2, nuevafecha);
    }
    [Test]
    public void FechaEnBlanco()
    {
        string testDate2=string.Empty;
        string nuevafecha= DateFormatter.ChangeFormat(FechaEnBlanco);
        Assert.AreEqual(string.Empty, nuevafecha);
    }
}
