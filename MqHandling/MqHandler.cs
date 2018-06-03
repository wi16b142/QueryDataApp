using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Messaging; //add reference to Messaging
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization; //add reference to Serialization
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace MqHandling
{
    public class MqHandler<T>
    {
        private string connectionString = @"FormatName:direct=os:";
        private string mqPrefix = @".\private$\";
        private string mqName;
        private MessageQueue mq;

        public MqHandler(string mqName)
        {
            this.mqName = mqName;
            if (!MessageQueue.Exists(mqPrefix + mqName))
            {
                MessageQueue.Create(mqPrefix + mqName);
            }
            mq = new MessageQueue(connectionString + mqPrefix + mqName);
            mq.Formatter = new XmlMessageFormatter(new Type[] { typeof(T) });
        }

        public void Send(T t)
        {
            mq.Send(t);
        }

        public T Receive()
        {
            return (T)mq.Receive().Body;
        }
    }
}
