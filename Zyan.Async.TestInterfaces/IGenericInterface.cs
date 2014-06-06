using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zyan.Async.TestInterfaces
{
	public interface IGenericInterface<T, U> where T : class where U : new()
	{
		void GenericProcedure(T value = default(T));

		T GenericFunction(U value);

		IList<T> GenericList(Dictionary<T, U> parameters);

		List<Dictionary<T, HashSet<R>>> GenericMethod4<R>(Func<T, U> func) where R : IDisposable;

		IEnumerable<T> GetEnumerable<R>(R param = default(R)) where R : struct;

		IQueryable<U> GetQuery<R>(R param = default(R)) where R : Stream, new();

		ICollection<R> GetCollection<R>(R param = default(R)) where R : class, IDisposable, new();
	}
}
