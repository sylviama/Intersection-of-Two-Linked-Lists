using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //list 1
            ListNode node1=new ListNode(2);
            ListNode node2=new ListNode(3);
            ListNode node3=new ListNode(6);
            
            //list 2
            ListNode node4=new ListNode(8);
            ListNode node5=new ListNode(10);
            
            //shared
            ListNode node6=new ListNode(5);
            ListNode node7=new ListNode(6);
            ListNode node8=new ListNode(9);
            
            //list1
            node1.next=node2;
            node2.next=node3;
            
            //list2
            node4.next=node5;
            
            //shared 
            node6.next=node7;
            node7.next=node8;
            
            //intersact
            node3.next=node6;
            node5.next=node6;
            
            
            Solution solu=new Solution();
            Console.WriteLine(solu.GetIntersectionNode(node1, node4).val);
        }
        
        public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        
        
    
        public class Solution {
            private int length(ListNode node)
            {
                int counter=0;
                while(node!=null)
                {
                    counter++;
                    node=node.next;
                }
                return counter;
            }
            
            
            public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
                
                
                int lenA=length(headA);
                int lenB=length(headB);
                
                ListNode currentA=headA;
                ListNode currentB=headB;
                
                //find the same length starting point, then start to compare
                if(lenA>=lenB)
                {
                    while(lenA-lenB>0)
                    {
                        currentA=currentA.next;
                        lenA--;
                    }
                    while(currentA!=currentB)
                    {
                        currentA=currentA.next;
                        currentB=currentB.next;
                    }
                    return currentA;
                }else
                {
                    while(lenB-lenA>0)
                    {
                        currentB=currentB.next;
                        lenB--;
                    }
                    while(currentA!=currentB)
                    {
                        currentA=currentA.next;
                        currentB=currentB.next;
                    }
                    return currentA;
                }
                return null;
   
            }
        }    
        
    }
}
