using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterativeBinaryTreeCSharp
{
    class TestTree
    {
        static void Main(string[] args)
        {
            /* Test with ints */
            System.Console.WriteLine("Integers test:\n===============");
            GenericBinTree<int> intsTree = new GenericBinTree<int>();
            intsTree.addElement(5);
            intsTree.addElement(2);
            intsTree.addElement(7);
            intsTree.addElement(5);
            intsTree.addElement(3);
            intsTree.addElement(1);
            intsTree.addElement(10);
            intsTree.addElement(8);
            intsTree.addElement(9);
            intsTree.addElement(4);
            intsTree.addElement(11);
            intsTree.addElement(6);
            if (intsTree.isExist(12))
            {
                System.Console.WriteLine("12 is in the tree!");
            }
            else
            {
                System.Console.WriteLine("12 is missing!");
            }
            if (intsTree.isExist(-12))
            {
                System.Console.WriteLine("-12 is in the tree!");
            }
            else
            {
                System.Console.WriteLine("-12 is missing!");
            }
            if (intsTree.isExist(5))
            {
                System.Console.WriteLine("5 is in the tree!");
            }
            else
            {
                System.Console.WriteLine("5 is missing!");
            }
            if (intsTree.isExist(9))
            {
                System.Console.WriteLine("9 is in the tree!");
            }
            else
            {
                System.Console.WriteLine("9 is missing!");
            }
            System.Console.WriteLine("\n\n");
            
            intsTree.printTree();

            /* Test with strings*/
            System.Console.WriteLine("\n\nStrings test:\n=============");
            GenericBinTree<String> stringsTree = new GenericBinTree<String>();
            stringsTree.addElement("123.192.0.1");
            stringsTree.addElement("123.192.0.10");
            stringsTree.addElement("123.456.7.8");
            stringsTree.addElement("321.192.3.2");
            stringsTree.addElement("567.892.5.1");
            stringsTree.addElement("123.192.6.1");
            stringsTree.addElement("173.182.0.1");
            stringsTree.addElement("133.132.0.1");
            stringsTree.addElement("001.192.0.1");
            stringsTree.addElement("100.000.0.1");
            stringsTree.addElement("156.562.0.1");
            stringsTree.addElement("129.192.0.1");
            stringsTree.addElement("123.196.0.1");
            String answer;
            answer = (stringsTree.isExist("123.192.0.1")) ? "Yes" : "No";
            System.Console.WriteLine(answer);
            answer = (stringsTree.isExist("567.892.5.1")) ? "Yes" : "No";
            System.Console.WriteLine(answer);
            answer = (stringsTree.isExist("173.182.0.11")) ? "Yes" : "No";
            System.Console.WriteLine(answer);
            answer = (stringsTree.isExist("123.196.0.1")) ? "Yes" : "No";
            System.Console.WriteLine(answer + "\n\n");
            stringsTree.printTree();
            System.Console.ReadKey();
        }
    }
}
