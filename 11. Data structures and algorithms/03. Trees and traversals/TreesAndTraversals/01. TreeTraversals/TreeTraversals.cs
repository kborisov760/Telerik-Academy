namespace TreeTraversals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TreeTraversals
    {
       

        static int pathLength = 0;
        static int maxPathLength = 0;

        static Stack<Node<int>> currentPath = new Stack<Node<int>>();
        static List<Stack<Node<int>>> pathsWithGivenSum = new List<Stack<Node<int>>>();
        static int sum = 0;
        
        static int currentPathLength = 0;


        //Return index of root element if found
        public static int FindRoot(Node<int>[] nodes)
        {
            var hasParent = new bool[nodes.Length];

            foreach (var node in nodes)
            {
                foreach (var child in node.Children)
                {
                    hasParent[child.Value] = true;
                }
            }

            for (int i = 0; i < hasParent.Length; i++)
            {
                if (!hasParent[i])
                {
                    return i;
                }
            }

            return -1;
        }

        public static List<Node<int>> FindAllLeafs(Node<int>[] nodes)
        {
            List<Node<int>> leafs = new List<Node<int>>();

            foreach (var node in nodes)
            {
                if (node.Children.Count == 0)
                {
                    leafs.Add(node);
                }
            }

            return leafs;
        }

        public static List<Node<int>> FindAllMiddleNodes(Node<int>[] nodes)
        {
            List<Node<int>> middleNodes = new List<Node<int>>();

            foreach (var node in nodes)
            {
                if (node.HasParent && node.Children.Count != 0)
                {
                    middleNodes.Add(node);
                }
            }

            return middleNodes;
        }

        public static void DFS(Node<int> root)
        {
            foreach (var child in root.Children)
            {
                if(child.Value != root.Value)
                {
                    pathLength++;
                    DFS(child);

                    if (maxPathLength < pathLength)
                    {
                        maxPathLength = pathLength;
                    }

                    pathLength--;
                }
            }
        }


        public static void DfsPath(Node<int> root, int comeFrom)
        {
            foreach (var child in root.Children)
            {
                if (child.Value != comeFrom)
                {
                    pathLength++;
                    DfsPath(child, root.Value);

                    if (maxPathLength < pathLength)
                    {
                        maxPathLength = pathLength;
                    }

                    pathLength--;
                }
            }
        }

        public static void DFS_SUM(Node<int> root, int givenSum)
        {
            currentPath.Push(root);

            if (root.Children.Count == 0)
            {
                sum = 0;

                foreach (var item in currentPath)
                {
                    sum += item.Value;
                }

                if (sum == givenSum)
                {
                    var clonedPath = new Stack<Node<int>>(new Stack<Node<int>>(currentPath.Reverse()));
                    pathsWithGivenSum.Add(clonedPath);

                }
            }

            foreach (var child in root.Children)
            {
                DFS_SUM(child, givenSum);
            }

            currentPath.Pop();
        }

        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            var nodes = new Node<int>[N];

            for (int i = 0; i < N; i++)
            {
                nodes[i] = new Node<int>(i);
            }

            for (int i = 1; i <= N - 1; i++)
            {
                var currentEdge = Console.ReadLine().Split(' ');
                var parentId = int.Parse(currentEdge[0]);
                var childId = int.Parse(currentEdge[1]);

                nodes[parentId].Children.Add(nodes[childId]);
                nodes[childId].Children.Add(nodes[parentId]);

                nodes[childId].HasParent = true;
                //nodes[parentId].HasParent = true;
            }
            /*
                        //Task 1: Find the root of the three
                        Console.WriteLine("The root of the tree is: {0}", FindRoot(nodes));

                        //Task 2: Find all leafs
                        var leafs = FindAllLeafs(nodes);

                        Console.Write("Leafs: ");
                        foreach (var leaf in leafs)
                        {
                            Console.Write("{0} ", leaf.Value);
                        }

                        Console.WriteLine();

                        //Task 3: Find all middle nodes
                        var middleNodes = FindAllMiddleNodes(nodes);

                        Console.Write("Middle nodes: ");
                        foreach (var middleNode in middleNodes)
                        {
                            Console.Write("{0} ", middleNode.Value);
                        }

                        Console.WriteLine();
            

            //Task 4: Find longest path from root to leaf
            pathLength = 0;
            var root = nodes[FindRoot(nodes)];
            DFS(root);
            Console.WriteLine(maxPathLength);


            //Task 5: Find all paths in the tree with given sum `S` of their nodes
            const int GIVEN_SUM = 8;
            DFS_SUM(nodes[FindRoot(nodes)], GIVEN_SUM);

            foreach (var path in pathsWithGivenSum)
            {
                Console.Write("Path with given sum: ");
                foreach (var node in path)
                {
                    Console.Write("{0} ", node.Value);
                }
                Console.WriteLine();
            }
*/

            foreach (var node in nodes)
            {
                if(node.Children.Count == 1)
                {
                    pathLength = 0;                    
                    DfsPath(node, -1);
                }
            }

            Console.WriteLine(maxPathLength);
        }
    }
}
