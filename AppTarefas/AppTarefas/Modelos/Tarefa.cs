﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AppTarefas.Modelos
{
    public class Tarefa
    {
        public int Id { get; set; }

        public DateTime? Data { get; set; }

        public TimeSpan HorarioInicial { get; set; }

        public TimeSpan HorarioFinal { get; set; }

        public string Nome { get; set; }

        public string Nota { get; set; }

        public string Finalizada { get; set; }
    }
}
