using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Zyan.Async.TestInterfaces;

namespace Zyan.Async.Tests
{
	public class GenericMethodsTests
	{
		private void Check(Action<IGenericMethods> action)
		{
			Assert.NotNull(action);
		}

		[Fact]
		public void VoidConvertsToTask()
		{
			Check(self => self.GenericMethod1Async<int>());
			Check(self => self.GenericMethod1Async<string>());
		}

		[Fact]
		public void ReturnTypeConvertsToTaskType()
		{
			Check(async (self) =>
			{
				int i = await self.GenericMethod2Async<int>();
				Task<string> t = self.GenericMethod2Async<string>();
			});
		}

		public void ComplexGenericReturnAndParameterTypesAreSupported()
		{
			Check(async (self) =>
			{
				IList<Guid> lg = await self.GenericMethod3Async(new Dictionary<string, Guid>());
				IList<string> ls = await self.GenericMethod3Async<string>(null);
			});
		}

		[Fact]
		public void SeveralGenericParametersAreSupported()
		{
			Check(async (self) =>
			{
				List<Dictionary<int, HashSet<string>>> a = await self.GenericMethod4Async<int, string>(x => x.Length);
				List<Dictionary<string, HashSet<int>>> b = await self.GenericMethod4Async(new Func<int, string>(x => x.ToString()));
				List<Dictionary<short, HashSet<byte>>> c = await self.GenericMethod4Async((byte x) => (short)x);
			});
		}

		[Fact]
		public void IEnumerableExample()
		{
			Check(async (self) =>
			{
				var query = await GetEnumerableAsync<int>(self);
				int[] result = query.ToArray();
			});
		}

		private Task<IEnumerable<T>> GetEnumerableAsync<T>(IGenericMethods self) where T : struct
		{
			return self.GetEnumerableAsync<T>();
		}

		[Fact]
		public void IQueryableExample()
		{
			Check(async (self) =>
			{
				var query = await GetQueryAsync<MemoryStream>(self);
				MemoryStream[] result = query.ToArray();
			});
		}

		private Task<IQueryable<T>> GetQueryAsync<T>(IGenericMethods self) where T : class, IDisposable, new()
		{
			return self.GetQueryAsync<T>();
		}
	}
}
