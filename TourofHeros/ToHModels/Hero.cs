using System;

namespace ToHModels
{
    public class Hero
    {
        private String name;
        public String Name 
        { 
            get{return name;} 
            set
            {
                if (value.Equals(null))
                {

                }
                name = value;
            } 
        }
        public int HP { get; set; }

        public Element ElementType { get; set; }
        public SuperPower Power { get; set; }
    }
    


}
