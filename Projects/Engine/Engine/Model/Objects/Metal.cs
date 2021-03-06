﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Model.Bullets;
using TanksInterfaces;

namespace Engine.Model.Objects
{
    internal class Metal : IPhysicalObject
    {
        public Vector Position { get; private set; }
        public Vector Direction { get; private set; }
        public int Size { get; private set; }
        public bool IsExists { get; private set; }

        private double Distance(Vector p1, Vector p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }

        public bool BulletProcess(Bullet bul)
        {
            if (Distance(bul.Position, Position) < (bul.Size + Size) / 2)
            {
                if (bul.Type == BulletType.Napalm)
                {
                    IsExists = false;
                    var n = bul as Napalm;
                    n.DecEnergy(5);
                    if (n.Energy <= 0)
                        return true;
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public ObjType Type { get; private set; }

        public Metal(Vector pos)
        {
            IsExists = true;
            Direction = Vector.Stand;
            Size = 20;
            Type = ObjType.Metal;
            Position = new Vector((pos.X*Size) - Size/2, (pos.Y*Size) - Size/2);
        }
    }
}
