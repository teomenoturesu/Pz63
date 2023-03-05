using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz63
{
        
    internal class TaskDatabase
    {
        internal List<Task> Tasks { get; set; }
        public void Initialize()
        {
            Tasks = new List<Task>()
            {
                new Task("Срочно что-то там сделать", "12.01.2023", TaskImportance.Срочное, TaskStatus.Отменено),
                new Task("Неважно", "01.08.2023", TaskImportance.Подождет, TaskStatus.Невыполнено),
                new Task("task3", "23.11.2023", TaskImportance.Важное, TaskStatus.Невыполнено),
                new Task("Task tri", "11.02.2023", TaskImportance.Обычное, TaskStatus.Выполнено),
                new Task("Какая-то задача", "13.01.2023", TaskImportance.Подождет, TaskStatus.Выполнено),
                new Task("Таска два", "26.03.2023", TaskImportance.Обычное, TaskStatus.Отменено),
                new Task("######", "04.12.2023", TaskImportance.Важное, TaskStatus.Невыполнено),
                new Task("Eighteenth task", "15.01.2023", TaskImportance.Обычное, TaskStatus.Выполнено),
                new Task("Что-то там сделать", "06.02.2023", TaskImportance.Обычное, TaskStatus.Выполнено),
                new Task("This is unpromising", "29.02.2023", TaskImportance.Подождет, TaskStatus.Отменено),
                new Task("Что-то very urgent neotlozhnoe delo", "30.02.2023", TaskImportance.Срочное, TaskStatus.Невыполнено),
                new Task("Таска для массовки", "93.13.2023", TaskImportance.Обычное, TaskStatus.Выполнено)
            };
        }
    }
}
