// <copyright file="UnitTestExampleTest.CapitalizeMaintainsLettersCount.g.cs">Copyright �  2013</copyright>
// <auto-generated>
// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
// </auto-generated>
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;

namespace UnitTesting.UnitTest
{
    public partial class UnitTestExampleTest
    {
[TestMethod]
[PexGeneratedBy(typeof(UnitTestExampleTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void CapitalizeMaintainsLettersCountThrowsArgumentNullException125()
{
    this.CapitalizeMaintainsLettersCount((string)null);
}
[TestMethod]
[PexGeneratedBy(typeof(UnitTestExampleTest))]
public void CapitalizeMaintainsLettersCount922()
{
    this.CapitalizeMaintainsLettersCount("");
}
[TestMethod]
[PexGeneratedBy(typeof(UnitTestExampleTest))]
public void CapitalizeMaintainsLettersCount526()
{
    this.CapitalizeMaintainsLettersCount("\0");
}
[TestMethod]
[PexGeneratedBy(typeof(UnitTestExampleTest))]
public void CapitalizeMaintainsLettersCount364()
{
    this.CapitalizeMaintainsLettersCount(":");
}
[TestMethod]
[PexGeneratedBy(typeof(UnitTestExampleTest))]
public void CapitalizeMaintainsLettersCount152()
{
    this.CapitalizeMaintainsLettersCount("a");
}
[TestMethod]
[PexGeneratedBy(typeof(UnitTestExampleTest))]
public void CapitalizeMaintainsLettersCount396()
{
    this.CapitalizeMaintainsLettersCount("aa");
}
[TestMethod]
[PexGeneratedBy(typeof(UnitTestExampleTest))]
public void CapitalizeMaintainsLettersCount217()
{
    this.CapitalizeMaintainsLettersCount("::");
}
[TestMethod]
[PexGeneratedBy(typeof(UnitTestExampleTest))]
public void CapitalizeMaintainsLettersCount554()
{
    this.CapitalizeMaintainsLettersCount("aaa\u8061");
}
[TestMethod]
[PexGeneratedBy(typeof(UnitTestExampleTest))]
public void CapitalizeMaintainsLettersCount783()
{
    this.CapitalizeMaintainsLettersCount("a:a\u8061");
}
    }
}
