using UnityEngine;
using System;
using System.Net.Sockets;

public class Client : MonoBehaviour {

    TcpClient client;
    NetworkStream stream;


    public Client(string User, string pass)
    {
        Connect("localhost", User + ";" + pass);
    }

    public void Connect(String server, String message)
    {
        try
        {
            Int32 port = 13000;
            client = new TcpClient(server, port);
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

            stream = client.GetStream();
            stream.Write(data, 0, data.Length);

            Console.WriteLine("Sent: {0}", message);
            data = new Byte[256];
            String responseData = String.Empty;

            // Read the first batch of the TcpServer response bytes.
            Int32 bytes = stream.Read(data, 0, data.Length);
            responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            Console.WriteLine("Received: {0}", responseData);

        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine("ArgumentNullException: {0}", e);
        }
        catch (SocketException e)
        {
            Console.WriteLine("SocketException: {0}", e);
        }

        Console.WriteLine("\n Press Enter to continue...");
        Console.Read();
    }

    public void closeConnection()
    {
        // Close everything.
        stream.Close();
        client.Close();
    }

    public bool isConnected()
    {
        if(client.Connected)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
