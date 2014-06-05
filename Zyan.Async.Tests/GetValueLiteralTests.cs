using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Zyan.Async.Tests
{
	public class GetValueLiteralTests
	{
		ZyanAsyncSamplePreprocessor codeGen = new ZyanAsyncSamplePreprocessor();

		[Fact]
		public void GetTrivialLiteralsWorksFine()
		{
			Assert.Equal("null", codeGen.GetValueLiteral(null));
			Assert.Equal("true", codeGen.GetValueLiteral(true));
			Assert.Equal("false", codeGen.GetValueLiteral(false));
			Assert.Equal("System.DayOfWeek.Saturday", codeGen.GetValueLiteral(DayOfWeek.Saturday));
		}

		[Fact]
		public void GetNumericLiteralsWorksGreat()
		{
			Assert.Equal("1", codeGen.GetValueLiteral(1));
			Assert.Equal("-1", codeGen.GetValueLiteral(-1));
			Assert.Equal("123U", codeGen.GetValueLiteral(123U));
			Assert.Equal("0L", codeGen.GetValueLiteral(0L));
			Assert.Equal("-10L", codeGen.GetValueLiteral(-10L));
			Assert.Equal("10UL", codeGen.GetValueLiteral(10UL));
			Assert.Equal("-100.00M", codeGen.GetValueLiteral(-100.00M));
			Assert.Equal("-100F", codeGen.GetValueLiteral(-100F));
			Assert.Equal("123D", codeGen.GetValueLiteral(123D));
		}

		[Fact]
		public void GetStringLiteralsWorksPerfectly()
		{
			Assert.Equal(@"@""""", codeGen.GetValueLiteral(string.Empty));
			Assert.Equal(@"@""123""", codeGen.GetValueLiteral("123"));
			Assert.Equal(@"@""Quotes """" and '""", codeGen.GetValueLiteral("Quotes \" and \'"));
		}
	}
}
