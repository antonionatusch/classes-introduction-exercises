namespace Ejercicios_Clases_Udemy_18_12
{
    public class Post
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime DateTime { get; set; }

        private int Votes { get; set; }

        public void DownVote()
        {
            Votes--;
        }

        public void UpVote()
        {
            Votes++;
        }

        
        public void ViewPost()
        {
            Console.WriteLine("\nTítulo: " + Title + "\n");
            Console.WriteLine("\nDescripción: " + Description + "\n");
            Console.WriteLine(DateTime.ToLongDateString() + " " + DateTime.ToLongTimeString() + "\n");
            Console.WriteLine("Cantidad de votos: " + Votes);
        }

    }
}
