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
		private void Check(Action<INonGenericMethods> action)
		{
			Assert.NotNull(action);
		}

		[Fact]
		public void VoidConvertsToTask()
		{
			Check(self => self.StartAsync());
		}

		[Fact]
		public void ReturnTypeConvertsToTaskType()
		{
			Check(async (self) =>
			{
				int i = await self.GetValueAsync();
				Task<int> t = self.GetValueAsync();
			});
		}

		[Fact(Skip = "Not yet implemented")]
		public void DefaultParameterValuesArePreserved()
		{
			Check(async (self) =>
			{
				string a = await self.GenerateNameAsync(1, 1.0m);
				//string b = await self.GenerateNameAsync(1); // TODO: add default value support
			});
		}

		[Fact]
		public void ParamArrayAttributeIsSupported()
		{
			Check(async (self) =>
			{
				var a = await self.CreateMessageAsync("format1", 1, 2, 3);
				var b = await self.CreateMessageAsync(null, null);
				var c = await self.CreateMessageAsync(string.Empty, string.Empty, 1, 2, 3);
			});
		}

		[Fact]
		public void GenericTypesAreSupported()
		{
			Check(async (self) =>
			{
				List<string> r = await self.ConvertToStringsAsync(new[] { 1, 2, 3 });
				List<string> t = await self.ConvertToStringsAsync(null); // TODO: add default value support
			});
		}

		[Fact]
		public void MultidimensionalArrayTypesAreSupported()
		{
			Check(async (self) =>
			{
				var multidimensional = new int [1, 2, 3];
				string[, , ,] result = await self.MultidimensionalArrayExampleAsync(multidimensional);
			});
		}

		[Fact]
		public void JaggedArrayTypesAreSupported()
		{
			Check(async (self) =>
			{
				var jagged = new string[1][][];
				int[][] result = await self.JaggedArrayExampleAsync(jagged);
			});
		}

		[Fact]
		public void MixedGenerixArrayTypesAreSupported()
		{
			Check(async (self) =>
			{
				var nullableIntArray = new[] { (int?)1, 0, null };
				Dictionary<string, Dictionary<string,int>>[] result = await self.MixedArrayExampleAsync(nullableIntArray);
			});
		}
	}
}
