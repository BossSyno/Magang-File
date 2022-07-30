using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Loading : MonoBehaviour
{
   public Transform progressBar;

[SerializeField]
private float nilaiSekarang;
[SerializeField]
private float nilaiKecepatan;

    // Update is called once per frame
    void Update()
    {
        if (nilaiSekarang < 100 ) {
            nilaiSekarang += nilaiKecepatan * Time.deltaTime;
            Debug.Log((int)nilaiKecepatan);
        }else
        {
            Application.LoadLevel("Prototype 3");
        }
        progressBar.GetComponent<Image>().fillAmount = nilaiSekarang / 100;
    }
}
