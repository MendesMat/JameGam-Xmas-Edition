using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField]
    CollectPresent collectPresent;

    [SerializeField]
    private GameObject present;

    private void Start()
    {
        present.SetActive(false);
    }

    private void Update()
    {
        ShowPresent();
    }

    void ShowPresent()
    {
        if (collectPresent.hasPresent)
        {
            present.SetActive(true);
        }
        else
        {
            present.SetActive(false);
        }
    }
}
