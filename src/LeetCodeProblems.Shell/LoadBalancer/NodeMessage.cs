using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Shell.LoadBalancer
{
    public class NodeMessage
    {
        public NodeMessage(int nodeId, NodeStatus status)
        {
            NodeId = nodeId;
            Status = status;
        }
        public int NodeId { get; private set; }
        public NodeStatus Status { get; private set; }
        public static NodeMessage Create(int nodeId, NodeStatus status)
        {
            return new NodeMessage(nodeId, status);
        }
    }

    public enum NodeStatus
    {
        Healthy,
        NotHealthy
    }
}
