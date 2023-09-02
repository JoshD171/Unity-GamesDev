using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    private int BlueRange;
    private int i = 3;
    // Start is called before the first frame update
    void Start()
    {
      BlueRange = Random.Range(150, 251);  
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);
        if (gameObject.CompareTag("Red") && i == 100)
        {
            gameObject.SetActive(false);
        }
        else if (gameObject.CompareTag("Blue") && i == BlueRange)
        {
            if (rend != null)
            {
                rend.enabled = false;
            }
        }
    }
}
