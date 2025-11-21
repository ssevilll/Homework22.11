using Homework22._11.Task3.Enums;
using Homework22._11.Task3.Model;

namespace Homework22._11.Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter informations for your weapon");
            Console.WriteLine("Enter weapon's capacity:");
            int capacity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter weapon's bullet count:");
            int bulletcount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter weapon's time of discharge:");
            int timeofdischarge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter weapon's shoot type number(0 for Single, 1 for Automatic):");
            int shoottypeInput = Convert.ToInt32(Console.ReadLine());
            
            Shoottype shoottype;
            try 
            { 
                shoottype = (Shoottype)shoottypeInput;
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid shoot type input. Defaulting to Single.");
                shoottype = Shoottype.Single;
            }
            
            Weapon weapon = new Weapon(capacity, bulletcount, timeofdischarge, shoottype);

            bool isrunning = true;
            while (isrunning)
            {
                Console.WriteLine("\nWhat you want to do?:\n0.Get information 1Shoot 2.Fire 3.GetRemainBulletCount 4.Reload 5.ChangeFireMode 6.Quit 7.Edit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.WriteLine($"Weapon capacity: {weapon.BulletCapacity}, weapon bullet count: {weapon.BulletCount}, weapon's time of discharge: {weapon.TimeofDischarge}, weapon's shoot type: {weapon.ShootType}");
                        break;
                    case 1:
                        weapon.Shoot();
                        break;
                    case 2:
                        weapon.Fire();
                        break;
                    case 3:
                        Console.WriteLine($"The number of needed bullets to fully charge your weapon is {weapon.GetRemainBulletCount()}");
                        break;
                    case 4:
                        weapon.Reload();
                        break;
                    case 5:
                        weapon.ChangeFireMode();
                        break;
                    case 6:
                        isrunning = false;
                        break;
                    case 7:
                        Console.WriteLine("What you want to do?:\nT.Change capacity, S.Change number of bullets, D.Change the time of discharge");
                        string editchoice = Console.ReadLine();
                        switch (editchoice)
                        {
                            case "T":
                                Console.WriteLine("Enter new capacity:");
                                int newcapacity = Convert.ToInt32(Console.ReadLine());
                                weapon.BulletCapacity = newcapacity;
                                break;
                            case "S":
                                Console.WriteLine("Enter new number of bullets:");
                                int newbulletcount = Convert.ToInt32(Console.ReadLine());
                                weapon.BulletCount = newbulletcount;
                                break;
                            case "D":
                                Console.WriteLine("Enter new time of discharge:");
                                int newtimeofdischarge = Convert.ToInt32(Console.ReadLine());
                                weapon.TimeofDischarge = newtimeofdischarge;
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Please try again.");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
