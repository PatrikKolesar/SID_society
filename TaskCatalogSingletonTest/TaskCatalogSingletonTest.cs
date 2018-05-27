
using System;
using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SID_Project.Model;

namespace TaskCatalogSingletonTest
{
    [TestClass]
    public class TaskCatalogSingletonTest
    {
        [TestMethod]
        public void LoadDataToObservableCollection_ReturnsObservableCollection_IsTrue()
        {
            //Arrange
            var collection = new TaskCatalogSingleton();
            //Art
            var result = collection.LoadDataToObservableCollection();
            //Assets
            Assert.IsNotNull(result);
        }
    }
}
