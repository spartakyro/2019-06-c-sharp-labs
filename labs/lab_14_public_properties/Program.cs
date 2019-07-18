using System;

namespace lab_14_public_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var bob = new person();
            bob.Name = "bob";
            bob.setNINO("ABC123","");
            bob.SetAge(23, 22);

            
        }
    }

    class person
    {
        private string NINO; 
        private string password;
       

        public string Name {get; set;}


        private int age { get; set; }

        private int NinoAge;
        private int NinoHeight;

        // getter/setter

        public void setNINO(string newNINO,String password)
        {
            if(this.password == password)
            {
                this.NINO = newNINO;
            }

        }

        public void SetAge (int age, int height)
        {
            if(this.NinoAge == height)
            {
                this.NinoAge = age;
            }
        }
    }
}
