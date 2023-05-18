using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class GameStart : MonoBehaviour
{
    public static GameStart Instance;
    public AudioSource scoure;
    public AudioSource scoure1;
    public Transform youtong;
    public GameObject go1;
    public GameObject go2;


    public Transform win;
    public int num;
    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        //播放音频


    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PlayAudio(string str)
    {
        scoure1.clip = Resources.Load<AudioClip>(str);
        scoure1.Play();
    }
    public void HideYOU()
    {
        youtong.GetChild(num - 1).gameObject.SetActive(false);
        if (num >= 3)
        {
            go1.SetActive(false);
            go2.SetActive(true);

            //win
            Invoke("winGo", 1);
        }
    }
    void winGo()
    {
        win.gameObject.SetActive(true);
        //向上的动画
        //win.DOLocalMoveY(122, 0.5f);
    }
}
