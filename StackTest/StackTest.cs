using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Schema;
using Xunit;

namespace Stack.Test
{
    public class StackTestLinkedListBased
    {
        //[Fact]
        //public void ListCountIsZeroWhenEmpty()
        //{
        //    int[] list = new int[5];
        //    Assert.Empty(list);
        //}
        //[Fact]
        //public void ListHeadTailAreNullWhenEmpty()
        //{
        //    int[] list = new int[5];
        //    Assert.Null(list.Head);
        //    Assert.Null(list.Tail);
        //}

        //[Theory]
        //[InlineData(0, new int[] { })]
        //[InlineData(1, new int[] { 1 })]
        //[InlineData(5, new int[] { 1, 2, 3, 4, 5 })]
        //public void PushTest(int expectedCount, int[] values)
        //{
        //    int[] stack = new int[5];
        //    foreach (var item in values)
        //    {
        //        Stack.Stack.Push(item);
        //    }

        //    Assert.Equal(expectedCount, stack.Count);
        //    if (expectedCount > 0)
        //    {
        //        Assert.Equal(stack.Head.prev, stack.Tail);
        //        Assert.Equal(stack.Tail.next, stack.Head);
        //        Assert.NotNull(stack.Head);
        //        Assert.NotNull(stack.Tail);
        //        Assert.Equal(values[0], stack.Head.data);
        //        Assert.Equal(values[values.Length - 1], Stack.addAt);
        //    }
        //}
        //[Theory]
        //[InlineData(0, new int[] { })]
        //[InlineData(1, new int[] { 1 })]
        //[InlineData(5, new int[] { 1, 2, 3, 4, 5 })]
        //public void PopTest(int expectedCount, int[] values)
        //{
        //    int[] stack = new int[5];
        //    foreach (var item in values)
        //    {
        //        Stack.Stack.Push(item);
        //    }

        //    Assert.Equal(expectedCount, stack.Count);
        //    if (expectedCount > 0)
        //    {
        //        Assert.Equal(stack.Head.prev, stack.Tail);
        //        Assert.Equal(stack.Tail.next, stack.Head);
        //        Assert.NotNull(stack.Head);
        //        Assert.NotNull(stack.Tail);
        //        Assert.Equal(values[0], stack.Head.data);
        //        if (values.Length > 1)
        //        {
        //            Stack.Stack.Pop(stack);
        //            Assert.Equal(values[values.Length - 2], stack.Tail.data);
        //        }
        //    }
        //}
    }

    public class StackTestArrayBased
    {
        [Fact]
        public void IsListEmpty()
        {
            int[] list = new int[0];
            Assert.Empty(list);
        }
        [Fact]
        public void EmptyStackPeekThrows()
        {
            var stack = new Stack<int>();
            Assert.Throws<InvalidOperationException>(() => stack.Peek());
        }
        [Fact]
        public void EmptyStackPopThrows()
        {
            var stack = new Stack<int>();
            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        [Theory]
        [InlineData(0, new int[] { })]
        [InlineData(1, new int[] { 1 })]
        [InlineData(5, new int[] { 1, 2, 3, 4, 5 })]
        public void PushTest(int expectedCount, int[] values)
        {
            Stack<int> stack = new Stack<int>();
            foreach (var item in values)
            {
                stack.Push(item);
            }
            Assert.Equal(expectedCount, stack.Count);
            if (expectedCount > 0)
            {
                Assert.Equal(stack.Count, values[values.Length - 1]);
            }
        }
        [Theory]
        [InlineData(0, new int[] { })]
        [InlineData(1, new int[1] { 1 })]
        [InlineData(5, new int[5] { 1, 2, 3, 4, 5 })]
        public void PopTest(int expectedCount, int[] values)
        {
            Stack<int> stack = new Stack<int>();
            foreach (var item in values)
            {
                stack.Push(item);
            }
            Assert.Equal(expectedCount, stack.Count);
            if (expectedCount > 0)
            {
                if (values.Length > 1)
                {
                    stack.Pop();
                    Assert.Equal(stack.Count, values[values.Length - 2]);
                }
            }
        }
    }
}
