using System;

namespace Menu_Utama
{
    internal class StreamReader
    {
        private string v;

        public StreamReader(string v)
        {
            this.v = v;
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal object ReadLine()
        {
            throw new NotImplementedException();
        }
    }
}