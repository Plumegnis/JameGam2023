using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gotHome : MonoBehaviour
{
    public GameObject WIN;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            StartCoroutine(WinningScreen());
        }
    }

    IEnumerator WinningScreen()
    {
        yield return new WaitForSeconds(3);

        WIN.SetActive(true);

    }
}
