using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gotHome : MonoBehaviour
{
    public GameObject WIN;
    public GameObject Lose;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(WinningScreen());
        }
    }

    IEnumerator WinningScreen()
    {
        yield return new WaitForSecondsRealtime(3f);
        if (JarFiller.instance.jamAmount >= 3f)
        {
            WIN.SetActive(true);
        }
        else
        {
            Lose.SetActive(true);
        }
      


    }
}
