using System;

namespace Zyan.Async
{
    public partial class ZyanAsyncSamplePreprocessor
    {
		public string GetTypeName<T>()
		{
			return GetTypeName(typeof(T));
		}
	}
}
