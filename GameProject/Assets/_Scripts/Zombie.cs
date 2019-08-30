using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Source: Jimmy Vegas- How To Make an FPS

public class Zombie : MonoBehaviour
{
    public GameObject player;
    public float distance;
    public float range = 10f;
    public GameObject zombie;
    public float zombieSpeed;
    public int attack;
    public RaycastHit hit;
    public int EnemyHealth = 100;
    public AudioSource death;
    public int zombieAttacking;
    public AudioSource Hurt;
    public int PainSound;

    
    public void DamageInflicted(int DamageAmount)
    {
        //if zombie health is 0 then add 25 to player's score, play death audio sound, and destroy zombie object
        EnemyHealth -= DamageAmount;
        if (EnemyHealth <= 0)
        {
            CurrentScore.GameScore += 25;
            death.Play();
            Destroy(gameObject);

        }
    }

    private void Update()
    {
        transform.LookAt(player.transform);
        
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
        {
            // If player is within range of zombie
            distance = hit.distance;
            if(distance < range)
            {
                //zombie will start to walk towards the player
                zombieSpeed = 0.1f;
                if(attack == 0)
                {
                    //zombie animation plays
                    zombie.GetComponent<Animation>().Play("Walk");
                    transform.position = Vector3.MoveTowards(transform.position, player.transform.position, Time.deltaTime);

                }
            }
            else
            {
                // if player is not within range, zombie remains idle
                zombieSpeed = 0;
                zombie.GetComponent<Animation>().Play("Idle");
            }
        }

        //Zombie will attack once in range within player's enemy trigger
        if (attack == 1)
        {
            //zombie will stop walking, and play the attack animation

            if (zombieAttacking == 0){
                StartCoroutine (EnemyDamage ());
            } 
            
            zombieSpeed = 0;
            zombie.GetComponent<Animation>().Play("Attack");
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        attack = 1;
    }

    private void OnTriggerExit(Collider other)
    {
        attack = 0;
    }

    //Takes away player's health and plays hurt audio sound when attacked by Zombie
    IEnumerator EnemyDamage()
    {
        zombieAttacking = 1;
        yield return new WaitForSeconds(0.5f);
        PlayerHealth.MaxHealth -= 10;
        Hurt.Play();
        yield return new WaitForSeconds(1);
        zombieAttacking = 0;
    }

}
