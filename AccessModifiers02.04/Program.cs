using AccessModifiers02._04.Moduls;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace AccessModifiers02._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon(20,15);
            //Console.WriteLine(weapon.BulletCapacity);
          //  weapon.Fire();
          // weapon.Shoot();
          //weapon.GetRemainBulletCount();
          //  weapon.Reload();
                      int num;
            do
            {
                Console.WriteLine(@"0 - İnformasiya almaq üçün
1 - Shoot metodu üçün
2 - Fire metodu üçün
3 - GetRemainBulletCount metodu üçün
4 - Reload metodu üçün
5 - ChangeFireMode metodu üçün
6 - Proqramdan dayandırmaq üçün
7 - Redaktə et :
T - Tutumu dəyişsin
S - Güllə sayı
D - Sıfırlama saniyəsi");
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    switch (num)
                    {
                        //case 0:
                        //    weapon.GetInfo();
                        //    break;
                        case 1:
                            weapon.Shoot();
                            break;
                        case 2:
                            weapon.Fire();
                            break;
                        case 3:
                            weapon.GetRemainBulletCount();
                            break;
                        case 4:
                                weapon.Reload();
                            break;
                            case 5:
                                weapon.ChangeFireMood();
                            break;
                        case 6:
                            Console.WriteLine("Çıxış...");
                            break;
                        default:
                            Console.WriteLine("Başqa rəqəm daxil edin.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Reqem daxil edin.");
                }

                Console.WriteLine();
            } while (num != 0);


        }
        
    }
}
