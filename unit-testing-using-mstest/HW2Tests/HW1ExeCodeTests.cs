using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW2;
using System.Collections.Generic;
using System;

namespace HW2Tests
{
    [TestClass]
    public class UnitTest1
    {
        // Remember to name test methods as so:
        // The name of the method being tested.
        // The scenario under which it's being tested.
        // The expected behavior when the scenario is invoked.

        // Expected is what you SHOULD get
        // Actual is what you are actually getting

        // I wanted to stick with the theme of making sure all the functions return the correct value



        [TestMethod]
        public void ShipIsEqualToShippingRate()  
        // Checks that the shipping rate from the instance and the shipping rate from "Ship()" are equal
        {
            // Arange 
            Book a = new Book()
            {
                Title = "Welcome to Advanced C#",
                Price = 50D,
                TaxRate = 0.0825D,
                ShippingRate = 5D
            };

            // Act
            var expected = a.ShippingRate;
            var actual = a.Ship();
            
            
            // Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void TaxIsEqualToTaxRate()
        // Checks that the tax rate from the instance and the tax rate from "Tax()" are equal
        {
            // Arange 
            Book a = new Book()
            {
                Title = "Welcome to Advanced C#",
                Price = 50D,
                TaxRate = 0.0825D,
                ShippingRate = 5D
            };

            // Act
            var expected = a.Price * a.TaxRate;
            var actual = a.Tax();
            

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void CalculateTaxIsEqualToTotalProjectTax()
        // Tests that CalculateTax(items) is calculating the total project tax correctly
        {
            // Arange
            List<ITaxable> taxes = new List<ITaxable>();

            // Act
            taxes.Add(new TShirt() {
                Size = "2X",
                Price = 10D,
                TaxRate = 0.10D,
                ShippingRate = 2
            });

            taxes.Add(new Book() {
                Title = "Welcome to Advanced C#",
                Price = 20D,
                TaxRate = 0.10D,
                ShippingRate = 5D
            });

            var taxesExpected = 3;
            var taxesActual = Program.CalculateTax(taxes);


            // Assert
            Assert.AreEqual(taxesExpected, taxesActual);
        }


        [TestMethod]
        public void CalculateShippingIsEqualToTotalShipping()
        // Tests that CalculateShipping(items) is calculating the total project shipping correctly
        {
            // Arange
            List<IShippable> shipping = new List<IShippable>();

            // Act
            shipping.Add(new TShirt()
            {
                Size = "2X",
                Price = 10D,
                TaxRate = 0.10D,
                ShippingRate = 2
            });

            shipping.Add(new Book()
            {
                Title = "Welcome to Advanced C#",
                Price = 20D,
                TaxRate = 0.10D,
                ShippingRate = 5D
            });

            var taxesExpected = 7;
            var taxesActual = Program.CalculateShipping(shipping);


            // Assert
            Assert.AreEqual(taxesExpected, taxesActual);
        }


        [TestMethod]
        public void CompleteTransaction()
        // Tests that CompleteTransaction(items) is equal to the total price
        {
            // Arange
            List<IPurchasable> purchase = new List<IPurchasable>();

            // Act
            purchase.Add(new TShirt()
            {
                Size = "2X",
                Price = 10D,
                TaxRate = 0.10D,
                ShippingRate = 2
            });

            purchase.Add(new Book()
            {
                Title = "Welcome to Advanced C#",
                Price = 20D,
                TaxRate = 0.10D,
                ShippingRate = 5D
            });

            purchase.Add(new Snack()
            {
                Price = 2D
            });

            purchase.Add(new Appointment()
            {
                Name = "Caleb",
                StartDateTime = DateTime.Now.AddHours(1),
                EndDateTime = DateTime.Now.AddHours(2),
                Price = 100D
            });

            var taxesExpected = 132;    // Price of all objects
            var taxesActual = Program.CompleteTransaction(purchase);


            // Assert
            Assert.AreEqual(taxesExpected, taxesActual);
        }



        [TestMethod]
        public void CheckGrandTotalComputesCorrectly()
        // Got this from the discussion board in order to test the formulas not accessible in the main
        {
            // Arange 
            double shippingAmount = 2;
            double taxAmount = 2;
            double total = 30.50;
            double grandTotal;

            // Act
            grandTotal = Program.GrandTotal(shippingAmount, taxAmount, total);

            // Assert
            Assert.AreEqual(34.50, grandTotal);
        }



    }
}
