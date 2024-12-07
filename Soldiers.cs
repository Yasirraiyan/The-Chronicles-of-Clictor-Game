    public class Soldiers
    {
        public int id;
        public string name;
        public int health;
        public bool attack = false;
        public int x;
        public int y;
        public int z;
        public int damage;
        public string thing;
        public string sword;
        public int power;
        public int arrow;
        public bool fire=false;
        public string type;
        public int reduces;
        public int weapons;
        public int damage2;
        public Soldiers(int id, string name, int health, int x, int y, int z, int damage, string thing,string sword,int power,int arrow,string type,int reduces,int weapons,int damage2)
        {
            this.id = id;
            this.name = name;
            this.health = health;
            this.x = x;
            this.y = y;
            this.z = z;
            this.damage = damage;
            this.thing = thing;
            this.sword = sword;
            this.power = power;
            this.arrow = arrow;
            this.type= type;
            this.reduces = reduces;
            this.weapons = weapons;
            this.damage = damage;
            
        }

        public (int, int) GetPosition2d(int x, int y)
        {

            Console.WriteLine($"The point is at: ({x}, {y})");


            if (x > 0 && y > 0)
            {
                Console.WriteLine("The point is in the first quadrant.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("The point is in the second quadrant.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("The point is in the third quadrant.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("The point is in the fourth quadrant.");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("The point is on the Y-axis.");
            }
            else if (x == 0 && y > 0)
            {
                Console.WriteLine("The point is on the positive Y-axis.");
            }
            else if (x == 0 && y < 0)
            {
                Console.WriteLine("The point is on the negative Y-axis.");
            }
            else if (y == 0 && x != 0)
            {
                Console.WriteLine("The point is on the X-axis.");
            }
            else if (y == 0 && x > 0)
            {
                Console.WriteLine("The point is on the positive X-axis.");
            }
            else if (y == 0 && x < 0)
            {
                Console.WriteLine("The point is on the negative X-axis.");
            }
            else
            {
                Console.WriteLine("The point is at the origin.");
            }


            return (x, y);
        }
        public (int, int, int) GetPosition3d(int x, int y, int z)
        {
            Console.WriteLine($"The point is at: ({x}, {y}, {z})");
            if (x > 0 && y > 0 && z > 0)
            {
                Console.WriteLine("The point is in the first octant.");
            }
            else if (x < 0 && y > 0 && z > 0)
            {
                Console.WriteLine("The point is in the second octant.");
            }
            else if (x < 0 && y < 0 && z > 0)
            {
                Console.WriteLine("The point is in the third octant.");
            }
            else if (x > 0 && y < 0 && z > 0)
            {
                Console.WriteLine("The point is in the fourth octant.");
            }
            else if (x > 0 && y > 0 && z < 0)
            {
                Console.WriteLine("The point is in the fifth octant.");
            }
            else if (x < 0 && y > 0 && z < 0)
            {
                Console.WriteLine("The point is in the sixth octant.");
            }
            else if (x < 0 && y < 0 && z < 0)
            {
                Console.WriteLine("The point is in the seventh octant.");
            }
            else if (x > 0 && y < 0 && z < 0)
            {
                Console.WriteLine("The point is in the eighth octant.");
            }
            else if (x == 0 && y == 0 && z != 0)
            {
                Console.WriteLine("The point is on the Z-axis.");
            }
            else if (x == 0 && z == 0 && y != 0)
            {
                Console.WriteLine("The point is on the Y-axis.");
            }
            else if (y == 0 && z == 0 && x != 0)
            {
                Console.WriteLine("The point is on the X-axis.");
            }
            else if (x == 0 && y == 0 && z == 0)
            {
                Console.WriteLine("The point is at the origin.");
            }
            else
            {
                Console.WriteLine("The point is on one of the planes but not on any axis.");
            }
            return (x, y, z);
        }
        public void Expire(int health, bool attack)
        {
            
            while (health > 0)
            {
                if (!attack)
                {
                   
                    health = health / 5;

                    
                    if (health <= 0)
                    {
                        Console.WriteLine("Expire");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Not expired");
                    return;
                }
            }

            
            Console.WriteLine("Expire");
        }
        public void typesoldier(string thing)
        {
            if(thing =="arrows")
            {
                Console.WriteLine("Soldier is archers.");
            }
            if (thing == "swords")
            {
                Console.WriteLine("Soldier is knight.");
            }
            else
            {
                Console.WriteLine("Invalid type!");
            }
        }
        public void powersword(string sword)
        {
            if(sword =="iron")
            {
                Console.WriteLine("Power is 100.");
            }
            if (sword == "silver")
            {
                Console.WriteLine("Power is 50.");
            }
        }
        public (string,int) Damage(string sword,int power)
        {
            if (sword == "iron"&&power==50)
            {
                Console.WriteLine($"Power is.{power*2}");
            }
            if (sword == "silver"&&power==100)
            {
                Console.WriteLine($"Power is{power*1.5}.");
            }
            return(sword,power);
        }
        public void testdamage(int damage)
        {
            if(damage>=5&&damage<=25)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid!");
            }
        }
        public void reduce(int damage)
        {
            if(damage>5)
            {
                health = health - 5;
            }
            Console.WriteLine($"Reducing health is:{health}");
        }
        public void valid(int arrows)
        {
            if(arrow==10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid!");
            }
        }
        public int damagebyarrow(int arrow)
        {
            int damagebyarrow = arrow * 2;
            Console.WriteLine($"Damage by arrow is:{damagebyarrow}");
            return damagebyarrow;
        }
        public void lossarrow(bool fire)
        {
            if(!fire)
            {
                arrow = arrow - 1;
            }
            Console.WriteLine($"The present arrow is:{arrow}");
        }
        public void checkthing(string type)
        {
            if(type=="arrow"||type=="sword")
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid!");
            }
        }
        public(int,string,int) calculateweapons(int power,string type,int damage)
        {
            if(type=="arrow")
            {
                int weapons = power * damage * 5;
            }
            if (type == "sword")
            {
                int weapons = power * damage * 10;
            }
            return (power, type, damage);
        }
        public int reducehealth()
        {
            
            if(!fire)
            {
                damage2 = weapons*damage;

            }
            return damage2;
        }
        public void strikeoponent()
        {
           Random arrow=new Random();
            Console.WriteLine(arrow);
            Random rnd1 = new Random();
            Random rnd2 = new Random();
            int randomnumber = rnd1.Next(0, 2);
            Console.WriteLine(rnd1);
            Console.WriteLine(rnd2);
            Console.WriteLine(randomnumber);
            if(randomnumber==0)
            {
                Console.WriteLine("Strike by sword");
            }
            if (randomnumber == 1)
            {
                Console.WriteLine("Strike by sword successfully");
            }
        }
        public void attackbyarcher()
        {
            Random arrow = new Random();
            Console.WriteLine(arrow);
            Random rnd1 = new Random();
            Random rnd2 = new Random();
            int randomnumber = rnd1.Next(0, 2);
            Console.WriteLine(rnd1);
            Console.WriteLine(rnd2);
            Console.WriteLine(randomnumber);
            if (randomnumber == 0)
            {
                Console.WriteLine("Discharge arrow");
            }
            if (randomnumber == 1)
            {
                Console.WriteLine("Tristan");
            }
            if (randomnumber == 2)
            {
                Console.WriteLine("Morholt");
            }

        }
        
    }

}
