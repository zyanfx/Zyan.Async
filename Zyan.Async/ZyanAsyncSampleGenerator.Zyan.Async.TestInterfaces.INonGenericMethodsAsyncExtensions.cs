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
		public static System.Threading.Tasks.Task<System.Int32> GetValueAsync(this Zyan.Async.TestInterfaces.INonGenericMethods self)
		{
			return System.Threading.Tasks.Task.Run(() => self.GetValue());
		}

		// System.String GenerateName(Int32, System.Decimal)
		public static System.Threading.Tasks.Task<System.String> GenerateNameAsync(this Zyan.Async.TestInterfaces.INonGenericMethods self, System.Int32 a, System.Decimal b = 1.0M)
		{
			return System.Threading.Tasks.Task.Run(() => self.GenerateName(a, b));
		}

		// System.Object CreateMessage(System.String, System.Object[])
		public static System.Threading.Tasks.Task<System.Object> CreateMessageAsync(this Zyan.Async.TestInterfaces.INonGenericMethods self, System.String format = @"", params System.Object[] args)
		{
			return System.Threading.Tasks.Task.Run(() => self.CreateMessage(format, args));
		}

		// System.Collections.Generic.List`1[System.String] ConvertToStrings(System.Collections.Generic.IEnumerable`1[System.Int32])
		public static System.Threading.Tasks.Task<System.Collections.Generic.List<System.String>> ConvertToStringsAsync(this Zyan.Async.TestInterfaces.INonGenericMethods self, System.Collections.Generic.IEnumerable<System.Int32> ints = null)
		{
			return System.Threading.Tasks.Task.Run(() => self.ConvertToStrings(ints));
		}

		// System.String[,,,] MultidimensionalArrayExample(Int32[,,])
		public static System.Threading.Tasks.Task<System.String[,,,]> MultidimensionalArrayExampleAsync(this Zyan.Async.TestInterfaces.INonGenericMethods self, System.Int32[,,] a)
		{
			return System.Threading.Tasks.Task.Run(() => self.MultidimensionalArrayExample(a));
		}

		// Int32[][] JaggedArrayExample(System.String[][][])
		public static System.Threading.Tasks.Task<System.Int32[][]> JaggedArrayExampleAsync(this Zyan.Async.TestInterfaces.INonGenericMethods self, System.String[][][] x)
		{
			return System.Threading.Tasks.Task.Run(() => self.JaggedArrayExample(x));
		}

		// System.Collections.Generic.Dictionary`2[System.String,System.Collections.Generic.Dictionary`2[System.String,System.Int32]][] MixedArrayExample(System.Nullable`1[System.Int32][])
		public static System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Int32>>[]> MixedArrayExampleAsync(this Zyan.Async.TestInterfaces.INonGenericMethods self, System.Nullable<System.Int32>[] arg)
		{
			return System.Threading.Tasks.Task.Run(() => self.MixedArrayExample(arg));
		}

	}
} // Zyan.Async.TestInterfaces.INonGenericMethodsAsyncExtensions

