// Assembly name: Zyan.Async.TestInterfaces, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
namespace Zyan.Async.TestInterfaces
{
	// Rewriting XML comments is not supported
	#pragma warning disable 1591

	/// <summary>
	/// Asynchronous extension methods for the <see cref="Zyan.Async.TestInterfaces.IGenericInterface`2" /> interface.
	/// </summary>
	public static class IGenericInterfaceAsyncExtensions
	{
		// Void GenericProcedure(T)
		public static System.Threading.Tasks.Task GenericProcedureAsync<T, U>(this Zyan.Async.TestInterfaces.IGenericInterface<T, U> self, T value = null)
			where T : class
			where U : new()
		{
			return System.Threading.Tasks.Task.Run(() => self.GenericProcedure(value));
		}

		// T GenericFunction(U)
		public static System.Threading.Tasks.Task<T> GenericFunctionAsync<T, U>(this Zyan.Async.TestInterfaces.IGenericInterface<T, U> self, U value)
			where T : class
			where U : new()
		{
			return System.Threading.Tasks.Task.Run(() => self.GenericFunction(value));
		}

		// System.Collections.Generic.IList`1[T] GenericList(System.Collections.Generic.Dictionary`2[T,U])
		public static System.Threading.Tasks.Task<System.Collections.Generic.IList<T>> GenericListAsync<T, U>(this Zyan.Async.TestInterfaces.IGenericInterface<T, U> self, System.Collections.Generic.Dictionary<T, U> parameters)
			where T : class
			where U : new()
		{
			return System.Threading.Tasks.Task.Run(() => self.GenericList(parameters));
		}

		// System.Collections.Generic.List`1[System.Collections.Generic.Dictionary`2[T,System.Collections.Generic.HashSet`1[R]]] GenericMethod4[R](System.Func`2[T,U])
		public static System.Threading.Tasks.Task<System.Collections.Generic.List<System.Collections.Generic.Dictionary<T, System.Collections.Generic.HashSet<R>>>> GenericMethod4Async<T, U, R>(this Zyan.Async.TestInterfaces.IGenericInterface<T, U> self, System.Func<T, U> func)
			where T : class
			where U : new()
			where R : System.IDisposable
		{
			return System.Threading.Tasks.Task.Run(() => self.GenericMethod4<R>(func));
		}

		// System.Collections.Generic.IEnumerable`1[T] GetEnumerable[R](R)
		public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<T>> GetEnumerableAsync<T, U, R>(this Zyan.Async.TestInterfaces.IGenericInterface<T, U> self, R param = default(R))
			where T : class
			where U : new()
			where R : struct
		{
			return System.Threading.Tasks.Task.Run(() => self.GetEnumerable<R>(param));
		}

		// System.Linq.IQueryable`1[U] GetQuery[R](R)
		public static System.Threading.Tasks.Task<System.Linq.IQueryable<U>> GetQueryAsync<T, U, R>(this Zyan.Async.TestInterfaces.IGenericInterface<T, U> self, R param = null)
			where T : class
			where U : new()
			where R : System.IO.Stream, new()
		{
			return System.Threading.Tasks.Task.Run(() => self.GetQuery<R>(param));
		}

		// System.Collections.Generic.ICollection`1[R] GetCollection[R](R)
		public static System.Threading.Tasks.Task<System.Collections.Generic.ICollection<R>> GetCollectionAsync<T, U, R>(this Zyan.Async.TestInterfaces.IGenericInterface<T, U> self, R param = null)
			where T : class
			where U : new()
			where R : class, System.IDisposable, new()
		{
			return System.Threading.Tasks.Task.Run(() => self.GetCollection<R>(param));
		}

	}
} // Zyan.Async.TestInterfaces.IGenericInterfaceAsyncExtensions

