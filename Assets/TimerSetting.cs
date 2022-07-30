using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerSetting : MonoBehaviour
{

    public float Waktu = 1;
    public bool GameAktif = true;
    public GameObject CanvasTime;
    float s;
    void Update()
    {
        if (GameAktif)
        {
            s += Time.deltaTime;
            if (s >= 1)
            {
                Waktu--;
                s = 0;
            }
        }

        if (GameAktif && Waktu  <= 0)
        {
            CanvasTime.SetActive(true);
            GameAktif = false;
        }







    }
}
