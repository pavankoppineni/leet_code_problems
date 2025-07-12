using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Shell
{
    public class MergeInfiniteLog : InfiniteLog
    {
        private readonly IInfiniteLog _metadataLog;
        private readonly IInfiniteLog _timeseriesLog;
        public MergeInfiniteLog(
            IInfiniteLog metadataLog,
            IInfiniteLog timeseriesLog,
            Stream mergeStream) : base(mergeStream)
        {
            _metadataLog = metadataLog;
            _timeseriesLog = timeseriesLog;
        }
    }
}
