using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Zyan.Async.Tests
{
	public class GetTypeConstraintsTests
	{
		private static void NoConstraints<T>() { }

		private static void StructConstraint<V>() where V : struct { }

		private static void ClassConstraint<C>() where C : class { }

		private static void TypeConstraint<T>() where T : Stream { }

		private static void DefaultConstructorConstraint<C>() where C : new() { }

		private static void ConcreteTypeConstraint<I>() where I : class, IDisposable { }

		private static void ComplexConstraint<X>() where X : class, IDisposable, new() { }

		private Type GetTypeParameter(Action a)
		{
			return a.Method.GetGenericMethodDefinition().GetGenericArguments().First();
		}

		private string GetTypeConstraints(Action a)
		{
			return new ZyanAsyncSamplePreprocessor().GetTypeConstraints(GetTypeParameter(a));
		}

		[Fact]
		public void NoConstraintsYieldsNull()
		{
			Assert.Null(GetTypeConstraints(NoConstraints<int>));
		}

		[Fact]
		public void StructConstraintYieldsStructKeyword()
		{
			Assert.Equal("where V : struct", GetTypeConstraints(StructConstraint<int>));
		}

		[Fact]
		public void ClassConstraintYieldsClassKeyword()
		{
			Assert.Equal("where C : class", GetTypeConstraints(ClassConstraint<object>));
		}

		[Fact]
		public void TypeConstraintYieldsTypeFullName()
		{
			Assert.Equal("where T : System.IO.Stream", GetTypeConstraints(TypeConstraint<FileStream>));
		}

		[Fact]
		public void DefaultConstructorConstraintYieldsNewKeywork()
		{
			Assert.Equal("where C : new()", GetTypeConstraints(DefaultConstructorConstraint<MemoryStream>));
		}

		[Fact]
		public void ConcreteTypeConstraintYieldsClassKeyworkWithTypeFullName()
		{
			Assert.Equal("where I : class, System.IDisposable", GetTypeConstraints(ConcreteTypeConstraint<FileStream>));
		}

		[Fact]
		public void ComplexConstraintYieldsClassKeyworkTypeFullNameAndNewKeyword()
		{
			Assert.Equal("where X : class, System.IDisposable, new()", GetTypeConstraints(ComplexConstraint<MemoryStream>));
		}
	}
}
