using System;
using System.Diagnostics;

namespace SysPaciente.Entities
{
    internal class Settings
    {
        // dias trabalhados
        public bool workOnMondays;
        public bool workOnTuesdays;
        public bool workOnWednesdays;
        public bool workOnThursdays;
        public bool workOnFridays;
        public bool workOnSaturdays;
        public bool workOnSundays;

        // horarios de trabalho 
        public TimeSpan? startOfWorkOnMondays;// segunda
        public TimeSpan? endOfWorkOnMondays;

        public TimeSpan? startOfWorkOnTuesdays;// terça
        public TimeSpan? endOfWorkOnTuesdays;

        public TimeSpan? startOfWorkOnWednesdays;// quarta
        public TimeSpan? endOfWorkOnWednesdays;

        public TimeSpan? startOfWorkOnThursdays;// quinta
        public TimeSpan? endOfWorkOnThursdays;

        public TimeSpan? startOfWorkOnFridays;// sexta
        public TimeSpan? endOfWorkOnFridays;

        public TimeSpan? startOfWorkOnSaturdays;// sabádo
        public TimeSpan? endOfWorkOnSaturdays;

        public TimeSpan? startOfWorkOnSundays;// domingo
        public TimeSpan? endOfWorkOnSundays;

        // horario de almoço
        public TimeSpan? startOfBreakOnMondays;// segunda
        public TimeSpan? endOfBreakOnMondays;

        public TimeSpan? startOfBreakOnTuesdays;// terça
        public TimeSpan? endOfBreakOnTuesdays;

        public TimeSpan? startOfBreakOnWednesdays;// quarta
        public TimeSpan? endOfBreakOnWednesdays;

        public TimeSpan? startOfBreakOnThursdays;// quinta
        public TimeSpan? endOfBreakOnThursdays;

        public TimeSpan? startOfBreakOnFridays;// sexta
        public TimeSpan? endOfBreakOnFridays;

        public TimeSpan? startOfBreakOnSaturdays;// sabado
        public TimeSpan? endOfBreakOnSaturdays;

        public TimeSpan? startOfBreakOnSundays;// domindo
        public TimeSpan? endOfBreakOnSundays;

        //tempo padrão das consultas
        public int standardConsultationTime;

        public bool WorkingDay(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            { 
                case DayOfWeek.Monday:
                    return workOnMondays;
                
                case DayOfWeek.Tuesday:
                    return workOnTuesdays;

                case DayOfWeek.Wednesday:
                    return workOnWednesdays;

                case DayOfWeek.Thursday:
                    return workOnThursdays;

                case DayOfWeek.Friday:
                    return workOnFridays;

                case DayOfWeek.Saturday:
                    return workOnSaturdays;

                case DayOfWeek.Sunday:
                    return workOnSundays;

                default:
                    return false;
            }
        }

        public TimeSpan? StartOfWorkOnDayOfWeek(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Monday:
                    return startOfWorkOnMondays;

                case DayOfWeek.Tuesday:
                    return startOfWorkOnTuesdays;

                case DayOfWeek.Wednesday:
                    return startOfWorkOnWednesdays;

                case DayOfWeek.Thursday:
                    return startOfWorkOnThursdays;

                case DayOfWeek.Friday:
                    return startOfWorkOnFridays;

                case DayOfWeek.Saturday:
                    return startOfWorkOnSaturdays;

                case DayOfWeek.Sunday:
                    return startOfWorkOnSundays;

                default:
                    return null;
            }
        }

        public TimeSpan? EndOfWorkOnDayOfWeek(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Monday:
                    return endOfWorkOnMondays;

                case DayOfWeek.Tuesday:
                    return endOfWorkOnTuesdays;

                case DayOfWeek.Wednesday:
                    return endOfWorkOnWednesdays;

                case DayOfWeek.Thursday:
                    return endOfWorkOnThursdays;

                case DayOfWeek.Friday:
                    return endOfWorkOnFridays;

                case DayOfWeek.Saturday:
                    return endOfWorkOnSaturdays;

                case DayOfWeek.Sunday:
                    return endOfWorkOnSundays;

                default:
                    return null;
            }
        }

        public TimeSpan? StartOfBreakDayOfWeek(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Monday:
                    return startOfBreakOnMondays;

                case DayOfWeek.Tuesday:
                    return startOfBreakOnTuesdays;

                case DayOfWeek.Wednesday:
                    return startOfBreakOnWednesdays;

                case DayOfWeek.Thursday:
                    return startOfBreakOnThursdays;

                case DayOfWeek.Friday:
                    return startOfBreakOnFridays;

                case DayOfWeek.Saturday:
                    return startOfBreakOnSaturdays;

                case DayOfWeek.Sunday:
                    return startOfBreakOnSundays;

                default:
                    return null;
            }
        }

        public TimeSpan? EndOfBreakDayOfWeek(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Monday:
                    return endOfBreakOnMondays;

                case DayOfWeek.Tuesday:
                    return endOfBreakOnTuesdays;

                case DayOfWeek.Wednesday:
                    return endOfBreakOnWednesdays;

                case DayOfWeek.Thursday:
                    return endOfBreakOnThursdays;

                case DayOfWeek.Friday:
                    return endOfBreakOnFridays;

                case DayOfWeek.Saturday:
                    return endOfBreakOnSaturdays;

                case DayOfWeek.Sunday:
                    return endOfBreakOnSundays;

                default:
                    return null;
            }
        }

        public void PrintDaysWorked()
        {
            Debug.WriteLine("workOnMondays: " + workOnMondays);
            Debug.WriteLine("workOnTuesdays: " + workOnTuesdays);
            Debug.WriteLine("workOnWednesdays: " + workOnWednesdays);
            Debug.WriteLine("workOnThursdays: " + workOnThursdays);
            Debug.WriteLine("workOnFridays: " + workOnFridays);
            Debug.WriteLine("workOnSaturdays: " + workOnSaturdays);
            Debug.WriteLine("workOnSundays: " + workOnSundays);
        }

        public void PrintWorkingHours()
        {
            Debug.WriteLine("startOfWorkOnMondays: " + startOfWorkOnMondays);
            Debug.WriteLine("endOfWorkOnMondays: " + endOfWorkOnMondays);

            Debug.WriteLine("startOfWorkOnTuesdays: " + startOfWorkOnTuesdays);
            Debug.WriteLine("endOfWorkOnTuesdays: " + endOfWorkOnTuesdays);

            Debug.WriteLine("startOfWorkOnWednesdays: " + startOfWorkOnWednesdays);
            Debug.WriteLine("endOfWorkOnWednesdays: " + endOfWorkOnWednesdays);

            Debug.WriteLine("startOfWorkOnThursdays: " + startOfWorkOnThursdays);
            Debug.WriteLine("endOfWorkOnThursdays: " + endOfWorkOnThursdays);

            Debug.WriteLine("startOfWorkOnFridays: " + startOfWorkOnFridays);
            Debug.WriteLine("endOfWorkOnFridays: " + endOfWorkOnFridays);

            Debug.WriteLine("startOfWorkOnSaturdays: " + startOfWorkOnSaturdays);
            Debug.WriteLine("endOfWorkOnSaturdays: " + endOfWorkOnSaturdays);

            Debug.WriteLine("startOfWorkOnSundays: " + startOfWorkOnSundays);
            Debug.WriteLine("endOfWorkOnSundays: " + endOfWorkOnSundays);
        }

        public void PrintLunchHours()
        {
            Debug.WriteLine("startOfBreakOnMondays: " + startOfBreakOnMondays);
            Debug.WriteLine("endOfBreakOnMondays: " + endOfBreakOnMondays);

            Debug.WriteLine("startOfBreakOnTuesdays: " + startOfBreakOnTuesdays);
            Debug.WriteLine("endOfBreakOnTuesdays: " + endOfBreakOnTuesdays);

            Debug.WriteLine("startOfBreakOnWednesdays: " + startOfBreakOnWednesdays);
            Debug.WriteLine("endOfBreakOnWednesdays: " + endOfBreakOnWednesdays);

            Debug.WriteLine("startOfBreakOnThursdays: " + startOfBreakOnThursdays);
            Debug.WriteLine("endOfBreakOnThursdays: " + endOfBreakOnThursdays);

            Debug.WriteLine("startOfBreakOnFridays: " + startOfBreakOnFridays);
            Debug.WriteLine("endOfBreakOnFridays: " + endOfBreakOnFridays);

            Debug.WriteLine("startOfBreakOnSaturdays: " + startOfBreakOnSaturdays);
            Debug.WriteLine("endOfBreakOnSaturdays: " + endOfBreakOnSaturdays);

            Debug.WriteLine("startOfBreakOnSundays: " + startOfBreakOnSundays);
            Debug.WriteLine("endOfBreakOnSundays: " + endOfBreakOnSundays);
        }

        public void PrintStandardConsultationTime()
        {
            Debug.WriteLine("standardConsultationTime: " + standardConsultationTime);
        }
    
    
    }
}
