using Microsoft.VisualStudio.TestTools.UnitTesting;
using GarageApp;

namespace GarageApp.Tests
{
        /// <summary>
        /// Unit tests for the Garage class.
        /// These tests cover expected behaviour of a new garage
        /// and adding a vehicle.
        /// </summary>
        [TestClass] 
        public class GarageTests
        {
            /// <summary>
            /// Verify that a newly created Garage has zero vehicles inside.
            /// This ensures the initial state is correct.
            /// </summary>
            [TestMethod] 
            public void Garage_ShouldStartEmpty()
            {
                // Create a new garage
                var g = new Garage();

                //should contain 0 vehicles
                Assert.AreEqual(0, g.Vehicles.Count, "Start with 0.");
            }

            /// <summary>
            /// Verify that adding a car increases the vehicle count to 1.
            /// This ensures that AddVehicle works correctly for a single item.
            /// </summary>
            [TestMethod]
            public void AddVehicle_ShouldIncreaseCount()
            {
                // Create a new garage
                var g = new Garage();

                //Add one car to the garage
                g.AddVehicle(new Car("Hyundai", "i30", 5));

                // should now be 1
                Assert.AreEqual(1, g.Vehicles.Count, "Increase to 1.");
            }
        }
    }
