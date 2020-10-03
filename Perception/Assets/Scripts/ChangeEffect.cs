using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class ChangeEffect : MonoBehaviour
{
    //Private variables
    private Toggle effect;
    private Toggle other;
    private VideoPlayer vpNormal;
    private VideoPlayer vpEffect;

    //Public Variables
    public Camera temp;
    public Camera cam;
    public GameObject normalVideo;
    public GameObject effectVideo;
    public GameObject otherToggle;
    
    // Start is called before the first frame update
    void Start()
    {
        //instantiates variables
        effect = this.gameObject.GetComponent<Toggle>();
        other = otherToggle.GetComponent<Toggle>();
        vpEffect = effectVideo.GetComponent<VideoPlayer>();
        vpNormal = normalVideo.GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        //Changes the effect between drunk/depth
        if (effect.isOn)
        {
            vpNormal.targetCamera = temp;
            vpEffect.targetCamera = cam;
            other.isOn = false;
        }
        else if(other.isOn) //If the other one is on, this will goto a different camera
        {
            vpEffect.targetCamera = temp;
        }
        else // If both are off it'll set the normal camera to the normal video
        {
            vpNormal.targetCamera = cam;
            vpEffect.targetCamera = temp;
        }
    }
}
