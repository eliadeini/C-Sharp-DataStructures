using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterativeBinaryTreeCSharp
{
    class GenericBinTree<T> where T : System.IComparable<T>
    {
        private GenericNode<T> Root;

        public void addElement(T element)
        {
            GenericNode<T> newNode = new GenericNode<T>(element);

            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                GenericNode<T> currNode = Root;
                /* Here we will search for the correct location for the node */
                while (currNode != null)
                {
                    if (element.CompareTo(currNode.getData()) < 0)
                    {
                        if (currNode.getLeftNode() == null)
                        {
                            currNode.setLeftNode(newNode);
                            return;
                        }

                        currNode = currNode.getLeftNode();
                    }
                    else
                    {
                        if (currNode.getRightNode() == null)
                        {
                            currNode.setRightNode(newNode);
                            return;
                        }

                        currNode = currNode.getRightNode();
                    }
                }
            }
        }


        public bool isExist(T element) 
        {
            if (searchElement(element) != null)
            {
                return true;
            }
            return false;
        }


        public GenericNode<T> searchElement(T element_to_find)
        {
            if (Root == null)
            {
                return null;
            }

            GenericNode<T> currNode = Root;

            while (currNode != null)
            {
                if (element_to_find.Equals(currNode.getData()))
                {
                    return currNode;
                } 

                if (element_to_find.CompareTo(currNode.getData()) < 0) {
                    currNode = currNode.getLeftNode();
                }
                else
                {
                    currNode = currNode.getRightNode();
                }               
            }
            return null;
        }


        public void printTree()
        {
            if (Root == null)
            {
                return;
            }

            Stack<GenericNode<T>> nodesStack = new Stack<GenericNode<T>>();
            nodesStack.Push(Root);
            GenericNode<T> currNode = Root;
 
            while (nodesStack.Count() > 0)
            {
                while ((currNode != null) && (currNode.getLeftNode() != null))
                {
                    nodesStack.Push(currNode.getLeftNode());
                    currNode = currNode.getLeftNode();
                }
                currNode = nodesStack.Pop();
                Console.WriteLine(currNode.getData().ToString());

                if (currNode.getRightNode() != null)
                {
                    nodesStack.Push(currNode.getRightNode());
                    currNode = currNode.getRightNode();
                }
            }
        }
    }
}

