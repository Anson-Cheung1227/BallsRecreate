using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject _deathScreen;
    [SerializeField] private TMP_Text _scoreText;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.DeathState += ((sender, args) =>
        {
            _deathScreen.SetActive(true);
        });
    }

    // Update is called once per frame
    void Update()
    {
        _scoreText.text = GameManager.Instance.Score.ToString();
    }

    public void OnRestartButtonPress()
    {
        PersistentManager.Instance.Restart();
    }
}
