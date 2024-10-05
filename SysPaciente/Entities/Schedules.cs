using System;
using System.Collections.Generic;
using System.Data;

namespace SysPaciente.Entities
{
    internal class Schedules
    {
        // data relacionada
        public DateTime Date { get; private set; }

        // lista tuplas de horarios e booleanas
        public List<Tuple<TimeSpan, bool>> Times { get; private set; }

        // horario do inicio do trabalho
        private TimeSpan? _workStartTime;

        // horario do inicio do almoço
        private TimeSpan? _breakStartTime;

        // horario do final do almoço
        private TimeSpan? _breakEndTime;

        // horario do fim do trabalho
        private TimeSpan? _workEndTime;

        // tempo médio das consultas
        private int _interval;

        public Schedules(TimeSpan? workStartTime, TimeSpan? workEndTime, TimeSpan? breakStartTime,
            TimeSpan? breakEndTime, int interval, DateTime date)
        {
            _workStartTime = workStartTime;
            _workEndTime = workEndTime;
            _breakStartTime = breakStartTime;
            _breakEndTime = breakEndTime;
            _interval = interval;
            Date = date;

            Times = new List<Tuple<TimeSpan, bool>>();

            Fill(); // enchendo a lista com os horaros disponiveis no dia

            // ler do banco de dados os horarios já oculados

            // mudar o bool das tuplas
            ChangeSchedulesWithAppointment();
        }

        // cria todos os horarios disponiveis no dia considerando as configurações de horarios de trabalho
        private void Fill()
        {
            TimeSpan index;

            //Debug.WriteLine(" workStartTime: " + _workStartTime);

            // condição em que se trabalha pela manha até o almoço
            if (_breakStartTime != null &&
                TimeSpan.TryParse(_workStartTime.ToString(), out TimeSpan workStartTime))// horario do começo do trabalho
            {
                index = workStartTime;

                //Debug.Write(" Trabalhar até hora do almoço ");
                //Debug.Write(" workStartTime: " + workStartTime);

                while (index < _breakStartTime)
                {
                    //Debug.WriteLine("h1: " + index.ToString() + " - " + _interval);
                    Tuple<TimeSpan, bool> T = Tuple.Create(index, true);// criando a tupla para o horario 

                    Times.Add(T);

                    index = index.Add(TimeSpan.FromMinutes(_interval));// somando
                }
            }

            // condição em que se trabalha pela tarde depois do almoço
            if (TimeSpan.TryParse(_breakEndTime.ToString(), out TimeSpan breakEndTime))// horario do final do almoço
            {
                index = breakEndTime;

                //Debug.Write("Trabalhar depois da hora do almoço\n");

                while (index < _workEndTime)
                {
                    //Debug.WriteLine("h2: " + index.ToString());
                    Tuple<TimeSpan, bool> T = Tuple.Create(index, true);// criando a tupla para o horario 

                    Times.Add(T);

                    index = index.Add(TimeSpan.FromMinutes(_interval));// somando
                }
            }

            // condição em que se trabalha só a uma parte do dia
            if (_breakStartTime == null &&
                TimeSpan.TryParse(_workStartTime.ToString(), out TimeSpan value))
            {
                index = value;

                //Debug.Write(" Trabalhar metade do dia\n");

                while (index < _workEndTime)
                {
                    //Debug.WriteLine("h3: " + index.ToString());
                    Tuple<TimeSpan, bool> T = Tuple.Create(index, true);// criando a tupla para o horario 

                    Times.Add(T);

                    index = index.Add(TimeSpan.FromMinutes(_interval));// somando
                }
            }
        }

        // edita as tuplas para marcar horarios como marcados
        private void ChangeSchedulesWithAppointment()
        {
            DataTable scheduledTimes = Data.TakeTheScheduledTimes(Date);// data table com as consultas
            List<int> indicesToUpdate = new List<int>();// indices dos horarios ocupados

            foreach (DataRow row in scheduledTimes.Rows)// for no DataTable para pegar os horarios
            {
                for (int index = 0; index < Times.Count; index++) // for para cada tupla
                {
                    if (Times[index].Item1 == TimeSpan.Parse(row["timeOfConsultation"].ToString()))
                    {
                        indicesToUpdate.Add(index);

                        //Debug.WriteLine("Aqui é igual: " + Date + " - " + Times[index].Item1);
                    }
                }
            }

            foreach (int index in indicesToUpdate)// alterando a lista de tuplas
            {
                Times[index] = new Tuple<TimeSpan, bool>(Times[index].Item1, false);
            }
        }

        // retorna o proximo horario disponivel
        public TimeSpan? GetFreeSchedule()
        {
            foreach (Tuple<TimeSpan, bool> t in Times)
            {
                if (Date.Date == DateTime.Now.Date)
                {
                    if (t.Item2 && t.Item1 > DateTime.Now.TimeOfDay)
                        return t.Item1;
                }
                else if (t.Item2)
                    return t.Item1;
            }

            return null;
        }
    
        public int GetCount()
        {
            return Times.Count;
        }
    }
}
