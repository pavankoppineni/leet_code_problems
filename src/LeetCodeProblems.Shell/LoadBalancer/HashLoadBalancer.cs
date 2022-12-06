using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LeetCodeProblems.Shell.LoadBalancer
{
    public class HashLoadBalancer : ILoadBalancer
    {
        private Channel<NodeMessage> _channel;
        private IDictionary<long, INodeInstance> _nodesLookup;
        private IList<Task> _nodeTasks;
        private readonly int _instanceCount;
        public HashLoadBalancer(int instanceCount)
        {
            _channel = Channel.CreateUnbounded<NodeMessage>();
            _instanceCount = instanceCount;
            _nodesLookup = new Dictionary<long, INodeInstance>();
            _nodeTasks = new List<Task>();
        }

        public IResponse ProcessRequest(IRequest request)
        {
            var ticks = DateTime.Now.Ticks;
            var reminder = ticks % _instanceCount;
            var nodeInstance = _nodesLookup[reminder];
            return nodeInstance.ProcessRequest(request);
        }

        private async Task ReceiveHeartBeats(CancellationToken cancellationToken)
        {
            while(!cancellationToken.IsCancellationRequested)
            {
                if (await _channel.Reader.WaitToReadAsync(cancellationToken))
                {
                    var nodeMessage = await _channel.Reader.ReadAsync(cancellationToken);
                    Console.WriteLine($"Node Id : {nodeMessage.NodeId}, Node Status : {nodeMessage.Status}");
                }
            }
        }

        public void Spin()
        {
            for (var index = 0; index < _instanceCount; index++)
            {
                var nodeInstance = new NodeInstance(_channel.Writer, index);
                _nodesLookup.Add(index, nodeInstance);
            }

            Task.Run(() => ReceiveHeartBeats(CancellationToken.None));
            foreach (var nodeInstance in _nodesLookup.Values)
            {
                _nodeTasks.Add(nodeInstance.SpinAsync(CancellationToken.None));
            }
        }
    }
}
