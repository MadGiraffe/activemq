using System;
using OpenWire.Client.Commands;

namespace OpenWire.Client {
        /// <summary>
        /// Represents a single unit of work on an IConnection.
        /// So the ISession can be used to perform transactional receive and sends
        /// </summary>
        public interface ISession : IDisposable {


                /// <summary>
                /// Creates a producer of messages
                /// </summary>
                IMessageProducer CreateProducer();

                /// <summary>
                /// Creates a producer of messages on a given destination
                /// </summary>
                IMessageProducer CreateProducer(IDestination destination); 

                /// <summary>
                /// Creates a cpmsi,er of messages on a given destination
                /// </summary>
                IMessageConsumer CreateConsumer(IDestination destination); 

                /// <summary>
                /// Creates a cpmsi,er of messages on a given destination with a selector
                /// </summary>
                IMessageConsumer CreateConsumer(IDestination destination, string selector); 
                
                /// <summary>
                /// Returns the queue for the given name
                /// </summary>
                IQueue GetQueue(string name); 
                
                /// <summary>
                /// Returns the topic for the given name
                /// </summary>
                ITopic GetTopic(string name); 
                
                
        } 
}
