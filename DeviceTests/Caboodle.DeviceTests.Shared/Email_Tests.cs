﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Caboodle;
using Xunit;

namespace Caboodle.DeviceTests
{
    public class Email_Tests
    {
        [Fact]
        public void IsComposeSupported()
        {
            Assert.True(Email.IsComposeSupported == true);
        }
    }
}
