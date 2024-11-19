using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundPlayer : MonoBehaviour
{
    public static soundPlayer Instance;

    private AudioSource audioSource;
    private AudioListener audioListener;
    [SerializeField] private AudioClip buttonSound;
    [SerializeField] private AudioClip shotGun;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioListener = GetComponent<AudioListener>();
    }

    public void playButtonSound()
    {
        audioSource.PlayOneShot(buttonSound);

    }

    public void playShotGun()
    {
        AudioListener.volume = 0.3f;
        audioSource.PlayOneShot(shotGun);
        
    }
}
