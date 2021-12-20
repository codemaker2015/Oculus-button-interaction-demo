using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInteractionDemo : MonoBehaviour
{
    public GameObject image;
    bool status = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowImage() {
        status = !status;
        if(status)
            image.SetActive(true);
        else
            image.SetActive(false);
    }
}
