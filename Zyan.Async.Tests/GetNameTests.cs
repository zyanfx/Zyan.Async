using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Zyan.Async.Tests
{
	public class GetNameTests
	{
		private ZyanAsyncSamplePreprocessor codeGen = new ZyanAsyncSamplePreprocessor();

		[Fact]
		public void GetNameOfNullReturnsEmptyString()
		{
			Assert.Equal(string.Empty, codeGen.GetTypeName(null));
		}

		[Fact]
		public void GetNameOfSimpleTypeReturnsTypeFullName()
		{
			Assert.Equal("System.Int32", codeGen.GetTypeName<int>());
			Assert.Equal("System.Linq.Expressions.Expression", codeGen.GetTypeName<System.Linq.Expressions.Expression>());
		}

		[Fact]
		public void GetNameOfArrayTypeReturnsCSharpArraySyntax()
		{
			Assert.Equal("System.Byte[]", codeGen.GetTypeName<byte[]>());
			Assert.Equal("System.IDisposable[]", codeGen.GetTypeName<IDisposable[]>());
		}

		[Fact]
		public void GetNameOfGenericTypeReturnsCSharpGenericTypeSyntax()
		{
			Assert.Equal("System.Collections.Generic.List<System.String>", codeGen.GetTypeName<System.Collections.Generic.List<System.String>>());
			Assert.Equal("System.Collections.Generic.IDictionary<System.String, System.Object>", codeGen.GetTypeName<System.Collections.Generic.IDictionary<System.String, System.Object>>());
		}
	}
}
