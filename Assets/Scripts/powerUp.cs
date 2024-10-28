using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour
{

    public bool isPw1Taken;
    public bool isPw2Taken;
    public bool isPw3Taken;

    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Child Player"))
        {
            isPw1Taken = true;
            isPw2Taken = false;
            isPw3Taken = false;
            Debug.Log("power 1 aldýn");
        }
        else if (other.gameObject.layer == LayerMask.NameToLayer("Adult Player"))
        {
            isPw1Taken = false;
            isPw2Taken = true;
            isPw3Taken = false;
            Debug.Log("power 2 aldýn");
        }
        else if (other.gameObject.layer == LayerMask.NameToLayer("Old Player"))
        {
            isPw1Taken = false;
            isPw2Taken = false;
            isPw3Taken = true;
            Debug.Log("power 3 aldýn");
        }
    }


    public void pw1()
    {
        FindObjectOfType<playerMovement>().speed = 10f;
        //adult.GetComponent(Collider).isTrigger = true;
    }

    public void pw2()
    {
        //BURAYI EDÝTLE
    }

    public void pw3()
    {
        //BURAYI EDÝTLE
    }

    private void Update()
    {
        //Debug.Log(isPw1Taken);
    }

}
