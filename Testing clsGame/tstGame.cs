using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing_clsGame
{
    [TestClass]
    public class tstGame
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class that we want to create
            clsGame AGame = new clsGame();
            //test to see if the class works or not
            Assert.IsNotNull(AGame);
        }
        [TestMethod]
        public void AgeRestrictionOKProperty()
        {
            //create an instance of the class that we want to create
            clsGame AGame = new clsGame();
            //crete some test data
            string SomeAge = "";
            //assign the data to the property
            AGame.AgeRestriction = SomeAge;
            //test to see that the two values are the same
            Assert.AreEqual(AGame.AgeRestriction, SomeAge);

        }
        [TestMethod]
        public void ConditionPropertyOK()
        {
            //create an instance of the class that we want to create
            clsGame AGame = new clsGame();
            //crete some test data
            bool SomeCondition = true;
            //assign the data to the property
            AGame.Condition = SomeCondition;
            //test to see that the two values are the same
            Assert.AreEqual(AGame.Condition, SomeCondition);

        }
        [TestMethod]
        public void GenrePropertyOK()
        {
            //create an instance of the class that we want to create
            clsGame AGame = new clsGame();
            //crete some test data
            string SomeGenre = "";
            //assign the data to the property
            AGame.Genre = SomeGenre;
            //test to see that the two values are the same
            Assert.AreEqual(AGame.Genre, SomeGenre);

        }

        [TestMethod]
        public void NamePropertyOK()
        {
            //create an instance of the class that we want to create
            clsGame AGame = new clsGame();
            //crete some test data
            string SomeName = "";
            //assign the data to the property
            AGame.Name = SomeName;
            //test to see that the two values are the same
            Assert.AreEqual(AGame.Name, SomeName);

        }

    }
}
