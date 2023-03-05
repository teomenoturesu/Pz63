using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz63
{
    public enum TaskImportance
    {
        Важное,
        Подождет,
        Обычное,
        Срочное
    }
    public enum TaskStatus
    {
        Выполнено,
        Отменено,
        Невыполнено
    }

    internal class Task
    {
        private string title;
        private string date;
        private TaskImportance importance;
        private TaskStatus status;
        public string Title { get => title; }
        public string Date { get => date; }
        public TaskImportance Importance { get => importance; }
        public TaskStatus Status { get => status; }
        public Task(string title, string date, TaskImportance importance, TaskStatus status)
        {
            this.title = title;
            this.date = date;
            this.importance = importance;
            this.status = status;
        }
    }
}
