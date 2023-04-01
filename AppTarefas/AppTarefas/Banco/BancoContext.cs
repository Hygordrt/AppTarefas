using AppTarefas.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppTarefas.Banco
{
    public class BancoContext : DbContext
    {
        public DbSet<Tarefa> Tarefas { get; set; }

        public BancoContext()
        {
            
            //Garantido que o banco seja criado
            Database.EnsureCreated();
        }
        //Chamada para a conexão com o banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={Constantes.CaminhoDoBanco}");
        }
    }
}
//Foi instalado o pacote SQlite 3.1.4