﻿using Flunt.Notifications;
using Flunt.Validations;
using System;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    public class UpdateTodoCommand : Notifiable, ICommand
    { 
        // Construtor
        public UpdateTodoCommand() { }
        public UpdateTodoCommand(Guid id, string title, string user)
        {
            Id = id;
            Title = title;
            User = user;
            
        }

        // Entidade
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string User  { get; set; }

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
