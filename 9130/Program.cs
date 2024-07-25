using System;
//using System.Collections.Generic;
using Unit4New;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9130
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        // 1
        // build list from 1st element to last
        // add element at end
        // param : int[]
        // return : Node<int>
        // example:
        // param : {1,2,3,4} return : ->1->2->3->4
        public static Node<int> buildListFromArrForword(int[] arr)
        {
            return null;
        }
        // 2
        // build list from last element to first
        // param : Node<int>
        // return : Node<int>
        // example:
        // param : ->1,2,3,4,5 return : ->5,4,3,2,1
        public static Node<int> buildReverseList(Node<int> lst)
        {
            return null;

        }

        // 3
        // List Length
        // param : Node<int>
        // return : int
        // example: param: ->1->2->1->4, return: 4
        // example: param: ->1->2->1, return: 3
        public static int len(Node<int> lst)
        {
            return 0;
        }

        // 4
        // number of occurrences of an element in a List 
        // param1 : Node<int>
        // param2 : int
        // return : int
        // example: param1: ->1->2->1->4, param2: 1, return: 2
        // example: param1: ->1->2->1->4, param2: 6, return: 0
        public static int count(Node<int> lst, int num)
        {
            return 0;

        }

        // 5
        // count elements greater than the one next
        // param : Node<int>
        // return : int
        // example: param: ->1->2->1->4->3->1, return: 3
        // example: param: ->1->2->3->4, return: 0
        public static int greaterThan(Node<int> lst)
        {
            return 0;
        }

        // 6
        // print List
        // param : Node<int>
        // print list in pattern : [1Element,2Element,....nElement]
        // example: param: ->1->2->1->4->3->1, print [1,2,1,4,3,1]
        // example: param: -> print null
        // note - use Convert.ToString()
        public static void print(Node<int> lst)
        {


        }

        // 7
        // change element to the max element from list begin to the element (include)
        // param : Node<int>
        // example: before: ->5->3->9->2->3->10->4->7, after: ->5->5->9->9->9->10->10->10
        // example: before: ->5, after : ->5
        // example: before: null, after : null
        public static void Change(Node<int> lst)
        {

        }

        // 8
        // delete elements greater than the previous
        // after - no element should be greather than previous
        // param : Node<int>
        // example: before: ->8->7->9->5->10->9->4->4->3->9, after:  ->8->7->5->4->4->3
        // example: before: ->5, after: ->5
        // example: before: null, after: null
        public static void deleteGreaters(Node<int> lst)
        {

        }
    }
}

