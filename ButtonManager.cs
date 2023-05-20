using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
   [Header("SFX")] 
   [SerializeField] private AudioSource true_sfx;
   [SerializeField] private AudioSource false_sfx;
   
   
   [Header("GameObjects")]
   [SerializeField] private GameObject all;
   [SerializeField] private GameObject true_i;
   [SerializeField] private GameObject false_i;

   private void Start()
   {
      Cursor.visible = true;
      Cursor.lockState = CursorLockMode.None;
      true_i.SetActive(false);
      false_i.SetActive(false);
        

   }

   public void True()
   {
      Debug.Log("True");
      all.SetActive(false);
      true_sfx.Play();
		
        if (SceneManager.GetActiveScene().name == "5")
        {
            SceneManager.LoadScene("Credits");
        }
        else
        {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
		true_i.SetActive(true);
	  
	}

	public void False()
   {
      Debug.Log("False");
      all.SetActive(false);
      false_sfx.Play();
      false_i.SetActive(true);
      SceneManager.LoadScene("Scenes/11");
   }
} 
    