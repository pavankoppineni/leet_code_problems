using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Shell
{
    public class MenuItem
    {
        public string code {  get; set; }
        public string text {  get; set; }
        public string created_timestamp {  get; set; }
        public string created {  get; set; }
        public string deleted_timestamp {  get; set; }
        public bool? deleted { get; set; }
    }
}
