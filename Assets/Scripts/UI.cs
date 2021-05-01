using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public GameObject Instructions;

    void Start()
    {
	if(PlayerData.score == 0)
	{
	    StartCoroutine("TurnOff");
	}
	else
	{
	    Instructions.SetActive(false);
	}
    }

    IEnumerator TurnOff()
    {
        yield return new WaitForSeconds(5f);
	Instructions.SetActive(false);
	Time.timeScale = 1f;
    }
}