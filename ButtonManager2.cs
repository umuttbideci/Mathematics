using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonManager2 : MonoBehaviour
{
   public void FirstScene()
	{
		SceneManager.LoadScene("11");
	}

	public IEnumerator Credit()
	{
		Debug.Log("Started");
		yield return new WaitForSeconds(3);
		SceneManager.LoadScene("Main Menu");
	}

	private void Update()
	{
		if (SceneManager.GetActiveScene().name == "Credits")
		{
			StartCoroutine(Credit());
		}
	}
}
