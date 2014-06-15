using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Zyan.Async.TestInterfaces;

namespace Zyan.Async.Tests
{
	class PropertyTests
	{
		private void Check(Action<IProperties> action)
		{
			Assert.NotNull(action);
		}

		[Fact]
		public void SimplePropertyGetTranslatesToGetAsync()
		{
			Check(async (self) =>
			{
				string s = await self.GetNameAsync();
				Task<string> ts = self.GetNameAsync();
				int q = await self.GetQuantityAsync();
				Task<int> tq = self.GetQuantityAsync();
			});
		}

		[Fact]
		public void SimplePropertySetTranslatesToSetAsync()
		{
			Check(async (self) =>
			{
				await self.SetQuantityAsync(123);
				Task tq = self.SetQuantityAsync(123);
			});
		}

		[Fact]
		public void IndexerGetTranslatesToGetItemAsync()
		{
			Check(async (self) =>
			{
				string s = await self.GetItemAsync(123);
				Task<string> ts = self.GetItemAsync(321);
				object o1 = await self.GetItemAsync("Name", 123, new object());
				Task<object> to1 = self.GetItemAsync("Same", 321, null);
				object o2 = await self.GetItemAsync("Name", 123); // default parameter value is supported
				Task<object> to2 = self.GetItemAsync("Same", 321);
			});
		}

		[Fact]
		public void IndexerSetTranslatesToSetItemAsync()
		{
			Check(async (self) =>
			{
				// default parameter value is not supported because of the last "value" parameter which doesn't have a default value
				await self.SetItemAsync("Name", 123, new object(), null);
				Task t = self.SetItemAsync("Same", 321, null, new object());
			});
		}
	}
}
