// Assembly name: Zyan.Async.TestInterfaces, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
namespace Zyan.Async.TestInterfaces
{
	// Rewriting XML comments is not supported
	#pragma warning disable 1591

	/// <summary>
	/// Asynchronous extension methods for the <see cref="Zyan.Async.TestInterfaces.INonGenericMethods" /> interface.
	/// </summary>
	public static class INonGenericMethodsAsyncExtensions
	{
		// Void Start()
		public static System.Threading.Tasks.Task StartAsync(this Zyan.Async.TestInterfaces.INonGenericMethods self)
		{
			return System.Threading.Tasks.Task.Run(() => self.Start());
		}

		// Int32 GetValue()
		public static System.Threading.Tasks.Task<int> GetValueAsync(this Zyan.Async.TestInterfaces.INonGenericMethods self)
		{
			return System.Threading.Tasks.Task.Run(() => self.GetValue());
		}

		// System.String GenerateName(Int32, System.Decimal)
		public static System.Threading.Tasks.Task<string> GenerateNameAsync(this Zyan.Async.TestInterfaces.INonGenericMethods self, int a, decimal b = 1.0M)
		{
			return System.Threading.Tasks.Task.Run(() => self.GenerateName(a, b));
		}

		// System.Object CreateMessage(System.String, System.Object[])
		public static System.Threading.Tasks.Task<object> CreateMessageAsync(this Zyan.Async.TestInterfaces.INonGenericMethods self, string format, params object[] args)
		{
			return System.Threading.Tasks.Task.Run(() => self.CreateMessage(format, args));
		}

		// System.Collections.Generic.List`1[System.String] ConvertToStrings(System.Collections.Generic.IEnumerable`1[System.Int32])
		public static System.Threading.Tasks.Task<System.Collections.Generic.List<string>> ConvertToStringsAsync(this Zyan.Async.TestInterfaces.INonGenericMethods self, System.Collections.Generic.IEnumerable<int> ints = null)
		{
			return System.Threading.Tasks.Task.Run(() => self.ConvertToStrings(ints));
		}

		// System.String[,,,] MultidimensionalArrayExample(Int32[,,])
		public static System.Threading.Tasks.Task<string[,,,]> MultidimensionalArrayExampleAsync(this Zyan.Async.TestInterfaces.INonGenericMethods self, int[,,] a)
		{
			return System.Threading.Tasks.Task.Run(() => self.MultidimensionalArrayExample(a));
		}

		// Int32[][] JaggedArrayExample(System.String[][][])
		public static System.Threading.Tasks.Task<int[][]> JaggedArrayExampleAsync(this Zyan.Async.TestInterfaces.INonGenericMethods self, string[][][] x)
		{
			return System.Threading.Tasks.Task.Run(() => self.JaggedArrayExample(x));
		}

		// System.Collections.Generic.Dictionary`2[System.String,System.Collections.Generic.Dictionary`2[System.String,System.Int32]][] MixedArrayExample(System.Nullable`1[System.Int32][])
		public static System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, int>>[]> MixedArrayExampleAsync(this Zyan.Async.TestInterfaces.INonGenericMethods self, System.Nullable<int>[] arg)
		{
			return System.Threading.Tasks.Task.Run(() => self.MixedArrayExample(arg));
		}

	}
} // Zyan.Async.TestInterfaces.INonGenericMethodsAsyncExtensions

