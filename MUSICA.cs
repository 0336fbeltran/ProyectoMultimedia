using System.Collections;	
using System.Collections.Generic;
using UnityEngine;

public class MUSICA : MonoBehaviour
{
  private AudioSource _audioSource;
  private void Awake()
  {
    DontDestroyOnLoad(transform.gameObject);
    _audioSource = GetComponent<AudioSource>();
    PlayMusic();
  }
  public void PlayMusic()
  {
    if (_audioSource.isPlaying) return;
    _audioSource.Play();
  }
  public void StopMusic()
  {
    _audioSource.Stop();
  }
       
}
