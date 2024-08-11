using System;

namespace TreeImplementation
{
    public class BinarySearchTree : BinaryTree
    {
        public BinarySearchTree(int rootValue) : base(rootValue)
        {
        }

        // Add
        public void Add(int data)
        {
            try
            {
                Root = AddRecursive(Root, data);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding data: {ex.Message}");
            }
        }

        private Node AddRecursive(Node node, int data)
        {
            try
            {
                if (node == null)
                {
                    return new Node(data);
                }

                if (data < node.Value)
                {
                    node.Left = AddRecursive(node.Left, data);
                }
                else if (data > node.Value)
                {
                    node.Right = AddRecursive(node.Right, data);
                }

                return node;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AddRecursive: {ex.Message}");
                throw; 
            }
        }

        // Contains
        public bool Contains(int data)
        {
            try
            {
                return ContainsRecursive(Root, data);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error checking if data is contained: {ex.Message}");
                return false;
            }
        }

        private bool ContainsRecursive(Node node, int data)
        {
            try
            {
                if (node == null)
                {
                    return false;
                }

                if (data == node.Value)
                {
                    return true;
                }
                else if (data < node.Value)
                {
                    return ContainsRecursive(node.Left, data);
                }
                else
                {
                    return ContainsRecursive(node.Right, data);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in ContainsRecursive: {ex.Message}");
                throw; 
            }
        }

        // Remove
        public void Remove(int data)
        {
            try
            {
                Root = RemoveRecursive(Root, data);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error removing data: {ex.Message}");
            }
        }

        private Node RemoveRecursive(Node node, int data)
        {
            try
            {
                if (node == null)
                {
                    return null;
                }

                if (data < node.Value)
                {
                    node.Left = RemoveRecursive(node.Left, data);
                }
                else if (data > node.Value)
                {
                    node.Right = RemoveRecursive(node.Right, data);
                }
                else
                {
                    if (node.Left == null && node.Right == null)
                    {
                        return null;
                    }

                    if (node.Left == null)
                    {
                        return node.Right;
                    }
                    if (node.Right == null)
                    {
                        return node.Left;
                    }

                    Node successor = FindMin(node.Right);
                    node.Value = successor.Value;
                    node.Right = RemoveRecursive(node.Right, successor.Value);
                }

                return node;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in RemoveRecursive: {ex.Message}");
                throw; 
            }
        }

        private Node FindMin(Node node)
        {
            try
            {
                while (node.Left != null)
                {
                    node = node.Left;
                }
                return node;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error finding minimum node: {ex.Message}");
                throw; 
            }
        }

        // Binary Tree Traversal
        public void PrintPreOrder()
        {
            try
            {
                Console.WriteLine("Pre-Order Traversal:");
                PreOrder(Root);
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during Pre-Order traversal: {ex.Message}");
            }
        }

        public void PrintInOrder()
        {
            try
            {
                Console.WriteLine("In-Order Traversal:");
                InOrder(Root);
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during In-Order traversal: {ex.Message}");
            }
        }

        public void PrintPostOrder()
        {
            try
            {
                Console.WriteLine("Post-Order Traversal:");
                PostOrder(Root);
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during Post-Order traversal: {ex.Message}");
            }
        }
    }

    
}