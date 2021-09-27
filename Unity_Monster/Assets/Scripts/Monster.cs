using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/// <summary>
/// 怪物類別
/// 儲存怪物資料
/// </summary>
public class Monster : MonoBehaviour
{
    [Header("移動速度"), Range(0, 10)]
    public float speed = 3.5f;
    
    [Range(0, 500)]
    public float attack = 100;
    
    [Range(0, 5000)]
    public float hp = 350;
    
    [Range(0, 50)]
    public float Trackrange = 30;
    public Vector3 offsetTrack;

    [Header("掉落道具")]
    public GameObject prop;
    [Range(0, 1)]
    public float probability = 1;
    
    [Header("掉落道具音效")]
    public AudioClip Droppropsound;
    [Header("受傷音效")]
    public AudioClip Hurtsound;
    [Header("攻擊音效")]
    public AudioClip attacksound;

    private AudioSource aud;
    private Rigidbody2D rig;
    private Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
