using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Server : MonoBehaviour 
{
    public Text displayText;
    public string url = "http://192.168.0.5/~cs1533/project.php";
    
    public void Bulb()
    {
        WWWForm formDate = new WWWForm ();
        formDate.AddField ("val", "1");
        WWW www = new WWW (url, formDate);
        StartCoroutine (request (www));
    }
    public void Fan()
    {
        WWWForm formDate = new WWWForm ();
        formDate.AddField ("val", "2");
        WWW www = new WWW (url, formDate);
        StartCoroutine (request (www));
    }
    IEnumerator request (WWW www) 
    {
        yield return www;

        displayText.text = www.text;
    }
}