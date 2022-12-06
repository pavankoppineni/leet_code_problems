using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LeetCodeProblems.Shell.LoadBalancer
{
    public interface INodeInstance
    {
        Task SpinAsync(CancellationToken cancellationToken);
        IResponse ProcessRequest(IRequest request);
    }
}
