using Bilioteca.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilioteca.Model.Repositories
{
    public class RepositoryAutor : RepositoryBase<RepositoryAutor>
    {
        public RepositoryAutor(bool saveChanges= true) : base(saveChanges) 
        {

        }

        public async Task IncluirAsync(Nome Nome, Nacionalidade Nacionalidade, Livros)
        {
            _context.Entry(cliente).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            await _context.SaveChangesAsync();

            endereco.EndCodigoCliente = cliente.CliCodigo;
            _context.Entry(endereco).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            await _context.SaveChangesAsync();
        }
    }
