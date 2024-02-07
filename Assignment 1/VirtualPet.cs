using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {
        #region fields
        
        string petsName;
        string petType;
        int hunger;
        int thirst;     
        int energy;
        #endregion

        #region Constructors
        public VirtualPet()
        {
        }
        public VirtualPet(string petType, string petsName)
        {
            this.petType = petType;
            this.petsName = petsName;
        }
        public VirtualPet(int hunger, int thirst, int energy)
        {
            this.hunger = hunger;
            this.thirst = thirst;
            this.energy = energy;
           
        }
        #endregion

        #region properties
        public string PetType
        {
            get { return this.petType; }
            set { this.petType = value; }
        }


        public string PetsName
        {
            get { return this.petsName; }
            set { this.petsName = value; }
        }

        public int Hunger
        {
            get
            {
                return this.hunger;

            }
            set
            {
                this.hunger = value;
                if (this.hunger < 0)
                {
                    this.hunger = 0;
                }
                if (this.hunger > 100)
                {
                    this.hunger = 100;
                }
            }

        }
        public int Thirst
        {
            get { return this.thirst; }

            set
            {
                this.thirst = value;
                if (this.thirst < 0)
                {
                    this.thirst = 0;
                }
                if (this.thirst > 100)
                {
                    this.thirst = 100;
                }
            }
        }

      

        public int Energy
        {
            get { return this.energy; }

            set
            {
                this.energy = value;
                if (this.energy < 0)
                {
                    this.energy = 0;
                }
                if (this.energy > 100)
                {
                    this.energy = 100;
                }
            }
        }
       

        public double PetSatisfaction 
        {
            get { return 100 - ((this.Hunger + this.Thirst + this.Energy) / 3); }

        }

        

         
        public void ShowPetStatus()
        {
            Console.WriteLine("{0} the {1} :", this.PetsName, this.PetType);
            Console.WriteLine("\tis {0}% hungry.", this.Hunger);
            Console.WriteLine("\tis {0}% thirsty.", this.Thirst);
            Console.WriteLine("\tis {0}% energetic.", this.Energy);
            Console.WriteLine();
        }

        public void FeedPet()
        {
            this.Hunger -= 50;
            this.Energy += 10;
            this.Thirst += 30;
            Console.WriteLine("{0} says, \"Yum!\"", this.PetsName);
        }

        public void WaterPet()
        {
            this.Thirst += 80;
            Console.WriteLine("{0} says, \"Refreshing!\"", this.PetsName);
        }


        public void PlayWithPet()
        {
            this.Energy += 40;
            this.Hunger -= 40;
            Console.WriteLine("{0} says, \"This is so much fun!\"", this.PetsName);
        }
        #endregion
    }
}
