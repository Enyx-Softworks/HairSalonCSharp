using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairSalonCSharp
{
    public class Customer
    {
        public int id = 0;
        public string name = "";
        public Gender gender = Gender.female;
        public int age = 26;
        public Hair currentHair = new Hair();
        public Hair desiredHair = new Hair();
        public Mood mood = new Mood();
        public SpecialAttributes specialAttributes = new SpecialAttributes();
    }

    public enum Gender
    {
        female = 0,
        male = 1,
        futa = 2
    }

    public class Hair
    {
        public int length = 1;
        public string lengthText = "Short";
        public HairColor color = HairColor.Pink;
        public string photo = "";
        public HairComposition composition = HairComposition.Straight;
    }

    public enum FirstNames
    {
        Kaley,
        Ann,
        Jana,
        Bianca,
        Victoriia,
        Franziska,
        Reese,
        Steffi
    }

    public enum HairColor
    {
        White = 0xFFFFFF,
        HoneyBlond = 0xcea84d,
        PlatinBlond = 0xf7e2b0,
        Brown = 0x3c3115,
        Black = 0x151515,
        Red = 0x933d1f,
        Pink = 0xc222df
    }

    public enum HairComposition
    {
        Straight = 0,
        Curly = 1
    }

    public enum Mood
    {
        Normal = 0,
        Angry = 1,
        Flirty = 2,
        Bored = 3,
        Impatient = 4
    }

    public class SpecialAttributes
    {
        public int affection = 0;
     
        public SpecialAttributes()
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            affection = random.Next(0, 100);
        }
    }
}
