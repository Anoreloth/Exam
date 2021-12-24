using System;

namespace Exam
{
    interface Lamp
    {

        string type { get; set; }
        string producer { get; set; }
        string power { get; set; }
        string view { get; set; }
        int number { get; set; }
    }
    interface Camera
    {
        string type { get; set; }
        string producer { get; set; }
        string lightsensitivity { get; set; }


    }
    class PhotoStudio : Lamp, Camera
    {
      
        public string type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string producer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string power { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string view { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int number { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string lightsensitivity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void descriptionlamp(string type, string producer, string power, string view, int number)
        {
            Lamp[] des = { ("Люмінісцентна", "Україна", "700 люменів", "кругова", 2) }: base( type, producer, power, view, number);
            foreach (Lamp l in des)
            {
                l.descriptionlamp();
            }
            Console.WriteLine();
        }
        public void descriptioncamera()
        {
            Camera[] des = { ("Оптична", "Україна", "висока") }: base(type, producer, lightsensitivity);
            foreach (Camera c in des)
            {
                c.descriptioncamera();
            }
            Console.WriteLine();
        }


        
    }

 
}