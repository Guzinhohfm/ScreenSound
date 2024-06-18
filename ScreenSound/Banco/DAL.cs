using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ScreenSound.Modelos;


namespace ScreenSound.Banco;

internal class DAL<T> where T : class
{
    protected readonly ScreenSoundContext _context;

    public DAL(ScreenSoundContext context)
    {
        _context = context;
    }

    public IEnumerable<T> Get() 
    {
        return _context.Set<T>().ToList();
    }

    public void Add(T objeto)
    {

        _context.Set<T>().Add(objeto);
        _context.SaveChanges();

    }

    public void Update(T objeto)
    {
        _context.Set<T>().Update(objeto);
        _context.SaveChanges();
    }

    public void Delete(T objeto)
    {
        _context.Set<T>().Remove(objeto);
        _context.SaveChanges();
    }

    public T GetPor(Func<T, bool> condicao)
    {
        return _context.Set<T>().FirstOrDefault(condicao); //irá trazer o primeiro retorno que atende a condição
    }
}
