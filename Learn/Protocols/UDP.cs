using System.Configuration;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Learn.Protocols
{
    /*
     * UDP (User Datagram Protocol)
     * It is a connectionless protocol. When you send data or message, you don’t know if it will get there, 
     * it could get lost on the way. There may be corruption while transferring a message. 
     * UDP does not use streaming and it uses datagrams instead of streams. It is light weighted. 
     * There is No ordering of messages It’s just like fire(send) and forgets! This means it is a lot faster, 
     * UDP does not provide a guarantee it will be delivered or not or also cannon tracked once fired.
     * 
     * UDP is an alternative Protocol to Transmission Control Protocol (TCP). 
     * UDP is commonly used for applications that can handle some packet loss. such as streaming audio and video.
     */
    public static class UDP
    {
        public static void Server()
        {
            UdpClient udpc = new UdpClient(7878);
            Console.WriteLine("Server Started, servicing on port no. 7878");
            IPEndPoint ep = null;
            while (true)
            {
                // Store received data from client
                byte[] receivedData = udpc.Receive(ref ep);

                string studentName = Encoding.ASCII.GetString(receivedData);

                string msg = ConfigurationSettings.AppSettings[studentName];
                if (msg == null) msg = "No such Student available for conversation";
                byte[] sdata = Encoding.ASCII.GetBytes(msg);
                udpc.Send(sdata, sdata.Length, ep);
            }
        }

        public static void Client()
        {
            UdpClient udpc = new UdpClient("EN1411135", 7878);
            IPEndPoint ep = null;
            while (true)
            {
                Console.Write("Enter Your Name: ");
                string studentName = Console.ReadLine();


                // Check weather student entered name to start conversation
                if (studentName == "")
                {
                    Console.Write("You did not enter your name. Closing...");
                    break;
                }

                // Data to send
                byte[] msg = Encoding.ASCII.GetBytes(studentName);
                udpc.Send(msg, msg.Length);

                // received Data
                byte[] rdata = udpc.Receive(ref ep);
                string job = Encoding.ASCII.GetString(rdata);
                Console.WriteLine(job);
            }
        }


    }
}
