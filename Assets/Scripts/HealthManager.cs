using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    public PlayerCombat playerCombat;

    private void Update()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < playerCombat.currentHealth)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
        }
    }
}