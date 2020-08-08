using System;
using Xunit;

namespace Stack.Test
{
    public class StackTest
    {
        [Fact]
        public void ListCountIsZeroWhenEmpty()
        {
            var list = new DoublyLinkedList<int>();
            Assert.Equal(0, list.Count);
        }
        [Fact]
        public void ListHeadTailAreNullWhenEmpty()
        {
            var list = new DoublyLinkedList<int>();

            Assert.Null(list.Head);
            Assert.Null(list.Tail);
        }

        [Theory]
        [InlineData(0, new int[] {})]
        [InlineData(1, new int[] {1})]
        [InlineData(5, new int[] {1, 2, 3, 4, 5})]
        public void PushTest(int expectedCount, int[] values)
        {
            var stack = new DoublyLinkedList<int>();

            foreach (var item in values)
            {
                StackFunctions.Push(stack, item);
            }

            Assert.Equal(expectedCount, stack.Count);
            if (expectedCount > 0)
            {
                Assert.Equal(stack.Head.prev, stack.Tail);
                Assert.Equal(stack.Tail.next, stack.Head);
                Assert.NotNull(stack.Head);
                Assert.NotNull(stack.Tail);
                Assert.Equal(values[0], stack.Head.data);
                Assert.Equal(values[values.Length - 1], stack.Tail.data);
            }
        }
        [Theory]
        [InlineData(0, new int[] { })]
        [InlineData(1, new int[] {1})]
        [InlineData(5, new int[] {1, 2, 3, 4, 5})]
        public void PopTest(int expectedCount, int[] values)
        {
            var stack = new DoublyLinkedList<int>();
            foreach (var item in values)
            {
                StackFunctions.Push(stack, item);
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
                    StackFunctions.Pop(stack);
                    Assert.Equal(values[values.Length - 2], stack.Tail.data);
                }
            }
        }
    }
}
