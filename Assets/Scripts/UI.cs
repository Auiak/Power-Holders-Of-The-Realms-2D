using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public GameObject Instructions;

    void Start()
    {
	StartCoroutine("TurnOff");
    }

    IEnumerator TurnOff()
    {
        yield return new WaitForSeconds(5f);
	Instructions.SetActive(false);
	Time.timeScale = 1f;
    }
}