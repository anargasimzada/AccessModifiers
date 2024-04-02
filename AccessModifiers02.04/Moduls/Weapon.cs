using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers02._04.Moduls
{
    internal class Weapon
    {
        public int _bulletCapacity;
        public int _numberOfBullet;
        public int _bulDischargeSec;
        public bool ShootMode=false;

        public  int BulletCapacity
        {
            get
            {
                return _bulletCapacity;
            }
            set
            {
                if (value > 0)
                {
                    _bulletCapacity = value;
                    
                }
                else
                {
                    Console.WriteLine("daxil edilen reqem yanlisdir.Yeniden daxil edin");
                    
                }
            }
        }
        public int NumberOfBullet
        {
            get
            {
                return _numberOfBullet;
            }
            set
            {
                if (value > 0)
                {
                    _numberOfBullet = value;
                }
               
            }
        }
        public int BulDischargeSec
        {
            get
            {
                return _bulDischargeSec;
            }
            set
            {
                if (value > 0)
                {
                    _bulDischargeSec = value;
                }
            }
        }
        public Weapon(int bulletcapacity,int numberofbullet)
        {
            BulletCapacity = bulletcapacity;
            NumberOfBullet=numberofbullet;
           
        }
        public void Shoot()
        {
            if (!ShootMode)
            {
                if (NumberOfBullet!=0)
                {
                    _numberOfBullet--;
                    Console.WriteLine($"ates acildi,daragda gulle sayi{_numberOfBullet}");
                }
                else
                {
                    Console.WriteLine("darag bosdur");
                }
            }
        }
        public void Fire()
        {
          
            if (!ShootMode)
            {
                while (NumberOfBullet != 0)
                {
                    _numberOfBullet--;
                    BulDischargeSec++;
                }
               
                //herbir gullenin silahdan cixma muddetini 1 saniye gotururem
                Console.WriteLine($"Gulleler ateslendikden {BulDischargeSec} saniye sonra bitir");

               
            }
        }
        public void GetRemainBulletCount()
        {
            int count=0;
            count = BulletCapacity-NumberOfBullet;
            Console.WriteLine(count);

        }
        public void Reload()
        {
            int save = 0;
            save = BulletCapacity - NumberOfBullet;
            BulletCapacity=save+NumberOfBullet;
            Console.WriteLine(BulletCapacity);
        }
        public bool ChangeFireMood()
        {
            if (ShootMode)
            {
                Shoot();
                Console.WriteLine("tekli mood");
                return false;
            }
            else
            {
                Fire();
                Console.WriteLine("avtomatik mood");
                return true;
            }
        }
    }
}
