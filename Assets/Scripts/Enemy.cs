using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{   
    Rigidbody2D rb;
    public GameObject bullet, explosion;
    public float Xspeed;
    public float Yspeed;
    public int score;
    public bool canShot;
    public float fireRate;
    public float health;

    void  Awake(){
        rb=GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        Destroy(gameObject, 10);
        if(!canShot) return;
        fireRate = fireRate+Random.Range(fireRate/-2, fireRate/2);
        InvokeRepeating("Shoot",fireRate,fireRate);
        
    }

    void Update()
    {
        rb.velocity = new Vector2(Xspeed, Yspeed*-1);
    }

    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.tag=="Player"){
            col.gameObject.GetComponent<SpaceShip>().Damage();
            Die();
        }
    }

    void Die(){
        Instantiate(explosion, transform.position,Quaternion.identity);
        Destroy(gameObject);
        PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score")+score);


    }

    public void Damage(){
        health--;
        if(health==0){
            Die();
        }
    }

    void Shoot(){
        GameObject temp = (GameObject) Instantiate(bullet,transform.position,Quaternion.identity);
        temp.GetComponent<Bullet>().ChangeDirection();
    }
    
}
