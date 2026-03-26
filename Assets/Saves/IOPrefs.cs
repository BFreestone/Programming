using UnityEngine;

public class IOPrefs : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        save();
        load();
    }

    void save()
    {
        PlayerPrefs.SetString("Character Name", "Steve");
        PlayerPrefs.SetInt("Character Level", 17);
        PlayerPrefs.SetFloat("Character Health", 100);
    }

    void load()
    {
        Debug.Log(PlayerPrefs.GetString("Character Name"));
        Debug.Log(PlayerPrefs.GetInt("Character Level"));
        Debug.Log(PlayerPrefs.GetFloat("Character Health"));

    }

}
