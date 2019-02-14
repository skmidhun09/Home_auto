using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BackButton : MonoBehaviour {

	void Update () {
		Invoke("Back",1);
		
	}

	void Back()
	{
		if (Input.anyKeyDown)
		{
			SceneManager.LoadScene(0);
			CancelInvoke();
		}
	}
}
