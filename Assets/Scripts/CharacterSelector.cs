using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelector : MonoBehaviour
{
    [SerializeField] GameObject chlid;
    [SerializeField] GameObject adult;
    [SerializeField] GameObject old;

    static int currentRun = 1;





    // Start is called before the first frame update
    void Start()
    {

        FindObjectOfType<cameraFollow>().targetObject = chlid.transform;
        chlid.SetActive(true);
        adult.SetActive(false);
        old.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Child Player"))
        {
            adult.transform.position = chlid.transform.position;
            FindObjectOfType<cameraFollow>().targetObject = adult.transform;
            chlid.SetActive(false);
            adult.SetActive(true);
            old.SetActive(false);
            FindObjectOfType<playerMovement>().speed = FindObjectOfType<playerMovement>().adultSpeed;
        }
        else if (other.gameObject.layer == LayerMask.NameToLayer("Adult Player"))
        {
            old.transform.position = adult.transform.position;
            FindObjectOfType<cameraFollow>().targetObject = old.transform;
            chlid.SetActive(false);
            adult.SetActive(false);
            old.SetActive(true);
            FindObjectOfType<playerMovement>().speed = FindObjectOfType<playerMovement>().oldSpeed;
        }
        else if (other.gameObject.layer == LayerMask.NameToLayer("Old Player"))
        {
            chlid.transform.position = old.transform.position;
            FindObjectOfType<cameraFollow>().targetObject = chlid.transform;
            chlid.SetActive(true);
            adult.SetActive(false);
            old.SetActive(false);
            FindObjectOfType<playerMovement>().speed = FindObjectOfType<playerMovement>().childSpeed;
            currentRun++;
            if (currentRun == 2 && FindObjectOfType<powerUp>().isPw1Taken)
            {
                Debug.Log("RUNNNN");
                FindObjectOfType<powerUp>().pw1();
            }
            else if (currentRun == 3 && FindObjectOfType<powerUp>().isPw2Taken)
            {
                Debug.Log("POWER 2 KULLANILIYO");
                FindObjectOfType<powerUp>().pw2();
            }
            else if (currentRun == 4 && FindObjectOfType<powerUp>().isPw3Taken)
            {
                Debug.Log("POWER 3 KULLANILIYO");
                FindObjectOfType<powerUp>().pw3();
            }
        }

    }

    private void Update()
    {

    }



}
