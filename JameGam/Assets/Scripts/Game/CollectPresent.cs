using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPresent : MonoBehaviour
{
    private CheckPresents checkPresents;

    public bool hasPresent = false;
    public GameObject Present;

    private void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Present" && !hasPresent)
        {
            checkPresents.PresentsCounter += 1;
            Destroy(col.gameObject);
            hasPresent = true;
            FindObjectOfType<AudioManager>().PlaySound("CollectGift");
        }
    }
}
