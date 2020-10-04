using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{

    public GameObject credits;

    //Changes the visibility of the credits object
    public void CreditsVisibility(bool v)
    {
        credits.SetActive(v);
    }
}
