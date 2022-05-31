﻿using Flunt.Notifications;
using Flunt.Validations;
using System;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    public class CreateTodoCommand : Notifiable, ICommand
    {
        // Construtor
        public CreateTodoCommand(){ }
        public CreateTodoCommand(string title, string user, DateTime date)
        {
            Title = title;
            User = user;
            Date = date;
        }

        // Entidade
        public string Title { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }

        // Metodos
        public void Validate()
        {
           AddNotifications(
               new Contract()
               .Requires()
               .HasMinLen(Title, 3, "Title", "Por favor, descreva melhor esta tarefa!")
               .HasMinLen(User, 6, "User", "Usuário inválido!"));
        }
    }
}
