
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Shell.RequestResponseAsync
{
    public class BatchRequest
    {
        public string CorpId { get; set; }
        public IList<Message> Messages { get; set; }
    }
}
