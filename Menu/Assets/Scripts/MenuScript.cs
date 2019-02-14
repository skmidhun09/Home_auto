using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    public GameObject select;
    private int i;

    private void Start()
    {
        i = 2;
    }

    void Update()
    {

        if (i == 2) 
        {
            StartCoroutine(selector());

        }

        if (Input.anyKeyDown)
        {
            i = 1;

            StartCoroutine(wait());
            StartCoroutine(reSet());
        }


        if (i == 1)
        {

        }
        else if (i == 0)
        {
            if (select.transform.position.x == 640)
            {
                Exit();
            }
            else if (select.transform.position.x == 70)
            {
                HomeMode();
            }
        }

    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(1);
        if (Input.anyKey)
            i = 0;
        StopCoroutine(wait());
    }

    IEnumerator reSet()
    {
        yield return new WaitForSeconds(3);
        i = 2;
    }

    void HomeMode()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void InteriorDesign()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    void Entertainmentmode()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    void RepairMode()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }

    void EducationMode()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }

    void Exit()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
    }

    IEnumerator selector()
    {
        yield return new WaitForSeconds(1f);
        select.transform.position = new Vector3(640, 154, 0);
        yield return new WaitForSeconds(1f);
        select.transform.position = new Vector3(70, 154, 0);
    }
}