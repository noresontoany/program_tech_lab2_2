using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WinFormsApp3.Form1;

namespace WinFormsApp3.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void answerTest1() // нет одинаковых
        {
            var message = Logic.answer(new List<int> { 1, 2, 3 });

            Assert.AreEqual("нет таких чисел", message);
        }

        [TestMethod()]
        public void answerTest2()  // есть одинаковые проверяем в конце
        {
            var message = Logic.answer(new List<int> { 1, 2, 3, 3 });
            Assert.AreEqual("номер 2 номер 3", message);
        }

        [TestMethod()]
        public void answerTest3()  // есть одинаковые в начале, несколько одианковых
        {
            var message = Logic.answer(new List<int> { 1, 1, 3, 3, 3 });
            Assert.AreEqual("номер 0 номер 1", message);
        }

        [TestMethod()]
        public void answerTest4()  // есть одинаковые в середине
        {
            var message = Logic.answer(new List<int> { 1, 3, 3, 1 });
            Assert.AreEqual("номер 1 номер 2", message);
        }

    }
}