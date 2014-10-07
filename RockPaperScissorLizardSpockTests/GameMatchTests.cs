using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissorLizardSpock;
using NUnit.Framework;
namespace RockPaperScissorLizardSpock.Tests
{
    [TestFixture]
    public class GameMatchTests
    {
        [Test]
        public void Scissor_Cuts_Paper()
        {
            var gameMatch = new GameMatch();
            string item = gameMatch.Decide(Scissor.GetInstance(), Paper.GetInstance());
            Assert.AreEqual("Scissor", item);
        }

        [Test]
        public void Paper_Covers_Rock()
        {
            var gameMatch = new GameMatch();
            string item = gameMatch.Decide(Paper.GetInstance(), Rock.GetInstance());
            Assert.AreEqual("Paper", item);
        }

        [Test]
        public void Paper_IsCut_Scissor()
        {
            var gameMatch = new GameMatch();
            string item = gameMatch.Decide(Paper.GetInstance(), Scissor.GetInstance());
            Assert.AreEqual("Scissor", item);
        }

        [Test]
        public void Rock_IsCovered_By_Paper()
        {
            var gameMatch = new GameMatch();
            string item = gameMatch.Decide(Rock.GetInstance(), Paper.GetInstance());
            Assert.AreEqual("Paper", item);
        }

        [Test]
        public void Rock_Crushes_Lizard()
        {
            var gameMatch = new GameMatch();
            string item = gameMatch.Decide(Rock.GetInstance(), Lizard.GetInstance());
            Assert.AreEqual("Rock", item);
        }

        [Test]
        public void Lizard_IsCrushed_By_Rock()
        {
            var gameMatch = new GameMatch();
            string item = gameMatch.Decide(Lizard.GetInstance(), Rock.GetInstance());
            Assert.AreEqual("Rock", item);
        }

        [Test]
        public void Lizard_Poisons_Spock()
        {
            var gameMatch = new GameMatch();
            string item = gameMatch.Decide(Lizard.GetInstance(), Spock.GetInstance());
            Assert.AreEqual("Lizard", item);
        }

        [Test]
        public void Spock_IsPoisoned_ByLizard()
        {
            var gameMatch = new GameMatch();
            string item = gameMatch.Decide(Spock.GetInstance(), Lizard.GetInstance());
            Assert.AreEqual("Lizard", item);
        }

        [Test]
        public void Lizard_Draws_Lizard()
        {
            var gameMatch = new GameMatch();
            string item = gameMatch.Decide(Lizard.GetInstance(), Lizard.GetInstance());
            Assert.AreEqual("Draw", item);
        }

        [Test]
        public void Rock_Draws_Rock()
        {
            var gameMatch = new GameMatch();
            string item = gameMatch.Decide(Rock.GetInstance(), Rock.GetInstance());
            Assert.AreEqual("Draw", item);
        }

        [Test]
        public void Paper_Draws_Paper()
        {
            var gameMatch = new GameMatch();
            string item = gameMatch.Decide(Paper.GetInstance(), Paper.GetInstance());
            Assert.AreEqual("Draw", item);
        }

        [Test]
        public void Spock_Draws_Spock()
        {
            var gameMatch = new GameMatch();
            string item = gameMatch.Decide(Spock.GetInstance(), Spock.GetInstance());
            Assert.AreEqual("Draw", item);
        }

        [Test]
        public void Scissor_Draws_Scissor()
        {
            var gameMatch = new GameMatch();
            string item = gameMatch.Decide(Scissor.GetInstance(), Scissor.GetInstance());
            Assert.AreEqual("Draw", item);
        }

        [Test]
        public void Spock_Smashes_Scissor()
        {
            var gameMatch = new GameMatch();
            string item = gameMatch.Decide(Spock.GetInstance(), Scissor.GetInstance());
            Assert.AreEqual("Spock", item);
        }

        [Test]
        public void Scissor_IsSmashed_BySpock()
        {
            var gameMatch = new GameMatch();
            string item = gameMatch.Decide(Scissor.GetInstance(), Spock.GetInstance());
            Assert.AreEqual("Spock", item);
        }

        [Test]
        public void Scissor_Decapitate_Lizard()
        {
            var gameMatch = new GameMatch();
            string item = gameMatch.Decide(Scissor.GetInstance(), Lizard.GetInstance());
            Assert.AreEqual("Scissor", item);
        }

        [Test]
        public void Lizard_IsDecapitated_ByScissor()
        {
            var gameMatch = new GameMatch();
            string item = gameMatch.Decide(Lizard.GetInstance(), Scissor.GetInstance());
            Assert.AreEqual("Scissor", item);
        }

        [Test]
        public void Lizard_Eats_Paper()
        {
            var gameMatch = new GameMatch();
            string item = gameMatch.Decide(Lizard.GetInstance(), Paper.GetInstance());
            Assert.AreEqual("Lizard", item);
        }

        [Test]
        public void Paper_IsEaten_ByLizard()
        {
            var gameMatch = new GameMatch();
            string item = gameMatch.Decide(Paper.GetInstance(), Lizard.GetInstance());
            Assert.AreEqual("Lizard", item);
        }

        [Test]
        public void Paper_Disproves_Spock()
        {
            var gameMatch = new GameMatch();
            string item = gameMatch.Decide(Paper.GetInstance(), Spock.GetInstance());
            Assert.AreEqual("Paper", item);
        }

        [Test]
        public void Spock_IsDisaproved_ByPaper()
        {
            var gameMatch = new GameMatch();
            string item = gameMatch.Decide(Spock.GetInstance(), Paper.GetInstance());
            Assert.AreEqual("Paper", item);
        }

        [Test]
        public void Spock_Vaporizes_Rock()
        {
            var gameMatch = new GameMatch();
            string item = gameMatch.Decide(Spock.GetInstance(), Rock.GetInstance());
            Assert.AreEqual("Spock", item);
        }

        [Test]
        public void Rock_IsVaporized_BySpock()
        {
            var gameMatch = new GameMatch();
            string item = gameMatch.Decide(Rock.GetInstance(), Spock.GetInstance());
            Assert.AreEqual("Spock", item);
        }

        [Test]
        public void Rock_Crushes_Scissors()
        {
            var gameMatch = new GameMatch();
            string item = gameMatch.Decide(Rock.GetInstance(), Scissor.GetInstance());
            Assert.AreEqual("Rock", item);
        }

        [Test]
        public void Scissors_IsCrushed_ByRock()
        {
            var gameMatch = new GameMatch();
            string item = gameMatch.Decide(Scissor.GetInstance(), Rock.GetInstance());
            Assert.AreEqual("Rock", item);
        }
    }
}
