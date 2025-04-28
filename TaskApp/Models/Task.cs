using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskApp.Models
{
    public enum Prioritylevel
    {
        Niski,
        Średni,
        Wysoki
    }
    public class Task
    {
        //prywatne pola
        private string _title;
        private string _description;
        private DateTime _dueTime;
        private bool _isCompleted;
        private Prioritylevel priority;

        //Właściwości z walidacją
        public string Title
        {
            get { return _title; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Tytuł zadania nie może byc pusty");
                }
                _title = value;
            }

        }

        public string Description
        {
            get { return _description; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Opis zadania nie może byc pusty");
                }
                _description = value;
            }
        }

        public DateTime DueTime
        {
            get { return _dueTime; }
            set
            {
                if (value < DateTime.Now)
                {
                    throw new ArgumentException("Data wykonania zadania nie może być w przeszłości");
                }
                _dueTime = value;
            }
        }

        public bool IsCompleted
        {
            get { return _isCompleted; }
            set { _isCompleted = value; }
        }

        public Prioritylevel Priority
        {
            get { return priority; }
            set
            {
                if (!Enum.IsDefined(typeof(Prioritylevel), value))
                {
                    throw new ArgumentException($"Priorytet: '{value}' nie jest dozwolony. Dozwolone priorytety: {string.Join(",", Enum.
                        GetNames(typeof(Prioritylevel)))}");
                }
            }
        }

        //Konstruktor domyślny
        public Task()
        {
            _title = "Nieokreślony tytuł";
            _description = "Brak opisu";
            _dueTime = DateTime.Now.AddDays(1);
            _isCompleted = false;
            priority = Prioritylevel.Średni;
        }

        //Konstruktor parametryczny
        public Task(string title, string description, DateTime dueTime, bool isCompleated, Prioritylevel priority)
        {
            _title = title;
            _description = description;
            _dueTime = dueTime;
            _isCompleted = isCompleated;
            Priority = priority;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Zadanie: {Title}\n Opis: {Description}\n Termin wykonania: {DueTime}\n Wykonane: {IsCompleted}\n " +
                $"Priorytet: {Priority}");
        }

    }
}
