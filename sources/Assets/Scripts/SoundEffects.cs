using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public AudioSource die;
    public AudioSource jump;
    public AudioSource crash;
    public AudioSource bonusPoints;

    public void PlayJumpSoundEffect()
    {
        jump.Play();
    }

    public void PlayDieSoundEffect()
    {
        die.Play();
    }

    public void PlayCrashSoundEffect()
    {
        crash.Play();
    }

    public void PlayBonusPointsSoundEffect()
    {
        bonusPoints.Play();
    }
}
