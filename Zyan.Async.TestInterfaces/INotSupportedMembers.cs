using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zyan.Async.TestInterfaces
{
	/// <remarks>
	/// Not supported member types: properties, indexers and events. Reasons:
	/// 1) C# doesn't support extension properties, indexers and events. Only extension methods are allowed.
	/// 2) Translating events and properties into extension methods ruins C# syntax sugar for events and properties.
	/// 3) Converting property/indexer type T -> Task<T> for property getter is Ok, but for setter is meaningless.
	/// </remarks>
	public interface INotSupportedMembers
	{
		// properties

		string Name { get; }

		int Quantity { get; set; }

		// indexers

		string this[int index] { get; }

		object this[string name, int index, object tag = null] { get; set; }

		// events

		event EventHandler Started;

		event EventHandler<CancelEventArgs> Stopping;

		event CancelEventHandler Closing;

		// dummy method (will be converted to assert that INotSupportedMembers interface is actually processed)

		void Dummy();
	}
}
