using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSystem : MonoBehaviour
    
{
    public float xp { get; private set; }
    public int level { get; private set; }

    private float xpForNextLevel;
    public float xpLevelAdjust;

    public Text xpTest;
    public Text levelText;
    public Slider Slider;

    private void Start() {
        xpForNextLevel = level * xpLevelAdjust;
        UpdateUI();
  
    }

    public void AddXp(float _amnt) {
        xp += _amnt;

        if(xp >= xpForNextLevel) {
            xp = xp - xpForNextLevel;
            level += 1;
            xpForNextLevel += level * xpLevelAdjust;
        }

        UpdateUI();
    }
    private void UpdateUI() {
        xpTest.text = "XP:" + xp.ToString();
        levelText.text = "Level " + level.ToString();

    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.G)) {
            float amnt = Random.Range(1f, 40f);
            AddXp(amnt);
        }
        Slider.maxValue = xpForNextLevel;
        Slider.value = xp;

    }

}

