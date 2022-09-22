
using UnityEngine;

public class AudioScr : MonoBehaviour
    
{

    public AudioSource audio;

    private static AudioScr instance = null;

    private void Start()
    {
        audio.Play();
    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
    }
}
