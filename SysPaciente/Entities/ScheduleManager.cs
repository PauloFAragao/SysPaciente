﻿using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SysPaciente.Entities
{
    public static class ScheduleManager
    {
        // proximos 7 dias
        private static List<Schedules> schedules = new List<Schedules>();

        // objeto com as configurações 
        private static Settings settings;

        static ScheduleManager()
        {
            // criar os mebros da lista
            // ler do banco de dados os dias trabalhados e os horarios
            settings = Data.GetSettings();

            // dia da semana
            DayOfWeek day = DateTime.Now.DayOfWeek;

            // data
            DateTime date = DateTime.Now;

            // 7 dias a frente do dia de hj
            int i = 0, index = 0;

            while (index < 7)
            {
                //Debug.Write("Dia: " + day + " Data " + date);
                if (settings.WorkingDay(day)) // se o dia é trabalhado
                {
                    schedules.Add(new Schedules(settings.StartOfWorkOnDayOfWeek(day),
                        settings.EndOfWorkOnDayOfWeek(day), settings.StartOfBreakDayOfWeek(day),
                        settings.EndOfBreakDayOfWeek(day), settings.standardConsultationTime, date));
                    index++;
                }
                else
                {
                    //Debug.WriteLine(" Dia não trabalhado");
                }

                date = date.AddDays(1);
                day = date.DayOfWeek;

                i++;
            }
        }

        // retorna o proximo horario disponivel para consultas
        public static DateTime? GetFreeSchedule()
        {
            foreach (Schedules s in schedules)
            {
                if (TimeSpan.TryParse(s.GetFreeSchedule().ToString(), out TimeSpan value))
                {
                    return new DateTime(s.Date.Year, s.Date.Month, s.Date.Day, value.Hours, value.Minutes, value.Seconds);
                }
            }

            return null;
        }

        // retorna o objeto dos horarios do dia
        internal static Schedules GetSchedules(DateTime date)
        {
            foreach(Schedules s in schedules)
            {
                if (s.Date.Date == date.Date)
                {
                    return s;
                }
            }

            return null;
        }
    }
}