using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Ashenvale
{
    class ParallelListener
    {
        private frm_Main frm_Main;
        public TcpListener serverSocket = null;
        public TcpClient clientSocket = null;

        public ParallelListener(frm_Main frm_Main)
        {
            this.frm_Main = frm_Main;
        }
    }
}
