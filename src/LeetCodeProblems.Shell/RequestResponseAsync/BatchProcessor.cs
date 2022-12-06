using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LeetCodeProblems.Shell.RequestResponseAsync
{
    public class BatchProcessor
    {
        private ConcurrentDictionary<string, Guid> _concurrentLookup;
        private ConcurrentDictionary<Guid, Task> _taskQueue;
        public BatchProcessor()
        {
            _concurrentLookup = new ConcurrentDictionary<string, Guid>();
            _taskQueue = new ConcurrentDictionary<Guid, Task>();
        }

        public Task ProcessAsync(BatchRequest batchRequest)
        {
            var guid = Guid.NewGuid();
            if (!_concurrentLookup.ContainsKey(batchRequest.CorpId))
            {
                _concurrentLookup.TryAdd(batchRequest.CorpId, guid);
            }
            var task = Task.Run(() => Console.WriteLine("Task is running!"));
            _taskQueue.TryAdd(guid, task);
            return task;
        }
    }
}
