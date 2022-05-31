using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Text;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    public class MarkTodoAsUndoneCommand : Notifiable, ICommand
    {
        // Construtor
        public MarkTodoAsUndoneCommand() { }
        public MarkTodoAsUndoneCommand(Guid id, string user)
        {
            Id = id;
            User = user;
        }

        // Entidade
        public Guid Id { get; set; }
        public string User { get; set; }

        // Metodo
        public void Validate() => AddNotifications(new Contract().Requires().HasMinLen(User, 6, "User", "Usuário inválido!"));
    }
}
