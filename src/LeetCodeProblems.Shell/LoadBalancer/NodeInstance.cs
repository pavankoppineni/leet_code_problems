using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LeetCodeProblems.Shell.LoadBalancer
{
    public class NodeInstance : INodeInstance
    {
        private readonly int _nodeId;
        private readonly ChannelWriter<NodeMessage> _writer;
        public NodeInstance(ChannelWriter<NodeMessage> writer, int nodeId)
        {
            _writer = writer;
            _nodeId = nodeId;
        }

        private async Task RunHeartBeatAsync(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                await _writer.WriteAsync(NodeMessage.Create(_nodeId, NodeStatus.Healthy));
                await Task.Delay(5000);
            }
        }

        public Task SpinAsync(CancellationToken cancellationToken)
        {
            return Task.Run(async () => await RunHeartBeatAsync(cancellationToken));
        }

        public IResponse ProcessRequest(IRequest request)
        {
            Console.WriteLine($"Processing Request : {request.Id}, Node Id : {_nodeId}");
            return Response.Ok(request.Id);
        }
    }
}
