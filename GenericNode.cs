using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterativeBinaryTreeCSharp
{
    class GenericNode<T> where T : System.IComparable<T>
    {
        private T data;
        private GenericNode<T> leftNode;
        private GenericNode<T> rightNode;

        public GenericNode(T nodeData, GenericNode<T> left_node = null, GenericNode<T> right_node = null) {
            data = nodeData;
            leftNode = left_node;
            rightNode = right_node;
        }

        public T getData()
        {
            return data;
        }

        public GenericNode<T> getLeftNode()
        {
            return leftNode;
        }

        public void setLeftNode(GenericNode<T> new_left_node)
        {
            leftNode = new_left_node;
        }

        public GenericNode<T> getRightNode()
        {
            return rightNode;
        }

        public void setRightNode(GenericNode<T> new_right_node)
        {
            rightNode = new_right_node;
        }

        public String ToString()
        {
            return data.ToString();
        }
    }
}
