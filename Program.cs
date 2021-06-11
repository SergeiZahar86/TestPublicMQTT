using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace TestPublic
{
    class Program
    {
        static void Main(string[] args)
        {
            String id = Guid.NewGuid().ToString();

            
            MqttClient client = new MqttClient("10.90.90.5");
            byte code = client.Connect(id, "root","root");

            ushort msgId = client.Publish("/my_topic", // topic
               Encoding.UTF8.GetBytes("Hello"), // message body
               MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, // QoS level
               false); // retained
            client.Disconnect();
        }
    }
}
