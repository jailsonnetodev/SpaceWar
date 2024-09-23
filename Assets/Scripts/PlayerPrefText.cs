using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class PlayerPrefText : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI score_text;
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text=PlayerPrefs.GetInt("Score")+"";
    }
}
