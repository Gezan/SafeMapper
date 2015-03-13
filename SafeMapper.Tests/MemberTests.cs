﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeMapper.Tests
{
    using System.Collections.Specialized;

    using NUnit.Framework;

    using SafeMapper.Reflection;

    [TestFixture]
    public class MemberTests
    {
        [Test]
        public void Ctor_ConstructorInfo_SHouldBeMethodTypeUndefined()
        {
            var constructor = typeof(NameValueCollection).GetConstructor(Type.EmptyTypes);

            var member = new Member(constructor);

            Assert.AreEqual(MemberType.Undefined, member.MemberType);
        }
    }
}
