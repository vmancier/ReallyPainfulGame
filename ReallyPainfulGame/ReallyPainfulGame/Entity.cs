﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReallyPainfulGame
{
    public abstract class Entity
    {
        private string _name;
        private int _healthMax;
        private int _health;
        private int _manaMax;
        private int _mana;
        private int _level;
        private int _gold;
        private int _attack;
        private int _defense;
        private int _critical;
        private int _speed;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }
        public int HealthMax
        {
            get
            {
                return _healthMax;
            }

            set
            {
                _healthMax = value;
            }
        }
        public int Health
        {
            get
            {
                return _health;
            }

            set
            {
                _health = value;
            }
        }
        public int ManaMax
        {
            get
            {
                return _manaMax;
            }

            set
            {
                _manaMax = value;
            }
        }
        public int Mana
        {
            get
            {
                return _mana;
            }

            set
            {
                _mana = value;
            }
        }
        public int Level
        {
            get
            {
                return _level;
            }

            set
            {
                _level = value;
            }
        }
        public int Gold
        {
            get
            {
                return _gold;
            }

            set
            {
                _gold = value;
            }
        }
        public int Attack
        {
            get
            {
                return _attack;
            }

            set
            {
                _attack = value;
            }
        }
        public int Defense
        {
            get
            {
                return _defense;
            }

            set
            {
                _defense = value;
            }
        }
        public int Critical
        {
            get
            {
                return _critical;
            }

            set
            {
                _critical = value;
            }
        }
        public int Speed
        {
            get
            {
                return _speed;
            }

            set
            {
                _speed = value;
            }
        }

        public Entity(string name, int level, int healthMax, int manaMax, int attack, int defense, int critical, int speed, int gold){
            Name = name;
            HealthMax = healthMax;     
            ManaMax = manaMax;
            Level = level;
            Gold = gold;
            Attack = attack;
            Defense = defense;
            Critical = critical;
            Speed = speed;
            Regeneration();
        }

        /*
          Name : Regeneration
          Description : Restore all the Health and Mana
        */
        public virtual void Regeneration()
        {
            Health = HealthMax;
            Mana = ManaMax;
        }

        /*
          Name : GetDamages
          Description : Calculate the effective damage
          Parameters :
              in int attack
              in int defense
        */
        public int GetDamages(int attack, int defense)
        {
            int dmg = ((int)(((2 * attack - defense) / 2) * Math.Pow(attack, 1 / 3) / Math.Sqrt(defense)));
            if (dmg > 1) 
            {
                return dmg;
            }
            else
            {
                return 1;
            }
        }
    }
}
