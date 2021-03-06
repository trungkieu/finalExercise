using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business;
// <copyright file="BusinessPlayerTest.AddCustomer.g.cs">Copyright ©  2017</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace Business.Tests
{
    public partial class BusinessPlayerTest
    {

[TestMethod]
[PexGeneratedBy(typeof(BusinessPlayerTest))]
public void AddCustomer64()
{
    BusinessPlayer businessPlayer;
    int i;
    businessPlayer = new BusinessPlayer((string)null, (string)null);
    i = this.AddCustomer(businessPlayer, (string)null, (string)null, (string)null, 
                         (string)null, (string)null, (string)null, (string)null, (string)null);
    Assert.AreEqual<int>(0, i);
    Assert.IsNotNull((object)businessPlayer);
}

[TestMethod]
[PexGeneratedBy(typeof(BusinessPlayerTest))]
public void AddCustomer591()
{
    BusinessPlayer businessPlayer;
    int i;
    businessPlayer = new BusinessPlayer((string)null, (string)null);
    i = this.AddCustomer(businessPlayer, "", "", (string)null, 
                         (string)null, (string)null, (string)null, (string)null, (string)null);
    Assert.AreEqual<int>(0, i);
    Assert.IsNotNull((object)businessPlayer);
}

[TestMethod]
[PexGeneratedBy(typeof(BusinessPlayerTest))]
public void AddCustomer238()
{
    BusinessPlayer businessPlayer;
    int i;
    businessPlayer = new BusinessPlayer((string)null, (string)null);
    i = this.AddCustomer(businessPlayer, "", "", "", 
                         "", (string)null, (string)null, (string)null, (string)null);
    Assert.AreEqual<int>(0, i);
    Assert.IsNotNull((object)businessPlayer);
}

[TestMethod]
[PexGeneratedBy(typeof(BusinessPlayerTest))]
public void AddCustomer388()
{
    BusinessPlayer businessPlayer;
    int i;
    businessPlayer = new BusinessPlayer((string)null, (string)null);
    i = this.AddCustomer
            (businessPlayer, "", "", "", "", "", "", (string)null, (string)null);
    Assert.AreEqual<int>(0, i);
    Assert.IsNotNull((object)businessPlayer);
}

[TestMethod]
[PexGeneratedBy(typeof(BusinessPlayerTest))]
public void AddCustomer633()
{
    BusinessPlayer businessPlayer;
    int i;
    businessPlayer = new BusinessPlayer((string)null, (string)null);
    i = this.AddCustomer(businessPlayer, "", "", "", "", "", "", "", (string)null);
    Assert.AreEqual<int>(0, i);
    Assert.IsNotNull((object)businessPlayer);
}

[TestMethod]
[PexGeneratedBy(typeof(BusinessPlayerTest))]
public void AddCustomer653()
{
    BusinessPlayer businessPlayer;
    int i;
    businessPlayer = new BusinessPlayer((string)null, (string)null);
    i = this.AddCustomer(businessPlayer, "", "", "", 
                         "", "", (string)null, (string)null, (string)null);
    Assert.AreEqual<int>(0, i);
    Assert.IsNotNull((object)businessPlayer);
}

[TestMethod]
[PexGeneratedBy(typeof(BusinessPlayerTest))]
public void AddCustomer419()
{
    BusinessPlayer businessPlayer;
    int i;
    businessPlayer = new BusinessPlayer((string)null, (string)null);
    i = this.AddCustomer(businessPlayer, "", "", "", 
                         (string)null, (string)null, (string)null, (string)null, (string)null);
    Assert.AreEqual<int>(0, i);
    Assert.IsNotNull((object)businessPlayer);
}

[TestMethod]
[PexGeneratedBy(typeof(BusinessPlayerTest))]
public void AddCustomer491()
{
    BusinessPlayer businessPlayer;
    int i;
    businessPlayer = new BusinessPlayer((string)null, (string)null);
    i = this.AddCustomer(businessPlayer, "", (string)null, (string)null, 
                         (string)null, (string)null, (string)null, (string)null, (string)null);
    Assert.AreEqual<int>(0, i);
    Assert.IsNotNull((object)businessPlayer);
}
    }
}
