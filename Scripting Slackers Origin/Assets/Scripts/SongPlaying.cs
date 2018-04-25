using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SongPlaying : MonoBehaviour {



    public AudioClip [] dosSounds;
    public enum SoundName { a1, a2, a3, a4, a5, a6, a7};
    public SoundName mySound;



    public void PlaySound()
    {
        switch (mySound)
        {
            case SoundName.a1:
                AudioSource.PlayClipAtPoint(dosSounds[0], transform.position);
                break;

            case SoundName.a2:
                AudioSource.PlayClipAtPoint(dosSounds[1], transform.position);
                break;

            case SoundName.a3:
                AudioSource.PlayClipAtPoint(dosSounds[2], transform.position);
                break;

            case SoundName.a4:
                AudioSource.PlayClipAtPoint(dosSounds[3], transform.position);
                break;

            case SoundName.a5:
                AudioSource.PlayClipAtPoint(dosSounds[4], transform.position);
                break;

            case SoundName.a6:
                AudioSource.PlayClipAtPoint(dosSounds[5], transform.position);
                break;

            case SoundName.a7:
                AudioSource.PlayClipAtPoint(dosSounds[6], transform.position);
                break;

            default:
                break;
        }
    }
}
