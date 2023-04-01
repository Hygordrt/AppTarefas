using AppTarefas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTarefas.Banco
{
    public class TarefaDb
    {
        public BancoContext Banco { get; set; }

        public TarefaDb() 
        { 
            Banco= new BancoContext();
        }

        public async Task<List<Tarefa>> PesquisarAsync(DateTime data) 
        {
            Banco.Tarefas.Where( a => 
                a.Data.HasValue &&  
                a.Data.Value.Year == data.Year &&
                a.Data.Value.Month == data.Month &&
                a.Data.Value.Day == data.Day
            ).ToList();
        }
        //Cadastro
        public async Task<bool> Cadastrar(Tarefa tarefa)
        {
            Banco.Tarefas.Add(tarefa);
            int linhas = await Banco.SaveChangesAsync();
            return (linhas > 0) ? true : false;
        }

        //Atualizar tarefa
        public async Task<bool> Atualizar(Tarefa tarefa)
        {
            Banco.Tarefas.Update(tarefa);
            int linhas = await Banco.SaveChangesAsync();
            return (linhas > 0) ? true : false;
        }

        //Excluir
        public async Task<bool> Excluir(int id)
        {
            Tarefa tarefa = await Consultar(id);
            Banco.Tarefas.Remove(tarefa);
            int linhas = await Banco.SaveChangesAsync();
            return (linhas > 0) ? true : false;
        }

        //Consultar
        public async Task<Tarefa> Consultar(int id)
        {
            return await Banco.Tarefas.FindAsync(id);
        }

    }
}
