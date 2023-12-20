// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;
using System;
using ConsoleApp1;



namespace JustAnotherApp

{
    public delegate void MessageBroadcastHandler(string name);


    public class ChatRoom
    {
        public event MessageBroadcastHandler MessageBroadcasted;

        public void BroadcastMessage(ChatRoom chatRoom, string message)
        {
            MessageBroadcasted?.Invoke(message);
        }


        
    }
}
