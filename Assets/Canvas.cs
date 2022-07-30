using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Canvas : MonoBehaviour
{
    public GameObject person;
    public GameObject potongan;
    public GameObject potongan_shadow;
    public GameObject roti;
    public GameObject roti_shadow;
    public GameObject button;
    private float m_timer = 2.0f;
    private float timer;
    public static bool isNew = false;
    public static int count = 0;
    public int max;
    private void Update()
    {
        if (isNew && count < max)
        {

            timer += Time.deltaTime;
            if (timer > m_timer)
            {
                isNew = false;
                person.gameObject.SetActive(true);
                potongan.gameObject.SetActive(false);
                potongan_shadow.gameObject.SetActive(false);
                roti_shadow.gameObject.SetActive(true);
                roti.gameObject.SetActive(true);
                button.gameObject.SetActive(false);
                Canvas.count += 1;

                timer = 0;

            }

            





        }
    }
    
}


    

