/*using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;
using Xunit;

namespace Stack.Test
{
    public class StackTest
    {
        [Fact]
        public void ListCountIsZeroWhenEmpty()
        {
            int[] list = new int[5];
            Assert.Empty(list);
        }
        [Fact]
        public void ListHeadTailAreNullWhenEmpty()
        {
            int[] list = new int[5];
            Assert.Null(list.Head);
            Assert.Null(list.Tail);
        }

        [Theory]
        [InlineData(0, new int[] {})]
        [InlineData(1, new int[] {1})]
        [InlineData(5, new int[] {1, 2, 3, 4, 5})]
        public void PushTest(int expectedCount, int[] values)
        {
            int[] stack = new int[5];
            foreach (var item in values)
            {
                Stack.Stack.Push(item);
            }

            Assert.Equal(expectedCount, stack.Count);
            if (expectedCount > 0)
            {
                Assert.Equal(stack.Head.prev, stack.Tail);
                Assert.Equal(stack.Tail.next, stack.Head);
                Assert.NotNull(stack.Head);
                Assert.NotNull(stack.Tail);
                Assert.Equal(values[0], stack.Head.data);
                Assert.Equal(values[values.Length - 1], Stack.addAt);
            }
        }
        [Theory]
        [InlineData(0, new int[] { })]
        [InlineData(1, new int[] {1})]
        [InlineData(5, new int[] {1, 2, 3, 4, 5})]
        public void PopTest(int expectedCount, int[] values)
        {
            int[] stack = new int[5];
            foreach (var item in values)
            {
                Stack.Stack.Push(item);
            }

            Assert.Equal(expectedCount, stack.Count);
            if (expectedCount > 0)
            {
                Assert.Equal(stack.Head.prev, stack.Tail);
                Assert.Equal(stack.Tail.next, stack.Head);
                Assert.NotNull(stack.Head);
                Assert.NotNull(stack.Tail);
                Assert.Equal(values[0], stack.Head.data);
                if (values.Length > 1)
                {
                    Stack.Stack.Pop(stack);
                    Assert.Equal(values[values.Length - 2], stack.Tail.data);
                }
            }
        }
    }
}*/
