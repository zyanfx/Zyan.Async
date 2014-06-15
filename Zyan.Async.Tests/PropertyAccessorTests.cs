using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Zyan.Async.Tests
{
	public class PropertyAccessorTests
	{
		private ZyanAsyncSamplePreprocessor codeGen = new ZyanAsyncSamplePreprocessor();

		[Fact]
		public void IsAccessorReturnsFalseForNonPropertyMethods()
		{
			var method = new Action(IsAccessorReturnsFalseForNonPropertyMethods).Method;
			Assert.NotNull(method);
			Assert.False(codeGen.IsPropertyGetAccessor(method));
			Assert.False(codeGen.IsPropertySetAccessor(method));
		}

		[Fact]
		public void IsGetAccessorReturnsTrueForPropertyGetAccessor()
		{
			var method = typeof(string).GetMethod("get_Length");
			Assert.NotNull(method);
			Assert.True(codeGen.IsPropertyGetAccessor(method));
			Assert.False(codeGen.IsPropertySetAccessor(method));
		}

		[Fact]
		public void IsSetAccessorReturnsTrueForPropertySetAccessor()
		{
			var method = typeof(IComponent).GetMethod("set_Site");
			Assert.NotNull(method);
			Assert.False(codeGen.IsPropertyGetAccessor(method));
			Assert.True(codeGen.IsPropertySetAccessor(method));
		}

		[Fact]
		public void GetPropertyNameReturnsPropertyName()
		{
			var method = typeof(IComponent).GetMethod("set_Site");
			Assert.NotNull(method);
			Assert.Equal("Site", codeGen.GetPropertyInfo(method).Name);

			method = typeof(string).GetMethod("get_Length");
			Assert.NotNull(method);
			Assert.Equal("Length", codeGen.GetPropertyInfo(method).Name);
		}

		[Fact]
		public void FormatMethodNameForOrdinalMethodReturnsMethodNameWithAsyncSuffix()
		{
			var method = new Action(FormatMethodNameForOrdinalMethodReturnsMethodNameWithAsyncSuffix).Method;
			Assert.NotNull(method);
			Assert.Equal("FormatMethodNameForOrdinalMethodReturnsMethodNameWithAsyncSuffixAsync", codeGen.FormatMethodName(method));
		}

		[Fact]
		public void FormatMethodNameForPropertyGetterReturnsGetMethodNameAsync()
		{
			var method = typeof(string).GetMethod("get_Length");
			Assert.NotNull(method);
			Assert.Equal("GetLengthAsync", codeGen.FormatMethodName(method));
		}

		[Fact]
		public void FormatMethodNameForPropertySetterReturnsSetMethodNameAsync()
		{
			var method = typeof(IComponent).GetMethod("set_Site");
			Assert.NotNull(method);
			Assert.Equal("SetSiteAsync", codeGen.FormatMethodName(method));
		}
	}
}
