using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour {
    public InputField username;
    public InputField password;
    public Client client;

    public void getLoginData()
    {
        client = new Client(username.text, password.text);
        if(client.isConnected())
        {
            Debug.Log("kiralyok vagyunk!");
            client.closeConnection();
            if (!client.isConnected())
            {
                Debug.Log("kiralyok vagyunk!");
        }
            else
            {
                Debug.Log("luzerek vagyunk!");
            }
        }
        else
        {
            Debug.Log("luzerek vagyunk!");
        }
    }
}
