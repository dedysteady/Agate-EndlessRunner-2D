using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSoundController : MonoBehaviour
{
    public AudioClip jump;
    public AudioClip scoreHighlight;
    public AudioClip finish;
    private AudioSource audioPlayer;
    // Start is called before the first frame update
    private void Start()
    {
        audioPlayer = GetComponent<AudioSource>();
    }
    public void Finish()
    {
        audioPlayer.PlayOneShot(finish);
    }
    public void PlayJump()
    {
        audioPlayer.PlayOneShot(jump);
    }
    public void PlayScoreHighlight()
    {
        audioPlayer.PlayOneShot(scoreHighlight);
    }
    // Update is called once per frame
    
}
