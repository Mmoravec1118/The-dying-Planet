using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class CharacterSelectButton : MonoBehaviour {

    public void FlatShipSelection ()
    {
        PlayerPrefs.SetInt("CharacterChoice", 0);
        //SceneManager.LoadScene("Level 1");
    }

    public void CurvedShipSelection()
    {
        PlayerPrefs.SetInt("CharacterChoice", 1);
        //SceneManager.LoadScene("Level 1");
    }
}
