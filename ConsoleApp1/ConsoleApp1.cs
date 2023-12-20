using JustAnotherApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ConsoleApp1
    {
        static void Main()
        {
            ChatRoom chatRoom = new ChatRoom();

            User user1 = new User("Alice");
            User user2 = new User("Bob");

            user1.JoinChatRoom(chatRoom);
            user2.JoinChatRoom(chatRoom);

            user1.SendMessage(chatRoom, "Hi there!");
            user2.SendMessage(chatRoom, "Hello, Alice.");






            Console.ReadLine();
        }
    }
}
