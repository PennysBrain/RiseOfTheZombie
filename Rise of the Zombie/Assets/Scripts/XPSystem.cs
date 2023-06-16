using UnityEngine;
using TMPro;

public class XPSystem : MonoBehaviour
{
    public int currentXP = 0;
    public int level = 1;
    public int defaultRequiredXP = 100;
    private int requiredXP;

    private const string XPKey = "XP";
    private const string LevelKey = "Level";
    private const string RequiredXPKey = "RequiredXP";

    public TextMeshProUGUI currentXPText;
    public TextMeshProUGUI xpLevelText;

    private void Start()
    {
        LoadXPData();
        UpdateLevelDisplay();
    }

    // Call this method to add XP points
    public void AddXP(int xpAmount)
    {
        currentXP += xpAmount;
        if (currentXP >= requiredXP)
        {
            LevelUp();
        }

        SaveXPData();
        UpdateLevelDisplay();
    }

    // Call this method to level up
    private void LevelUp()
    {
        level++;
        if (level == 2)
        {
            requiredXP = 250;
        }
        else
        {
            requiredXP = CalculateRequiredXP();
        }

        // Perform any additional actions on level up

        SaveXPData();
        UpdateLevelDisplay();
    }

    // Calculate the required XP for the next level using a formula
    private int CalculateRequiredXP()
    {
        return requiredXP * 2; // Example: multiplying the required XP by 5 for each level
    }

    // Save XP data to PlayerPrefs
    private void SaveXPData()
    {
        PlayerPrefs.SetInt(XPKey, currentXP);
        PlayerPrefs.SetInt(LevelKey, level);
        PlayerPrefs.SetInt(RequiredXPKey, requiredXP);
        PlayerPrefs.Save();
    }

    // Load XP data from PlayerPrefs
    private void LoadXPData()
    {
        if (PlayerPrefs.HasKey(XPKey))
        {
            currentXP = PlayerPrefs.GetInt(XPKey);
        }

        if (PlayerPrefs.HasKey(LevelKey))
        {
            level = PlayerPrefs.GetInt(LevelKey);
        }

        if (PlayerPrefs.HasKey(RequiredXPKey))
        {
            requiredXP = PlayerPrefs.GetInt(RequiredXPKey);
        }
        else
        {
            requiredXP = defaultRequiredXP;
        }
    }

    // Update the XP level and current XP display
    private void UpdateLevelDisplay()
    {
        if (xpLevelText != null)
        {
            xpLevelText.text = "Level: " + level.ToString();
        }

        if (currentXPText != null)
        {
            currentXPText.text = "Current XP: " + currentXP.ToString() + " / " + requiredXP.ToString();
        }
    }

    private void Update()
    {
        // Increase XP points by 5 for testing purposes by pressing the "U" key
        if (Input.GetKeyDown(KeyCode.U))
        {
            AddXP(5);
        }

        // Reset XP level and current XP when the "=" key is pressed
        if (Input.GetKeyDown(KeyCode.Equals))
        {
            level = 1;
            currentXP = 0;
            requiredXP = defaultRequiredXP;

            SaveXPData();
            UpdateLevelDisplay();
        }
    }
}
