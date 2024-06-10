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
        public IEnumerable<Artista> GetArtistas()
        {

            using var context = new ScreenSoundContext();

            return context.Artistas.ToList();

        }

        //public void AddArtista(Artista artista)
        //{
        //    using var connection = new ScreenSoundContext().ObterConexao();
        //    connection.Open();

        //    string sqlInsert = "INSERT INTO Artistas (Nome, FotoPerfil, Bio) VALUES (@nome, @perfilPadrao, @bio)";

        //    SqlCommand command = new SqlCommand(sqlInsert, connection);

        //    command.Parameters.AddWithValue("@nome", artista.Nome);
        //    command.Parameters.AddWithValue("@perfilPadrao", artista.FotoPerfil);
        //    command.Parameters.AddWithValue("@bio", artista.Bio);

        //    int retorno = command.ExecuteNonQuery(); //retorna a qtd de linhas afetadas
        //    Console.WriteLine($"Linhas afetadas: {retorno}");
        //}

        //public void DeleteArtista(int id)
        //{
        //    using var connection = new ScreenSoundContext().ObterConexao();
        //    connection.Open();

        //    string sqlDelete = "DELETE FROM Artistas WHERE Id ="+id;

        //    SqlCommand command = new SqlCommand( sqlDelete, connection);

        //    int retorno = command.ExecuteNonQuery(); //retorna a qtd de linhas afetadas
        //    Console.WriteLine($"Linhas afetadas: {retorno}");

        //}

        //public void UpdateArtista(Artista artista)
        //{
        //    using var connection = new ScreenSoundContext().ObterConexao();
        //    connection.Open();

        //    string sqlUpdate = $"UPDATE Artistas SET Nome = @nome, Bio = @bio WHERE Id = @id";

        //    SqlCommand command = new SqlCommand(sqlUpdate, connection);

        //    command.Parameters.AddWithValue("@nome", artista.Nome);
        //    command.Parameters.AddWithValue("@bio", artista.Bio);
        //    command.Parameters.AddWithValue("@id", artista.Id);


        //    int retorno = command.ExecuteNonQuery(); //retorna a qtd de linhas afetadas
        //    Console.WriteLine($"Linhas afetadas: {retorno}");
        //}
    }
}
