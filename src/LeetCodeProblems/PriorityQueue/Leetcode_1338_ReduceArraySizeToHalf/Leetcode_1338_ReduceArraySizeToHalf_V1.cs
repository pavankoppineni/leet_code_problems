using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.PriorityQueue.Leetcode_1338_ReduceArraySizeToHalf
{
    /// <summary>
    /// https://leetcode.com/problems/reduce-array-size-to-the-half/
    /// </summary>
    public class Leetcode_1338_ReduceArraySizeToHalf_V1
    {
        //JAVA Solution

        //public int minSetSize(int[] arr)
        //{
        //    HashMap<Integer, Integer> map = new HashMap<Integer, Integer>();
        //    for (int i = 0; i < arr.length; i++)
        //    {
        //        if (map.containsKey(arr[i]))
        //        {
        //            Integer value = map.get(arr[i]);
        //            map.put(arr[i], value + 1);
        //        }
        //        else
        //        {
        //            map.put(arr[i], 1);
        //        }
        //    }
        //    PriorityQueue<Integer> priorityQueue = new PriorityQueue<Integer>((a, b)-> {
        //        return b - a;
        //    });
        //    Iterator<Map.Entry<Integer, Integer>> itr = map.entrySet().iterator();
        
        //    while(itr.hasNext())
        //    {
        //         Map.Entry<Integer, Integer> entry = itr.next();
        //         priorityQueue.offer(entry.getValue());
        //    }

        //    Integer count = 0;
        //    Integer removedItems = 0;
        //    Integer maxItemsToRemove = arr.length >> 1;
        //        while(removedItems<maxItemsToRemove)
        //        {   
        //            removedItems = removedItems + priorityQueue.poll();
        //            count = count + 1;
        //        }
        //    return count;
        //}
    }
}
