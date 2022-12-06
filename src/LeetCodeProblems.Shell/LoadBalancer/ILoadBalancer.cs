using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Shell.LoadBalancer
{
    public interface ILoadBalancer
    {
        IResponse ProcessRequest(IRequest request);
        void Spin();
    }
}
