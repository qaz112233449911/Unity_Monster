using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/// <summary>
/// �Ǫ����O
/// �x�s�Ǫ����
/// </summary>
public class Monster : MonoBehaviour
{
    [Header("���ʳt��"), Range(0, 10)]
    public float speed = 3.5f;
    
    [Range(0, 500)]
    public float attack = 100;
    
    [Range(0, 5000)]
    public float hp = 350;
    
    [Range(0, 50)]
    public float Trackrange = 30;
    public Vector3 offsetTrack;

    [Header("�����D��")]
    public GameObject prop;
    [Range(0, 1)]
    public float probability = 1;
    
    [Header("�����D�㭵��")]
    public AudioClip Droppropsound;
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
