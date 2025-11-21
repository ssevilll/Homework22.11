using System;
using Homework22._11.Task3.Enums;

namespace Homework22._11.Task3.Model
{
    internal class Weapon
    {
        public int BulletCapacity { get; set; }
        public int BulletCount { get; set; }
        public int TimeofDischarge { get; set; }
        public Shoottype ShootType { get; set; }

        public Weapon(int capacity, int bulletcount, int timeofdischarge, Shoottype shoottype)
        {
            BulletCapacity = capacity;
            BulletCount = bulletcount;
            TimeofDischarge = timeofdischarge;
            ShootType = shoottype;
        }

        public void Shoot()
        {
            if (BulletCount > 0)
            {
                Console.WriteLine("\nBang!");
                Console.WriteLine("One bullet was used!\n");
                BulletCount--;
            }
            else
            {
                throw new InvalidOperationException("Cannot shoot: No bullets left.");
            }
        }

        public void Fire()
        {
            if (BulletCount > 0)
            {
                Console.WriteLine("Firing...\n");
                while (BulletCount > 0)
                {
                    Shoot();
                }
            }
            else
            {
                throw new InvalidOperationException("Cannot fire: No bullets left.");
            }
            Console.WriteLine($"All bullets ended in {TimeofDischarge} seconds.\n");
        }

        public int GetRemainBulletCount()
        {
            return BulletCapacity - BulletCount;
        }
        public void Reload()
        {
            BulletCount = BulletCapacity;
            Console.WriteLine("Weapon reloaded.\n");
        }

        public void ChangeFireMode()
        {
            if (ShootType == Shoottype.Single)
            {
                ShootType = Shoottype.Automatic;
            }
            else
            {
                ShootType = Shoottype.Single;
            }
        }
    }
}
