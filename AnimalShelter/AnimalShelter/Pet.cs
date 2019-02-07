using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Pet
    {
        public int PetId;
        public string Name;
        public string Color;
        public string Gender;
        public string Description;


        public Pet(int petId, string name, string color, string gender)
        {
            PetId = petId;
            Name = name;
            Color = color;
            Gender = gender;
        }

        // 가상 메서드 ( 자식 클래스에서 호출 및 재정의 )
        public virtual string MakeSound()
        {
            return "";
        }
    }
}
