﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Todo.Domain.Entities;

namespace Todo.Domain.Tests.EntityTests
{
    [TestClass]
    public class TodoItemTests
    {

            private readonly TodoItem _todoValid = new TodoItem("Titulo Aqui", "Victor", DateTime.Now);

        [TestMethod]
        public void Dado_um_novo_todo_o_mesmo_nao_pode_ser_concluido()
        {

            Assert.AreEqual(_todoValid.Done, false);
        }
    }
}
