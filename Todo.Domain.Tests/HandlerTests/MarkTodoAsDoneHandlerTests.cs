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
    public class MarkTodoAsDoneHandlerTests
    {
        private MarkTodoAsDoneCommand _comandInvalid = new MarkTodoAsDoneCommand(new Guid(), "");
        private MarkTodoAsDoneCommand _comandValid = new MarkTodoAsDoneCommand(Guid.NewGuid(), "victor");
        private TodoHandler _handler = new TodoHandler(new FakeTodoRepository());


        [TestMethod]
        public void Marcar_como_feito_invalido()
        {
           

            var result = (GenericCommandResult)_handler.Handle(_comandInvalid);


            Assert.AreEqual(result.Success, false);
        }

        [TestMethod]
        public void Marcar_como_feito_valido()
        {


            var result = (GenericCommandResult)_handler.Handle(_comandValid);


            Assert.AreEqual(result.Success, true);
        }
    }
}
