using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeProblems.PriorityQueue._1834_SingleThreadedCPU
{
    /// <summary>
    /// https://leetcode.com/problems/single-threaded-cpu/
    /// </summary>
    public class Leetcode_1834_SingleThreadedCPU_V1
    {

        //JAVA Solution

//        public int[] getOrder(int[][] tasks)
//        {
//            int count = tasks.length;
//            Task[] taskObjects = new Task[tasks.length];
//            for (int index = 0; index < tasks.length; index++)
//            {
//                taskObjects[index] = new Task(index, tasks[index][0], tasks[index][1]);
//            }
//            Arrays.sort(taskObjects, (a, b)-> {
//                if (a.EnqueueTime == b.EnqueueTime)
//                {
//                    return a.ProcessingTime - b.ProcessingTime;
//                }
//                return a.EnqueueTime - b.EnqueueTime;
//            });
//            PriorityQueue<Task> priorityQueue = new PriorityQueue<Task>((a, b)-> {
//            if (a.ProcessingTime == b.ProcessingTime)
//            {
//                return a.Index - b.Index;
//            }
//            return a.ProcessingTime - b.ProcessingTime;
//        });
//        int[] taskOrder = new int[tasks.length];
//        int order = 0;
//        int time = 0;
//        int index = 0;
//        while(order<tasks.length)
//        {
//            while(index<count)
//            {
//                Task task = taskObjects[index];
//                if(task.EnqueueTime <= time){
//                    priorityQueue.offer(task);
//                    index++;
//                }else{
//                    break;
//                }
//            }
            
//            //Case 1 : When queue is empty
//            if (priorityQueue.size() == 0)
//{
//    time = taskObjects[index].EnqueueTime;
//    continue;
//}

//Task taskObj = priorityQueue.poll();
//taskOrder[order] = taskObj.Index;
//order++;
//time += taskObj.ProcessingTime;
//        }
//        return taskOrder;
//    }
    }

    public class Task
    {
        public Task(int index, int startTime, int processingTime)
        {
            Index = index;
            EnqueueTime = startTime;
            ProcessingTime = processingTime;
        }
        public int Index;
        public int EnqueueTime;
        public int ProcessingTime;
    }
}
