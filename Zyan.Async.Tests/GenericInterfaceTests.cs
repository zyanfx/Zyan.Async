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
				IList<string> l = await self.GenericListAsync(new Dictionary<string, object>());
			});
		}

		[Fact]
		public void GenericArgumentsOfTypeAndMethodAreConcatenated()
		{
			Check<string, object>(async self =>
			{
				List<Dictionary<string, HashSet<Stream>>> l = await self.GenericMethod4Async<string, object, Stream>(s => s);
			});
		}
	}
}
