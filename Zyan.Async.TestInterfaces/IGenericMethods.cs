using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zyan.Async.TestInterfaces
{
	public interface IGenericMethods
	{
		void GenericMethod1<T>();

		T GenericMethod2<T>();

		IList<T> GenericMethod3<T>(Dictionary<string, T> parameters);

		List<Dictionary<T, HashSet<R>>> GenericMethod4<T, R>(Func<R, T> func);

		IEnumerable<T> GetEnumerable<T>() where T : struct;

		IQueryable<T> GetQuery<T>() where T : class, IDisposable, new();
	}
}
