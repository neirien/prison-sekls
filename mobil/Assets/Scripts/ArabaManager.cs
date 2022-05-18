using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArabaManager : MonoBehaviour
{

    public ArabaList arList;

    public SpriteRenderer artworkSprite;

    private int selectedOption = 0;

    private void Start()
    {
        UpdateCharacter(selectedOption);
    }

    public void NextOption()
    {
        selectedOption++;

        if(selectedOption >= arList.arabaCount)
        {
            selectedOption = 0;
        }

        UpdateCharacter(selectedOption);
    }

    public void PrevOption()
    {
        selectedOption--;

        if(selectedOption < 0)
        {
            selectedOption = arList.arabaCount - 1;
        }

        UpdateCharacter(selectedOption);
    }


    private void UpdateCharacter(int selectedOption)
    {
        Araba araba = arList.arabaSelect(selectedOption);
        artworkSprite.sprite = araba.arabaSprite;
    }
}
