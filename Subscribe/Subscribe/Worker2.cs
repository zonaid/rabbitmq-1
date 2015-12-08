﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscribe
{
    public class Worker2 : AbstractWorker
    {
        public Worker2()
            : base("ghjk")
        {

        }
        protected override void Implement(RabbitMQ.Client.IModel channel, RabbitMQ.Client.Events.BasicDeliverEventArgs ea)
        {
            var body = ea.Body;
            var message = Encoding.UTF8.GetString(body);
            Console.WriteLine(" worker2 Received {0}", message);

            channel.BasicAck(deliveryTag: ea.DeliveryTag, multiple: false);
        }
    }
}
