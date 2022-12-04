using Mirror;
using UnityEngine;

public class GrowPlayer : NetworkBehaviour
{
    [Header("Skin Head")]
    [SerializeField] GameObject player0;
    [Header("Skin 1")]
    [SerializeField] GameObject player1;
    [Header("Skin 2")]
    [SerializeField] GameObject player2;
    [Header("Skin 3")]
    [SerializeField] GameObject player3;
    [Header("Skin 4")]
    [SerializeField] GameObject player4;
    [Header("Skin 5")]
    [SerializeField] GameObject player5;
    [Header("Skin 6")]
    [SerializeField] GameObject player6;
    [Header("Skin 7")]
    [SerializeField] GameObject player7;
    [Header("Skin 8")]
    [SerializeField] GameObject player8;
    [Header("Skin 9")]
    [SerializeField] GameObject player9;

    SkinChangerIngame skinChanger;
    SnakeManager snakeM;

    int count = 0;
    int skinStartsAtIndex = 0;
    int currentSkin = 0;
    bool _FirstRun = true;

    void Start()
    {
        skinChanger = GetComponent<SkinChangerIngame>();
        snakeM = GetComponent<SnakeManager>(); 
        skinStartsAtIndex = CharCreation.SkinsStartsPlayer;
        currentSkin = CharCreation.currentSkinPlayer;

    }
    public void AddBodyParts(int size)
    {
        if (transform.gameObject.scene.IsValid())
            ValidateSkin(size); 
    }

    private void ValidateSkin(int size)
    {

        if (_FirstRun)
        {
            skinChanger.ValidateSkin(currentSkin);
            skinStartsAtIndex = CharCreation.SkinsStartsPlayer;
            currentSkin = CharCreation.currentSkinPlayer;
            _FirstRun = false;
            for (int i = 0; i < size; i++)
            {
                CreateBodyParts();
            }
        }
        else
            for (int i = 0; i < size; i++)
            {
                switch (currentSkin)
                {
                    case 0:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 1:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 2:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 3:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 4:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 5:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 6:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 7:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 8:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 9:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 10:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 11:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 12:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 13:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 14:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 15:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 16:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 17:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 18:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 19:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 20:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 21:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 22:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 23:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 24:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 25:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 26:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 27:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 28:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 29:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 30:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 31:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 32:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 33:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 34:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 35:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 36:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 37:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 38:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 39:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 40:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 41:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 42:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 43:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 44:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 45:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 46:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 47:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 48:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 49:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 50:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 51:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 52:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 53:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 54:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 55:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 56:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 57:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 58:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 59:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                    case 60:
                        if (count >= 10)
                            count = skinStartsAtIndex;
                        break;
                }
                CreateBodyParts();
               
            }
    }
    private void CreateBodyParts()
    {
        switch (count)
        {
            case 0:
                snakeM.AddBodyParts(player0);
                break;
            case 1:
                snakeM.AddBodyParts(player1);
                break;
            case 2:
                snakeM.AddBodyParts(player2);
                break;
            case 3:
                snakeM.AddBodyParts(player3);
                break;
            case 4:
                snakeM.AddBodyParts(player4);
                break;
            case 5:
                snakeM.AddBodyParts(player5);
                break;
            case 6:
                snakeM.AddBodyParts(player6);
                break;
            case 7:
                snakeM.AddBodyParts(player7);
                break;
            case 8:
                snakeM.AddBodyParts(player8);
                break;
            case 9:
                snakeM.AddBodyParts(player9);
                break;
        }
        count++;
    }
}
