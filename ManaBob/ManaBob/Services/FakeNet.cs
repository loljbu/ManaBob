using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManaBob.Services
{
    public sealed class FakeNet : INetService
    {
        bool INetService.IsConnected
        {
            get{ return true; }
        }

        void INetService.Close()
        {
            IDisposable target = this;
            target.Dispose();
        }

        void IDisposable.Dispose()
        {
            return;
        }

        int INetService.Receive(byte[] _buffer, int _offset, int _length)
        {
            return (_buffer == null) ? -1 : (_length - _offset);
        }

        Task<int> INetService.ReceiveAsync(byte[] _buffer, int _offset, int _length)
        {
            return Task.Factory.StartNew<int>(() =>
            {
                return (_buffer == null) ? -1 : (_length - _offset);
            });
        }

        bool INetService.Recover()
        {
            return true;
        }

        int INetService.Send(byte[] _buffer, int _offset, int _length)
        {
            return (_buffer == null) ? -1 : (_length - _offset);
        }

        Task<int> INetService.SendAsync(byte[] _buffer, int _offset, int _length)
        {
            return Task.Factory.StartNew<int>(() =>
            {
                return (_buffer == null) ? -1 : (_length - _offset);
            });
        }

    }

}
