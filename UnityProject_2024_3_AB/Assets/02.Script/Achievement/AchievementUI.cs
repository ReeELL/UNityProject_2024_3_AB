using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementUI : MonoBehaviour
{

    public GameObject achievementPanel;
    public GameObject achievementItemPrefabs;
    public Transform contect;

    private List<GameObject> achievementItems = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        UpdateAchiecementUI();
    }

    // Update is called once per frame
    public void UpdateAchiecementUI()
        {
        foreach(var achiecvement in AchievementManager.instance.achievements)
        {
            GameObject item = Instantiate(achievementItemPrefabs, contect);
            Text[] text = item.GetComponentsInChildren<Text>();
            text[0].text = achiecvement.name;
            text[1].text = achiecvement.description;
            text[2].text = $"{achiecvement.currentProgress}/{achiecvement.goal}";
            text[3].text = achiecvement.isUnlocked ? "含失" : "耕含失";
            achievementItems.Add(item);
        }
    }
}
