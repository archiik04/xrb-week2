using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    public GameObject winCanvas;  
    public GameObject winEffect; 

    private void Start()
    {
        winCanvas.SetActive(false);  
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))  
        {
            winCanvas.SetActive(true); 

            if (winEffect != null)
            {
                Instantiate(winEffect, transform.position, Quaternion.identity);  
            }
        }
    }
}

