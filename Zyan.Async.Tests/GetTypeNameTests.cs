using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Zyan.Async.Tests
{
	public class GetTypeNameTests
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
			Assert.Equal("int", codeGen.GetTypeName<int>());
			Assert.Equal("System.Linq.Expressions.Expression", codeGen.GetTypeName<System.Linq.Expressions.Expression>());
		}

		[Fact]
		public void GetNameOfArrayTypeReturnsCSharpArraySyntax()
		{
			Assert.Equal("byte[]", codeGen.GetTypeName<byte[]>());
			Assert.Equal("System.IDisposable[]", codeGen.GetTypeName<IDisposable[]>());
		}

		[Fact]
		public void GetNameOfGenericTypeReturnsCSharpGenericTypeSyntax()
		{
			Assert.Equal("System.Collections.Generic.List<string>", codeGen.GetTypeName<System.Collections.Generic.List<System.String>>());
			Assert.Equal("System.Collections.Generic.IDictionary<string, object>", codeGen.GetTypeName<System.Collections.Generic.IDictionary<System.String, System.Object>>());
		}

		[Fact]
		public void BuiltInTypesAreConvertedToCSharpAliases()
		{
			Assert.Equal("object", codeGen.GetTypeName<object>());
			Assert.Equal("string", codeGen.GetTypeName<string>());
			Assert.Equal("char", codeGen.GetTypeName<char>());
			Assert.Equal("int", codeGen.GetTypeName<int>());
			Assert.Equal("uint", codeGen.GetTypeName<uint>());
			Assert.Equal("long", codeGen.GetTypeName<long>());
			Assert.Equal("ulong", codeGen.GetTypeName<ulong>());
			Assert.Equal("byte", codeGen.GetTypeName<byte>());
			Assert.Equal("sbyte", codeGen.GetTypeName<sbyte>());
			Assert.Equal("short", codeGen.GetTypeName<short>());
			Assert.Equal("ushort", codeGen.GetTypeName<ushort>());
			Assert.Equal("decimal", codeGen.GetTypeName<decimal>());
			Assert.Equal("float", codeGen.GetTypeName<float>());
			Assert.Equal("double", codeGen.GetTypeName<double>());
			Assert.Equal("byte[]", codeGen.GetTypeName<byte[]>());
		}
	}
}
