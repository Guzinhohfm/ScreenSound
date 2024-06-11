using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;

namespace ScreenSound.Banco
{
    internal class ArtistaDAL
    {

        private readonly ScreenSoundContext _context;

        public ArtistaDAL(ScreenSoundContext context)
        {
            _context = context;
        }

        public IEnumerable<Artista> GetArtistas()
        {

           
            return _context.Artistas.ToList();

        }

        public void AddArtista(Artista artista)
        {


            _context.Artistas.Add(artista);
            _context.SaveChanges();

          
        }


        public void UpdateArtista(Artista artista)
        {

            _context.Artistas.Update(artista);
            _context.SaveChanges();


        }

        public void DeleteArtista(Artista artista)
        {

            _context.Artistas.Remove(artista);
            _context.SaveChanges();

        }


    }
}
