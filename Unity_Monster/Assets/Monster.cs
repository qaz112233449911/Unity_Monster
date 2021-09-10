using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [Header("���ʳt��"), Range(0, 10)]
    public float speed = 3.5f;
    
    [Header("�����O"), Range(0, 500)]
    public float attack = 100f;
    
    [Header("��q"), Range(0, 5000)]
    public float hp = 350f;
    
    [Header("�l�ܽd��"), Range(0, 50)]
    public float Trackingrange = 30f;
    public Vector3 v3Trackingrange;

    [Header("�����D��"), Range(0, 1)]
    public bool isDropitems;
    public float Dropitems = 0f;

    [Header("�����D�㭵��")]
    public AudioClip Dropitemssound;
    [Header("���˭���")]
    public AudioClip Hurtsound;
    [Header("��������")]
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
