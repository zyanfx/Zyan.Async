using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zyan.Async.TestInterfaces
{
	public interface IProperties
	{
		// properties (supported)

		string Name { get; }

		int Quantity { get; set; }

		// indexers (supported)

		string this[int index] { get; }

		object this[string name, int index, object tag = null] { get; set; }

		// events (not yet supported)

		event EventHandler Started;

		event EventHandler<CancelEventArgs> Stopping;

		event CancelEventHandler Closing;
	}
}

// Events:
// async Task SubscribeStartedAsync(EventHandler<CancelEventArgs> handler)
// async Task UnsubscribeStartedAsync(EventHandler<CancelEventArgs> handler)
