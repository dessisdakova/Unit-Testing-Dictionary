using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class NumberFrequencyTests
{
    [Test]
    public void Test_CountDigits_ZeroNumber_ReturnsEmptyDictionary()
    {
        // Arrange
        int input = 0;
        // Act 
        Dictionary<int, int> actual = NumberFrequency.CountDigits(input);
        // Assert
        Assert.That(actual.Count, Is.EqualTo(0));
    }

    [Test]
    public void Test_CountDigits_SingleDigitNumber_ReturnsDictionaryWithSingleEntry()
    {
        // Arrange
        int input = 7;
        // Act 
        Dictionary<int, int> actual = NumberFrequency.CountDigits(input);
        Dictionary<int, int> expected = new()
        {
            { 7, 1 }
        };
        // Assert
        Assert.That(actual.Count, Is.EqualTo(1));
        Assert.That(actual.ContainsKey(input));
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CountDigits_MultipleDigitNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        // Arrange
        int input = 12344555;
        // Act 
        Dictionary<int, int> actual = NumberFrequency.CountDigits(input);
        Dictionary<int, int> expected = new()
        {
            { 1, 1 },
            { 2, 1 },
            { 3, 1 },
            { 4, 2 },
            { 5, 3 }
        };
        // Assert
        Assert.That(actual.Count, Is.EqualTo(5));
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CountDigits_NegativeNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        // Arrange
        int input = -999764;
        // Act 
        Dictionary<int, int> actual = NumberFrequency.CountDigits(input);
        Dictionary<int, int> expected = new()
        {
            { 9, 3 },
            { 7, 1 },
            { 6, 1 },
            { 4, 1 }
        };
        // Assert
        Assert.That(actual.Count, Is.EqualTo(4));
        Assert.That(actual, Is.EqualTo(expected));
    }
}
