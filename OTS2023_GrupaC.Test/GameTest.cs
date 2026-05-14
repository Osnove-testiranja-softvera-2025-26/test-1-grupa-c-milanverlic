using NUnit.Framework;
using OTS2026_GrupaC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace OTS2026_GrupaC.Test
{
    [TestFixture]
    internal class GameTest
    {
        private Game game;

        [SetUp]
        public void SetUp(Game game)
        {
            game = new Game(new Location(1, 1, 1), new Location(3, 3, 3));
        }

        [Test]

        public void LocationOutsideOfBounds()
        {
            Exception ex = Assert.Throws<Exceptions.LocationOutsideOfMapException>((TestDelegate)(() => new Game(new Location(), null)));
            Assert.That(ex.Message, Is.EqualTo("Locations must be valid"));
        }

        [Test]
        public void LocationOutsideOfBounds1()
        {
            Exception ex = Assert.Throws<Exceptions.LocationOutsideOfMapException>((TestDelegate)(() => new Game(null, new Location())));
            Assert.That(ex.Message, Is.EqualTo("Locations must be valid"));
        }

        public object GetGame1()
        {
            return game;
        }

        [TestCase(31,1,1)]
        [TestCase(-1,1,1)]

        public void MoveUp(int x, int y)
        {

        }
    }
}
