using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Todo.Domain.Commands;
using Todo.Domain.Handlers;
using Todo.Domain.Tests.Repositories;

namespace Todo.Domain.Tests.HandlerTests
{
    [TestClass]
    public class CrerateTodoHandlerTests
    {
        private readonly CreateTodoCommand _commandInvalid = new CreateTodoCommand("", "", DateTime.Now);
        private readonly CreateTodoCommand _commandValid = new CreateTodoCommand("Titulo da Tarefa", "Victor", DateTime.Now);
        private readonly TodoHandler _handler = new TodoHandler(new FakeTodoRepository());
        


        [TestMethod]
        public void Dado_um_comando_invalido_deve_interromper_a_execucao()
        {
            var result = (GenericCommandResult)_handler.Handle(_commandInvalid);

            Assert.AreEqual(result.Success, false);
        }


        [TestMethod]
        public void Dado_um_comando_valido_deve_criar_a_tarefa()
        {
            var result = (GenericCommandResult)_handler.Handle(_commandValid);
            Assert.AreEqual(result.Success, true);
        }

    }
}
