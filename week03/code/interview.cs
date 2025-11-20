using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

public class Interview
{
    // An intersection of two sets contains items that are in both of the two sets.
    // A union of two sets contains all items that are in either set.

    /// <summary>
    /// Given two sets, return a new set that is the intersection of the two sets.
    /// For example, the intersection of {1,2,3} and {2,3,4} is {2,3}.
    /// <params name="set1">The first set.</param>
    /// <params name="set2">The second set.</param>
    /// <returns>The intersection of the two sets.</returns>
    /// </summary>
    public static string[] Intersection(string[] set1, string[] set2)
    {
        var result = new HashSet<string>();
        var set2Lookup = new HashSet<string>(set2);

        foreach (var item in set1)
        {
            if (set2Lookup.Contains(item))
            {
                result.Add(item);
            }
        }

        return result.ToArray();
    }

    /// <summary>
    /// Given two sets, return a new set that is the union of the two sets.
    /// For example, the union of {1,2,3} and {2,3,4} is {1,2,3,4}.
    /// <params name="set1">The first set.</param>
    /// <params name="set2">The second set.</param>
    /// <returns>The union of the two sets.</returns>
    /// </summary>
    public static string[] Union(string[] set1, string[] set2)
    {
        var result = new HashSet<string>(set1);
        foreach (var item in set2)
        {
            result.Add(item);
        }
        return result.ToArray();
    }

}

[TestClass]
public class InterviewTests
{
    // Intersection Tests
    [TestMethod]
    public void TestIntersection1()
    {
        var set1 = new string[] { "a", "b", "c", "d" };
        var set2 = new string[] { "c", "d", "e", "f" };
        var expected = new string[] { "c", "d" };

        var actual = Interview.Intersection(set1, set2);

        CollectionAssert.AreEquivalent(expected, actual);
    }
    [TestMethod]
    public void TestIntersection2()
    {
        var set1 = new string[] { "a", "b", "c", "d" };
        var set2 = new string[] { "e", "f", "g", "h" };
        var expected = new string[] { };

        var actual = Interview.Intersection(set1, set2);

        CollectionAssert.AreEquivalent(expected, actual);
    }
    [TestMethod]
    public void TestIntersection3()
    {
        var set1 = new string[] { "a", "b", "c", "d" };
        var set2 = new string[] { "a", "b", "c", "d" };
        var expected = new string[] { "a", "b", "c", "d" };

        var actual = Interview.Intersection(set1, set2);

        CollectionAssert.AreEquivalent(expected, actual);
    }

    // Union Tests
    [TestMethod]
    public void TestUnion1()
    {
        var set1 = new string[] { "a", "b", "c", "d" };
        var set2 = new string[] { "c", "d", "e", "f" };
        var expected = new string[] { "a", "b", "c", "d", "e", "f" };

        var actual = Interview.Union(set1, set2);

        CollectionAssert.AreEquivalent(expected, actual);
    }
    [TestMethod]
    public void TestUnion2()
    {
        var set1 = new string[] { "a", "b", "c", "d" };
        var set2 = new string[] { "e", "f", "g", "h" };
        var expected = new string[] { "a", "b", "c", "d", "e", "f", "g", "h" };

        var actual = Interview.Union(set1, set2);

        CollectionAssert.AreEquivalent(expected, actual);
    }
    [TestMethod]
    public void TestUnion3()
    {
        var set1 = new string[] { "a", "b", "c", "d" };
        var set2 = new string[] { "a", "b", "c", "d" };
        var expected = new string[] { "a", "b", "c", "d" };

        var actual = Interview.Union(set1, set2);

        CollectionAssert.AreEquivalent(expected, actual);
    }
}
