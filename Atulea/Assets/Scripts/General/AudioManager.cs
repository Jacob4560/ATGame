using UnityEngine;
using UnityEngine.Audio;
using System.Collections;

/*
* Audio Manager
* ~~~~~~~~~~~~~~
* Controls output for music and SFX
*/
public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;

    [Header("-------------Audio Source-------------")]
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioSource SFXSource;


    [Header("-------------Music Audio Clips-------------")]
    public AudioClip mainMusic;

    [Header("-------------SFX Audio Clips-------------")]
    public AudioClip buttonClick;

    public static AudioManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        if (mainMusic != null)
        {
            musicSource.clip = mainMusic;
            musicSource.Play();
        }
        // Check Player prefs for volume
        audioMixer.SetFloat("Music", Mathf.Log10(PlayerPrefs.GetFloat("musicVolume", 0.8f)) * 20);
        audioMixer.SetFloat("SFX", Mathf.Log10(PlayerPrefs.GetFloat("sfxVolume", 0.6f)) * 20);
    }

    public bool isMusicClipPlaying(AudioClip clip)
    {
        return musicSource.clip == clip;
    }

    public void PlaySFX(AudioClip clip)
    {
        if (clip != null)
        {
            SFXSource.PlayOneShot(clip);
        }
    }

    public void PlayMusic(AudioClip clip)
    {
        if (clip != null)
        {
            musicSource.clip = clip;
            musicSource.Play();
        }
    }

    public void StopSFX()
    {
        SFXSource.Stop();
    }

    public void StopMusic()
    {
        musicSource.Stop();
    }

    public void PlayClipTwice(AudioClip clip)
    {
        if (clip != null)
        {
            StartCoroutine(playClipSoundDelayed(clip));
        }
        else
        {
            Debug.LogError("Audio clip is not assigned.");
        }
    }
            

    IEnumerator playClipSoundDelayed(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
        yield return new WaitForSeconds(clip.length);
        SFXSource.PlayOneShot(clip);
    }
}
