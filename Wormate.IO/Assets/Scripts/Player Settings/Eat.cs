using Mirror;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class Eat : NetworkBehaviour
{
    public Sprite[] UIAbilitySprites;
    [Header("Main Camera")]
    public Animator animCamera;
    [Header("Ability1")]
    public Animator anim1;
    [Header("Ability2")]
    public Animator anim2;
    [Header("Ability3")]
    public Animator anim3;
    [Header("Ability4")]
    public Animator anim4;
    [Header("Ability5")]
    public Animator anim5;
    [Header("Ability6")]
    public Animator anim6;
    [Header("Ability7")]
    public Animator anim7;
    [SyncVar]
    public string food, bang, ring, powerup;
   
    private Text YourRank;
    private Text Rank1;
    private Text Rank2;
    private Text Rank3;
    private Text Rank4;
    private Text Rank5;
    private Text Rank6;
    private Text Rank7;
    private Text Rank8;
    private Text Rank9;
    private Text Rank10;
    [SyncVar]
    [Header("Body Size")]
    public float Increase;
    [SyncVar]
    public int Score = 0;
    [SyncVar]
    bool _Multi2, _Multi5, _Multi10;
    [SyncVar]
    [Header("Eat Points")]
    public int eatPoints = 10;
    [SyncVar]
    [Header("Kill Points")]
    public int killPoints = 10;
    [SyncVar]
    GrowPlayer growPlayer;
    [SyncVar]
    SnakeManager manager;
    private void Start()
    {
        YourRank = GameObject.FindGameObjectWithTag("RankYour").GetComponent<Text>();
        Rank1 = GameObject.FindGameObjectWithTag("Rank1").GetComponent<Text>();
        Rank2 = GameObject.FindGameObjectWithTag("Rank2").GetComponent<Text>();
        Rank3 = GameObject.FindGameObjectWithTag("Rank3").GetComponent<Text>();
        Rank4 = GameObject.FindGameObjectWithTag("Rank4").GetComponent<Text>();
        Rank5 = GameObject.FindGameObjectWithTag("Rank5").GetComponent<Text>();
        Rank6 = GameObject.FindGameObjectWithTag("Rank6").GetComponent<Text>();
        Rank7 = GameObject.FindGameObjectWithTag("Rank7").GetComponent<Text>();
        Rank8 = GameObject.FindGameObjectWithTag("Rank8").GetComponent<Text>();
        Rank9 = GameObject.FindGameObjectWithTag("Rank9").GetComponent<Text>();
        Rank10 = GameObject.FindGameObjectWithTag("Rank10").GetComponent<Text>();

        animCamera = Camera.main.GetComponent<Animator>();
        anim1 = GameObject.FindGameObjectWithTag("UIAbility1").GetComponent<Animator>();
        anim2 = GameObject.FindGameObjectWithTag("UIAbility2").GetComponent<Animator>();
        anim3 = GameObject.FindGameObjectWithTag("UIAbility3").GetComponent<Animator>();
        anim4 = GameObject.FindGameObjectWithTag("UIAbility4").GetComponent<Animator>();
        anim5 = GameObject.FindGameObjectWithTag("UIAbility5").GetComponent<Animator>();
        anim6 = GameObject.FindGameObjectWithTag("UIAbility6").GetComponent<Animator>();
        anim7 = GameObject.FindGameObjectWithTag("UIAbility7").GetComponent<Animator>();

        GameObject.FindGameObjectWithTag("UIAbility1").GetComponent<Image>().sprite = UIAbilitySprites[7];
        GameObject.FindGameObjectWithTag("UIAbility2").GetComponent<Image>().sprite = UIAbilitySprites[7];
        GameObject.FindGameObjectWithTag("UIAbility3").GetComponent<Image>().sprite = UIAbilitySprites[7];
        GameObject.FindGameObjectWithTag("UIAbility4").GetComponent<Image>().sprite = UIAbilitySprites[7];
        GameObject.FindGameObjectWithTag("UIAbility5").GetComponent<Image>().sprite = UIAbilitySprites[7];
        GameObject.FindGameObjectWithTag("UIAbility6").GetComponent<Image>().sprite = UIAbilitySprites[7];
        GameObject.FindGameObjectWithTag("UIAbility7").GetComponent<Image>().sprite = UIAbilitySprites[7];
        manager = this.GetComponent<SnakeManager>();
        growPlayer = this.GetComponent<GrowPlayer>();
    }
    public void FastModeSetScore()
    {
        Score -= 3;
        YourRank.text = Score + " : Steven";
    }

    public void KillEnemySetScore()
    {
        Score += killPoints;
        YourRank.text = Score + " : Steven";
    }

    public void EatFoodSetScore(int scoreIncre)
    {
        if (scoreIncre == 0)
        {
            if (_Multi10)
            {
                Score += (eatPoints * 10);
            }
            if (_Multi5)
            {
                Score += (eatPoints * 5);
            }
            if (_Multi2)
            {
                Score += (eatPoints * 2);
            }

            if (!_Multi10 && !_Multi5 && !_Multi2)
            {
                Score += eatPoints;
            }
        }
        else
        {
            Score += scoreIncre;
        }
        Rank1.text = Score + " : Steven";
    }
  
    async void OnTriggerEnter(Collider other)
    {
        try
        {
           
            if (other.gameObject.CompareTag("ZoomOut"))
            {
                Destroy(other.gameObject);
                NetworkServer.Destroy(other.gameObject);
                if (!animCamera.GetBool("ZoomOut"))
                {
                    animCamera.SetBool("ZoomOut", true);
                    SetAbilityToCanvasUI(6);
                    await Task.Delay(30000);
                    animCamera.SetBool("ZoomOut", false);
                }
              
            }
            else if (other.gameObject.CompareTag("BetterRotate"))
            {
                Destroy(other.gameObject);
                NetworkServer.Destroy(other.gameObject);
                if (manager.rotateSpeed == 300f)
                {
                    manager.rotateSpeed = 720f;
                    SetAbilityToCanvasUI(1);
                    await Task.Delay(30000);
                    manager.rotateSpeed = 300f;
                }
              
            }
            else if (other.gameObject.CompareTag("Coin"))
            {

                Destroy(other.gameObject);
                NetworkServer.Destroy(other.gameObject);
            }
            else if (other.gameObject.CompareTag("FastForward"))
            {
                Destroy(other.gameObject);
                NetworkServer.Destroy(other.gameObject);
                if (manager.fastSpeed == 4.5f)
                {
                    manager.fastSpeed = 6.5f;
                    SetAbilityToCanvasUI(0);
                    await Task.Delay(30000);
                    manager.fastSpeed = 4.5f;
                }
              
            }
            else if (other.gameObject.CompareTag("Heavy"))
            {

                Destroy(other.gameObject);
                NetworkServer.Destroy(other.gameObject);
                transform.localScale += new Vector3(Increase * 2, Increase * 2, Increase * 2);
                growPlayer.AddBodyParts(10);

            }
            else if (other.gameObject.CompareTag("Magnetise"))
            {
                Destroy(other.gameObject);
                NetworkServer.Destroy(other.gameObject);
                if (GameObject.FindWithTag("PHead").GetComponent<SphereCollider>().radius == 0.4f)
                {
                    GameObject.FindWithTag("PHead").GetComponent<SphereCollider>().radius = 3.5f;
                    SetAbilityToCanvasUI(2);
                    await Task.Delay(30000);
                    GameObject.FindWithTag("PHead").GetComponent<SphereCollider>().radius = 0.4f;
                }
                

            }
            else if (other.gameObject.CompareTag("Mistery"))
            {

                Destroy(other.gameObject);
                NetworkServer.Destroy(other.gameObject);
                switch (UnityEngine.Random.Range(0, 8))
                {
                    case 0:
                        if (!animCamera.GetBool("ZoomOut"))
                        {
                            animCamera.SetBool("ZoomOut", true);
                            SetAbilityToCanvasUI(6);
                            await Task.Delay(30000);
                            animCamera.SetBool("ZoomOut", false);
                        }
                        break;
                    case 1:
                        if (manager.rotateSpeed == 300f)
                        {
                            manager.rotateSpeed = 720f;
                            SetAbilityToCanvasUI(1);
                            await Task.Delay(30000);
                            manager.rotateSpeed = 300f;
                        }
                        break;
                    case 2:
                        if (manager.fastSpeed == 4.5f)
                        {
                            manager.fastSpeed = 6.5f;
                            SetAbilityToCanvasUI(0);
                            await Task.Delay(30000);
                            manager.fastSpeed = 4.5f;
                        }
                        break;
                    case 3:
                        transform.localScale += new Vector3(Increase * 2, Increase * 2, Increase * 2);
                        growPlayer.AddBodyParts(10);
                        break;
                    case 4:
                        if (GameObject.FindWithTag("PHead").GetComponent<SphereCollider>().radius == 0.4f)
                        {
                            GameObject.FindWithTag("PHead").GetComponent<SphereCollider>().radius = 3.5f;
                            SetAbilityToCanvasUI(2);
                            await Task.Delay(30000);
                            GameObject.FindWithTag("PHead").GetComponent<SphereCollider>().radius = 0.4f;
                        }
                        break;
                    case 5:
                        if (!_Multi2)
                        {
                            _Multi2 = true;
                            SetAbilityToCanvasUI(3);
                            await Task.Delay(30000);
                            _Multi2 = false;
                        }
                        break;
                    case 6:
                        if (!_Multi5)
                        {
                            _Multi5 = true;
                            SetAbilityToCanvasUI(4);
                            await Task.Delay(30000);
                            _Multi5 = false;
                        }
                        break;
                    case 7:
                        if (!_Multi10)
                        {
                            _Multi10 = true;
                            SetAbilityToCanvasUI(5);
                            await Task.Delay(30000);
                            _Multi10 = false;
                        }
                        break;
                }
            }
            else if (other.gameObject.CompareTag("Multi2"))
            {
                Destroy(other.gameObject);
                NetworkServer.Destroy(other.gameObject);
                if (!_Multi2)
                {
                    _Multi2 = true;
                    SetAbilityToCanvasUI(3);
                    await Task.Delay(30000);
                    _Multi2 = false;
                }
               
            }
            else if (other.gameObject.CompareTag("Multi5"))
            {
                Destroy(other.gameObject);
                NetworkServer.Destroy(other.gameObject);
                if (!_Multi5)
                {
                    _Multi5 = true;
                    SetAbilityToCanvasUI(4);
                    await Task.Delay(30000);
                    _Multi5 = false;
                }
            }
            else if (other.gameObject.CompareTag("Multi10"))
            {
                Destroy(other.gameObject);
                NetworkServer.Destroy(other.gameObject);
                if (!_Multi10)
                {
                    _Multi10 = true;
                    SetAbilityToCanvasUI(5);
                    await Task.Delay(30000);
                    _Multi10 = false;
                }
            }

            if (other.gameObject.CompareTag(bang) || other.gameObject.CompareTag(ring))
            {
                Destroy(other.gameObject);
                NetworkServer.Destroy(other.gameObject);
            }

            if (other.gameObject.CompareTag(food))
            {
                Destroy(other.gameObject);
                NetworkServer.Destroy(other.gameObject);
                transform.localScale += new Vector3(Increase, Increase, Increase);
                growPlayer.AddBodyParts(1);
                EatFoodSetScore(0);
            }
        }
        catch (Exception ex)
        {
            print("Eat: " + ex.Message + " other: "+ other.transform.tag + " me: "+transform.tag);
        }
    }

    private async void SetAbilityToCanvasUI(int ImageIndex)
    {
        try
        {
            if (GameObject.FindGameObjectWithTag("UIAbility1").GetComponent<Image>().sprite == UIAbilitySprites[7])
        {
            GameObject.FindGameObjectWithTag("UIAbility1").GetComponent<Image>().sprite = UIAbilitySprites[ImageIndex];
            await Task.Delay(25000);
            anim1.SetBool("PulseAway", true);
            await Task.Delay(5000);
            anim1.SetBool("PulseAway", false);
            GameObject.FindGameObjectWithTag("UIAbility1").GetComponent<Image>().sprite = UIAbilitySprites[7];
        }
        else
        if (GameObject.FindGameObjectWithTag("UIAbility2").GetComponent<Image>().sprite == UIAbilitySprites[7])
        {
            GameObject.FindGameObjectWithTag("UIAbility2").GetComponent<Image>().sprite = UIAbilitySprites[ImageIndex];
            await Task.Delay(25000);
            anim2.SetBool("PulseAway", true);
            await Task.Delay(5000);
            anim2.SetBool("PulseAway", false);
            GameObject.FindGameObjectWithTag("UIAbility2").GetComponent<Image>().sprite = UIAbilitySprites[7];
        }
        else
        if (GameObject.FindGameObjectWithTag("UIAbility3").GetComponent<Image>().sprite == UIAbilitySprites[7])
        {
            GameObject.FindGameObjectWithTag("UIAbility3").GetComponent<Image>().sprite = UIAbilitySprites[ImageIndex];
            await Task.Delay(25000);
            anim3.SetBool("PulseAway", true);
            await Task.Delay(5000);
            anim3.SetBool("PulseAway", false);
            GameObject.FindGameObjectWithTag("UIAbility3").GetComponent<Image>().sprite = UIAbilitySprites[7];
        }
        else
        if (GameObject.FindGameObjectWithTag("UIAbility4").GetComponent<Image>().sprite == UIAbilitySprites[7])
        {
            GameObject.FindGameObjectWithTag("UIAbility4").GetComponent<Image>().sprite = UIAbilitySprites[ImageIndex];
            await Task.Delay(25000);
            anim4.SetBool("PulseAway", true);
            await Task.Delay(5000);
            anim4.SetBool("PulseAway", false);
            GameObject.FindGameObjectWithTag("UIAbility4").GetComponent<Image>().sprite = UIAbilitySprites[7];
        }
        else
        if (GameObject.FindGameObjectWithTag("UIAbility5").GetComponent<Image>().sprite == UIAbilitySprites[7])
        {
            GameObject.FindGameObjectWithTag("UIAbility5").GetComponent<Image>().sprite = UIAbilitySprites[ImageIndex];

            await Task.Delay(25000);
            anim5.SetBool("PulseAway", true);
            await Task.Delay(5000);
            anim5.SetBool("PulseAway", false);
            GameObject.FindGameObjectWithTag("UIAbility5").GetComponent<Image>().sprite = UIAbilitySprites[7];
        }
        else
        if (GameObject.FindGameObjectWithTag("UIAbility6").GetComponent<Image>().sprite == UIAbilitySprites[7])
        {
            GameObject.FindGameObjectWithTag("UIAbility6").GetComponent<Image>().sprite = UIAbilitySprites[ImageIndex];
            await Task.Delay(25000);
            anim6.SetBool("PulseAway", true);
            await Task.Delay(5000);
            anim6.SetBool("PulseAway", false);
            GameObject.FindGameObjectWithTag("UIAbility6").GetComponent<Image>().sprite = UIAbilitySprites[7];
        }
        else
        if (GameObject.FindGameObjectWithTag("UIAbility7").GetComponent<Image>().sprite == UIAbilitySprites[7])
        {
            GameObject.FindGameObjectWithTag("UIAbility7").GetComponent<Image>().sprite = UIAbilitySprites[ImageIndex];
            await Task.Delay(25000);
            anim7.SetBool("PulseAway", true);
            await Task.Delay(5000);
            anim7.SetBool("PulseAway", false);
            GameObject.FindGameObjectWithTag("UIAbility7").GetComponent<Image>().sprite = UIAbilitySprites[7];
        }
        }
        catch (Exception ex)
        {
            print("UIAbility: " + ex.Message);
        }

    }
}
