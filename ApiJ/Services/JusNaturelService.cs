using ApiJ.Models;
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace ApiJ.Services
{
    public static class JusNaturelService
    {
        static List<JusNaturel> JusNaturels { get; }
        static int nextId = 3;

        static JusNaturelService()
        {
            JusNaturels = new List<JusNaturel>
            {
                new JusNaturel {Id = 1, Name = "Mango", UrlImg="D:/Pictures/mangue1.jpg", Price = 800},

                new JusNaturel {Id = 2, Name = "Anana", UrlImg="D:/Pictures/anana0.jpg", Price = 500},

                new JusNaturel {Id = 3, Name = "Orange", UrlImg="D:/Pictures/orange.jpg", Price = 700}

            };
        }
        public static List<JusNaturel> GetAll() => JusNaturels;
        public static JusNaturel? Get(int id) => JusNaturels.FirstOrDefault(p => p.Id ==id);
        
        public static void Add(JusNaturel jusNaturel)
        {
            jusNaturel.Id = nextId++;
            JusNaturels.Add(jusNaturel);
        }

        public static void Delete(int id)
        {
            var jusNaturel = Get(id);
            if(jusNaturel is null)
                return;

            JusNaturels.Remove(jusNaturel);
            
        }

        public static void Update(JusNaturel jusNaturel)
        {
            var index = JusNaturels.FindIndex(p => p.Id == jusNaturel.Id);
            if(index < 0)
                return;

            JusNaturels[index] = jusNaturel;
        }
    }
}
