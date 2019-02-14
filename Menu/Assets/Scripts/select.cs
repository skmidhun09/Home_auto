using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class select : MonoBehaviour
{
	private int flag=0,f=2;
	public GameObject sel;
	public GameObject menu1;
	public GameObject menu2;
	public GameObject menu3;
	public GameObject menu4;
	public GameObject menu5;
	public GameObject menu6;
	void Update()
	{
		if (Input.anyKeyDown)
		{
			f = 1;

			StartCoroutine(wait());
			StartCoroutine(reSet());
		}
		
		if (f == 2)
		{
			Invoke("change", 1);
			if (flag == 0)
				sel.transform.position = menu1.transform.position;
			if (flag == 1)
				sel.transform.position = menu2.transform.position;
			if (flag == 2)
				sel.transform.position = menu3.transform.position;
			if (flag == 3)
				sel.transform.position = menu4.transform.position;
			if (flag == 4)
				sel.transform.position = menu5.transform.position;
			if (flag == 5)
				sel.transform.position = menu6.transform.position;
		}
		if (f == 1)
		{

		}
		else if (f == 0)
		{
			if (sel.transform.position == menu1.transform.position)
			{
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
			}
			else if (sel.transform.position == menu2.transform.position)
			{
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
			}
			else if (sel.transform.position == menu3.transform.position)
			{
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
			}
			else if (sel.transform.position == menu4.transform.position)
			{
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
			}
			else if (sel.transform.position == menu5.transform.position)
			{
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
			}
			else if (sel.transform.position == menu6.transform.position)
			{
				Application.Quit();
			}
		}
	} IEnumerator wait()
	{
		yield return new WaitForSeconds(1);
		if (Input.anyKey)
			f = 0;
		StopCoroutine(wait());
	}

	IEnumerator reSet()
	{
		yield return new WaitForSeconds(3);
		f = 2;
	}

	public void change()
	{
		flag = (flag + 1) % 6;
		CancelInvoke(
			);
	}
}
