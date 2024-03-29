﻿using System;

namespace Todo.Domain.Entities
{
    public class TodoItem : Entity
    {

        // Construtor
        public TodoItem(string title, string user, DateTime date)
        {
            Title = title;
            Done = false;
            Date = date;
            User = user;
        }

        // Entidades
        public string Title { get; private set; }
        public bool Done { get; private set; }
        public DateTime Date { get; private set; }
        public string User { get; private set; }

        //Metodos
        public void MarkAsDone() => Done = true;
        public void MarkAsUndone() => Done = false;
        public void UpdateTitle(string title) => Title = title;
    }
}
