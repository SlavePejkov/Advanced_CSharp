namespace Models
{
    public class PetStore<T> where T : Pet
    {
        private List<T> pets;

        public PetStore(List<T> pets)
        {
            this.pets = pets;
        }

        public void PrintPets()
        {
            Console.WriteLine($"Pets available in the store:");
            foreach (T pet in pets)
            {
                pet.PrintInfo();
            }
        }

        public void BuyPet(string name)
        {
            bool foundPet = false;
            for (int i = 0; i < pets.Count; i++)
            {
                if (pets[i].Name == name)
                {
                    pets.RemoveAt(i);
                    foundPet = true;
                    Console.WriteLine($"Congratulations, you just bought a {name}!");
                    break;
                }
            }
            if (!foundPet)
            {
                Console.WriteLine($"Sorry, we don't have a pet named {name} in our store.");
            }
        }
    }
}
