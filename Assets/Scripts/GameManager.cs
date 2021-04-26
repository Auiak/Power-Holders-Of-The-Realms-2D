using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Carnelian;

    void Start()
    {
        if(PlayerData.score > 800)
	{
	    Carnelian.SetActive(true);
	}
    }
}