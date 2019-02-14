using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
	public GameObject cubes;

	void Update () {
			Invoke("wait",5);
			Invoke("wait2",10);
		
	}

	void wait()
	{
		cubes.transform.Rotate(Time.deltaTime *100, 0, 0);

	}

	void wait2()
	{
		CancelInvoke("wait");
		cubes.transform.Rotate(0,Time.deltaTime *100, 0);

	}
}
