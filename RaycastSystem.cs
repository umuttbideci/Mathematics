using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RaycastSystem : MonoBehaviour
{
    [SerializeField] public float scene;
    [SerializeField] public float loadedScene = 0;
    [SerializeField] public float activeDistance;
    [SerializeField] public LayerMask layer;
    [SerializeField] public Camera cam;

    

    private void Start()
    {

        
    }

    private void Update()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, activeDistance, layer) && Input.GetKeyDown(KeyCode.F))
        {
            //On Raycast Hit
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }

    }

}
   

    
    
