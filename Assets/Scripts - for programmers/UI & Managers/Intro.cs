﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    [SerializeField] float musicWait;
    [SerializeField] float nextLevelWait;
    [SerializeField] AudioClip introMusic;

    private void Start() {
        StartCoroutine(MusicWait());
        StartCoroutine(NextLevelWait());
    }
    IEnumerator MusicWait()
    {
        yield return new WaitForSeconds(musicWait);
        AudioSource.PlayClipAtPoint(introMusic, Camera.main.transform.position);
    }
    IEnumerator NextLevelWait()
    {
        yield return new WaitForSeconds(nextLevelWait);
        SceneManager.LoadScene("LevelFinal");
    }
}
