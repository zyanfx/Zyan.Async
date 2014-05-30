using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zyan.Async.TestInterfaces
{
	public interface INonGenericMethods
	{
		void Start();

		int GetValue();

		string GenerateName(int a, decimal b = 1.0m);

		object CreateMessage(string format = "", params object[] args);

		List<string> ConvertToStrings(IEnumerable<int> ints = null);
	}
}
