using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class SoundsAttributes
{
    [HideInInspector]
    public AudioSource source;

    public string Name;
    public AudioClip AudioClip;

    [Range(0f, 1f)]
    public float Volume = 1f;
    [Range(.1f, 3f)]
    public float Pitch;
    public bool Loop;
}
