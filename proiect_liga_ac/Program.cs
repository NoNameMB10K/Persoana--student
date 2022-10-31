internal class Program
{
    private static void Main(string[] args)
    {
        Student stud1 = new Student("Simion", "Alex", 19, 8.57, "AC");
        stud1.afiseaza_media();
        stud1.schimba_media(9.99);
        stud1.afiseaza_media();
    }
    
    class Persoana
    {
        public string nume;
        public string prenume;
        public int varsta;
    }

    class Student : Persoana
    {
        double medie_generala;
        string facultate;

        public Student(string nume, string prenume, int varsta, double medie_generala, string facultate)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.varsta = varsta;
            this.medie_generala = medie_generala;
            this.facultate = facultate;
        }

        public void schimba_media(double media_noua)
        {
            this.medie_generala = media_noua;
        }

        public void afiseaza_media()
        {
            Console.WriteLine(this.medie_generala);
        }
    }
}