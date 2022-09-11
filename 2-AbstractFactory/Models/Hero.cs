using _2_AbstractFactory.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_AbstractFactory.Models
{
    public class Hero
    {
        private Weapon _weapon;
        private Movement _movement;

        public Hero(HeroFactory heroFactory)
        {
            _weapon = heroFactory.CreateWeapon();
            _movement = heroFactory.CreateMovement();
        }

        public void Move()
        {

            _movement.Move();
        }

        public void Hit()
        {

            _weapon.Hit();
        }
    }
}
