using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    void OnCollosionEnter2D(Collision2D collision)
    {
	SceneManager.LoadScene(1);
    }
}