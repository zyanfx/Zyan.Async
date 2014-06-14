// Assembly name: Zyan.Async.TestInterfaces, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
namespace Zyan.Async.TestInterfaces
{
	// Rewriting XML comments is not supported
	#pragma warning disable 1591

	/// <summary>
	/// Asynchronous extension methods for the <see cref="Zyan.Async.TestInterfaces.INotSupportedMembers" /> interface.
	/// </summary>
	public static class INotSupportedMembersAsyncExtensions
	{
		// Void Dummy()
		public static System.Threading.Tasks.Task DummyAsync(this Zyan.Async.TestInterfaces.INotSupportedMembers self)
		{
			return System.Threading.Tasks.Task.Run(() => self.Dummy());
		}

	}
} // Zyan.Async.TestInterfaces.INotSupportedMembersAsyncExtensions

