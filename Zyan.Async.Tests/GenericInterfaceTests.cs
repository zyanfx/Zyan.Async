using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Zyan.Async.TestInterfaces;

namespace Zyan.Async.Tests
{
	class GenericInterfaceTests
	{
		private void Check<T, U>(Action<IGenericInterface<T, U>> action) where T : class where U : new()
		{
			Assert.NotNull(action);
		}

		[Fact]
		public void VoidConvertsToTask()
		{
			Check<string, object>(self => self.GenericProcedureAsync(string.Empty));
			Check<object, object>(self => self.GenericProcedureAsync());
		}

		[Fact]
		public void TypeConvertsToTaskType()
		{
			Check<string, object>(async self =>
			{
				string a = await self.GenericFunctionAsync(null);
				Task<string> ta = self.GenericFunctionAsync(default(object));
				IList<string> l = await self.GenericListAsync(new Dictionary<string, object>());
				Task<IList<string>> tl = self.GenericListAsync(default(Dictionary<string, object>));
				IEnumerable<string> e1 = await self.GetEnumerableAsync<string, object, int>();
				IEnumerable<string> e2 = await self.GetEnumerableAsync(1);
				Task<IEnumerable<string>> te = self.GetEnumerableAsync(default(DateTime));
				IQueryable<object> q1 = await self.GetQueryAsync<string, object, MemoryStream>();
				IQueryable<object> q2 = await self.GetQueryAsync(new MemoryStream());
				Task<IQueryable<object>> tq = self.GetQueryAsync(default(MemoryStream));
				ICollection<SecureString> c1 = await self.GetCollectionAsync<string, object, SecureString>();
				ICollection<SecureString> c2 = await self.GetCollectionAsync(new SecureString());
				Task<ICollection<SecureString>> tc = self.GetCollectionAsync(default(SecureString));
			});
		}

		[Fact]
		public void GenericArgumentsOfTypeAndMethodAreConcatenated()
		{
			Check<string, object>(async self =>
			{
				List<Dictionary<string, HashSet<Stream>>> l = await self.GenericMethod4Async<string, object, Stream>(s => s);
				Task<List<Dictionary<string, HashSet<Stream>>>> tl = self.GenericMethod4Async<string, object, Stream>(null);
			});
		}
	}
}
