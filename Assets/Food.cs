using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Food : MonoBehaviour
{
    public GameObject food_shadow;
    public GameObject button;
    public GameObject person;
    private Vector3 originPos;
    // script baru untuk food
    private void OnTriggerEnter2D(Collider2D other)
    {
        

        if (other.gameObject == food_shadow)
        {
            Canvas.count += 1;
            person.gameObject.SetActive(false);
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
            button.SetActive(true);
            Canvas.isNew = true;
            gameObject.transform.position = originPos;


        }
    }
    public void Start()
    {
        originPos = gameObject.transform.position;
    }
}