namespace Ejercicios_Clases_Udemy_18_12
{
    public class ExerciseSolutions
    {

        public static void Exercise1()
        {
            Console.WriteLine("Digite \"Start\" para arrancar el cronómetro, \"Stop\" para detenerlo y \"Exit\" para salir.");
            var userInput = Console.ReadLine();
            var stopwatch = new Stopwatch();
            var isStarted = false;
            var isRunning = false;

            while (userInput?.ToLower() != "exit")
            {
                if (userInput?.ToLower() == "start")
                {
                    if (isRunning)
                    {
                        throw new InvalidOperationException("No se pueden inicializar 2 cronómetros al mismo tiempo.");
                    }
                    else
                    {
                        stopwatch.Start();
                        isStarted = true;
                        isRunning = true;
                        Console.WriteLine("Ahora escriba \"Stop\" para detenerlo. ");
                        userInput = Console.ReadLine();
                    }

                }
                else if (userInput?.ToLower() == "stop")
                {
                    if (isStarted)
                    {
                        stopwatch.Stop();
                        Console.WriteLine("La duración fue de: " + stopwatch.GetDuration());
                        isRunning = false;
                        isStarted = false;

                    }
                    else
                    {
                        Console.WriteLine("Si desea iniciar otro cálculo, escriba \"Start\" o \"Exit\" para salir.");
                        userInput = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Opción no válida.");
                    userInput = Console.ReadLine();
                }


            }
        }

        public static void Exercise2()
        {
            var post = new Post();
            Console.WriteLine("Inserte el título de su post: ");
            var userPostTitle = Console.ReadLine();
            post.Title = userPostTitle;
            Console.WriteLine("Inserte la descripción de su post: ");
            var userPostDescription = Console.ReadLine();
            post.Description = userPostDescription;
            post.DateTime = DateTime.Now;
            var userOption = "";

            while (userOption.ToLower() != "exit")
            {
                post.ViewPost();
                Console.WriteLine("\nDigite \"up\" para votar positivamente, \"down\" para votar negativamente, o exit para salir. ");
                userOption = Console.ReadLine();

                if (userOption?.ToLower() == "up")
                {
                    post.UpVote();
                    continue;
                }
                else if (userOption?.ToLower() == "down")
                {
                    post.DownVote();
                    continue;
                }
                break;
            }
        }

    }
}
