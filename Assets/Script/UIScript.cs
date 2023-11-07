using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIScript : MonoBehaviour
{
    [SerializeField] FoodPanelSC mainPnl;
    [SerializeField] GameObject welcomePnl;

    [SerializeField] AudioClip mainSoundClip;
    [SerializeField] AudioSource mainSoundSource;

    private void Start() => OnStartApps();
    public void OnStartApps()
    {
        PlayTheme();
        mainPnl.gameObject.SetActive(false);
        StartCoroutine(WaitingPanel());
    }
    private IEnumerator WaitingPanel()
    {
        yield return new WaitForSeconds(4f);
        mainPnl.gameObject.SetActive(true);
        welcomePnl.gameObject.SetActive(false);
    }
    private void PlayTheme() => mainSoundSource.Play();
}
