using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Shell
{
    public interface IInfiniteLog : IDisposable
    {
        void Append(byte[] bytes, bool addNewLine = false);

        void Append(byte[] bytes, int offset, int count, bool addNewLine = false);
        void AppendNewLine();
    }

    public class InfiniteLog : IInfiniteLog
    {
        private Stream _stream;
        private static byte[] newLine = Encoding.UTF8.GetBytes("\n");
        public InfiniteLog(Stream stream)
        {
            _stream = stream;
        }

        public void Append(byte[] bytes, bool addNewLine = false)
        {
            _stream.Write(bytes, 0, bytes.Length);
            if (addNewLine)
            {
                _stream.Write(newLine, 0, newLine.Length);
            }
        }

        public void Append(byte[] bytes, int offset, int count, bool addNewLine = false)
        {
            _stream.Write(bytes, offset, count);
            if (addNewLine)
            {
                _stream.Write(newLine, 0, newLine.Length);
            }
        }

        public void AppendNewLine()
        {
            _stream.Write(newLine);
        }

        public void Dispose()
        {
            _stream.Flush();
            _stream?.Dispose();
        }

        public static IInfiniteLog Create(string fileName)
        {
            var fileStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            return new InfiniteLog(fileStream);
        }
    }
}
