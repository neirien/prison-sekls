using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ArabaList : ScriptableObject
{

    public Araba[] araba;

    public int arabaCount
    {
        get
        {
            return araba.Length;
        }
    }

    public Araba arabaSelect(int index)
    {
        return araba[index];
    }
}
