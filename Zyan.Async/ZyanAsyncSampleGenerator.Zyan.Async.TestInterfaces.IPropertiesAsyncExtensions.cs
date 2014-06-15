// Assembly name: Zyan.Async.TestInterfaces, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
namespace Zyan.Async.TestInterfaces
{
	// Rewriting XML comments is not supported
	#pragma warning disable 1591

	/// <summary>
	/// Asynchronous extension methods for the <see cref="Zyan.Async.TestInterfaces.IProperties" /> interface.
	/// </summary>
	public static class IPropertiesAsyncExtensions
	{
		// System.String get_Name()
		public static System.Threading.Tasks.Task<string> GetNameAsync(this Zyan.Async.TestInterfaces.IProperties self)
		{
			return System.Threading.Tasks.Task.Run(() => self.Name);
		}

		// Int32 get_Quantity()
		public static System.Threading.Tasks.Task<int> GetQuantityAsync(this Zyan.Async.TestInterfaces.IProperties self)
		{
			return System.Threading.Tasks.Task.Run(() => self.Quantity);
		}

		// Void set_Quantity(Int32)
		public static System.Threading.Tasks.Task SetQuantityAsync(this Zyan.Async.TestInterfaces.IProperties self, int value)
		{
			return System.Threading.Tasks.Task.Run(() => self.Quantity = value);
		}

		// System.String get_Item(Int32)
		public static System.Threading.Tasks.Task<string> GetItemAsync(this Zyan.Async.TestInterfaces.IProperties self, int index)
		{
			return System.Threading.Tasks.Task.Run(() => self[index]);
		}

		// System.Object get_Item(System.String, Int32, System.Object)
		public static System.Threading.Tasks.Task<object> GetItemAsync(this Zyan.Async.TestInterfaces.IProperties self, string name, int index, object tag = null)
		{
			return System.Threading.Tasks.Task.Run(() => self[name, index, tag]);
		}

		// Void set_Item(System.String, Int32, System.Object, System.Object)
		public static System.Threading.Tasks.Task SetItemAsync(this Zyan.Async.TestInterfaces.IProperties self, string name, int index, object tag, object value)
		{
			return System.Threading.Tasks.Task.Run(() => self[name, index, tag] = value);
		}

	}
} // Zyan.Async.TestInterfaces.IPropertiesAsyncExtensions

