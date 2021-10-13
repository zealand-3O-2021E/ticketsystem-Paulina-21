using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text.Json;
using System.Threading.Tasks;
using Book_Library;

namespace Book_Server
{
    class Program
    {
        public static List<Book> ListOfBooks = new List<Book>();
        static void Main(string[] args)
        {
            Console.WriteLine("Server Started");

            TcpListener listener = new TcpListener(System.Net.IPAddress.Loopback, 4646);
            listener.Start();

            //while loop keeps the socket running continuously 
            while (true)
            {
                //Accepts clients 
                TcpClient socket = listener.AcceptTcpClient();

                //Creates threads to run "HandleClient" method for each client
                Task.Run(() => { HandleClient(socket); });
            }

        }

        public static void HandleClient(TcpClient socket)
        {
            NetworkStream ns = socket.GetStream();
            StreamReader reader = new StreamReader(ns);
            StreamWriter writer = new StreamWriter(ns);

            string message1= reader.ReadLine();

            Console.WriteLine("Client wrote:" + message1);

            writer.WriteLine(message1);

            if (message1 == "GetAll")
            {
                writer.WriteLine(GetAll());
            }

            if (message1 == "Get")
            {
                Console.WriteLine("Getting message2");
                string message2 = reader.ReadLine();
                writer.WriteLine(Get(message2));
            }

            if (message1 == "Save")
            {
                Console.WriteLine("Getting message2");
                string message2 = reader.ReadLine();
                Save(message2);

            }
            writer.Flush();
            socket.Close();

        }

        public static string GetAll()
        {
            var results = ListOfBooks;
            string serializedBooks = JsonSerializer.Serialize(results);

            return serializedBooks;
        }


        public static string Get(string isbn13)
        {
            Book  book = ListOfBooks.Find(b => b.ISBN13.Equals(isbn13));
            string serializedBook = JsonSerializer.Serialize(book);

            return serializedBook;
        }


        public static void Save(string message)
        {
            Book book = JsonSerializer.Deserialize<Book>(message);
            ListOfBooks.Add(book);
        }


        //{"Title": "UML", "Author": "Larman", "PageNo": 654, "ISBN13": "9780133594140"}
        //{"Title": "Twilight", "Author": "Stephenie Meyer", "numberOfPages": 501, "ISBN13": "9780316015844"}
        //{"Title": "To Kill a Mockingbird", "Author": "Harper Lee", "numberOfPages": 324, "ISBN13": "9780446310789"}
        //{"Title": "Dune", "Author": "Frank Herbert", "numberOfPages": 688, "ISBN13": "9780593099322"}

    }
}
