using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Todo.Domain.Commands;
using Todo.Domain.Handlers;
using Todo.Domain.Tests.Repositories;

namespace Todo.Domain.Tests.HandlerTests
{
    [TestClass]
    public class UpdateTodoHandlerTests
    {
        private readonly UpdateTodoCommand _commandInvalid = new UpdateTodoCommand(new Guid(), "", "");
        private readonly UpdateTodoCommand _commandValid = new UpdateTodoCommand(Guid.NewGuid(), "Testando", "Victor");
        private TodoHandler _handler = new TodoHandler(new FakeTodoRepository());

        public UpdateTodoHandlerTests()
        {
            
        }

        [TestMethod]
        public void Dado_um_comando_invalido_deve_interromper_a_execucao()
        {
            var result = (GenericCommandResult)_handler.Handle(_commandInvalid);

            Assert.AreEqual(result.Success, false);

        }

        [TestMethod]
        public void Dado_um_comando_valido_deve_alterar_a_tarefa()
        {
           

            var result = (GenericCommandResult)_handler.Handle(_commandValid);

            Assert.AreEqual(result.Success, true);

        }

    }
}
