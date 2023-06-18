using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{

    public void Level1()
    {
		SceneManager.LoadScene("Menu1");
	}

	public void Level2()
	{
		SceneManager.LoadScene("Menu2");
	}

	public void Level3()
	{
		SceneManager.LoadScene("Menu3");
	}




	public void QuitGame()
    {
        Application.Quit();
    }
}
