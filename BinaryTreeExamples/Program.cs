using System;

namespace BinaryTreeExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BinaryTree Implementation\n");

            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Add(1);
            binaryTree.Add(2);
            binaryTree.Add(7);
            binaryTree.Add(4);
            binaryTree.Add(10);
            binaryTree.Add(5);
            binaryTree.Add(8);
            binaryTree.Add(6);
            binaryTree.Add(3);

            Node node = binaryTree.Find(5);
            int depth = binaryTree.GetTreeDepth();

            Console.WriteLine("PreOrder Transversal");
            binaryTree.TraversePreOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("InOrder Transversal");
            binaryTree.TraversePreOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("PostOrder Transversal");
            binaryTree.TraversePreOrder(binaryTree.Root);
            Console.WriteLine();

            binaryTree.Remove(7);
            binaryTree.Remove(8);


            Console.WriteLine("PreOrder Traversal After Removing Operation:");
            binaryTree.TraversePreOrder(binaryTree.Root);
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
