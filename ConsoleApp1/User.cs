using JustAnotherApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class User
    {
        public string name { get; set; }

        public User(string _name)
        {
            name = _name;
        }

        public void SendMessage(ChatRoom chatRoom, string message)
        {
            chatRoom.BroadcastMessage($"{name} says: {message}");
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void JoinChatRoom(ChatRoom chatRoom)
        {
            chatRoom.MessageBroadcasted += ReceiveMessage;
            Console.WriteLine($"{name} has joined the chat room.");
        }
    }

}

