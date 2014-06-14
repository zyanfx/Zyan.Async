// Assembly name: Zyan.Async.TestInterfaces, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
namespace Zyan.Async.TestInterfaces
{
	// Rewriting XML comments is not supported
	#pragma warning disable 1591

	/// <summary>
	/// Asynchronous extension methods for the <see cref="Zyan.Async.TestInterfaces.IGenericMethods" /> interface.
	/// </summary>
	public static class IGenericMethodsAsyncExtensions
	{
		// Void GenericMethod1[T]()
		public static System.Threading.Tasks.Task GenericMethod1Async<T>(this Zyan.Async.TestInterfaces.IGenericMethods self)
		{
			return System.Threading.Tasks.Task.Run(() => self.GenericMethod1<T>());
		}

		// T GenericMethod2[T]()
		public static System.Threading.Tasks.Task<T> GenericMethod2Async<T>(this Zyan.Async.TestInterfaces.IGenericMethods self)
		{
			return System.Threading.Tasks.Task.Run(() => self.GenericMethod2<T>());
		}

		// System.Collections.Generic.IList`1[T] GenericMethod3[T](System.Collections.Generic.Dictionary`2[System.String,T])
		public static System.Threading.Tasks.Task<System.Collections.Generic.IList<T>> GenericMethod3Async<T>(this Zyan.Async.TestInterfaces.IGenericMethods self, System.Collections.Generic.Dictionary<System.String, T> parameters)
		{
			return System.Threading.Tasks.Task.Run(() => self.GenericMethod3<T>(parameters));
		}

		// System.Collections.Generic.List`1[System.Collections.Generic.Dictionary`2[T,System.Collections.Generic.HashSet`1[R]]] GenericMethod4[T,R](System.Func`2[R,T])
		public static System.Threading.Tasks.Task<System.Collections.Generic.List<System.Collections.Generic.Dictionary<T, System.Collections.Generic.HashSet<R>>>> GenericMethod4Async<T, R>(this Zyan.Async.TestInterfaces.IGenericMethods self, System.Func<R, T> func = null)
		{
			return System.Threading.Tasks.Task.Run(() => self.GenericMethod4<T, R>(func));
		}

		// System.Collections.Generic.IEnumerable`1[T] GetEnumerable[T]()
		public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<T>> GetEnumerableAsync<T>(this Zyan.Async.TestInterfaces.IGenericMethods self)
			where T : struct
		{
			return System.Threading.Tasks.Task.Run(() => self.GetEnumerable<T>());
		}

		// System.Linq.IQueryable`1[T] GetQuery[T]()
		public static System.Threading.Tasks.Task<System.Linq.IQueryable<T>> GetQueryAsync<T>(this Zyan.Async.TestInterfaces.IGenericMethods self)
			where T : class, System.IDisposable, new()
		{
			return System.Threading.Tasks.Task.Run(() => self.GetQuery<T>());
		}

	}
} // Zyan.Async.TestInterfaces.IGenericMethodsAsyncExtensions

