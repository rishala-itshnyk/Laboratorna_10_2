namespace Laboratorna_10_2.Tests;

[TestFixture]
public class Tests
{
    [Test]
    public void Count()
    {
        string filePath = "t.txt";
        string fileContent = "batman Bat jocker";
        File.WriteAllText(filePath, fileContent);

        try
        {
            int count = Program.Count(filePath);

            Assert.AreEqual(2, count);
        }
        finally
        {
            File.Delete(filePath);
        }
    }
}