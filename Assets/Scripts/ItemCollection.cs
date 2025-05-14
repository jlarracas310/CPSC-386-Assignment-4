using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollection : MonoBehaviour
{
    private int gems = 0;
    [SerializeField] private Text gemsText;

    [SerializeField] private AudioSource collectSoundEffect;

    //Collect Gems on collision
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Gem"))
        {
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            gems++;
            gemsText.text = "GEMS : " + gems; 
        }
    }
}
