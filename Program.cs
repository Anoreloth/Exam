using System;

namespace Exam
{
    interface Lamp
    {
        string type();
        string producer();
        string power { get; }
        string view();
       string  number { get; }

        void Printl();
        void ChangeP();
    }
    interface Camera
    {
        string typec();
        string producerc();
        string lightsensitivity { get; }
        void Printc();
        void ChangeS();
    }
    class PhotoStudio : Lamp, Camera
    {
        protected int r { get; set; }
        protected int k { get; set; }
        protected int i { get; set; }
        public PhotoStudio(int r, int k, int i)
        {
            this.r = r;
            this.k = k;
            this.i = i;
        }

        public string type()
        {
            return "Type lamp: FLM-200";
        }
        public string producer()
        {
            return "Producer lamp: Ukraine";
        }
        public string power
        {
            get
            {
                return $"Power in lumen:{r} ";
            }
        }
        public string view()
        {
            return "View: Luminescent";
        }

        public string number
        {
            get
            {
                return $"Numbers: {k} ";
            }
        }
        public string typec()
        {
            return "Type camera: AHD ";
        }
        public string producerc()
        {
            return "Producer camera: Ukraine";
        }
        public string lightsensitivity
        {
            get
            {
                return $"Light sensitivity:{i} ";
            }
        }
        public void Printl()
        {
            Console.WriteLine($"{type()}\n{producer()}\n{power}\n{view()}\n");
        }
        public void Printc()
        {
            Console.WriteLine($"{typec()}\n{producerc()}\n{lightsensitivity}\n");
        }
        public void ChangeP()
        {
            Console.WriteLine("Input the power: ");
            r =Convert.ToInt32(Console.ReadLine ());
        }
        public void ChangeS()
        {
            Console.WriteLine("Input the sensitivity: ");
            i = Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            PhotoStudio[] foto = { new PhotoStudio(1200, 3, 200), new PhotoStudio(1600, 1, 1600) };
            foreach (PhotoStudio p in foto)
            {
                p.Printl();
                p.Printc();
                Console.WriteLine("If want change power print p:");
                if (Console.ReadLine() == "p")
                {
                    p.ChangeP();
                    p.Printl();
                }
                Console.WriteLine("If want change sensitivity print s:");
                if (Console.ReadLine() == "s")
                {
                    p.ChangeS();
                    p.Printc();
                }
            }
        }
    }
}
