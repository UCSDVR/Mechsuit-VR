﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : Weapon {

    public GameObject CoreDefense;

    public override void Setup() { }

    public void OnTriggerEnter(Collider collider) {
        if (collider.gameObject != CoreDefense) {
            // Health of other
            IHealth health = (IHealth)collider.gameObject.GetComponent(typeof(IHealth));
            if (health != null) {
                IHealthChange damage = (IHealthChange)GetComponent(typeof(IHealthChange));
                damage.ChangeHealth(health);
            }
        }
    }
}