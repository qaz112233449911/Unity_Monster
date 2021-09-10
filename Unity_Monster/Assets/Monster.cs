using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [Header("移動速度"), Range(0, 10)]
    public float speed = 3.5f;
    
    [Header("攻擊力"), Range(0, 500)]
    public float attack = 100f;
    
    [Header("血量"), Range(0, 5000)]
    public float hp = 350f;
    
    [Header("追蹤範圍"), Range(0, 50)]
    public float Trackingrange = 30f;
    public Vector3 v3Trackingrange;

    [Header("掉落道具"), Range(0, 1)]
    public bool isDropitems;
    public float Dropitems = 0f;

    [Header("掉落道具音效")]
    public AudioClip Dropitemssound;
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
