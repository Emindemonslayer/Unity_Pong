using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public GameObject PauseMenu;
    public bool esc,win;
    [SerializeField] Slider slider;
    public AudioSource source;
    public AudioClip[] SFX;

    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        
    }
    #region Esc and Quit
    public void OnEsc(InputValue Value)
    {
        esc = !esc;
        if(esc)
        {
            PauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            PauseMenu.SetActive(false);
            Time.timeScale = 1;
        }
    }
    public void Quit()
    {
        Application.Quit();
    }
    #endregion

    public void MusicVolume()
    {
        source.volume = slider.value;
    }
    public void Restart()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
