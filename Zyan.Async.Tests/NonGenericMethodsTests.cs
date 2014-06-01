using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Zyan.Async.TestInterfaces;

namespace Zyan.Async.Tests
{
	public class NonGenericMethodsTests
	{
		private void Check<T>(Action<T> action)
		{
			Assert.NotNull(action);
		}

		[Fact]
		public void VoidConvertsToTask()
		{
			Check<INonGenericMethods>(self => self.StartAsync());
		}

		[Fact]
		public void IntConvertsToTaskInt()
		{
			Check<INonGenericMethods>(async (self) =>
			{
				int i = await self.GetValueAsync();
				Task<int> t = self.GetValueAsync();
			});
		}

		[Fact(Skip = "Not yet implemented")]
		public void DefaultParameterValuesArePreserved()
		{
			Check<INonGenericMethods>(async (self) =>
			{
				string a = await self.GenerateNameAsync(1, 1.0m);
				//string b = await self.GenerateNameAsync(1); // TODO: add default value support
			});
		}

		[Fact]
		public void ParamArrayAttributeIsSupported()
		{
			Check<INonGenericMethods>(async (self) =>
			{
				var a = await self.CreateMessageAsync("format1", 1, 2, 3);
				var b = await self.CreateMessageAsync(null, null);
				var c = await self.CreateMessageAsync(string.Empty, string.Empty, 1, 2, 3);
			});
		}

		[Fact]
		public void GenericTypesAreSupported()
		{
			Check<INonGenericMethods>(async (self) =>
			{
				List<string> r = await self.ConvertToStringsAsync(new[] { 1, 2, 3 });
				List<string> t = await self.ConvertToStringsAsync(null); // TODO: add default value support
			});
		}
	}
}
