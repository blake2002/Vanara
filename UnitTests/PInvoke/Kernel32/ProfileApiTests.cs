﻿using NUnit.Framework;
using static Vanara.PInvoke.Kernel32;

namespace Vanara.PInvoke.Tests
{
	[TestFixture]
	public class ProfileApiTests
	{
		[Test]
		public void QueryPerformanceCounterTest()
		{
			Assert.That(QueryPerformanceCounter(out var cnt), Is.True);
			Assert.That(cnt, Is.GreaterThan(0));
		}

		[Test]
		public void QueryPerformanceFrequencyTest()
		{
			Assert.That(QueryPerformanceFrequency(out var fr), Is.True);
			Assert.That(fr, Is.GreaterThan(0));
		}
	}
}