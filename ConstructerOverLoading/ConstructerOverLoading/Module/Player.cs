using System;

namespace ConstructerOverLoading.Module
{
    class Player
    {
        private string _name;
        private int _age;
        GenderType _gender;

        public Player(String _name) : this(_name, 18, GenderType.male)
        {
        }
        public Player(String _name, int _age, GenderType _gender)
        {
            //this(_name);
            this._name = _name;
            this._age = _age;
            this._gender = _gender;
            Console.WriteLine("Object Created");

        }
        public string GetName()
        {
            return _name;
        }
        public int GetAge()
        {
            return _age;
        }
        public GenderType GetGenderr()
        {
            return _gender;
        }
        public Player WhoIsElder(Player v)
        {
            if (this.GetAge() > v.GetAge())
            {
                return this;
            }
            else 
                return v;
        }
    }


}
