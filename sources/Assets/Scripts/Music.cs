using UnityEngine;
using UnityEngine.UI;


public class Music : MonoBehaviour
{
    public float volumeToSet = 0.5f;
    static public float volume = 0.5f;
    public AudioSource music;
    public Slider slider;

    private void Update()
    {
        if (slider == null)
        {
            music.volume = volume;
        }
        else
        {
            volume = slider.value;
            music.volume = volume;
        }
    }
}
