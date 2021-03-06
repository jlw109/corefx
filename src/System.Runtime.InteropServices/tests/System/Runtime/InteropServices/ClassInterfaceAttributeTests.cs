// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Xunit;

namespace System.Runtime.InteropServices.Tests
{
    public class ClassInterfaceAttributeTests
    {
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(4)]
        public void Ctor_ShortClassInterfaceType(short classInterfaceType)
        {
            var attribute = new ClassInterfaceAttribute(classInterfaceType);
            Assert.Equal((ClassInterfaceType)classInterfaceType, attribute.Value);
        }

        [Theory]
        [InlineData((ClassInterfaceType)(-1))]
        [InlineData(ClassInterfaceType.None)]
        [InlineData((ClassInterfaceType)4)]
        public void Ctor_ClassInterfaceType(ClassInterfaceType classInterfaceType)
        {
            var attribute = new ClassInterfaceAttribute(classInterfaceType);
            Assert.Equal(classInterfaceType, attribute.Value);
        }
    }
}
