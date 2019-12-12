using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    Image healthBar;

    Transform player;

    [SerializeField]
    GameObject objFailed;

    Transform parentObject;

    Vector3 offsetFromPlayer;

    // How much damage to sustain after colliding with a pacman
    float damage = .4f;

    // How much regen takes place at each tick
    float repairRate;

    // How long between each regen tick (in seconds)
    float regenTick = .5f;

    // Is regen already active?
    bool isRegenNow = false;

    AvailablePortals availablePortals;

    [SerializeField]
    GameObject barObject;

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        // Listen for when player takes damage
        player.gameObject.GetComponent<playerController>().damageTaken.AddListener(HandleHealthLoss);

        parentObject = gameObject.transform.parent;
        availablePortals = GameObject.FindGameObjectWithTag("availablePortals").GetComponent<AvailablePortals>();
        healthBar = GetComponent<Image>();
        healthBar.fillAmount = 1f;

        offsetFromPlayer = new Vector3(.035f, .8f, 0f);

        repairRate = damage / 3f;

        animator = barObject.GetComponent<Animator>();
        animator.SetBool("isPulsating", false);
    }

    IEnumerator StopPulsating()
    {
        yield return new WaitForSeconds(1f);
        animator.SetBool("isPulsating", false);
    }
    void HandleHealthLoss()
    {
        healthBar.fillAmount -= damage;

        animator.SetBool("isPulsating", true);
        StartCoroutine(StopPulsating());
        if (healthBar.fillAmount <= 0 && !availablePortals.isInPlaylistMode)
        {
            // This is where the ghost dies
            GameObject objectiveFailed = Instantiate(objFailed);
        }

        if (!isRegenNow)
        {
            CheckHealth();
        }           
    }

    void CheckHealth()
    {
        if (healthBar.fillAmount < 1)
        {
            StartCoroutine("RegenHealth");
        }
    }

    private void Update()
    {
        parentObject.position = player.position + offsetFromPlayer;
    }

    IEnumerator RegenHealth()
    {
        isRegenNow = true;
        yield return new WaitForSeconds(regenTick);

        float tempHealth = healthBar.fillAmount + repairRate;

        if (tempHealth >= 1)
        {
            healthBar.fillAmount = 1;
            isRegenNow = false;
            yield return null;
        }
        else
        {
            healthBar.fillAmount = tempHealth;
            CheckHealth();
        }
    }
}
