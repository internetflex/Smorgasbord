using System.Diagnostics;
using Shouldly;
using TestProject;
using Xunit;

namespace UnitTests
{
    public class TestMergeLinkedLists
    {
        [Theory]
        [InlineData(new[]{1,4,5}, new[]{1,2,2}, new[] { 1, 1, 2, 2, 4, 5 })]
        [InlineData(new[]{1,2,3}, new[]{3,4}, new[] { 1, 2, 3, 3, 4 })]
        [InlineData(new[]{4,5,6}, new[]{1,2,10}, new[] { 1, 2, 4, 5, 6, 10 })]
        public void Test1(int[] arr1, int[] arr2, int[] expected)
        {
            var list1 = new MergeLinkedLists.SinglyLinkedList();
            foreach (var i in arr1)
            {
                list1.InsertNode(i);
            }

            var list2 = new MergeLinkedLists.SinglyLinkedList();
            foreach (var i in arr2)
            {
                list2.InsertNode(i);
            }

            var resultNode = MergeLinkedLists.MergeLists(list1.head, list2.head);

            for (var j = 0; j < expected.Length; j++)
            {
                resultNode.data.ShouldBe(expected[j]);
                resultNode = resultNode.next;
            }
        }
    }
}
