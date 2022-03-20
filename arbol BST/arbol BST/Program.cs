using System;
using System.Collections.Generic;

namespace SearchBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arbol Binario De Busqueda\n");

            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Insert(75);
            binaryTree.Insert(57);
            binaryTree.Insert(90);
            binaryTree.Insert(32);
            binaryTree.Insert(7);
            binaryTree.Insert(44);
            binaryTree.Insert(60);
            binaryTree.Insert(86);
            binaryTree.Insert(93);
            binaryTree.Insert(99);
            binaryTree.Insert(100);


            Console.WriteLine("Orden Transversal (Izquierda-->Raiz-->Derecha)");
            binaryTree.InOrderTraversal();
            Console.WriteLine("\n\n\nPre-Orden Transversal (Raiz-->Izquierda-->Derecha)");
            binaryTree.PreorderTraversal();
            Console.WriteLine("\n\n\nPost-Orden Transversal (Izquierda-->Derecha-->Raiz)");
            binaryTree.PostorderTraversal();

            Console.WriteLine("\n\n\nEncontrar 99");
            var node = binaryTree.Find(99);
            Console.WriteLine(node.Data);
            //Console.WriteLine("Busqueda Recursiva 99");
            //var nodeR = binaryTree.FindRecursive(99);
            //Console.WriteLine(nodeR.Data);
            Console.WriteLine("\n\nBorrar un Nodo Hoja (44)");
            binaryTree.Remove(44);
            Console.WriteLine("Borrar Nodo con un solo Hijo(93)");
            binaryTree.Remove(93);
            Console.WriteLine("Borrar Nodo con dos Hijos(75)");
            binaryTree.Remove(75);
            //Console.WriteLine("SoftDelete a Node with one child (93)");
            //binaryTree.SoftDelete(93);


            Console.WriteLine("\n\nObtener Nodo mas Pequeño");
            Console.WriteLine(binaryTree.Smallest());
            Console.WriteLine("Obtener Nodo mas Grande");
            Console.WriteLine(binaryTree.Largest());
            Console.WriteLine("Obtener numero de Nodos Hojas");
            Console.WriteLine(binaryTree.NumberOfLeafNodes());
            Console.WriteLine("Obtener altura del Arbol");
            Console.WriteLine(binaryTree.Height());
            Console.WriteLine("El Arbol esta Vacio");
            Console.WriteLine(binaryTree.isEmpty());

            //Check if the binary tree is balanced. A balanced tree occurs when the height of two subtrees of any node do not differe more than 1.
            //bool balanced = binaryTree.IsBalanced();

        }


        public static int getHeight(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return Math.Max(getHeight(root.LeftNode), getHeight(root.RightNode)) + 1;
        }

        public static bool isBalanced(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            int heightDiff = getHeight(root.LeftNode) - getHeight(root.RightNode);
            if (Math.Abs(heightDiff) > 1)
            {
                return false;
            }
            else
            {
                return (isBalanced(root.LeftNode) && isBalanced(root.RightNode));
            }
        }


    }
}
