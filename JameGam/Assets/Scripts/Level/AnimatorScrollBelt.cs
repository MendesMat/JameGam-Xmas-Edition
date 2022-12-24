using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorScrollBelt : MonoBehaviour
{
    [SerializeField]
    public float scrollRate = 0.0355f;

    private void Update()
    {
        float offsetX = Time.time * scrollRate;
        switch (tag)
        {
            case "RightBelt":
                GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, offsetX);
                break;

            case "LeftBelt":
                GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, -offsetX);
                break;
        }
    }
}
