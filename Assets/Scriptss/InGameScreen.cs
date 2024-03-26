using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class InGameScreen : MonoBehaviour
{

    public TextMeshProUGUI hpText;

    // Start is called before the first frame update
    void Awake()
    {
        PlayerHealthSystem.onHealthChanged.AddListener(UpdateHpText);
    }

    public void UpdateHpText()
    {
        Debug.Log("hp changed");
        hpText.text = "hp: " + PlayerHealthSystem.instance.currentHp.ToString() + "/" + PlayerHealthSystem.instance.maxHp.ToString();
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
