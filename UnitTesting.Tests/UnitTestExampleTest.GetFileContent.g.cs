// <copyright file="UnitTestExampleTest.GetFileContent.g.cs">Copyright �  2013</copyright>
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
[HostType("Moles")]
public void GetFileContent206()
{
    this.GetFileContent("\0");
}
[TestMethod]
[PexGeneratedBy(typeof(UnitTestExampleTest))]
[ExpectedException(typeof(InvalidOperationException))]
[HostType("Moles")]
public void GetFileContentThrowsInvalidOperationException84()
{
    this.GetFileContent((string)null);
}
[TestMethod]
[PexGeneratedBy(typeof(UnitTestExampleTest))]
[ExpectedException(typeof(InvalidOperationException))]
[HostType("Moles")]
public void GetFileContentThrowsInvalidOperationException19()
{
    this.GetFileContent("");
}
    }
}
