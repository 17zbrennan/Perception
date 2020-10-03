using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Allows us to interact with colorblind asset script
namespace Wilberforce
{
    public class ChangeColor : MonoBehaviour
    {
        //gets variables
        GameObject main;
        Dropdown drop;

        public Camera mainCamera;
        // Start is called before the first frame update
        void Start()
        {
            //gets drop down
            drop = this.GetComponent<Dropdown>();
        }

        // Update is called once per frame
        void Update()
        {
            //Changes the colorblind setting from the asset we got for colorblind
            Colorblind c = mainCamera.GetComponent<Colorblind>();
            c.Type = drop.value;

        }
    }
}
