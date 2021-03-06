// <copyright file="BusinessPlayerTest.cs">Copyright ©  2017</copyright>

using System;
using Business;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Business.Tests
{
    [TestClass]
    [PexClass(typeof(BusinessPlayer))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class BusinessPlayerTest
    {

        [PexMethod]
        public int AddAccount(
            [PexAssumeUnderTest]BusinessPlayer target,
            string user,
            string pass,
            string IDCustomer
        )
        {
            int result = target.AddAccount(user, pass, IDCustomer);
            return result;
            // TODO: add assertions to method BusinessPlayerTest.AddAccount(BusinessPlayer, String, String, String)
        }
    }
}
