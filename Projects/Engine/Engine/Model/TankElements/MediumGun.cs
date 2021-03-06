﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Model.Bullets;
using TanksInterfaces;
using TanksInterfaces.TankElements;

namespace Engine.Model.TankElements
{
    internal class MediumGun : Gun
    {
        public override Bullet Fire(Vector start, Vector dir)
        {
            TimeToReloadEnd = ReloadTime;
            return new BigBullet(start + dir * 20, dir, Damage);
        }

        public MediumGun()
        {
            Type = GunType.MediumDamageGun;
            Damage = 2;
            ReloadTime = 30;
        }
    }
}
